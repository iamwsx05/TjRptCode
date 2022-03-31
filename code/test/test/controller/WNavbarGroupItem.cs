using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel.Design;

namespace NavbarWinTest
{

    [DefaultEvent("Click"), TypeConverter(typeof(ExpandableObjectConverter)), ToolboxItem(false)]
    public class WNavbarGroupItem : Control
    {
        public WNavbarGroupItem() : base()
        {
            SetStyle(ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.ResizeRedraw |
               ControlStyles.SupportsTransparentBackColor, true);

            base.ForeColor = Color.FromArgb(61, 66, 68);
            base.BackColor = Color.FromArgb(251, 251, 251);

            this.Font = new Font("Microsoft YaHei UI", 10f);
        }

        #region public

        protected override Size DefaultSize => new Size(210, 40);

        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (base.Text != value)
                {
                    base.Text = value;
                    this.Invalidate();
                }

            }
        }


        [Browsable(false)]
        public override DockStyle Dock { get => base.Dock; set => base.Dock = value; }


        //图标绘制样式
        public enum ImageDrawStyle
        {
            Default,

            Image,

            None
        }

        //文本和图标对齐
        public enum TextImageAlignStyle
        {
            Left,

            Center
        }

        //图片及文本相对位置
        public enum TextImageRelationStyle
        {
            ImageBeforeText,
            ImageAboveText
        }

        //鼠标滑过时的样式
        public enum MouseOverStyle
        {
            BackColor,
            Border,
            BorderAndColor,
            HeaderAndColor
        }





        [Browsable(true), Category("Custom"), DefaultValue(typeof(Point), "60,0"), Description("文本偏移量"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Point TextOffset
        {
            get { return _textOffset; }
            set
            {
                if (_textOffset != value)
                {
                    _textOffset = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(typeof(ImageDrawStyle), "Default"), Description("图标绘制模式"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public ImageDrawStyle ImageDrawMode
        {
            get { return _imageDrawStyle; }
            set
            {
                if (value != _imageDrawStyle)
                {
                    _imageDrawStyle = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), Description("图标"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Image Image
        {
            get { return _image; }
            set
            {
                if (value != _image)
                {
                    _image = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Size), "16,16"), Description("图标大小"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Size ImageSize
        {
            get { return _imageSize; }
            set
            {
                if (value != _imageSize)
                {
                    _imageSize = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(typeof(Point), "38,0"), Description("图标偏移量"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Point ImageOffset
        {
            get { return _imageOffset; }
            set
            {
                if (_imageOffset != value)
                {
                    _imageOffset = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(typeof(TextImageAlignStyle), "Left"), Description("图标和文本的对齐方式"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public TextImageAlignStyle TextImageAlign
        {
            get { return _textImageAlign; }
            set
            {
                if (value != _textImageAlign)
                {
                    _textImageAlign = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(TextImageRelationStyle), "ImageBeforeText"), Description("图标和文本的排列方式"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public TextImageRelationStyle TextImageRelation
        {
            get { return _textImageRelation; }
            set
            {
                if (value != _textImageRelation)
                {
                    _textImageRelation = value;
                    this.Invalidate();
                }
            }
        }



        [Browsable(true), Category("Custom"), DefaultValue(false), Description("当点击后是否保持选中状态(焦点)，若开启此项请将所有子项全部开启，否则会影响视觉效果"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public bool IsKeepSelected
        {
            get { return _isKeepSelected; }
            set
            {
                if (value != _isKeepSelected)
                {
                    _isKeepSelected = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(false), Description("是否已获得焦点，仅当IsKeepSelected为true时生效"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), Description("选中或鼠标滑过时外框颜色"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Color SelectedBorderColor
        {
            get { return _selectedBorderColor; }
            set
            {
                if (_selectedBorderColor != value)
                {
                    _selectedBorderColor = value;
                    Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), Description("选中或鼠标滑过时背景填充颜色"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Color SelectedBackColor
        {
            get { return _selectedBackColor; }
            set
            {
                if (_selectedBackColor != value)
                {
                    _selectedBackColor = value;
                    Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), Description("选中或鼠标滑过时前景颜色"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Color SelectedForeColor
        {
            get { return _selectedForeColor; }
            set
            {
                if (_selectedForeColor != value)
                {
                    _selectedForeColor = value;
                    Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), Description("选中或鼠标滑过时的图标"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Image SelectedImage
        {
            get { return _selectedImage; }
            set
            {
                if (value != _selectedImage)
                {
                    _selectedImage = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(typeof(MouseOverStyle), "HeaderAndColor"), Description("鼠标滑过或选中时的样式"), RefreshProperties(RefreshProperties.Repaint)]
        public MouseOverStyle MouseHoverStyle
        {
            get { return this._mouseOverStyle; }
            set
            {
                if (this._mouseOverStyle != value)
                {
                    this._mouseOverStyle = value;
                    Invalidate();
                }
            }
        }




        #endregion

        #region private

        private Point _textOffset = new Point(60, 0);//文本偏移量
        private ImageDrawStyle _imageDrawStyle = ImageDrawStyle.Default;

        private Image _image = null;
        public Size _imageSize = new Size(16, 16);
        private Point _imageOffset = new Point(38, 0);

        private TextImageAlignStyle _textImageAlign = TextImageAlignStyle.Left;
        private TextImageRelationStyle _textImageRelation = TextImageRelationStyle.ImageBeforeText;


        private bool _isKeepSelected = false;//仅鼠标滑过样式,此种样式下控件选择后不留焦点 

        private bool _isSelected = false;

        private Color _selectedBorderColor = Color.FromArgb(138, 138, 167);

        private Color _selectedBackColor = Color.FromArgb(211, 211, 222);
        private Color _selectedForeColor = Color.FromArgb(61, 66, 68);
        private Image _selectedImage = null;


        private MouseOverStyle _mouseOverStyle = MouseOverStyle.HeaderAndColor;


        private bool _isMouseOver = false;
        #endregion

        #region override

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isMouseOver = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isMouseOver = false;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Left)
            {
                if (_isKeepSelected)
                {
                    this._isSelected = true;
                    this.Invalidate();
                    SelectStatusChangedNotifyParent();//通知父级菜单项
                }

                base.OnClick(e);
                if (this.Parent is WNavbarGroup group)
                {
                    group.OnItemClick(this);
                }
            }

        }

        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);//屏蔽原单击
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;

            DrawBackColor(g);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            DrawImageText(g);
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateParentSize();
            this.Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _image?.Dispose();
                _selectedImage?.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        #region methods

        //选择状态改变,通知父容器刷新选择状态.
        private void SelectStatusChangedNotifyParent()
        {
            if (!_isKeepSelected)//无焦点
            {
                return;
            }
            if (this.Parent is WNavbarGroup parent)
            {
                parent?.RefreshItemSelectedStatus(this);
            }
        }


        //更新父容器大小
        private void UpdateParentSize()
        {
            var parent = this.Parent as WNavbarGroup;
            if (parent != null)
            {
                parent.RefreshGroupHeight();
            }
        }



        private void DrawImageText(Graphics g)
        {
            var changeFore = _isMouseOver || (_isKeepSelected && _isSelected);
            var foreColor = changeFore ? this._selectedForeColor : this.ForeColor;

            var imgRect = new RectangleF(_imageOffset, _imageSize);

            var txtRect = new Rectangle(_textOffset, new Size(this.Width - _textOffset.X, this.Height));
            txtRect.Y += 1;

            var format = new StringFormat();

            var txtSize = g.MeasureString(Text, Font);

            switch (_textImageRelation)
            {
                default:
                case TextImageRelationStyle.ImageBeforeText:
                    imgRect.Y = imgRect.Y + (this.Height - imgRect.Height) / 2f;
                    break;
                case TextImageRelationStyle.ImageAboveText://上下图文间隔5
                    imgRect.Y = imgRect.Y + (this.Height - imgRect.Height - txtSize.Height - 5) / 2f;

                    txtRect.Y = (int)(txtRect.Y + (this.Height - imgRect.Height - txtSize.Height - 5) / 2f + imgRect.Height + 5);
                    txtRect.Height = (int)txtSize.Height;

                    break;
            }

            switch (_textImageAlign)
            {
                default:
                case TextImageAlignStyle.Left:
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Center;
                    break;
                case TextImageAlignStyle.Center://居中忽略偏移
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Near;

                    imgRect.X = (this.Width - imgRect.Width) / 2f;
                    txtRect.X = 0;
                    txtRect.Width = this.Width;
                    break;
            }

            Image img = null;
            switch (_imageDrawStyle)
            {
                default:
                case ImageDrawStyle.Default:
                    #region image

                    var bmp = new Bitmap(_imageSize.Width, _imageSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    using (Graphics gp = Graphics.FromImage(bmp))
                    {
                        gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        gp.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                        gp.Clear(Color.Transparent);
                        using (var sd = new SolidBrush(Color.FromArgb(150, foreColor)))
                        {
                            var pLen = txtSize.Height / 3f * 1;//参考字高                            
                            gp.FillEllipse(sd, (bmp.Width - pLen) / 2f, (bmp.Height - pLen) / 2f, pLen, pLen);
                        }
                    }
                    img = bmp;

                    #endregion
                    break;
                case ImageDrawStyle.Image:
                    if (this._image != null)
                    {
                        if (changeFore && this._selectedImage != null)
                            img = this._selectedImage.Clone() as Image;
                        else
                            img = this._image.Clone() as Image;
                    }
                    break;
                case ImageDrawStyle.None:
                    break;
            }
            if (img != null)
            {
                g.DrawImage(img, imgRect);
                img.Dispose();
            }

            using (var p = new SolidBrush(foreColor))//颜色减轻
            {
                g.DrawString(this.Text, this.Font, p, txtRect, format);
                format.Dispose();
            }
        }


        private void DrawBackColor(Graphics g)
        {
            var c = this.BackColor;
            var b = _isMouseOver || (_isKeepSelected && _isSelected);

            switch (_mouseOverStyle)
            {
                default:
                case MouseOverStyle.BackColor:
                    using (var bp = new SolidBrush(b ? _selectedBackColor : c))
                    {
                        g.FillRectangle(bp, this.ClientRectangle);
                    }
                    break;
                case MouseOverStyle.Border:
                    using (var bp = new SolidBrush(c))
                    {
                        g.FillRectangle(bp, this.ClientRectangle);
                    }
                    if (b)
                    {
                        using (var p = new Pen(_selectedBorderColor, 1f))
                        {
                            g.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
                        }
                    }
                    break;
                case MouseOverStyle.BorderAndColor:
                    using (var bp = new SolidBrush(b ? _selectedBackColor : c))
                    {
                        g.FillRectangle(bp, this.ClientRectangle);
                    }
                    if (b)
                    {
                        using (var p = new Pen(_selectedBorderColor, 1f))
                        {
                            g.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
                        }
                    }
                    break;
                case MouseOverStyle.HeaderAndColor:
                    using (var bp = new SolidBrush(b ? _selectedBackColor : c))
                    {
                        g.FillRectangle(bp, this.ClientRectangle);
                        if (b)
                        {
                            bp.Color = _selectedBorderColor;
                            g.FillRectangle(bp, 0, 0, 6, this.Height);
                        }
                    }
                    break;
            }


        }


        #endregion

    }

    //属性编辑器
    public class WNavbarGroupItemCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public WNavbarGroupItemCollectionEditor(Type type) : base(type)
        {

        }

        protected override bool CanSelectMultipleInstances()
        {
            return false;
        }

        protected override Type CreateCollectionItemType()
        {
            return typeof(WNavbarGroupItem);
        }

        protected override void DestroyInstance(object instance)
        {
            base.DestroyInstance(instance);
            if (base.Context.Instance is WNavbarGroup group)
            {
                group.RefreshGroupHeight();
            }
        }



        protected override object CreateInstance(Type itemType)
        {
            return base.CreateInstance(itemType);
        }

        protected override CollectionForm CreateCollectionForm()
        {
            var frm = base.CreateCollectionForm();
            var fi = frm.GetType().GetField("propertyBrowser", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (fi != null)
            {
                (fi.GetValue(frm) as PropertyGrid).HelpVisible = true;
            }
            return frm;
        }

        protected override object SetItems(object editValue, object[] value)
        {
            try
            {
                return base.SetItems(editValue, value);
            }
            finally
            {
                if (base.Context.Instance is WNavbarGroup group)
                {
                    group.IsExpand = true;//若是手动编辑则项可视化
                }
            }

        }

    }
}
