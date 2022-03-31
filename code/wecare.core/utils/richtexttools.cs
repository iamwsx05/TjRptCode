using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Drawing.Imaging;
using System.IO;
using System.Xml;
using weCare.Core.Entity;
using weCare.Core.Itf;

namespace weCare.Core.Utils
{
    #region Reach.MaxLength
    /// <summary>
    /// HandleReachMaxLength
    /// </summary>
    /// <param name="sender"></param>
    public delegate void HandleReachMaxLength(object sender);
    #endregion

    #region 选择图片事件
    /// <summary>
    /// 选择图片事件
    /// </summary>
    public class EvtSelectedImage : EventArgs
    {
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected { get; set; }
    }
    #endregion

    #region RichTextBoxPlus
    /// <summary>
    /// RichTextBoxPlus
    /// </summary>
    public class RichTextBoxPlus
    {
        public const int
        EmfToWmfBitsFlagsDefault = 0x00000000,
        EmfToWmfBitsFlagsEmbedEmf = 0x00000001,
        EmfToWmfBitsFlagsIncludePlaceable = 0x00000002,
        EmfToWmfBitsFlagsNoXORClip = 0x00000004;

        [DllImport("gdiplus.dll")]
        public static extern uint GdipEmfToWmfBits(IntPtr _hEmf, uint _bufferSize, byte[] _buffer, int _mappingMode, int _flags);

        private struct RtfFontFamilyDef
        {
            public const string Unknown = @"\fnil";
            public const string Roman = @"\froman";
            public const string Swiss = @"\fswiss";
            public const string Modern = @"\fmodern";
            public const string Script = @"\fscript";
            public const string Decor = @"\fdecor";
            public const string Technical = @"\ftech";
            public const string BiDirect = @"\fbidi";
        }

        private const int MM_ISOTROPIC = 7;
        private const int MM_ANISOTROPIC = 8;
        private const int HMM_PER_INCH = 2540;
        private const int TWIPS_PER_INCH = 1440;

        private const string FF_UNKNOWN = "UNKNOWN";

        private const string RTF_HEADER = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033";
        private const string RTF_DOCUMENT_PRE = @"\viewkind4\uc1\pard\cf1\f0\fs20";
        private const string RTF_DOCUMENT_POST = @"\cf0\fs17}";
        private const string RTF_IMAGE_POST = @"}";

        private static HybridDictionary rtfFontFamily;

        static RichTextBoxPlus()
        {
            rtfFontFamily = new HybridDictionary();

            #region 2014-03-19 林志宏修改
            //添加前需要判断是否存在
            if (!rtfFontFamily.Contains(FontFamily.GenericMonospace.Name))
                rtfFontFamily.Add(FontFamily.GenericMonospace.Name, RtfFontFamilyDef.Modern);

            if (!rtfFontFamily.Contains(FontFamily.GenericSansSerif.Name))
                rtfFontFamily.Add(FontFamily.GenericSansSerif.Name, RtfFontFamilyDef.Swiss);

            if (!rtfFontFamily.Contains(FontFamily.GenericSerif.Name))
                rtfFontFamily.Add(FontFamily.GenericSerif.Name, RtfFontFamilyDef.Roman);

            if (!rtfFontFamily.Contains(FF_UNKNOWN))
                rtfFontFamily.Add(FF_UNKNOWN, RtfFontFamilyDef.Unknown);
            #endregion
        }

        private static string GetFontTable(Font _font)
        {
            StringBuilder _fontTable = new StringBuilder();
            _fontTable.Append(@"{\fonttbl{\f0");
            _fontTable.Append(@"\");
            if (rtfFontFamily.Contains(_font.FontFamily.Name))
                _fontTable.Append(rtfFontFamily[_font.FontFamily.Name]);
            else
                _fontTable.Append(rtfFontFamily[FF_UNKNOWN]);
            _fontTable.Append(@"\fcharset0");
            _fontTable.Append(_font.Name);
            _fontTable.Append(@";}}");
            return _fontTable.ToString();
        }

        /// 
        /// 在RichTextBox当前光标处插入一副图像。 
        /// 
        /// 多格式文本框控件 
        /// 插入的图像 
        public static void InsertImage(RichTextBox rtb, Image image)
        {
            StringBuilder _rtf = new StringBuilder();
            _rtf.Append(RTF_HEADER);
            _rtf.Append(GetFontTable(rtb.Font));
            _rtf.Append(GetImagePrefix(rtb, image));
            _rtf.Append(GetRtfImage(rtb, image));
            _rtf.Append(RTF_IMAGE_POST);
            rtb.SelectedRtf = _rtf.ToString();
        }

        private static string GetImagePrefix(RichTextBox rtb, Image _image)
        {
            float xDpi;
            float yDpi;
            using (Graphics _graphics = rtb.CreateGraphics())
            {
                xDpi = _graphics.DpiX;
                yDpi = _graphics.DpiY;
            }

            StringBuilder _rtf = new StringBuilder();
            int picw = (int)Math.Round((_image.Width / xDpi) * HMM_PER_INCH);
            int pich = (int)Math.Round((_image.Height / yDpi) * HMM_PER_INCH);
            int picwgoal = (int)Math.Round((_image.Width / xDpi) * TWIPS_PER_INCH);
            int pichgoal = (int)Math.Round((_image.Height / yDpi) * TWIPS_PER_INCH);
            _rtf.Append(@"{\pict\wmetafile8");
            _rtf.Append(@"\picw");
            _rtf.Append(picw);
            _rtf.Append(@"\pich");
            _rtf.Append(pich);
            _rtf.Append(@"\picwgoal");
            _rtf.Append(picwgoal);
            _rtf.Append(@"\pichgoal");
            _rtf.Append(pichgoal);
            _rtf.Append(" ");
            return _rtf.ToString();
        }

        private static string GetRtfImage(RichTextBox rtb, Image _image)
        {
            StringBuilder _rtf = null;
            MemoryStream _stream = null;
            Graphics _graphics = null;
            Metafile _metaFile = null;
            IntPtr _hdc;
            try
            {
                _rtf = new StringBuilder();
                _stream = new MemoryStream();
                using (_graphics = rtb.CreateGraphics())
                {
                    _hdc = _graphics.GetHdc();
                    _metaFile = new Metafile(_stream, _hdc);
                    _graphics.ReleaseHdc(_hdc);
                }
                using (_graphics = Graphics.FromImage(_metaFile))
                {
                    _graphics.DrawImage(_image, new Rectangle(0, 0, _image.Width, _image.Height));
                }
                IntPtr _hEmf = _metaFile.GetHenhmetafile();
                uint _bufferSize = GdipEmfToWmfBits(_hEmf, 0, null, MM_ANISOTROPIC, EmfToWmfBitsFlagsDefault);
                byte[] _buffer = new byte[_bufferSize];
                uint _convertedSize = GdipEmfToWmfBits(_hEmf, _bufferSize, _buffer, MM_ANISOTROPIC, EmfToWmfBitsFlagsDefault);
                for (int i = 0; i < _buffer.Length; ++i)
                {
                    _rtf.Append(String.Format("{0:X2}", _buffer[i]));
                }

                return _rtf.ToString();
            }
            finally
            {
                if (_graphics != null)
                    _graphics.Dispose();
                if (_metaFile != null)
                    _metaFile.Dispose();
                if (_stream != null)
                    _stream.Close();
            }
        }

        private static string GetDocumentArea(string text, Font font)
        {
            StringBuilder doc = new StringBuilder();

            doc.Append(RTF_DOCUMENT_PRE);
            doc.Append(@"\highlight2");

            if (font.Bold)
                doc.Append(@"\b");

            if (font.Italic)
                doc.Append(@"\i");

            if (font.Strikeout)
                doc.Append(@"\strike");

            if (font.Underline)
                doc.Append(@"\ul");

            doc.Append(@"\f0");
            doc.Append(@"\fs");   //font   size   
            doc.Append((int)Math.Round((2 * font.SizeInPoints)));

            //   Apppend   a   space   before   starting   actual   text   (for   clarity)   
            //doc.Append(@"     ");

            //escape   special   characters   
            text = text.Replace(@"\", @"\\");
            text = text.Replace("{", "\\{");
            text = text.Replace("}", "\\}");

            doc.Append(text.Replace("\n", @"\par   "));   //new   lines   to   \par   

            doc.Append(@"\highlight0");

            if (font.Bold)
                doc.Append(@"\b0");

            if (font.Italic)
                doc.Append(@"\i0");

            if (font.Strikeout)
                doc.Append(@"\strike0");

            if (font.Underline)
                doc.Append(@"\ulnone");

            doc.Append(@"\f0");
            doc.Append(@"\fs20");

            doc.Append(RTF_DOCUMENT_POST);

            return doc.ToString();
        }

        private struct RtfColorDef
        {
            public const string Black = @"\red0\green0\blue0";
            public const string Red = @"\red128\green0\blue0";
            public const string Green = @"\red0\green128\blue0";
            public const string Yellow = @"\red128\green128\blue0";
            public const string Blue = @"\red0\green0\blue128";
            public const string Magenta = @"\red128\green0\blue128";
            public const string Cyan = @"\red0\green128\blue128";
            public const string White = @"\red192\green192\blue192";
            public const string BrightBlack = @"\red128\green128\blue128";
            public const string BrightRed = @"\red255\green0\blue0";
            public const string BrightGreen = @"\red0\green255\blue0";
            public const string BrightYellow = @"\red255\green255\blue0";
            public const string BrightBlue = @"\red0\green0\blue255";
            public const string BrightMagenta = @"\red255\green0\blue255";
            public const string BrightCyan = @"\red0\green255\blue255";
            public const string BrightWhite = @"\red255\green255\blue255";
        }

        public enum RtfColor
        {
            Black = 0,
            Red,
            Green,
            Yellow,
            Blue,
            Magenta,
            Cyan,
            White,
            //brights   start   @   8   
            BrightBlack,
            BrightRed,
            BrightGreen,
            BrightYellow,
            BrightBlue,
            BrightMagenta,
            BrightCyan,
            BrightWhite
        }

        private HybridDictionary rtfColor;

        //private static string GetColorTable(RtfColor textColor, RtfColor backColor)
        private static string GetColorTable()
        {
            string strForeColor = @"\red0\green0\blue0";
            string strBackColor = @"\red192\green192\blue192";
            StringBuilder colorTable = new StringBuilder();

            colorTable.Append(@"{\colortbl;");

            colorTable.Append(strForeColor);
            colorTable.Append(@";");

            colorTable.Append(strBackColor);
            colorTable.Append(@";}\n");

            return colorTable.ToString();
        }


        /// <summary>
        /// 插入文本
        /// </summary>
        /// <param name="p_objRTX"></param>
        /// <param name="p_strText"></param>
        public static void InsertText(RichTextBox p_objRTX, string p_strText)
        {
            StringBuilder _rtf = new StringBuilder();
            _rtf.Append(RTF_HEADER);
            _rtf.Append(GetFontTable(p_objRTX.Font));
            //_rtf.Append(GetColorTable(textColor, backColor));
            _rtf.Append(GetColorTable());
            _rtf.Append(GetDocumentArea(p_strText, p_objRTX.Font));
            //p_objRTX.SelectedRtf = _rtf.ToString();
            p_objRTX.SelectedText = p_strText;
            p_objRTX.SelectionLength = 0;
        }

        /// <summary>
        /// 插新行
        /// </summary>
        /// <param name="rtb"></param>
        /// <param name="p_intRowCount"></param>
        /// <param name="p_strCaption"></param>
        public static void InsertNewLine(RichTextBox rtb, int p_intRowCount, string p_strCaption)
        {
            //if (p_intRowCount <= 1) p_intRowCount = 1;
            if (p_intRowCount <= 1) return;

            rtb.Focus();
            rtb.SuspendLayout();
            for (int i = 0; i < p_intRowCount; i++)
            {
                SendKeys.SendWait("{ENTER}");
            }
            rtb.ResumeLayout();
            return;

            Graphics objGrp = rtb.CreateGraphics();

            int intW = rtb.Width;
            int intW1 = (int)objGrp.MeasureString(p_strCaption, rtb.Font).Width;
            int intW2 = (int)objGrp.MeasureString(" ", rtb.Font).Width;

            int n = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < p_intRowCount; i++)
            {
                if (i == 0)
                {
                    n = (int)Math.Floor(((double)intW - (double)intW1) / (double)intW2);
                }
                else
                {
                    n = (int)Math.Floor(((double)intW) / (double)intW2);
                }
                for (int j = 0; j < n; j++)
                {
                    sb.Append(" ");
                }
                if (i != p_intRowCount - 1)
                    sb.Append("\r\n");
            }
            int intInitInx = rtb.Text.Length;
            rtb.SelectionStart = intInitInx;
            RichTextBoxPlus.InsertText(rtb, sb.ToString());
        }

        /// <summary>
        /// 获取图片状态
        /// </summary>
        /// <param name="p_objRtb"></param>
        /// <param name="p_intIndex"></param>
        /// <returns></returns>
        public static bool GetImageStatus(RichTextBox p_objRtb, int p_intIndex)
        {
            bool blnRet = false;
            string strRtf = string.Empty;

            try
            {
                int intSelectionStart = p_objRtb.SelectionStart;
                using (RichTextBox objRich = new RichTextBox())
                {
                    objRich.Rtf = p_objRtb.Rtf;

                    objRich.Select(p_intIndex, 1);
                    if (objRich.SelectionType == RichTextBoxSelectionTypes.Object)
                    {
                        strRtf = objRich.SelectedRtf;
                        int idx = strRtf.IndexOf("picwgoal");
                        if (idx > 0)
                        {
                            blnRet = true;
                        }
                    }
                }
            }
            catch { return false; }

            return blnRet;
        }

        /// <summary>
        /// 获取图片索引
        /// </summary>
        /// <param name="p_objRtb"></param>
        /// <param name="p_intStartIndex"></param>
        /// <param name="p_intEndIndex"></param>
        /// <param name="p_lstImageIdx"></param>
        public static void GetImageIndex(RichTextBox p_objRtb, int p_intStartIndex, int p_intEndIndex, ref List<int> p_lstImageIdx)
        {
            int idx = 0;
            string strRtf = string.Empty;

            int intSelectionStart = p_objRtb.SelectionStart;
            using (RichTextBox objRich = new RichTextBox())
            {
                objRich.Rtf = p_objRtb.Rtf;
                for (int i = p_intStartIndex; i <= p_intEndIndex; i++)
                {
                    objRich.Select(i, 1);
                    if (objRich.SelectionType == RichTextBoxSelectionTypes.Object)
                    {
                        strRtf = objRich.SelectedRtf;
                        idx = strRtf.IndexOf("picwgoal");
                        if (idx <= 0)
                        {
                            return;
                        }
                        p_lstImageIdx.Add(i);
                    }
                }
            }
        }

        /// <summary>
        /// 获取单点图像
        /// </summary>
        /// <param name="p_objRtb"></param>
        /// <param name="p_intIndex"></param>
        /// <param name="p_objImage"></param>
        public static void GetImage(RichTextBox p_objRtb, int p_intIndex, ref Image p_objImage)
        {
            p_objImage = null;
            RichTextBox objRich = new RichTextBox();
            objRich.Rtf = p_objRtb.Rtf;
            int intSelectionStart = p_objRtb.SelectionStart;

            objRich.Select(p_intIndex, 1);
            if (objRich.SelectionType == RichTextBoxSelectionTypes.Object)
            {
                string strRtf = objRich.SelectedRtf;
                int idx = strRtf.IndexOf("picwgoal");
                if (idx <= 0)
                {
                    return;
                }
                strRtf = strRtf.Substring(idx + 8);
                idx = strRtf.IndexOf(@"\");
                int intW = int.Parse(strRtf.Substring(0, idx).Trim());

                idx = strRtf.IndexOf("pichgoal");
                strRtf = strRtf.Substring(idx + 8);
                idx = strRtf.IndexOf("\r\n");
                int intH = int.Parse(strRtf.Substring(0, idx).Trim());

                strRtf = strRtf.Substring(idx + 2);
                idx = strRtf.IndexOf("}");
                string strImage = strRtf.Substring(0, idx);
                strImage = strImage.Replace("\r\n", "");
                List<byte> lstImage = new List<byte>();
                int count = strImage.Length / 2;
                for (int j = 0; j < count; j++)
                {
                    lstImage.Add(Convert.ToByte(strImage.Substring(j * 2, 2), 16));
                }
                Image img = Function.ImgConvertByteToImage(lstImage.ToArray());

                intW = (int)Math.Round(((double)intW / 1440) * 96);
                intH = (int)Math.Round(((double)intH / 1440) * 96);
                p_objImage = img.GetThumbnailImage(intW, intH, null, new IntPtr());
            }
            objRich.Dispose();
            objRich = null;
        }

        /// <summary>
        /// 返回图像列表
        /// </summary>
        /// <param name="p_objRtb"></param>
        /// <param name="p_lstImage"></param>
        public static void GetImageList(RichTextBox p_objRtb, ref List<EntityRtfImage> p_lstImage)
        {
            Image objImage = null;
            EntityRtfImage objRtfImage = null;
            p_lstImage = new List<EntityRtfImage>();
            for (int i = 0; i < p_objRtb.Text.Length; i++)
            {
                GetImage(p_objRtb, i, ref objImage);
                if (objImage != null)
                {
                    objRtfImage = new EntityRtfImage();
                    objRtfImage.Index = i;
                    objRtfImage.Image = objImage;
                    p_lstImage.Add(objRtfImage);
                }
            }
        }

        public const int WM_USER = 0x0400;
        public const int EM_GETPARAFORMAT = WM_USER + 61;
        public const int EM_SETPARAFORMAT = WM_USER + 71;
        public const long MAX_TAB_STOPS = 32;
        public const uint PFM_LINESPACING = 0x00000100;
        [StructLayout(LayoutKind.Sequential)]
        public struct PARAFORMAT2
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public short sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public short wShadingWeight;
            public short wShadingStyle;
            public short wNumberingStart;
            public short wNumberingStyle;
            public short wNumberingTab;
            public short wBorderSpace;
            public short wBorderWidth;
            public short wBorders;
        }
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, ref PARAFORMAT2 lParam);
    }
    #endregion

