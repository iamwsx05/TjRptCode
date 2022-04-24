using Common.Controls;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using RptFunc.Entity;
using RptFunc.Xtyy;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace RptFunc
{
    public partial class frmXtyyZybRpt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmXtyyZybRpt()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
        }

        string filePath = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            ribbonControl.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = ribbonControl;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;
            Init();
        }

        List<EntityDw> lstDw = null;
        List<EntityXmfl> lstXmfl = null;

        #region Init
        void Init()
        {
            DateTime dteNow = DateTime.Now;
            this.dteBegin.Text = dteNow.ToString("yyyy-MM") + "-01";
            this.dteEnd.Text = dteNow.ToString("yyyy-MM-dd");
            lstDw = new List<EntityDw>();
            lstXmfl = new List<EntityXmfl>();

            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                lstDw = proxy.Service.GetZdDw();
                lstXmfl = proxy.Service.GetZdXmfl();
            }

            this.lueDw.Properties.PopupWidth = this.lueDw.Width;
            this.lueDw.Properties.PopupHeight = 600;
            this.lueDw.Properties.ValueColumn = EntityDw.Columns.lnc_code;
            this.lueDw.Properties.DisplayColumn = EntityDw.Columns.lnc_name;
            this.lueDw.Properties.Essential = false;
            this.lueDw.Properties.IsShowColumnHeaders = true;
            this.lueDw.Properties.ColumnWidth.Add(EntityDw.Columns.lnc_code, 70);
            this.lueDw.Properties.ColumnWidth.Add(EntityDw.Columns.lnc_name, this.lueDw.Width - 70);
            this.lueDw.Properties.ColumnHeaders.Add(EntityDw.Columns.lnc_code, "编码");
            this.lueDw.Properties.ColumnHeaders.Add(EntityDw.Columns.lnc_name, "名称");
            this.lueDw.Properties.ShowColumn = EntityDw.Columns.lnc_code + "|" + EntityDw.Columns.lnc_name;
            this.lueDw.Properties.IsUseShowColumn = true;
            this.lueDw.Properties.FilterColumn = EntityDw.Columns.lnc_code + "|" + EntityDw.Columns.lnc_name;
            if (lstDw != null)
            {
                this.lueDw.Properties.DataSource = lstDw.ToArray();
                this.lueDw.Properties.SetSize();
            }

            this.lueXmfl.Properties.PopupWidth = this.lueDw.Width;
            this.lueXmfl.Properties.PopupHeight = 400;
            this.lueXmfl.Properties.ValueColumn = EntityXmfl.Columns.cls_code;
            this.lueXmfl.Properties.DisplayColumn = EntityXmfl.Columns.cls_name;
            this.lueXmfl.Properties.Essential = false;
            this.lueXmfl.Properties.IsShowColumnHeaders = true;
            this.lueXmfl.Properties.ColumnWidth.Add(EntityXmfl.Columns.cls_code, 70);
            this.lueXmfl.Properties.ColumnWidth.Add(EntityXmfl.Columns.cls_name, this.lueDw.Width - 70);
            this.lueXmfl.Properties.ColumnHeaders.Add(EntityXmfl.Columns.cls_code, "编码");
            this.lueXmfl.Properties.ColumnHeaders.Add(EntityXmfl.Columns.cls_name, "名称");
            this.lueXmfl.Properties.ShowColumn = EntityXmfl.Columns.cls_code + "|" + EntityXmfl.Columns.cls_name;
            this.lueXmfl.Properties.IsUseShowColumn = true;
            this.lueXmfl.Properties.FilterColumn = EntityXmfl.Columns.cls_code + "|" + EntityXmfl.Columns.cls_name;
            if (lstXmfl != null)
            {
                this.lueXmfl.Properties.DataSource = lstXmfl.ToArray();
                this.lueXmfl.Properties.SetSize();
            }
        }
        #endregion

        #region 
        private void iOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                String filepath = f.FileName;//G:\新建文件夹\新建文本文档.txt
                String filename = f.SafeFileName;//新建文本文档.txt
                filePath = filepath;
            }
        }

        private void iState_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {

            }
            else if (tabPane1.SelectedPageIndex == 1)
            {

            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }

        }

        private void iExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {

            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }

        #region Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {

            }
            else if (tabPane1.SelectedPageIndex == 1)
            {

            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
            else if (tabPane1.SelectedPageIndex == 4)
            {

            }
            else if (tabPane1.SelectedPageIndex == 5)
            {

            }
        }
        #endregion

        #endregion

        #region GetRowObj
        //public EntityPeItem GetRowObjPeItem()
        //{
        //    if (this.gvPeResult.FocusedRowHandle < 0)
        //        return null;
        //    else
        //    {
        //        EntityPeItem vo = this.gvPeResult.GetRow(this.gvPeResult.FocusedRowHandle) as EntityPeItem;
        //        return vo;
        //    }
        //}


        #endregion

        #region 职业健康检查人员名单及检查结果
        /// <summary>
        /// 
        /// </summary>
        internal void QueryZybRegRpt()
        {
            List<EntityItemRpt> data = new List<EntityItemRpt>();

            string lncCode = string.Empty;
            string lncName = this.lueDw.Text;
            string cls_name = this.lueXmfl.Text;
            string cls_code = string.Empty;
            string regNo = this.txtRegNo.Text;
            string ycgjz = this.txtYcgjz.Text;
            string ycgjzF = this.txtYcgjzF.Text;
            if (!string.IsNullOrEmpty(lncName))
            {
                EntityDw dw = lstDw.Find(r => r.lnc_name == lncName);
                if (dw != null)
                    lncCode = dw.lnc_code;
            }
            if (!string.IsNullOrEmpty(cls_name))
            {
                EntityXmfl vo = lstXmfl.Find(r => r.cls_name == cls_name);
                if (vo != null)
                    cls_code = vo.cls_code;
            }

            List<EntityParm> dicParm = new List<EntityParm>();
            string beginTime = this.dteBegin.Text.Replace('-', '.');
            string endTime = this.dteEnd.Text.Replace('-', '.');
            if (beginTime != string.Empty && endTime != string.Empty)
            {
                dicParm.Add(Function.GetParm("regDate", beginTime + "|" + endTime));
            }
            if (!string.IsNullOrEmpty(lncCode))
            {
                dicParm.Add(Function.GetParm("lncCode", lncCode));
            }
            if (!string.IsNullOrEmpty(regNo))
            {
                dicParm.Add(Function.GetParm("regNo", regNo));
            }
            if (!string.IsNullOrEmpty(cls_code))
            {
                dicParm.Add(Function.GetParm("xmfl", cls_code));
            }
            if (!string.IsNullOrEmpty(ycgjz))
            {
                if (ycgjz.Contains("+"))
                {
                    string[] strArr = ycgjz.Split('+');

                    foreach (var vo in strArr)
                    {
                        dicParm.Add(Function.GetParm("ycgjz", vo));
                    }
                }
                else
                    dicParm.Add(Function.GetParm("ycgjz", ycgjz));
            }
            if (!string.IsNullOrEmpty(ycgjzF))
            {
                if (ycgjzF.Contains("+"))
                {
                    string[] strArr = ycgjzF.Split('+');

                    foreach (var vo in strArr)
                    {
                        dicParm.Add(Function.GetParm("ycgjzF", vo));
                    }
                }
                else
                    dicParm.Add(Function.GetParm("ycgjzF", ycgjzF));

            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcZybRegRpt.DataSource = proxy.Service.GetZybRegRpt(dicParm);
                this.gcZybRegRpt.RefreshDataSource();
            }

        }
        #endregion


        #region
        internal void QueryTjjdb()
        {


        }
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                QueryZybRegRpt();
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {
            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                uiHelper.ExportToXls(this.gvZybRegRpt);
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {
              
            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }

        private void gvZybRegRpt_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Appearance.ForeColor = Color.Gray;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
    }
}