    #region RichTextBoxTool
    /// <summary>
    /// RichTextBoxTool
    /// </summary>
    public class RichTextBoxTool
    {
        #region 外部API
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0xB;
        #endregion
        /// <summary>
        /// 表单模板类名
        /// </summary>
        public static string TemplateFormClass
        {
            get
            {
                return "com.HopeBridge.ehr.client.frmEhrCasetemplate";
            }
        }
        /// <summary>
        /// 双划线前缀
        /// </summary>
        public static string DSTPrefix
        {
            get
            { return Function.AsciiToStr(26); }
        }
        /// <summary>
        /// 术语前缀
        /// </summary>
        public static string TermPrefix
        {
            get
            { return string.Empty; }
        }
        /// <summary>
        /// 图片前缀
        /// </summary>
        public static string ImagePrefix
        {
            get
            { return string.Empty; }
        }
        /// <summary>
        /// 术语颜色
        /// </summary>
        public static Color TermColor
        {
            get { return Color.Blue; }
        }
        /// <summary>
        /// 编辑元素颜色
        /// </summary>
        public static Color ElementEditColor
        {
            get { return Color.OrangeRed; }
        }
        #region 重绘/暂停重绘
        /// <summary>
        /// 暂停重绘
        /// </summary>
        public static void StopRedraw(IntPtr hwnd)
        {
            SendMessage(hwnd, WM_SETREDRAW, 0, IntPtr.Zero);
        }
        /// <summary>
        /// 重绘
        /// </summary>
        public static void Redraw(IntPtr hwnd)
        {
            SendMessage(hwnd, WM_SETREDRAW, 1, IntPtr.Zero);
        }
        #endregion

        #region 从XMLInfo对象获取xml文本
        /// <summary>
        /// 从XMLInfo对象获取xml文本
        /// </summary>
        public static string GetXmlFromInfo(string textStr, DateTime dateNow, bool extSpecModifyFlag, string formTypeName, EntityModifyUserInfo userInfo, List<EntityDstInfo> p_lstDSTIndex, List<EntityModifyUserInfo> p_lstUserInfo, List<EntityUserContentInfo> p_lstTextContentInfos, List<EntityMedicalTerm> p_lstMedicalTerm, DateTime? p_dtmCaseWriteDate)
        {
            if (string.IsNullOrEmpty(textStr.Trim())) return string.Empty;
            MemoryStream objXmlStream = new MemoryStream();
            XmlTextWriter objXmlWriter = new XmlTextWriter(objXmlStream, System.Text.Encoding.Unicode);

            objXmlWriter.WriteStartDocument();
            objXmlWriter.WriteStartElement("Main");
            DateTime dtmCurrent = dateNow;

            #region 内容信息
            if (p_lstUserInfo.Count > 0 || p_lstTextContentInfos.Count > 0)
            {
                objXmlWriter.WriteStartElement("Content");
                /*
                int intIndex = 1;
                foreach (clsModifyUserInfo objUserInfo in p_lstUserInfo)
                {
                    objUserInfo.m_intUserSequence = intIndex++;

                    objXmlWriter.WriteStartElement("UI");
                    objXmlWriter.WriteAttributeString("D", objUserInfo.m_strUserID);
                    objXmlWriter.WriteAttributeString("N", objUserInfo.m_strUserName);
                    objXmlWriter.WriteAttributeString("S", objUserInfo.m_intUserSequence.ToString());
                    objXmlWriter.WriteAttributeString("M", objUserInfo.m_dtmModifyDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    objXmlWriter.WriteAttributeString("C", objUserInfo.m_clrText.ToArgb().ToString());
                    objXmlWriter.WriteEndElement();
                }
                 * */

                List<EntityUserContentInfo> lstContent = new List<EntityUserContentInfo>();
                EntityUserContentInfo objContentInfo = null;
                for (int i = 0; i < p_lstTextContentInfos.Count; i++)
                {
                    objContentInfo = p_lstTextContentInfos[i];

                    if (string.IsNullOrEmpty(objContentInfo.UserID)) objContentInfo.UserID = userInfo.UserID;
                    if (string.IsNullOrEmpty(objContentInfo.UserName)) objContentInfo.UserName = userInfo.UserName;
                    if (objContentInfo.EndIndex > textStr.Length - 1) continue;
                    if (extSpecModifyFlag && objContentInfo.UserID == GlobalRichTextParm.LoginID) continue;
                    if (lstContent.Any(t => t.StartIndex == objContentInfo.StartIndex && t.EndIndex == objContentInfo.EndIndex && t.UserID == objContentInfo.UserID))
                        continue;
                    else
                        lstContent.Add(objContentInfo);

                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objContentInfo.StartIndex.ToString());
                    objXmlWriter.WriteAttributeString("E", objContentInfo.EndIndex.ToString());
                    objXmlWriter.WriteAttributeString("I", objContentInfo.UserID);
                    objXmlWriter.WriteAttributeString("N", objContentInfo.UserName);
                    objXmlWriter.WriteAttributeString("R", objContentInfo.ColorText.ToArgb().ToString());
                    if (p_dtmCaseWriteDate == null)
                    {
                        if (objContentInfo.ModifyDate.ToString("yyyy") == "0001")
                        {
                            objXmlWriter.WriteAttributeString("D", dtmCurrent.ToString("yyyy-MM-dd HH:mm:ss"));
                            objContentInfo.ModifyDate = dtmCurrent;
                        }
                        else
                        {
                            objXmlWriter.WriteAttributeString("D", objContentInfo.ModifyDate.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                    }
                    else
                    {
                        objXmlWriter.WriteAttributeString("D", p_dtmCaseWriteDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        objContentInfo.ModifyDate = p_dtmCaseWriteDate.Value;
                    }
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            #region 术语
            if (p_lstMedicalTerm.Count > 0)
            {
                p_lstMedicalTerm.Sort();
                objXmlWriter.WriteStartElement("MedicalTerm");
                EntityMedicalTerm objMedicalTerm = null;
                for (int i = 0; i < p_lstMedicalTerm.Count; i++)
                {
                    objMedicalTerm = p_lstMedicalTerm[i];
                    if ((objMedicalTerm.TID == "PatInfo" && formTypeName != TemplateFormClass) ||
                        (objMedicalTerm.TID.StartsWith("Intellection") && formTypeName != TemplateFormClass))
                    {
                        continue;
                    }
                    if (formTypeName == TemplateFormClass)
                    {
                        objMedicalTerm.UserID = string.Empty;
                        objMedicalTerm.UserName = string.Empty;
                    }
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objMedicalTerm.StartIndex.ToString());
                    objXmlWriter.WriteAttributeString("E", objMedicalTerm.EndIndex.ToString());
                    //objXmlWriter.WriteAttributeString("I", objMedicalTerm.m_strUserID);
                    //objXmlWriter.WriteAttributeString("N", objMedicalTerm.m_strUserName);
                    //objXmlWriter.WriteAttributeString("D", (p_dtmCaseWriteDate == null ? objMedicalTerm.m_dtmCreateTime.ToString("yyyy-MM-dd HH:mm:ss") : p_dtmCaseWriteDate.Value.ToString("yyyy-MM-dd HH:mm:ss")));
                    if (string.IsNullOrEmpty(objMedicalTerm.CaseCode))
                        objXmlWriter.WriteAttributeString("A", GlobalCase.caseInfo.CaseCode);
                    else
                        objXmlWriter.WriteAttributeString("A", objMedicalTerm.CaseCode);
                    objXmlWriter.WriteAttributeString("T", objMedicalTerm.TID);
                    objXmlWriter.WriteAttributeString("V", objMedicalTerm.Value);
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            #region 双划线
            if (p_lstDSTIndex.Count > 0)
            {
                p_lstDSTIndex.Sort();
                objXmlWriter.WriteStartElement("DDL");
                EntityDstInfo objDST = null;
                for (int i = 0; i < p_lstDSTIndex.Count; i++)
                {
                    objDST = p_lstDSTIndex[i];
                    objXmlWriter.WriteStartElement("C ");
                    objXmlWriter.WriteAttributeString("S", objDST.StartIndex.ToString());
                    objXmlWriter.WriteAttributeString("E", objDST.EndIndex.ToString());
                    objXmlWriter.WriteAttributeString("V", objDST.Value.Substring(1));
                    //objXmlWriter.WriteAttributeString("C", objDST.m_clrDST.ToArgb().ToString());
                    objXmlWriter.WriteAttributeString("I", objDST.UserID);
                    objXmlWriter.WriteAttributeString("N", objDST.UserName);
                    //objXmlWriter.WriteAttributeString("I", objDST.m_intUserSequence.ToString());
                    //objXmlWriter.WriteAttributeString("D", (p_dtmCaseWriteDate == null ? objDST.m_dtmDeleteTime.ToString("yyyy-MM-dd HH:mm:ss") : p_dtmCaseWriteDate.Value.ToString("yyyy-MM-dd HH:mm:ss")));

                    if (p_dtmCaseWriteDate == null)
                    {
                        if (objDST.DeleteTime.ToString("yyyy") == "0001")
                        {
                            objXmlWriter.WriteAttributeString("D", dtmCurrent.ToString("yyyy-MM-dd HH:mm:ss"));
                            objDST.DeleteTime = dtmCurrent;
                        }
                        else
                        {
                            objXmlWriter.WriteAttributeString("D", objDST.DeleteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                    }
                    else
                    {
                        objXmlWriter.WriteAttributeString("D", p_dtmCaseWriteDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        objDST.DeleteTime = p_dtmCaseWriteDate.Value;
                    }

                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            objXmlWriter.WriteEndElement();
            objXmlWriter.WriteEndDocument();
            objXmlWriter.Flush();

            string strXml = System.Text.Encoding.Unicode.GetString(objXmlStream.ToArray(), 0, (int)objXmlStream.Length);
            int intRootBegin = strXml.IndexOf("<Main");
            return strXml.Substring(intRootBegin, strXml.Length - intRootBegin);
        }
        #endregion

        #region 从XMLInfo对象获取TraceXml文本
        /// <summary>
        /// 从XMLInfo对象获取TraceXml文本
        /// </summary>
        /// <param name="p_lstDSTIndex"></param>
        /// <param name="p_lstUserInfo"></param>
        /// <param name="p_lstTextContentInfos"></param>
        /// <param name="p_lstSuperSubScriptInfo"></param>
        /// <param name="p_lstFontColor"></param>
        /// <param name="p_lstFontBold"></param>
        /// <param name="p_lstFontItalic"></param>
        /// <param name="p_lstFontUnderLine"></param>
        /// <param name="p_lstMedicalTerm"></param>
        /// <returns></returns>
        public static string GetTraceXmlFromInfo(string textStr, List<EntityDstInfo> p_lstDSTIndex, List<EntityModifyUserInfo> p_lstUserInfo, List<EntityUserContentInfo> p_lstTextContentInfos, List<EntitySuperSubScript> p_lstSuperSubScriptInfo,
                                                 List<EntityFontColor> p_lstFontColor, List<EntityFontBold> p_lstFontBold, List<EntityFontItalic> p_lstFontItalic, List<EntityFontUnderLine> p_lstFontUnderLine, List<EntityMedicalTerm> p_lstMedicalTerm)
        {
            MemoryStream objXmlStream = new MemoryStream();
            XmlTextWriter objXmlWriter = new XmlTextWriter(objXmlStream, System.Text.Encoding.Unicode);
            objXmlWriter.WriteStartDocument();
            objXmlWriter.WriteStartElement("Main");

            #region 内容信息
            objXmlWriter.WriteStartElement("OrgContent");
            objXmlWriter.WriteStartElement("Description");
            objXmlWriter.WriteAttributeString("Value", textStr);
            objXmlWriter.WriteEndElement();
            objXmlWriter.WriteEndElement();

            if (p_lstUserInfo.Count > 0 || p_lstTextContentInfos.Count > 0)
            {
                objXmlWriter.WriteStartElement("Content");
                /*
                int intIndex = 1;
                foreach (clsModifyUserInfo objUserInfo in p_lstUserInfo)
                {
                    objUserInfo.m_intUserSequence = intIndex++;

                    objXmlWriter.WriteStartElement("UI");
                    objXmlWriter.WriteAttributeString("D", objUserInfo.m_strUserID);
                    objXmlWriter.WriteAttributeString("N", objUserInfo.m_strUserName);
                    objXmlWriter.WriteAttributeString("S", objUserInfo.m_intUserSequence.ToString());
                    objXmlWriter.WriteAttributeString("M", objUserInfo.m_dtmModifyDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    objXmlWriter.WriteAttributeString("C", objUserInfo.m_clrText.ToArgb().ToString());
                    objXmlWriter.WriteEndElement();
                }
                 * */

                foreach (EntityUserContentInfo objContentInfo in p_lstTextContentInfos)
                {
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objContentInfo.StartIndex.ToString());
                    objXmlWriter.WriteAttributeString("E", objContentInfo.EndIndex.ToString());
                    //objXmlWriter.WriteAttributeString("Q", objContentInfo.objUserInfo.m_intUserSequence.ToString());
                    objXmlWriter.WriteAttributeString("I", objContentInfo.UserID);
                    objXmlWriter.WriteAttributeString("N", objContentInfo.UserName);
                    objXmlWriter.WriteAttributeString("D", objContentInfo.ModifyDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            #region 术语
            if (p_lstMedicalTerm.Count > 0)
            {
                p_lstMedicalTerm.Sort();
                objXmlWriter.WriteStartElement("MedicalTerm");
                foreach (EntityMedicalTerm objMedicalTerm in p_lstMedicalTerm)
                {
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objMedicalTerm.StartIndex.ToString());
                    objXmlWriter.WriteAttributeString("E", objMedicalTerm.EndIndex.ToString());
                    objXmlWriter.WriteAttributeString("I", objMedicalTerm.UserID);
                    objXmlWriter.WriteAttributeString("N", objMedicalTerm.UserName);
                    objXmlWriter.WriteAttributeString("D", objMedicalTerm.CreateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    objXmlWriter.WriteAttributeString("T", objMedicalTerm.TID);
                    objXmlWriter.WriteAttributeString("V", objMedicalTerm.Value);
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            #region 上下标
            if (p_lstSuperSubScriptInfo.Count > 0)
            {
                objXmlWriter.WriteStartElement("SuperSubScript");
                foreach (EntitySuperSubScript objScript in p_lstSuperSubScriptInfo)
                {
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objScript.Index.ToString());
                    objXmlWriter.WriteAttributeString("O", objScript.CharOffset.ToString());
                    objXmlWriter.WriteAttributeString("V", objScript.Value);
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            #region 字体其他属性
            if (p_lstFontColor.Count > 0)
            {
                objXmlWriter.WriteStartElement("FontColor");
                foreach (EntityFontColor objFontColor in p_lstFontColor)
                {
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objFontColor.Index.ToString());
                    objXmlWriter.WriteAttributeString("R", objFontColor.ColorValue.ToArgb().ToString());
                    objXmlWriter.WriteAttributeString("V", objFontColor.TxtValue);
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }

            if (p_lstFontBold.Count > 0)
            {
                objXmlWriter.WriteStartElement("FontBold");
                foreach (EntityFontBold objFontBold in p_lstFontBold)
                {
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objFontBold.Index.ToString());
                    objXmlWriter.WriteAttributeString("V", objFontBold.Value);
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }

            if (p_lstFontItalic.Count > 0)
            {
                objXmlWriter.WriteStartElement("FontItalic");
                foreach (EntityFontItalic objFontItalic in p_lstFontItalic)
                {
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objFontItalic.Index.ToString());
                    objXmlWriter.WriteAttributeString("V", objFontItalic.Value);
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }

            if (p_lstFontUnderLine.Count > 0)
            {
                objXmlWriter.WriteStartElement("FontUnderLine");
                foreach (EntityFontUnderLine objFontUnderLine in p_lstFontUnderLine)
                {
                    objXmlWriter.WriteStartElement("C");
                    objXmlWriter.WriteAttributeString("S", objFontUnderLine.Index.ToString());
                    objXmlWriter.WriteAttributeString("V", objFontUnderLine.Value);
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            #region 双划线
            if (p_lstDSTIndex.Count > 0)
            {
                p_lstDSTIndex.Sort();
                objXmlWriter.WriteStartElement("DST");
                foreach (EntityDstInfo objDST in p_lstDSTIndex)
                {
                    objXmlWriter.WriteStartElement("C ");
                    objXmlWriter.WriteAttributeString("S", objDST.StartIndex.ToString());
                    objXmlWriter.WriteAttributeString("E", objDST.EndIndex.ToString());
                    objXmlWriter.WriteAttributeString("V", objDST.Value);
                    //objXmlWriter.WriteAttributeString("C", objDST.m_clrDST.ToArgb().ToString());
                    objXmlWriter.WriteAttributeString("I", objDST.UserID);
                    objXmlWriter.WriteAttributeString("N", objDST.UserName);
                    //objXmlWriter.WriteAttributeString("I", objDST.m_intUserSequence.ToString());
                    objXmlWriter.WriteAttributeString("D", objDST.DeleteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    objXmlWriter.WriteEndElement();
                }
                objXmlWriter.WriteEndElement();
            }
            #endregion

            objXmlWriter.WriteEndElement();
            objXmlWriter.WriteEndDocument();
            objXmlWriter.Flush();

            string strXml = System.Text.Encoding.Unicode.GetString(objXmlStream.ToArray(), 0, (int)objXmlStream.Length);
            int intRootBegin = strXml.IndexOf("<Main");
            return strXml.Substring(intRootBegin, strXml.Length - intRootBegin);
        }
        #endregion

        /// <summary>
        /// 删除视图信息
        /// </summary>
        /// <param name="p_intStartIndex"></param>
        /// <param name="p_intEndIndex"></param>
        /// <param name="p_strUserID"></param>
        private static void DeleteTextView(int p_intStartIndex, int p_intEndIndex, string p_strUserID, ref List<EntityUserContentInfo> lstTextContentInfos)
        {
            for (int i = lstTextContentInfos.Count - 1; i >= 0; i--)
            {
                if (lstTextContentInfos[i].StartIndex == p_intStartIndex &&
                    lstTextContentInfos[i].EndIndex == p_intEndIndex &&
                    lstTextContentInfos[i].UserID == p_strUserID)
                {
                    lstTextContentInfos.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary>
        /// 调整内容段位置.删除
        /// </summary>
        /// <param name="p_intStartIndex"></param>
        /// <param name="p_intOldLength"></param>
        /// <param name="p_intDiffLength"></param>
        public static void AdjustContentPosition_Delete(int p_intStartIndex, int p_intOldLength, int p_intDiffLength, ref List<EntityUserContentInfo> lstTextContentInfos, bool isBackspace, RichTextBox rich)
        {
            //只能在自己添加的区域替换，并由此决定此区域必定连续区域。(即被替换的部分处于同一个文本段,一个文本段要么包含该区域,要么不包含该区域)
            //即添加只在一个区域内替换。
            //但需要把替换的区域后的区域更新
            int intTmpValue = 0;
            EntityUserContentInfo objContentInfo = null;
            for (int i = lstTextContentInfos.Count - 1; i >= 0; i--)
            {
                objContentInfo = lstTextContentInfos[i];
                if (isBackspace)
                    intTmpValue = p_intStartIndex + 1;
                else
                    intTmpValue = p_intStartIndex;
                if (Math.Abs(p_intDiffLength) == 1 && (intTmpValue == objContentInfo.StartIndex) && (objContentInfo.StartIndex == objContentInfo.EndIndex))
                {
                    lstTextContentInfos.RemoveAt(i);
                    DeleteTextView(objContentInfo.StartIndex, objContentInfo.EndIndex, objContentInfo.UserID, ref lstTextContentInfos);
                    break;
                }

                //替换区域属于当前文本段
                if ((objContentInfo.StartIndex <= p_intStartIndex) && (objContentInfo.EndIndex >= p_intStartIndex))
                {
                    //此区域是替换区域，更新结束坐标
                    objContentInfo.EndIndex += p_intDiffLength;
                    if (objContentInfo.EndIndex < objContentInfo.StartIndex)
                    {
                        //此区域被删除
                        lstTextContentInfos.RemoveAt(i);
                        DeleteTextView(objContentInfo.StartIndex, objContentInfo.EndIndex, objContentInfo.UserID, ref lstTextContentInfos);
                    }
                }
                //当前文本段在替换区域之后,位置向后偏移
                else if (objContentInfo.StartIndex > p_intStartIndex)
                {
                    //此区域在替换区域后，更新开始和结束坐标
                    objContentInfo.StartIndex += p_intDiffLength;
                    objContentInfo.EndIndex += p_intDiffLength;
                }
            }
            //将用户相同的相邻的文本段衔接起来作为一个文本段
            EntityUserContentInfo objPreContentInfo = null;
            for (int i = 0; i < lstTextContentInfos.Count; i++)
            {
                objContentInfo = lstTextContentInfos[i];
                if (objPreContentInfo != null && objPreContentInfo.EndIndex + 1 == objContentInfo.StartIndex && objPreContentInfo.UserInfo == objContentInfo.UserInfo)
                {
                    objPreContentInfo.EndIndex = objContentInfo.EndIndex;
                    lstTextContentInfos.RemoveAt(i);
                    DeleteTextView(objContentInfo.StartIndex, objContentInfo.EndIndex, objContentInfo.UserID, ref lstTextContentInfos);
                    i--;
                }
                else
                {
                    objPreContentInfo = objContentInfo;
                }
            }

            if (Math.Abs(p_intDiffLength) > 50)
            {
                rich.Invalidate();
            }
        }

        public static void AdjustElementPosition_Delete(int p_intStartIndex, int p_intOldLength, int p_intDiffLength, bool isBackspace, Font font, ref List<EntityMedicalTerm> lstMedicalTerm, RichTextBox rich)
        {
            //只能在自己添加的区域替换，并由此决定此区域必定连续区域。(即被替换的部分处于同一个文本段,一个文本段要么包含该区域,要么不包含该区域)
            //即添加只在一个区域内替换。
            //但需要把替换的区域后的区域更新
            int intTmpValue = 0;
            EntityMedicalTerm objContentInfo = null;
            for (int i = lstMedicalTerm.Count - 1; i >= 0; i--)
            {
                objContentInfo = lstMedicalTerm[i];
                if (isBackspace)
                    intTmpValue = p_intStartIndex + 1;
                else
                    intTmpValue = p_intStartIndex;
                if (Math.Abs(p_intDiffLength) == 1 && (intTmpValue == objContentInfo.StartIndex) && (objContentInfo.StartIndex == objContentInfo.EndIndex))
                {
                    lstMedicalTerm.RemoveAt(i);
                    break;
                }

                //替换区域属于当前文本段
                if ((objContentInfo.StartIndex <= p_intStartIndex) && (objContentInfo.EndIndex >= p_intStartIndex))
                {
                    //此区域是替换区域，更新结束坐标
                    if (objContentInfo.EndIndex - p_intStartIndex >= Math.Abs(p_intDiffLength))
                        objContentInfo.EndIndex += p_intDiffLength;
                    else
                        objContentInfo.EndIndex = p_intStartIndex - 1;
                    SetElementName(objContentInfo, rich);

                    if (objContentInfo.EndIndex < objContentInfo.StartIndex)
                    {
                        //此区域被删除
                        lstMedicalTerm.RemoveAt(i);
                    }
                }
                else if (objContentInfo.StartIndex > p_intStartIndex)
                {
                    int intTmpEndIndex = p_intStartIndex + Math.Abs(p_intDiffLength);
                    if (intTmpEndIndex > objContentInfo.EndIndex)
                    {
                        lstMedicalTerm.RemoveAt(i);
                    }
                    else if (intTmpEndIndex <= objContentInfo.StartIndex)
                    {
                        objContentInfo.StartIndex += p_intDiffLength;
                        objContentInfo.EndIndex += p_intDiffLength;
                    }
                    else if (intTmpEndIndex > objContentInfo.StartIndex && intTmpEndIndex <= objContentInfo.EndIndex)
                    {
                        objContentInfo.StartIndex = p_intStartIndex;
                        objContentInfo.EndIndex += p_intDiffLength;
                        SetElementName(objContentInfo, rich);
                    }
                }
            }
            SetMedicalTermColor(0, font, rich, lstMedicalTerm);
        }

        private static void SetElementName(EntityMedicalTerm objElement, RichTextBox rich)
        {
            try
            {
                objElement.Value = rich.Text.Substring(objElement.StartIndex, objElement.EndIndex - objElement.StartIndex + 1);
            }
            catch
            {
                //MessageBox.Show("text len: " + this.Text.Length + "  Start:" + objElement.m_intStartIndex.ToString() + "   End:" + objElement.m_intEndIndex.ToString() + "  diff len:" + Convert.ToString(this.Text.Length - objElement.m_intStartIndex + 1));
            }
        }

        /// <summary>
        /// 调整内容段位置.插入
        /// </summary>
        /// <param name="p_intNewLen"></param>
        /// <param name="lstTextContentInfos"></param>
        /// <param name="currentModifyUser"></param>
        /// <param name="currentCursorIndex"></param>
        /// <param name="dateNow"></param>
        /// <param name="oldParetnInsertColor"></param>
        public static void AdjustContentPosition_Insert(int p_intNewLen, ref List<EntityUserContentInfo> lstTextContentInfos, EntityModifyUserInfo currentModifyUser, int currentCursorIndex, DateTime dateNow, Color oldParetnInsertColor)
        {
            bool blnStatus = false;	//标识新增文本是否已被处理,若是则后续文本段只需位置向后偏移即可
            EntityUserContentInfo objContentInfo = null;
            int intIndex = 0;
            while (intIndex < lstTextContentInfos.Count)
            {
                objContentInfo = lstTextContentInfos[intIndex];

                //文本段位于新增文字之前时
                if (objContentInfo.EndIndex < currentCursorIndex)
                {
                    //如果是最后一个文本段,则延长改文本段(同一用户)或添加一个新的文本段(不同用户)
                    if (intIndex == lstTextContentInfos.Count - 1)
                    {
                        if (objContentInfo.UserInfo == currentModifyUser)
                        {
                            objContentInfo.EndIndex += p_intNewLen;				//延长
                        }
                        else
                        {
                            EntityUserContentInfo objInfo = new EntityUserContentInfo();		//新增
                            objInfo.UserInfo = currentModifyUser;
                            objInfo.StartIndex = currentCursorIndex;
                            objInfo.EndIndex = currentCursorIndex + p_intNewLen - 1;
                            objInfo.UserID = currentModifyUser.UserID;
                            objInfo.UserName = currentModifyUser.UserName;
                            objInfo.ModifyDate = dateNow;
                            objInfo.ColorText = oldParetnInsertColor;
                            objInfo.UserInfo.ModifyDate = objInfo.ModifyDate;

                            lstTextContentInfos.Add(objInfo);
                        }

                        break;
                    }
                    //如果新增文字紧接当前文本段,则考虑是否可以衔接
                    else if (objContentInfo.EndIndex + 1 == currentCursorIndex)
                    {
                        if (objContentInfo.UserInfo == currentModifyUser)
                        {
                            objContentInfo.EndIndex += p_intNewLen;
                            blnStatus = true;		//衔接后,后续文本段只需后移
                        }
                    }
                    intIndex++;
                }
                else //文本段位于新增文字之后
                {
                    //新增文本已被某个文本段所衔接,后续的文本段只需后移
                    if (blnStatus)
                    {
                        objContentInfo.StartIndex += p_intNewLen;
                        objContentInfo.EndIndex += p_intNewLen;
                        intIndex++;
                    }
                    else
                    {
                        #region 新增文本与文本段交叉
                        //相同用户,直接衔接						
                        if (objContentInfo.UserInfo == currentModifyUser)
                        {
                            objContentInfo.EndIndex += p_intNewLen;
                            intIndex++;
                            blnStatus = true;
                        }
                        else //不同用户
                        {
                            //新增文本处于文本段中间,将原有文本段分成两端,再插入一个新文本段
                            if (objContentInfo.StartIndex < currentCursorIndex && currentCursorIndex < objContentInfo.EndIndex)
                            {
                                int intEndIndex = objContentInfo.EndIndex;
                                //原有段->段1
                                objContentInfo.EndIndex = currentCursorIndex - 1;
                                intIndex++;

                                //新段->段2 , 插入到段1之后
                                EntityUserContentInfo objNewInfo = new EntityUserContentInfo();
                                objNewInfo.UserInfo = currentModifyUser;
                                objNewInfo.StartIndex = currentCursorIndex;
                                objNewInfo.EndIndex = currentCursorIndex + p_intNewLen - 1;
                                objNewInfo.UserID = currentModifyUser.UserID;
                                objNewInfo.UserName = currentModifyUser.UserName;
                                objNewInfo.ModifyDate = dateNow;
                                objNewInfo.ColorText = oldParetnInsertColor;
                                objNewInfo.UserInfo.ModifyDate = objNewInfo.ModifyDate;

                                lstTextContentInfos.Insert(intIndex, objNewInfo);
                                intIndex++;

                                //原有段的后部分->段3 
                                EntityUserContentInfo objOldInfo = new EntityUserContentInfo();
                                objOldInfo.UserInfo = objContentInfo.UserInfo;
                                objOldInfo.StartIndex = currentCursorIndex + p_intNewLen;
                                objOldInfo.EndIndex = intEndIndex + p_intNewLen;
                                objOldInfo.UserID = objContentInfo.UserID;
                                objOldInfo.UserName = objContentInfo.UserName;
                                objOldInfo.ModifyDate = objContentInfo.ModifyDate;
                                objOldInfo.ColorText = objContentInfo.ColorText;
                                objOldInfo.UserInfo.ModifyDate = objOldInfo.ModifyDate;

                                lstTextContentInfos.Insert(intIndex, objOldInfo);
                                intIndex++;
                                blnStatus = true;
                            }
                            else if (objContentInfo.StartIndex >= currentCursorIndex) //新增文本紧靠文本段之前
                            {
                                //插入一个新文本段
                                EntityUserContentInfo objNewInfo = new EntityUserContentInfo();
                                objNewInfo.UserInfo = currentModifyUser;
                                objNewInfo.StartIndex = currentCursorIndex;
                                objNewInfo.EndIndex = currentCursorIndex + p_intNewLen - 1;
                                objNewInfo.UserID = currentModifyUser.UserID;
                                objNewInfo.UserName = currentModifyUser.UserName;
                                objNewInfo.ModifyDate = dateNow;
                                objNewInfo.ColorText = oldParetnInsertColor;
                                objNewInfo.UserInfo.ModifyDate = objNewInfo.ModifyDate;

                                lstTextContentInfos.Insert(intIndex, objNewInfo);
                                intIndex++;
                                blnStatus = true;
                            }
                            else
                            {
                                intIndex++;
                            }
                        }
                        #endregion
                    }
                }
            }
        }

        /// <summary>
        /// AdjustDSTPosition
        /// </summary>
        /// <param name="lstDoubleStrikeThrough"></param>
        /// <param name="rich"></param>
        public static void AdjustDSTPosition(ref List<EntityDstInfo> lstDoubleStrikeThrough, RichTextBox rich)
        {
            if (lstDoubleStrikeThrough.Count == 0) return;

            int intStart = 0;
            int intPos = 0;
            string strText = rich.Text;
            lstDoubleStrikeThrough.Sort();
            foreach (EntityDstInfo objDST in lstDoubleStrikeThrough)
            {
                intPos = strText.IndexOf(objDST.Value, intStart);
                if (intPos != objDST.StartIndex)
                {
                    objDST.StartIndex = intPos;
                    objDST.EndIndex = intPos + objDST.Value.Length - 1;
                }
                intStart = objDST.EndIndex + 1;
            }
            rich.SelectionLength = 0;
            rich.Invalidate();
        }

        private static bool IsElement(RichTextBox rtx, int start)
        {
            rtx.Select(start, 1);
            if (rtx.SelectionFont.Name == "黑体")
                return true;
            else
                return false;
        }

        private static EntityMedicalTerm CursorPositionToTerm(int index, List<EntityMedicalTerm> lstMedicalTerm)
        {
            foreach (EntityMedicalTerm obj in lstMedicalTerm)
            {
                if (obj.StartIndex < index && index <= obj.EndIndex)
                {
                    return obj;
                }
            }
            return null;
        }

        public static void AdjustTermPosition(ref List<EntityMedicalTerm> lstMedicalTerm, Font font, RichTextBox rich)
        {
            if (lstMedicalTerm.Count == 0) return;
            lstMedicalTerm.Sort();

            int intType = 0;
            int intIndex = -1;
            using (RichTextBox rtx = new RichTextBox())
            {
                rtx.Rtf = rich.Rtf;
                for (int i = 0; i < rtx.Text.Length; i++)
                {
                    if (IsElement(rtx, i))
                    {
                        intIndex++;
                        if (intIndex < lstMedicalTerm.Count)
                        {
                            lstMedicalTerm[intIndex].StartIndex = i;
                            lstMedicalTerm[intIndex].EndIndex = i + lstMedicalTerm[intIndex].Value.Length - 1;
                            //this.m_lstMedicalTerm[intIndex].IsChangeColor = false;

                            i = lstMedicalTerm[intIndex].EndIndex;
                        }
                    }
                }
            }
            if (intIndex >= 0)
            {
                if (CursorPositionToTerm(rich.SelectionStart, lstMedicalTerm) == null)
                    SetMedicalTermColor(intType, font, rich, lstMedicalTerm);
            }
            else
            {
                lstMedicalTerm.Clear();
            }
        }

        /// <summary>
        /// 通过XML获取元素列表
        /// </summary>
        /// <param name="p_strXML"></param>
        /// <returns></returns>
        public static List<EntityMedicalTerm> GetElementListByXML(string p_strXML)
        {
            List<EntityMedicalTerm> lstElement = new List<EntityMedicalTerm>();
            XmlNodeList nodeList = Function.ReadXML(p_strXML, "MedicalTerm");
            if (nodeList != null)
            {
                EntityMedicalTerm objTerm = null;
                foreach (XmlNode node in nodeList)
                {
                    objTerm = new EntityMedicalTerm();
                    objTerm.StartIndex = int.Parse(node.Attributes["S"].Value);
                    objTerm.EndIndex = int.Parse(node.Attributes["E"].Value);
                    objTerm.TID = node.Attributes["T"].Value;
                    objTerm.Value = node.Attributes["V"].Value;
                    objTerm.UserID = node.Attributes["I"].Value;
                    objTerm.UserName = node.Attributes["N"].Value;
                    objTerm.CreateTime = DateTime.Parse(node.Attributes["D"].Value);

                    lstElement.Add(objTerm);
                }
            }
            return lstElement;
        }

        /// <summary>
        /// 修改者比较
        /// </summary>
        /// <param name="p_objModifierCur"></param>
        /// <param name="p_objModifierOrg"></param>
        /// <param name="dateNow"></param>
        /// <param name="tableFlag"></param>
        /// <param name="dbColName"></param>
        /// <param name="lstTextContentInfos"></param>
        /// <param name="currentModifyUser"></param>
        /// <returns></returns>
        public static bool CompareModifier(EntityModifyUserInfo p_objModifierCur, EntityModifyUserInfo p_objModifierOrg, DateTime dateNow, bool tableFlag, string dbColName, List<EntityUserContentInfo> lstTextContentInfos, EntityModifyUserInfo currentModifyUser)
        {
            #region 旧代码 2014-04-18 林志宏
            //bool blnReturn = true;
            //try
            //{
            //    if (clsGlobalCase.objCaseInfo.intCaseStatus != 2)
            //        return true;
            //    if (p_objModifierCur == null || p_objModifierOrg == null)
            //        return false;

            //    bool blnAllowModifyOther = false;
            //    if (clsGlobalSysParameter.dicSysParameter.ContainsKey(73))
            //    {
            //        blnAllowModifyOther = clsGlobalSysParameter.dicSysParameter[74].ToString().Trim() == "1" ? true : false;
            //    }

            //    int intHour = 0;
            //    if (clsGlobalSysParameter.dicSysParameter.ContainsKey(7))
            //    {
            //        int.TryParse(clsGlobalSysParameter.dicSysParameter[7], out intHour);
            //    }

            //    //if (p_objModifierOrg.m_dtmModifyDate.AddHours(double.Parse(intHour.ToString())) <= dateNow)
            //    if (p_objModifierOrg.m_dtmModifyDate.AddHours(double.Parse(intHour.ToString())) <= dateNow 
            //        && p_objModifierCur.m_strUserID == p_objModifierOrg.m_strUserID
            //        )
            //    {
            //        if (blnAllowModifyOther)
            //            return true;
            //        else
            //            return false;
            //    }

            //    if (p_objModifierCur.m_strUserID != p_objModifierOrg.m_strUserID)
            //    {
            //        return false;
            //    }

            //    if (p_objModifierOrg.m_dtmModifyDate <= clsGlobalCase.objCaseInfo.dtmCreateDate)
            //    {
            //        if (!CompareModifier(true, tableFlag, dbColName, lstTextContentInfos, currentModifyUser)) return false;
            //    }

            //    if (p_objModifierCur.m_strUserID == p_objModifierOrg.m_strUserID && p_objModifierCur.m_dtmModifyDate == p_objModifierOrg.m_dtmModifyDate)
            //        return true;
            //    //else
            //    //    return this.m_blnCompareModifier(true);
            //}
            //catch
            //{
            //    blnReturn = false;
            //}
            //return blnReturn; 
            #endregion

            bool flag = true;
            bool result;
            try
            {
                if (GlobalCase.caseInfo.CaseStatus != 2)
                {
                    result = true;
                    return result;
                }
                if (p_objModifierCur == null || p_objModifierOrg == null)
                {
                    result = false;
                    return result;
                }
                bool flag2 = GlobalRichTextParm.Parm74 == "1" ? true : false;
                int num = Function.Int(GlobalRichTextParm.Parm7);
                if (p_objModifierOrg.ModifyDate.AddHours(double.Parse(num.ToString())) <= dateNow)
                {
                    result = false;
                    return result;
                }
                else
                {
                    if (flag2)
                    {
                        result = true;
                        return result;
                    }

                    if (p_objModifierCur.UserID != p_objModifierOrg.UserID)
                    {
                        result = false;
                        return result;
                    }
                    if (p_objModifierOrg.ModifyDate <= GlobalCase.caseInfo.CreateDate)
                    {
                        if (!RichTextBoxTool.CompareModifier(true, tableFlag, dbColName, lstTextContentInfos, currentModifyUser))
                        {
                            result = false;
                            return result;
                        }
                    }
                    if (p_objModifierCur.UserID == p_objModifierOrg.UserID && p_objModifierCur.ModifyDate == p_objModifierOrg.ModifyDate)
                    {
                        result = true;
                        return result;
                    }
                }
            }
            catch
            {
                flag = false;
            }
            result = flag;
            return result;
        }
        /// <summary>
        /// 修改者比较
        /// </summary>
        public static bool CompareModifier(bool p_blnFlag, bool tableFlag, string dbColName, List<EntityUserContentInfo> lstTextContentInfos, EntityModifyUserInfo currentModifyUser)
        {
            bool blnReturn = true;
            if (GlobalCase.caseInfo.CaseStatus == 2)
            {
                bool bln41 = false;
                List<string> lst41 = GlobalRichTextParm.Parm41.ToLower().Split(';').ToList();
                if (lst41.Count > 0)
                {
                    foreach (string strP41 in lst41)
                    {
                        if (strP41.Split('-').Length == 2)
                        {
                            if (GlobalCase.caseInfo.CaseCode.ToLower().Trim() == strP41.Split('-')[0].Trim() && dbColName.ToLower().Trim() == strP41.Split('-')[1].Trim())
                            {
                                bln41 = true;
                            }
                        }
                    }
                }
                if (bln41)
                {
                    return true;
                }

                lstTextContentInfos.Sort();
                if (lstTextContentInfos.Count > 0)
                {
                    string strCreatorID = string.Empty;
                    if (tableFlag)
                    {
                        strCreatorID = lstTextContentInfos[0].UserID;
                    }
                    else
                    {
                        strCreatorID = GlobalCase.caseInfo.CreatorID.ToString();
                    }

                    if (p_blnFlag)
                    {
                        if (strCreatorID == currentModifyUser.UserID)
                        {
                            blnReturn = CheckUser(strCreatorID);
                        }
                    }
                    else
                    {
                        if (strCreatorID != currentModifyUser.UserID)
                        {
                            return false;
                        }
                        blnReturn = CheckUser(strCreatorID);
                    }
                }
            }
            return blnReturn;
        }
        /// <summary>
        /// 检查用户
        /// </summary>
        /// <param name="p_strEmpID"></param>
        /// <returns></returns>
        private static bool CheckUser(string p_strEmpID)
        {
            bool blnReturn = true;

            if (GlobalCase.caseInfo.Signature == null || GlobalCase.caseInfo.Signature.Count == 0)
            {
                return blnReturn;
            }

            var user = from textuser in GlobalCase.caseInfo.Signature /* this.m_lstTextContentInfos */
                       where (textuser.EmpID.ToString() != p_strEmpID)
                       select textuser;
            if (user.ToArray().Length > 0)
            {
                blnReturn = false;
            }

            return blnReturn;

            //var user = from textuser in this.m_lstTextContentInfos
            //           where ((textuser.m_strUserID != strCreatorID) && 
            //                  (strCreatorID == this.m_objCurrentModifyUser.m_strUserID))
            //           select textuser;
        }


        public static string GetHintInfo(List<EntityUserContentInfo> lstTextContentInfos, List<EntityDstInfo> lstDoubleStrikeThrough, List<EntityView> lstTextView, List<EntityView> lstDDLView, MouseEventArgs e)
        {
            if (GlobalCase.caseInfo != null && GlobalCase.caseInfo.CreatorID != null)
            {
                try
                {
                    string strUserName = string.Empty;
                    DateTime dtmOperDate = DateTime.Now;
                    bool blnStatus = false;

                    if (lstTextContentInfos.Count > 0)
                    {
                        lstTextContentInfos.Sort();
                        foreach (EntityView obj in lstTextView)
                        {
                            if (e.X >= obj.X1 && e.X <= obj.X2 &&
                                e.Y >= obj.Y1 && e.Y <= obj.Y2)
                            {
                                if (lstTextContentInfos[obj.Index].ColorText.ToArgb() == Color.Black.ToArgb())
                                {
                                    break;
                                }

                                strUserName = lstTextContentInfos[obj.Index].UserName;
                                dtmOperDate = lstTextContentInfos[obj.Index].ModifyDate;
                                blnStatus = true;
                                break;
                            }
                        }
                    }

                    if (lstDoubleStrikeThrough.Count > 0)
                    {
                        lstDoubleStrikeThrough.Sort();
                        foreach (EntityView obj in lstDDLView)
                        {
                            if (e.X >= obj.X1 && e.X <= obj.X2 &&
                                e.Y >= obj.Y1 && e.Y <= obj.Y2)
                            {
                                strUserName = lstDoubleStrikeThrough[obj.Index].UserName;
                                dtmOperDate = lstDoubleStrikeThrough[obj.Index].DeleteTime;
                                blnStatus = true;
                                break;
                            }
                        }
                    }

                    if (blnStatus)
                    {
                        return strUserName + "\r\n" + dtmOperDate.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
                catch { }
            }
            return string.Empty;
        }

        #region 获取术语信息
        /// <summary>
        /// 获取术语信息
        /// </summary>
        /// <returns></returns>
        public static string GetXmlOfTerm(List<EntityMedicalTerm> lstMedicalTerm)
        {
            if (lstMedicalTerm.Count == 0)
                return string.Empty;

            lstMedicalTerm.Sort();
            MemoryStream objXmlStream = new MemoryStream();
            XmlTextWriter objXmlWriter = new XmlTextWriter(objXmlStream, System.Text.Encoding.Unicode);

            objXmlWriter.WriteStartDocument();
            objXmlWriter.WriteStartElement("MedicalTerm");
            foreach (EntityMedicalTerm objMedicalTerm in lstMedicalTerm)
            {
                objXmlWriter.WriteStartElement("C");
                objXmlWriter.WriteAttributeString("S", objMedicalTerm.StartIndex.ToString());
                objXmlWriter.WriteAttributeString("E", objMedicalTerm.EndIndex.ToString());
                objXmlWriter.WriteAttributeString("I", objMedicalTerm.UserID);
                objXmlWriter.WriteAttributeString("N", objMedicalTerm.UserName);
                objXmlWriter.WriteAttributeString("D", objMedicalTerm.CreateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                objXmlWriter.WriteAttributeString("T", objMedicalTerm.TID);
                objXmlWriter.WriteAttributeString("V", objMedicalTerm.Value);
                objXmlWriter.WriteEndElement();
            }
            objXmlWriter.WriteEndElement();
            objXmlWriter.WriteEndDocument();
            objXmlWriter.Flush();

            string strXml = System.Text.Encoding.Unicode.GetString(objXmlStream.ToArray(), 0, (int)objXmlStream.Length);

            int intRootBegin = strXml.IndexOf("<MedicalTerm");

            return strXml.Substring(intRootBegin, strXml.Length - intRootBegin);
        }
        #endregion

        #region 获取双划线信息
        /// <summary>
        /// 获取双划线信息
        /// </summary>
        /// <returns></returns>
        public static string GetXmlOfDST(List<EntityDstInfo> lstDoubleStrikeThrough)
        {
            MemoryStream objXmlStream = new MemoryStream();
            XmlTextWriter objXmlWriter = new XmlTextWriter(objXmlStream, System.Text.Encoding.Unicode);

            lstDoubleStrikeThrough.Sort();
            objXmlWriter.WriteStartDocument();
            objXmlWriter.WriteStartElement("Del");
            foreach (EntityDstInfo objDST in lstDoubleStrikeThrough)
            {
                objXmlWriter.WriteStartElement("L");
                objXmlWriter.WriteAttributeString("S", objDST.StartIndex.ToString());
                objXmlWriter.WriteAttributeString("E", objDST.EndIndex.ToString());
                objXmlWriter.WriteAttributeString("V", objDST.Value);
                //objXmlWriter.WriteAttributeString("C", objDST.m_clrDST.ToArgb().ToString());
                objXmlWriter.WriteAttributeString("I", objDST.UserID);
                objXmlWriter.WriteAttributeString("N", objDST.UserName);
                //objXmlWriter.WriteAttributeString("I", objDST.m_intUserSequence.ToString());
                objXmlWriter.WriteAttributeString("D", objDST.DeleteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                objXmlWriter.WriteEndElement();
            }
            objXmlWriter.WriteEndElement();
            objXmlWriter.WriteEndDocument();
            objXmlWriter.Flush();

            string strXml = System.Text.Encoding.Unicode.GetString(objXmlStream.ToArray(), 0, (int)objXmlStream.Length);

            int intRootBegin = strXml.IndexOf("<Del");

            return strXml.Substring(intRootBegin, strXml.Length - intRootBegin);
        }
        #endregion

        private static string GetElementName(EntityMedicalTerm objElement, string textStr)
        {
            try
            {
                return textStr.Substring(objElement.StartIndex, objElement.EndIndex - objElement.StartIndex + 1);
            }
            catch
            { }
            return string.Empty;
        }

        public static bool RemoveElement(EntityMedicalTerm objElement, ref List<EntityMedicalTerm> lstMedicalTerm)
        {
            if (objElement.EndIndex < 0 || objElement.StartIndex > objElement.EndIndex || (objElement.StartIndex == objElement.EndIndex && objElement.Value == string.Empty))
            {
                lstMedicalTerm.Remove(objElement);
                return true;
            }
            return false;
        }

        /// <summary>
        /// AdjustElementPosition_DeleteBath
        /// </summary>
        /// <param name="p_intIndex"></param>
        /// <param name="p_intDiffLength"></param>
        /// <param name="textStr"></param>
        /// <param name="lstMedicalTerm"></param>
        public static void AdjustElementPosition_DeleteBath(int p_intIndex, int p_intDiffLength, string textStr, ref List<EntityMedicalTerm> lstMedicalTerm)
        {
            int intStartIndex = p_intIndex;
            int intEndIndex = intStartIndex + p_intDiffLength - 1;

            EntityMedicalTerm objElement = null;
            lstMedicalTerm.Sort();
            for (int i = lstMedicalTerm.Count - 1; i >= 0; i--)
            {
                objElement = lstMedicalTerm[i];
                if (objElement.StartIndex >= intStartIndex && objElement.EndIndex <= intEndIndex)
                {
                    lstMedicalTerm.Remove(objElement);
                    continue;
                }

                if (objElement.StartIndex >= intStartIndex && objElement.EndIndex > intEndIndex)
                {
                    if (objElement.EndIndex - p_intDiffLength >= textStr.Length)
                        continue;
                    objElement.StartIndex = intStartIndex;
                    objElement.EndIndex -= p_intDiffLength;
                    if (!RemoveElement(objElement, ref lstMedicalTerm))
                        objElement.Value = GetElementName(objElement, textStr); //this.Text.Substring(objElement.m_intStartIndex, objElement.m_intEndIndex - objElement.m_intStartIndex + 1);
                    continue;
                }

                if (objElement.StartIndex < intStartIndex && objElement.EndIndex <= intEndIndex && objElement.EndIndex >= intStartIndex)
                {
                    if (objElement.EndIndex - p_intDiffLength >= textStr.Length)
                        continue;
                    objElement.EndIndex -= p_intDiffLength;
                    if (!RemoveElement(objElement, ref lstMedicalTerm))
                        objElement.Value = GetElementName(objElement, textStr); //this.Text.Substring(objElement.m_intStartIndex, objElement.m_intEndIndex - objElement.m_intStartIndex + 1);
                    continue;
                }

                if (objElement.StartIndex < intStartIndex && objElement.EndIndex > intEndIndex)
                {
                    if (objElement.EndIndex - p_intDiffLength >= textStr.Length)
                        continue;
                    objElement.EndIndex -= p_intDiffLength;
                    if (!RemoveElement(objElement, ref lstMedicalTerm))
                        objElement.Value = GetElementName(objElement, textStr); //this.Text.Substring(objElement.m_intStartIndex, objElement.m_intEndIndex - objElement.m_intStartIndex + 1);
                    continue;
                }
            }
        }

        /// <summary>
        /// 计算字符
        /// </summary>
        /// <param name="p_lstTempData"></param>
        public static void ComputeChar(ref List<EntityTempData> p_lstTempData, List<EntityDstInfo> lstDoubleStrikeThrough, List<EntityMedicalTerm> lstMedicalTerm, string textStr)
        {
            EntityTempData objTempData = null;
            p_lstTempData = new List<EntityTempData>();
            if (lstDoubleStrikeThrough.Count > 0)
            {
                lstDoubleStrikeThrough.Sort();
                foreach (EntityDstInfo objDST in lstDoubleStrikeThrough)
                {
                    if (objDST.StartIndex < 0) continue;
                    objTempData = new EntityTempData();
                    objTempData.StartIndex = objDST.StartIndex;
                    objTempData.EndIndex = objDST.EndIndex;
                    objTempData.Len = objDST.Value.Length;
                    p_lstTempData.Add(objTempData);
                }
            }

            if (lstMedicalTerm.Count > 0)
            {
                lstMedicalTerm.Sort();
                if (p_lstTempData.Count > 0)
                {
                    int intStart = 0;
                    int intEnd = 0;
                    bool blnStatus1 = false;
                    bool blnStatus2 = false;
                    List<EntityTempData> lstTmp = new List<EntityTempData>();
                    foreach (EntityMedicalTerm objTerm in lstMedicalTerm)
                    {
                        blnStatus1 = false;
                        blnStatus2 = false;
                        intStart = objTerm.StartIndex;
                        intEnd = objTerm.EndIndex;
                        foreach (EntityTempData objTemp in p_lstTempData)
                        {
                            if (objTemp.StartIndex <= intStart && intStart <= objTemp.EndIndex)
                                blnStatus1 = true;
                            if (objTemp.StartIndex <= intEnd && intEnd <= objTemp.EndIndex)
                                blnStatus2 = true;
                            if (blnStatus1 && blnStatus2)
                                break;
                        }
                        if (!blnStatus1)
                        {
                            objTempData = new EntityTempData();
                            objTempData.StartIndex = intStart;
                            objTempData.EndIndex = objTempData.StartIndex;
                            objTempData.Len = 1;
                            if (textStr.Substring(objTempData.StartIndex, 1) == "[")
                            {
                                lstTmp.Add(objTempData);
                            }
                        }
                        if (!blnStatus2)
                        {
                            objTempData = new EntityTempData();
                            objTempData.StartIndex = intEnd;
                            objTempData.EndIndex = objTempData.StartIndex;
                            objTempData.Len = 1;
                            if (textStr.Substring(objTempData.StartIndex, 1) == "]")
                            {
                                lstTmp.Add(objTempData);
                            }
                        }
                    }
                    p_lstTempData.AddRange(lstTmp);
                }
                else
                {
                    foreach (EntityMedicalTerm objTerm in lstMedicalTerm)
                    {
                        objTempData = new EntityTempData();
                        objTempData.StartIndex = objTerm.StartIndex;
                        objTempData.EndIndex = objTempData.StartIndex;
                        objTempData.Len = 1;
                        if (textStr.Substring(objTempData.StartIndex, 1) == "[")
                        {
                            p_lstTempData.Add(objTempData);
                        }

                        objTempData = new EntityTempData();
                        objTempData.StartIndex = objTerm.EndIndex;
                        objTempData.EndIndex = objTempData.StartIndex;
                        objTempData.Len = 1;
                        if (textStr.Substring(objTempData.StartIndex, 1) == "]")
                        {
                            p_lstTempData.Add(objTempData);
                        }
                    }
                }
            }
            p_lstTempData.Sort();
        }

        #region 获取指定位置字符右下角的坐标
        /// <summary>
        ///  获取指定位置字符右下角的坐标.for Dst
        /// </summary>
        /// <param name="intCharIndex"></param>
        /// <param name="g"></param>
        /// <returns></returns>
        private static Point GetCharPositionRightDown(int intCharIndex, Graphics g, RichTextBox rich)
        {
            if (intCharIndex < 0) intCharIndex = 0;
            if (intCharIndex >= rich.TextLength) intCharIndex = rich.TextLength - 1;
            int fontHeight = rich.Font.Height;

            Point ptLeftUp = rich.GetPositionFromCharIndex(intCharIndex);
            Point ptRightUp = rich.GetPositionFromCharIndex(intCharIndex + 1);
            Point ptRightDown;
            if (ptLeftUp.Y == ptRightUp.Y)
            {
                ptRightDown = new Point(ptRightUp.X, ptRightUp.Y + fontHeight);
            }
            else
            {
                int intCharWidth = (int)g.MeasureString(rich.Text[intCharIndex].ToString(), rich.Font).Width - 5;
                ptRightDown = new Point(ptLeftUp.X + intCharWidth, ptLeftUp.Y + fontHeight);
            }
            return ptRightDown;
        }
        #endregion

        #region 画点
        /// <summary>
        /// 画点
        /// </summary>
        /// <param name="p_objGrp"></param>
        public static void DrawPoint(Graphics p_objGrp, List<EntityMedicalTerm> lstMedicalTerm, RichTextBox rich)
        {
            try
            {
                Form frmParent = rich.FindForm();
                if (frmParent is IRichTextStyle)
                {
                    if (((IRichTextStyle)frmParent).IsShowElementRedPoint)
                    {
                        Pen penPoint = new Pen(Color.Red);
                        SolidBrush brushPoint = new SolidBrush(Color.Red);
                        foreach (EntityMedicalTerm objElement in lstMedicalTerm)
                        {
                            if (GlobalCase.caseInfo.CaseStatus == 0 && (string.IsNullOrEmpty(objElement.UserID) || objElement.UserID == "8888"))
                            {
                                Point pntEnd = GetCharPositionRightDown(objElement.EndIndex, p_objGrp, rich);
                                p_objGrp.DrawEllipse(penPoint, pntEnd.X - 10, pntEnd.Y + 7, 3, 3);
                                p_objGrp.FillEllipse(brushPoint, pntEnd.X - 10, pntEnd.Y + 7, 3, 3);
                            }
                        }
                    }
                }
            }
            catch { }
        }
        #endregion

        #region 画双删除线
        /// <summary>
        /// 添加预览对象信息
        /// </summary>
        /// <param name="p_objPoint"></param>
        /// <param name="p_intWidth"></param>
        /// <param name="p_intHeight"></param>
        /// <param name="p_intIndex"></param>
        /// <param name="p_intType">1. 文本  2. 双划线 3. 元素(词汇)</param>
        private static void AddViewInfo(Point p_objPoint, int p_intWidth, int p_intHeight, int p_intIndex, int p_intType,
                                             ref List<EntityView> lstTextView, ref List<EntityView> lstDDLView, ref List<EntityView> lstElementView)
        {
            EntityView objView = new EntityView();
            objView.X1 = p_objPoint.X;
            objView.X2 = p_objPoint.X + p_intWidth;
            objView.Y1 = p_objPoint.Y - p_intHeight;
            objView.Y2 = p_objPoint.Y + p_intHeight + 10;
            objView.Index = p_intIndex;
            if (p_intType == 1)
            {
                lstTextView.Add(objView);
            }
            else if (p_intType == 2)
            {
                lstDDLView.Add(objView);
            }
            else if (p_intType == 3)
            {
                lstElementView.Add(objView);
            }
        }

        /// <summary>
        /// 画双删除线
        /// </summary>
        /// <param name="p_objGrp"></param> 
        public static void DrawDST(Graphics p_objGrp, Point pntEndVisible, int previouslyLen, bool useRowSpacing, bool tableFlag, RichTextBox rich, List<EntityUserContentInfo> lstTextContentInfos, List<EntityDstInfo> lstDoubleStrikeThrough, List<EntityMedicalTerm> lstMedicalTerm, ref List<EntityView> lstTextView, ref List<EntityView> lstDDLView, ref List<EntityView> lstElementView)
        {
            try
            {
                int intStartVisibleCharIndex = rich.GetCharIndexFromPosition(Point.Empty);
                int intEndVisibleCharIndex = rich.GetCharIndexFromPosition(pntEndVisible);

                if ((intEndVisibleCharIndex == 0) && (rich.Text.Length != 1)) return;

                #region 内容位置
                lstTextView.Clear();
                lstTextContentInfos.Sort();

                int fontHeight = rich.Font.Height;
                int intIndex = 0;
                foreach (EntityUserContentInfo objContentInfo in lstTextContentInfos)
                {
                    //if (objContentInfo.m_clrText != Color.Red) continue;
                    //起止位置
                    int intStartIndex = objContentInfo.StartIndex;
                    int intEndIndex = objContentInfo.EndIndex;
                    //在可视区域之前,不处理
                    if (intEndIndex < intStartVisibleCharIndex) continue;
                    //在可视区域之后,退出
                    if ((intEndVisibleCharIndex > 0) && (intStartIndex > intEndVisibleCharIndex)) break;
                    //数据合法性
                    if ((intStartIndex < 0) || (intEndIndex < 0) || (intStartIndex >= rich.TextLength) || (intEndIndex >= rich.TextLength)) continue;

                    while (intStartIndex <= intEndIndex)
                    {
                        //边界值处理
                        if (intStartIndex < intStartVisibleCharIndex)
                            intStartIndex = intStartVisibleCharIndex;

                        if ((intEndVisibleCharIndex > 0) && (intEndIndex > intEndVisibleCharIndex))
                            intEndIndex = intEndVisibleCharIndex;

                        //起止行
                        int intUpLine = rich.GetLineFromCharIndex(intStartIndex);
                        int intDownLine = rich.GetLineFromCharIndex(intEndIndex);

                        if (intUpLine == intDownLine)
                        {
                            #region 头尾同一行

                            Point pntStart = rich.GetPositionFromCharIndex(intStartIndex);
                            Point pntEnd = GetCharPositionRightDown(intEndIndex, p_objGrp, rich);

                            AddViewInfo(pntStart, pntEnd.X - pntStart.X, fontHeight, intIndex, 1,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);

                            #endregion
                        }
                        else
                        {
                            #region 不在同一行,即多行

                            Point pntTemp = new Point(rich.Width, 0);
                            Point pntStart = rich.GetPositionFromCharIndex(intStartIndex);

                            if (pntStart.Y < 0)
                            {
                                intStartIndex++;
                                continue;
                            }

                            pntTemp.Y = pntStart.Y;
                            int intEndCharIndex = rich.GetCharIndexFromPosition(pntTemp) - 1;
                            int intLineWidth = rich.GetPositionFromCharIndex(intEndCharIndex).X;
                            intLineWidth += (int)p_objGrp.MeasureString(rich.Text[intEndCharIndex].ToString(), rich.Font).Width - 5 - pntStart.X;
                            AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 1,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);

                            intUpLine++;
                            while (intUpLine < intDownLine)
                            {
                                int intStartCharIndex = intEndCharIndex + 1;
                                pntStart = rich.GetPositionFromCharIndex(intEndCharIndex + 1);

                                int intCharAdd = 2;
                                while (pntStart.Y == pntTemp.Y)
                                {
                                    intStartCharIndex = intEndCharIndex + intCharAdd;
                                    pntStart = rich.GetPositionFromCharIndex(intStartCharIndex);
                                    intCharAdd++;
                                }

                                pntTemp.Y = pntStart.Y;
                                intEndCharIndex = rich.GetCharIndexFromPosition(pntTemp) - 1;
                                if (intStartCharIndex < rich.Text.Length)
                                {
                                    if (intEndCharIndex - intStartCharIndex <= 0 || rich.Text.Substring(intStartCharIndex, intEndCharIndex - intStartCharIndex - 1).Trim() == "")
                                    {
                                        intUpLine++;
                                        continue;
                                    }
                                }

                                intLineWidth = rich.GetPositionFromCharIndex(intEndCharIndex).X;
                                intLineWidth += (int)p_objGrp.MeasureString(rich.Text[intEndCharIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                                AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 1,
                                            ref lstTextView, ref lstDDLView, ref lstElementView);
                                intUpLine++;
                            }

                            pntStart = rich.GetPositionFromCharIndex(intEndCharIndex + 1);

                            int intCharAdd1 = 2;
                            while (pntStart.Y == pntTemp.Y)
                            {
                                int intStartCharIndex = intEndCharIndex + intCharAdd1;
                                pntStart = rich.GetPositionFromCharIndex(intStartCharIndex);
                                intCharAdd1++;
                            }

                            if (intEndIndex + 1 < rich.Text.Length)
                            {
                                Point pntEnd = rich.GetPositionFromCharIndex(intEndIndex + 1);

                                if (pntEnd.Y == pntStart.Y)
                                    intLineWidth = pntEnd.X - pntStart.X;
                                else
                                    intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;
                            }
                            else
                                intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                            AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 1,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);
                            #endregion
                        }
                        break;
                    }
                    intIndex++;
                }
                #endregion

                #region 元素.词汇
                lstElementView.Clear();
                lstMedicalTerm.Sort();

                intIndex = 0;
                foreach (EntityMedicalTerm objElem in lstMedicalTerm)
                {
                    //起止位置
                    int intStartIndex = objElem.StartIndex;
                    int intEndIndex = objElem.EndIndex;
                    //在可视区域之前,不处理
                    if (intEndIndex < intStartVisibleCharIndex) continue;
                    //在可视区域之后,退出
                    if ((intEndVisibleCharIndex > 0) && (intStartIndex > intEndVisibleCharIndex)) break;
                    //数据合法性
                    if ((intStartIndex < 0) || (intEndIndex < 0) || (intStartIndex >= rich.TextLength) || (intEndIndex >= rich.TextLength)) continue;

                    while (intStartIndex <= intEndIndex)
                    {
                        //边界值处理
                        if (intStartIndex < intStartVisibleCharIndex)
                            intStartIndex = intStartVisibleCharIndex;

                        if ((intEndVisibleCharIndex > 0) && (intEndIndex > intEndVisibleCharIndex))
                            intEndIndex = intEndVisibleCharIndex;

                        //起止行
                        int intUpLine = rich.GetLineFromCharIndex(intStartIndex);
                        int intDownLine = rich.GetLineFromCharIndex(intEndIndex);

                        if (intUpLine == intDownLine)
                        {
                            #region 头尾同一行

                            Point pntStart = rich.GetPositionFromCharIndex(intStartIndex);
                            Point pntEnd = GetCharPositionRightDown(intEndIndex, p_objGrp, rich);

                            AddViewInfo(pntStart, pntEnd.X - pntStart.X, fontHeight, intIndex, 3,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);

                            #endregion
                        }
                        else
                        {
                            #region 不在同一行,即多行

                            Point pntTemp = new Point(rich.Width, 0);
                            Point pntStart = rich.GetPositionFromCharIndex(intStartIndex);

                            if (pntStart.Y < 0)
                            {
                                intStartIndex++;
                                continue;
                            }

                            pntTemp.Y = pntStart.Y;

                            int intEndCharIndex = rich.GetCharIndexFromPosition(pntTemp) - 1;
                            int intLineWidth = rich.GetPositionFromCharIndex(intEndCharIndex).X;
                            intLineWidth += (int)p_objGrp.MeasureString(rich.Text[intEndCharIndex].ToString(), rich.Font).Width - 5 - pntStart.X;
                            AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 3,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);

                            intUpLine++;
                            while (intUpLine < intDownLine)
                            {
                                int intStartCharIndex = intEndCharIndex + 1;
                                pntStart = rich.GetPositionFromCharIndex(intEndCharIndex + 1);

                                int intCharAdd = 2;
                                while (pntStart.Y == pntTemp.Y)
                                {
                                    intStartCharIndex = intEndCharIndex + intCharAdd;
                                    pntStart = rich.GetPositionFromCharIndex(intStartCharIndex);
                                    intCharAdd++;
                                }

                                pntTemp.Y = pntStart.Y;

                                intEndCharIndex = rich.GetCharIndexFromPosition(pntTemp) - 1;

                                if (intStartCharIndex < rich.Text.Length)
                                {
                                    if (intEndCharIndex - intStartCharIndex <= 0 || rich.Text.Substring(intStartCharIndex, intEndCharIndex - intStartCharIndex - 1).Trim() == "")
                                    {
                                        intUpLine++;
                                        continue;
                                    }
                                }

                                intLineWidth = rich.GetPositionFromCharIndex(intEndCharIndex).X;
                                intLineWidth += (int)p_objGrp.MeasureString(rich.Text[intEndCharIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                                AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 3,
                                            ref lstTextView, ref lstDDLView, ref lstElementView);
                                intUpLine++;
                            }

                            pntStart = rich.GetPositionFromCharIndex(intEndCharIndex + 1);

                            int intCharAdd1 = 2;
                            while (pntStart.Y == pntTemp.Y)
                            {
                                int intStartCharIndex = intEndCharIndex + intCharAdd1;
                                pntStart = rich.GetPositionFromCharIndex(intStartCharIndex);
                                intCharAdd1++;
                            }

                            if (intEndIndex + 1 < rich.Text.Length)
                            {
                                Point pntEnd = rich.GetPositionFromCharIndex(intEndIndex + 1);

                                if (pntEnd.Y == pntStart.Y)
                                {
                                    intLineWidth = pntEnd.X - pntStart.X;
                                }
                                else
                                    intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;
                            }
                            else
                                intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                            AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 3,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);
                            #endregion
                        }
                        break;
                    }
                    intIndex++;
                }
                #endregion

                if (lstDoubleStrikeThrough.Count == 0) return;
                Pen penStrike = new Pen(Color.Red);

                #region 画双划线
                int intOffset = 16;// 8;
                if (!useRowSpacing || tableFlag) intOffset = 8;
                //intOffset += Convert.ToInt32(Math.Ceiling(decimal.Parse(Convert.ToString((this._intRowSpacing - 300) * 8 / 300)))) * 2 + 2;

                lstDDLView.Clear();
                lstDoubleStrikeThrough.Sort();

                intIndex = 0;
                foreach (EntityDstInfo objDST in lstDoubleStrikeThrough)
                {
                    int intStartIndex = objDST.StartIndex;
                    int intEndIndex = objDST.EndIndex;

                    if (intEndIndex < intStartVisibleCharIndex) continue;

                    if ((intEndVisibleCharIndex > 0) && (intStartIndex > intEndVisibleCharIndex)) return;

                    penStrike.Color = objDST.ColorDst;

                    if ((intStartIndex < 0) || (intEndIndex < 0) || (intStartIndex >= previouslyLen) || (intEndIndex >= previouslyLen)) continue;

                    while (intStartIndex <= intEndIndex)
                    {
                        if (intStartIndex < intStartVisibleCharIndex)
                            intStartIndex = intStartVisibleCharIndex;

                        if ((intEndVisibleCharIndex > 0) && (intEndIndex > intEndVisibleCharIndex))
                            intEndIndex = intEndVisibleCharIndex;

                        int intUpLine = rich.GetLineFromCharIndex(intStartIndex);
                        int intDownLine = rich.GetLineFromCharIndex(intEndIndex);

                        if (intUpLine == intDownLine)
                        {
                            #region 头尾同一行

                            Point pntStart = rich.GetPositionFromCharIndex(intStartIndex);

                            int intLineWidth = 0;

                            if (intEndIndex + 1 < rich.Text.Length)
                            {
                                Point pntEnd = rich.GetPositionFromCharIndex(intEndIndex + 1);

                                if (pntEnd.Y == pntStart.Y)
                                    intLineWidth = pntEnd.X - pntStart.X;
                                else
                                    intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;
                            }
                            else
                                intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                            AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 2,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);
                            pntStart.Offset(0, intOffset);
                            p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);
                            pntStart.Offset(0, 3);
                            p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);

                            #endregion
                        }
                        else
                        {
                            #region 不在同一行,即多行

                            Point pntTemp = new Point(rich.Width, 0);

                            Point pntStart = rich.GetPositionFromCharIndex(intStartIndex);

                            if (pntStart.Y < 0)
                            {
                                intStartIndex++;
                                continue;
                            }
                            pntTemp.Y = pntStart.Y;

                            int intEndCharIndex = rich.GetCharIndexFromPosition(pntTemp) - 1;
                            int intLineWidth = rich.GetPositionFromCharIndex(intEndCharIndex).X;
                            intLineWidth += (int)p_objGrp.MeasureString(rich.Text[intEndCharIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                            AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 2,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);
                            pntStart.Offset(0, intOffset);
                            p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);
                            pntStart.Offset(0, 3);
                            p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);

                            intUpLine++;

                            while (intUpLine < intDownLine)
                            {
                                int intStartCharIndex = intEndCharIndex + 1;

                                pntStart = rich.GetPositionFromCharIndex(intEndCharIndex + 1);

                                int intCharAdd = 2;
                                while (pntStart.Y == pntTemp.Y)
                                {
                                    intStartCharIndex = intEndCharIndex + intCharAdd;
                                    pntStart = rich.GetPositionFromCharIndex(intStartCharIndex);
                                    intCharAdd++;
                                }

                                pntTemp.Y = pntStart.Y;

                                intEndCharIndex = rich.GetCharIndexFromPosition(pntTemp) - 1;

                                if (intStartCharIndex < rich.Text.Length)
                                {
                                    if (intEndCharIndex - intStartCharIndex == 0 || intEndCharIndex - intStartCharIndex <= 0 || rich.Text.Substring(intStartCharIndex, intEndCharIndex - intStartCharIndex - 1).Trim() == "")
                                    {
                                        intUpLine++;
                                        continue;
                                    }
                                }

                                intLineWidth = rich.GetPositionFromCharIndex(intEndCharIndex).X;
                                intLineWidth += (int)p_objGrp.MeasureString(rich.Text[intEndCharIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                                AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 2,
                                            ref lstTextView, ref lstDDLView, ref lstElementView);
                                pntStart.Offset(0, intOffset);
                                p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);
                                pntStart.Offset(0, 3);
                                p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);

                                intUpLine++;
                            }

                            pntStart = rich.GetPositionFromCharIndex(intEndCharIndex + 1);

                            int intCharAdd1 = 2;
                            while (pntStart.Y == pntTemp.Y)
                            {
                                int intStartCharIndex = intEndCharIndex + intCharAdd1;
                                pntStart = rich.GetPositionFromCharIndex(intStartCharIndex);
                                intCharAdd1++;
                            }

                            if (intEndIndex + 1 < rich.Text.Length)
                            {
                                Point pntEnd = rich.GetPositionFromCharIndex(intEndIndex + 1);

                                if (pntEnd.Y == pntStart.Y)
                                {
                                    intLineWidth = pntEnd.X - pntStart.X;
                                }
                                else
                                    intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;
                            }
                            else
                                intLineWidth = rich.GetPositionFromCharIndex(intEndIndex).X + (int)p_objGrp.MeasureString(rich.Text[intEndIndex].ToString(), rich.Font).Width - 5 - pntStart.X;

                            AddViewInfo(pntStart, intLineWidth, fontHeight, intIndex, 2,
                                        ref lstTextView, ref lstDDLView, ref lstElementView);
                            pntStart.Offset(0, intOffset);
                            p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);
                            pntStart.Offset(0, 3);
                            p_objGrp.DrawLine(penStrike, pntStart.X, pntStart.Y, pntStart.X + intLineWidth, pntStart.Y);

                            #endregion
                        }

                        break;
                    }
                    intIndex++;
                }
                #endregion

                penStrike.Dispose();
            }
            catch (Exception err)
            {
                string strErr = err.Message;
            }
        }
        #endregion

        #region 画虚线
        /// <summary>
        /// 画虚线
        /// </summary>
        public static void DrawVirtualLine(Graphics objGrp, int mode, string caption, RichTextBox rich)
        {
            if (mode == 1 || mode == 3)
            {
                SizeF sf = SizeF.Empty;
                if (!string.IsNullOrEmpty(caption))
                    sf = objGrp.MeasureString(caption, rich.Font);
                Pen p = new Pen(Brushes.Black);
                if (mode == 1)
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                    p.DashPattern = new float[] { 2.0F, 2.0F };
                }
                else if (mode == 3)
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }
                bool blnMuti = false;
                if (rich.Text.Length > 0)
                {
                    int intRow = 1;
                    int intRowChr = 0;
                    int intY = 0;
                    do
                    {
                        intRowChr = rich.GetFirstCharIndexFromLine(intRow);
                        Point point = rich.GetPositionFromCharIndex(intRowChr);
                        if (intY == point.Y)
                            break;
                        else if (point.Y > 15)
                        {
                            if (intRow == 1)
                                objGrp.DrawLine(p, new Point((Int32)sf.Width - 2, point.Y), new Point(rich.Width, point.Y));
                            else
                                objGrp.DrawLine(p, new Point(0, point.Y), new Point(rich.Width, point.Y));
                            blnMuti = true;
                        }
                        intY = point.Y;
                        intRow++;
                    } while (true);
                }
                if (blnMuti)
                    objGrp.DrawLine(p, new Point(0, rich.Height - 1), new Point(rich.Width, rich.Height - 1));
                else
                    objGrp.DrawLine(p, new Point((Int32)sf.Width - 2, rich.Height - 1), new Point(rich.Width, rich.Height - 1));
            }
        }
        #endregion

        /// <summary>
        /// 设置行间距
        /// </summary>
        public static void SetRowSpacing(int rowSpacing, RichTextBox rich)
        {
            RichTextBoxTool.StopRedraw(rich.Handle);

            RichTextBoxPlus.PARAFORMAT2 fmt = new RichTextBoxPlus.PARAFORMAT2();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.bLineSpacingRule = 3;
            fmt.dyLineSpacing = 20 * rowSpacing;
            fmt.dwMask = RichTextBoxPlus.PFM_LINESPACING;
            RichTextBoxPlus.SendMessage(new HandleRef(rich, rich.Handle), RichTextBoxPlus.EM_SETPARAFORMAT, 0, ref fmt);
            RichTextBoxTool.Redraw(rich.Handle);
        }

        /// <summary>
        /// SetMedicalTermColor
        /// </summary>
        /// <param name="p_intType"></param>
        /// <param name="font"></param>
        /// <param name="rich"></param>
        /// <param name="lstMedicalTerm"></param>
        /// <returns></returns>
        public static string SetMedicalTermColor(int p_intType, Font font, RichTextBox rich, List<EntityMedicalTerm> lstMedicalTerm)
        {
            if (lstMedicalTerm.Count == 0) return string.Empty;

            using (RichTextBox rtx = new RichTextBox())
            {
                rtx.Rtf = rich.Rtf;

                rtx.SelectionLength = 0;

                for (int i = 0; i < lstMedicalTerm.Count; i++)
                {
                    if (TermPrefix == string.Empty)
                    {
                        if (p_intType == 1)
                        {
                            rtx.SelectionStart = lstMedicalTerm[i].StartIndex + 1;
                            rtx.SelectionLength = lstMedicalTerm[i].Value.Length - 1;
                        }
                        else
                        {
                            rtx.SelectionStart = lstMedicalTerm[i].StartIndex;
                            rtx.SelectionLength = lstMedicalTerm[i].Value.Length;
                        }
                        if (lstMedicalTerm[i].IsChangeColor)
                            rtx.SelectionColor = ElementEditColor;
                        else
                            rtx.SelectionColor = TermColor;
                        rtx.SelectionFont = font;
                    }
                    else
                    {
                        rtx.SelectionStart = lstMedicalTerm[i].StartIndex;
                        rtx.SelectionLength = 1;
                        rtx.SelectionColor = rich.BackColor;
                        rtx.SelectionStart = lstMedicalTerm[i].StartIndex + 1;
                        rtx.SelectionLength = lstMedicalTerm[i].Value.Length - 1;
                    }
                }

                return rtx.Rtf;
            }
        }

        private static EntityMedicalTerm CursorPositionToTerm_Insert(int index, List<EntityMedicalTerm> lstMedicalTerm)
        {
            foreach (EntityMedicalTerm obj in lstMedicalTerm)
            {
                if (obj.StartIndex < index && index <= obj.EndIndex + 1)
                {
                    return obj;
                }
            }
            return null;
        }

        private static bool CursorPositionToTerm_Midd(int index, List<EntityMedicalTerm> lstMedicalTerm)
        {
            foreach (EntityMedicalTerm obj in lstMedicalTerm)
            {
                if (obj.StartIndex < index && index <= obj.EndIndex)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CursorPositionToTerm_End(int index, List<EntityMedicalTerm> lstMedicalTerm)
        {
            foreach (EntityMedicalTerm obj in lstMedicalTerm)
            {
                if (obj.EndIndex + 1 == index)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 分割元素
        /// </summary>
        /// <param name="p_strContent"></param>
        /// <returns></returns>
        private static string[] SplitElement(string p_strContent)
        {
            char[] chrArr = new char[] { ',', ';', '.', '，', '；', '。' };
            return p_strContent.Split(chrArr);
        }

        /// <summary>
        /// 调整元素.词汇位置---Insert
        /// </summary>
        /// <param name="p_intNewLen"></param>
        public static void AdjustElementPosition_Insert(int p_intIndex, int p_intNewLen, List<EntityMedicalTerm> lstMedicalTerm, string textStr)
        {
            EntityMedicalTerm objElement = CursorPositionToTerm_Insert(p_intIndex, lstMedicalTerm);
            if (objElement != null && objElement.EndIndex + p_intNewLen + 1 <= textStr.Length)
            {
                objElement.EndIndex += p_intNewLen;
                objElement.Value = textStr.Substring(objElement.StartIndex, objElement.EndIndex - objElement.StartIndex + 1);
            }
        }

        /// <summary>
        /// 处理添加
        /// </summary>
        /// <param name="p_intNewLen">新添加的长度</param>
        public static void HandleInsert(RichTextBox rich, ref List<EntityMedicalTerm> lstMedicalTerm, ref List<EntityUserContentInfo> lstTextContentInfos, ref List<EntityDstInfo> lstDoubleStrikeThrough, int p_intNewLen, Font font, ref bool canSelectedChanged, ref bool isInsertPatElement, ref int currentCursorIndex,
                                        bool isDealIdeaCol, bool isInsertNorElement, bool isAllowElementFreeEdit, EntityModifyUserInfo currentModifyUser, Color clrOldPartInsertText, DateTime dateNow)
        {
            //设置新插入部分的颜色
            bool blnTempCanSel = canSelectedChanged;
            canSelectedChanged = false;

            int intTempStartIndex = rich.SelectionStart;
            int intElementInsertPostion = intTempStartIndex - p_intNewLen;
            rich.SelectionLength = 0;

            if (isInsertPatElement)
            {
                isInsertPatElement = false;
            }
            else
            {
                if (!isInsertNorElement && CursorPositionToTerm_Midd(intElementInsertPostion, lstMedicalTerm) && isAllowElementFreeEdit)
                {
                    rich.SelectionStart = intElementInsertPostion;
                    rich.SelectionLength = p_intNewLen;
                    rich.SelectionColor = RichTextBoxTool.ElementEditColor;
                    rich.SelectionFont = font;
                    rich.SelectionCharOffset = 0;
                    AdjustElementPosition_Insert(intElementInsertPostion, p_intNewLen, lstMedicalTerm, rich.Text);
                }
                else if (!isInsertNorElement && CursorPositionToTerm_End(intElementInsertPostion, lstMedicalTerm) && isAllowElementFreeEdit)
                {
                    string strContent = rich.Text.Substring(intElementInsertPostion, p_intNewLen);
                    List<string> lstArr = SplitElement(strContent).ToList();
                    if (lstArr.Count == 1 && lstArr[0] != string.Empty && isAllowElementFreeEdit)
                    {
                        rich.SelectionStart = intElementInsertPostion;
                        rich.SelectionLength = p_intNewLen;
                        rich.SelectionColor = RichTextBoxTool.ElementEditColor;
                        rich.SelectionFont = font;
                        rich.SelectionCharOffset = 0;
                        AdjustElementPosition_Insert(intElementInsertPostion, p_intNewLen, lstMedicalTerm, rich.Text);
                    }
                    else if (lstArr.Count > 1)
                    {
                        if (lstArr[0] == string.Empty)
                        {
                            rich.SelectionStart = intElementInsertPostion;
                            rich.SelectionLength = p_intNewLen;
                            rich.SelectionColor = clrOldPartInsertText;
                            rich.SelectionFont = rich.Font;
                            rich.SelectionCharOffset = 0;
                        }
                        else
                        {
                            if (isAllowElementFreeEdit)
                            {
                                rich.SelectionStart = intElementInsertPostion;
                                rich.SelectionLength = lstArr[0].Length;
                                rich.SelectionColor = RichTextBoxTool.ElementEditColor;
                                rich.SelectionFont = font;
                                rich.SelectionCharOffset = 0;
                                AdjustElementPosition_Insert(intElementInsertPostion, lstArr[0].Length, lstMedicalTerm, rich.Text);
                            }

                            rich.SelectionStart = intElementInsertPostion + lstArr[0].Length;
                            rich.SelectionLength = p_intNewLen - lstArr[0].Length;
                            rich.SelectionColor = clrOldPartInsertText;
                            rich.SelectionFont = rich.Font;
                            rich.SelectionCharOffset = 0;
                        }
                    }
                }
                else
                {
                    if (intElementInsertPostion < 0) intElementInsertPostion = rich.SelectionStart;
                    rich.SelectionStart = intElementInsertPostion; // m_intCurrentCursorIndex;
                    rich.SelectionLength = p_intNewLen;
                    rich.SelectionColor = clrOldPartInsertText;
                    rich.SelectionFont = rich.Font;
                    rich.SelectionCharOffset = 0;
                }
            }
            rich.SelectionLength = 0;
            rich.SelectionStart = intTempStartIndex;

            canSelectedChanged = blnTempCanSel;
            RichTextBoxTool.AdjustContentPosition_Insert(p_intNewLen, ref lstTextContentInfos, currentModifyUser, currentCursorIndex, dateNow, clrOldPartInsertText);
            if (p_intNewLen != 0)
            {
                RichTextBoxTool.AdjustDSTPosition(ref lstDoubleStrikeThrough, rich);
                RichTextBoxTool.AdjustTermPosition(ref lstMedicalTerm, font, rich);
            }

            currentCursorIndex = rich.SelectionStart;
            rich.Invalidate();
        }

        #region HandleDelete
        /// <summary>
        /// 处理删除
        /// </summary>
        public static void HandleDelete(RichTextBox rich, int p_intDelLen, ref int currentCursorIndex, bool isBackspace, ref List<EntityUserContentInfo> lstTextContentInfos, ref List<EntityMedicalTerm> lstMedicalTerm, ref List<EntityDstInfo> lstDoubleStrikeThrough, Font font)
        {
            int intStartIndex = currentCursorIndex;
            if (isBackspace)
            {
                if (Math.Abs(p_intDelLen) < 2)
                {
                    intStartIndex = currentCursorIndex - p_intDelLen;
                }
            }
            RichTextBoxTool.AdjustContentPosition_Delete(intStartIndex, p_intDelLen, -1 * p_intDelLen, ref lstTextContentInfos, isBackspace, rich);
            RichTextBoxTool.AdjustElementPosition_Delete(rich.SelectionStart, p_intDelLen, -1 * p_intDelLen, isBackspace, font, ref lstMedicalTerm, rich);

            if (p_intDelLen != 0)
            {
                RichTextBoxTool.AdjustDSTPosition(ref lstDoubleStrikeThrough, rich);
                RichTextBoxTool.AdjustTermPosition(ref lstMedicalTerm, font, rich);
            }

            currentCursorIndex = rich.SelectionStart;
        }
        #endregion

        /// <summary>
        /// 用户选中了文本时,设置是否可以修改选择文本的标志
        /// </summary>
        /// <param name="lstTextContentInfos"></param>
        /// <param name="currentModifyUser"></param>
        /// <param name="selectedTextStartIndex"></param>
        /// <param name="selectedTextLength"></param>
        /// <param name="canModifySelection"></param>
        public static void CheckModifySelection(List<EntityUserContentInfo> lstTextContentInfos, EntityModifyUserInfo currentModifyUser, int selectedTextStartIndex, int selectedTextLength, ref bool canModifySelection)
        {
            #region 用户选中了文本时,设置是否可以修改选择文本的标志
            EntityUserContentInfo objContentInfo = null;
            int intEndSeletedIndex = selectedTextStartIndex + selectedTextLength - 1;
            for (int i = 0; i < lstTextContentInfos.Count; i++)
            {
                objContentInfo = lstTextContentInfos[i];

                //选择文本与当前文本段有交叉
                if ((selectedTextStartIndex >= objContentInfo.StartIndex) && (selectedTextStartIndex <= objContentInfo.EndIndex))
                {
                    //用户不同,不能修改
                    if (objContentInfo.UserInfo.UserID != currentModifyUser.UserID)
                    {
                        canModifySelection = false;
                        break;
                    }
                    //选中文本属于当前文本段,允许修改
                    if ((intEndSeletedIndex >= objContentInfo.StartIndex) && (intEndSeletedIndex <= objContentInfo.EndIndex))
                    {
                        break;
                    }
                }
            }
            #endregion
        }

        /// <summary>
        /// 获取正确的文本
        /// </summary>
        /// <returns></returns>
        public static string GetRightText(List<EntityDstInfo> lstDoubleStrikeThrough, string textStr)
        {
            StringBuilder sb = new StringBuilder();

            int intStartIndex = 0;
            lstDoubleStrikeThrough.Sort();
            foreach (EntityDstInfo objDST in lstDoubleStrikeThrough)
            {
                if (objDST.StartIndex > intStartIndex && intStartIndex < textStr.Length)
                    sb.Append(textStr.Substring(intStartIndex, objDST.StartIndex - intStartIndex));
                intStartIndex = objDST.EndIndex + 1;
            }
            if (intStartIndex < textStr.Length)
            {
                sb.Append(textStr.Substring(intStartIndex, textStr.Length - intStartIndex));
            }
            return sb.ToString();
        }
    }
    #endregion
}
