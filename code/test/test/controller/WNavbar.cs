using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.Collections;
using System.Drawing.Drawing2D;

namespace NavbarWinTest
{
    [ToolboxBitmap(typeof(SplitContainer)), ToolboxItem(true), DefaultEvent("GroupItemClick")]
    public class WNavbar : UserControl
    {

        public WNavbar() : base()
        {
            SetStyle(ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw |
            ControlStyles.SupportsTransparentBackColor, true);


            base.ForeColor = Color.FromArgb(61, 66, 68);
            base.BackColor = Color.FromArgb(251, 251, 251);
            this._font = new Font("Microsoft YaHei UI", 11f);
            BorderStyle = BorderStyle.None;

            panel = new Panel
            {
                AutoScroll = true,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill
            };
            base.Controls.Add(panel);

            Items = new WNavbarGroupCollection(this);

            CalcControlButtonRectangle();

            this._caption = "WNavbar";

        }

        #region WNavbarGroupCollection

        public class WNavbarGroupCollection : IList, ICollection, IEnumerable
        {

            WNavbar owner;
            public WNavbarGroupCollection(WNavbar owner)
            {
                this.owner = owner;
            }


            object IList.this[int index] { get => owner.panel.Controls[index]; set { } }


            public WNavbarGroup this[int index]
            {
                get
                {
                    if (index >= 0 && index < this.Count)
                    {
                        return (WNavbarGroup)this.owner.panel.Controls[index];
                    }
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                set { }
            }

            public WNavbarGroup this[string name]
            {
                get
                {
                    if (this.ContainsKey(name))
                    {
                        return (WNavbarGroup)this.owner.panel.Controls[name];
                    }
                    throw new ArgumentException(nameof(name));
                }
                set { }
            }




            bool IList.IsReadOnly => false;

            bool IList.IsFixedSize => false;

            int ICollection.Count => this.Count;

            [Browsable(false)]
            public int Count => this.owner.panel.Controls.Count;

            object ICollection.SyncRoot => this;

            bool ICollection.IsSynchronized => false;

            int IList.Add(object value)
            {
                if (value is WNavbarGroup)
                {
                    return this.Add((WNavbarGroup)value);
                }
                throw new ArgumentException("WNavbarGroup", nameof(value));
            }


            public int Add(WNavbarGroup item)
            {
                item.Dock = DockStyle.Top;
                item.Parent = owner;
                this.owner.panel.Controls.Add(item ?? throw new ArgumentNullException(nameof(item)));
                item.BringToFront();
                return IndexOf(item);
            }

            public void AddRange(WNavbarGroup[] items)
            {
                foreach (var item in items)
                {
                    this.Add(item);
                }
            }


            void IList.Clear()
            {
                this.Clear();
            }

            public void Clear()
            {
                this.owner.panel.Controls.Clear();
            }

            bool IList.Contains(object value)
            {
                return value is WNavbarGroup && this.Contains((WNavbarGroup)value);
            }

            public bool Contains(WNavbarGroup item)
            {
                return this.owner.panel.Controls.Contains(item ?? throw new ArgumentNullException(nameof(item)));
            }

            void ICollection.CopyTo(Array array, int index)
            {
                CopyTo(array, index);
            }


            public void CopyTo(Array array, int index)
            {
                if (this.Count > 0)
                {
                    this.owner.panel.Controls.CopyTo(array, index);
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public IEnumerator GetEnumerator()
            {
                return this.owner.panel.Controls.GetEnumerator();
            }


            int IList.IndexOf(object value)
            {
                if (value is WNavbarGroup)
                {
                    return this.IndexOf((WNavbarGroup)value);
                }
                throw new ArgumentException("WNavbarGroup", nameof(value));
            }

            public int IndexOf(WNavbarGroup item)
            {
                return this.owner.panel.Controls.IndexOf(item);
            }

            void IList.Insert(int index, object value)
            {
                if (value is WNavbarGroup)
                {
                    this.Insert(index, (WNavbarGroup)value);
                }
                throw new ArgumentException("WNavbarGroup", nameof(value));
            }

            public void Insert(int index, WNavbarGroup item)
            {
                this.owner.panel.Controls.Add(item);
                this.owner.panel.Controls.SetChildIndex(item, index);
            }

            void IList.Remove(object value)
            {
                if (value is WNavbarGroup)
                {
                    this.Remove((WNavbarGroup)value);
                }
            }

            public void Remove(WNavbarGroup item)
            {
                this.owner.panel.Controls.Remove(item);
            }

            void IList.RemoveAt(int index)
            {
                throw new NotImplementedException();
            }


            public void RemoveAt(int index)
            {
                if (index >= 0 && index < this.Count)
                {
                    this.owner.panel.Controls.RemoveAt(index);
                }
            }

            public bool ContainsKey(string name)
            {
                return !string.IsNullOrEmpty(name) && this.owner.panel.Controls.ContainsKey(name);
            }


        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new Control.ControlCollection Controls
        {
            get
            {
                return panel.Controls;
            }
        }

        [Browsable(true), Category("Custom"),
         Description("获取或设置组中的子项，当从设计器中编辑此项后，请从所在窗体Designer.cs中（控件的Items.AddRange方法）手工调整子项顺序,然后项目上右键》清理》重新生成，否则运行时控件顺序会颠倒，未找到其他方法."),
         RefreshProperties(RefreshProperties.All), NotifyParentProperty(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
         Editor(typeof(WNavbarGroupCollectionEditor), typeof(UITypeEditor)),
         Localizable(true)]
        public WNavbarGroupCollection Items { get; }

        #endregion

        #region public

        public override Rectangle DisplayRectangle
        {
            get
            {
                if (!_captionShow && !_captionControlButtonShow)
                {
                    return base.DisplayRectangle;
                }

                var rect = base.DisplayRectangle;
                rect.Y = rect.Y + _captionHeight;
                rect.Height = rect.Height - _captionHeight;
                if (_showBorder)
                {
                    rect.X += +1;
                    rect.Y += 1;
                    rect.Width -= 2;
                    rect.Height -= 2;
                }
                return rect;
            }
        }

        protected override Size DefaultSize => new Size(210, 300);

        public new Font Font
        {
            get => this._font; set
            {
                if (this._font != value)
                {
                    this._font = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(true), Description("是否显示标题栏."), RefreshProperties(RefreshProperties.Repaint)]
        public bool CaptionShow
        {
            get { return _captionShow; }
            set
            {
                if (this._captionShow != value)
                {
                    this._captionShow = value;
                    if (!this._captionShow && !this.IsNavbarExpand)
                    {
                        ExpandCollapseBar(false);
                    }
                    this.Invalidate();

                    if (!value && !this._captionControlButtonShow)
                    {
                        this.Update();
                    }
                }
            }
        }

        [Browsable(true), Category("Custom"), Description("获取或设置标题栏上显示的文本."), RefreshProperties(RefreshProperties.Repaint)]
        public string Caption
        {
            get { return _caption; }
            set
            {
                if (_caption != value)
                {
                    _caption = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(50), Description("获取或设置标题栏高度."), RefreshProperties(RefreshProperties.Repaint)]
        public int CaptionHeight
        {
            get { return _captionHeight; }
            set
            {
                if (_captionHeight != value)
                {
                    _captionHeight = value;
                    if (_captionHeight <= 0) _captionHeight = 0;
                    CalcControlButtonRectangle();
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(50), Description("获取或设置标题栏文本及图标的显示样式."), RefreshProperties(RefreshProperties.Repaint)]
        public HorizontalAlignment CaptionAlign
        {
            get { return _captionAlign; }
            set
            {
                if (_captionAlign != value)
                {
                    _captionAlign = value;
                    this.Invalidate();
                }
            }
        }



        [Browsable(true), Category("Custom"), DefaultValue(null), Description("获取或设置标题栏图标"), RefreshProperties(RefreshProperties.Repaint)]
        public Image CaptionImage
        {
            get { return _captionImage; }
            set
            {
                if (value != _captionImage)
                {
                    _captionImage = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(null), Description("获取或设置标题栏背景图片"), RefreshProperties(RefreshProperties.Repaint)]
        public Image CaptionBackImage
        {
            get { return _captionBackImage; }
            set
            {
                if (value != _captionBackImage)
                {
                    _captionBackImage = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Size), "24, 24"), Description("获取或设置标题栏显示的图标大小"), RefreshProperties(RefreshProperties.Repaint)]
        public Size CaptionImageSize
        {
            get { return _captionImageSize; }
            set
            {
                if (value != _captionImageSize)
                {
                    _captionImageSize = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Point), "0,0"), Description("获取或设置标题栏显示的图标位置偏移"), RefreshProperties(RefreshProperties.Repaint)]
        public Point CaptionImageOffset
        {
            get { return _captionImageOffset; }
            set
            {
                if (value != _captionImageOffset)
                {
                    _captionImageOffset = value;
                    this.Invalidate();
                }
            }
        }



        [Browsable(true), Category("Custom"), DefaultValue(true), Description("是否显示标题栏右侧的控制按钮."), RefreshProperties(RefreshProperties.Repaint)]
        public bool CaptionControlButtonShow
        {
            get { return _captionControlButtonShow; }
            set
            {
                if (this._captionControlButtonShow != value)
                {
                    this._captionControlButtonShow = value;
                    CalcControlButtonRectangle();
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(null), Description("获取或设置标题栏展开状态下控制按钮图标"), RefreshProperties(RefreshProperties.Repaint)]
        public Image CaptionControlExpandImage
        {
            get { return _captionControlExpandImage; }
            set
            {
                if (value != _captionControlExpandImage)
                {
                    _captionControlExpandImage = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(null), Description("获取或设置标题栏折合状态下控制按钮图标"), RefreshProperties(RefreshProperties.Repaint)]
        public Image CaptionControlCollapseImage
        {
            get { return _captionControlCollapseImage; }
            set
            {
                if (value != _captionControlCollapseImage)
                {
                    _captionControlCollapseImage = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Size), "24, 24"), Description("获取或设置标题栏控制按钮图标大小"), RefreshProperties(RefreshProperties.Repaint)]
        public Size CaptionControlImageSize
        {
            get { return _captionControlImageSize; }
            set
            {
                if (value != _captionControlImageSize)
                {
                    _captionControlImageSize = value;
                    CalcControlButtonRectangle();
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(20), Description("获取或设置标题栏控制按钮距离右边缘的宽度"), RefreshProperties(RefreshProperties.Repaint)]
        public int CaptionControlButtonOffset
        {
            get { return _captionControlButtonOffset; }
            set
            {
                if (value != _captionControlButtonOffset)
                {
                    _captionControlButtonOffset = value;
                    CalcControlButtonRectangle();
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), Description("用户点击标题上的折合展开控制按钮后触发该事件，IsNavbarExpand属性可获取当前控件状态")]
        public event EventHandler CaptionControlButtonClick;


        [Browsable(false), Category("Custom"), Description("控件状态是否折合")]
        public bool IsNavbarExpand { get; private set; } = true;


        [Browsable(true), Category("Custom"), DefaultValue(false), Description("是否显示控件的边框."), RefreshProperties(RefreshProperties.Repaint)]
        public bool ShowBorder
        {
            get { return _showBorder; }
            set
            {
                if (this._showBorder != value)
                {
                    this._showBorder = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Color), "203, 203, 203"), Description("控件的边框颜色."), RefreshProperties(RefreshProperties.Repaint)]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                if (this._borderColor != value)
                {
                    this._borderColor = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), Description("当容器中组控件的子项按钮被点击后,触发该事件.")]
        public event EventHandler GroupItemClick;

        #endregion

        #region private

        private string _caption = "";
        private int _captionHeight = 50;
        private bool _captionShow = true;
        private HorizontalAlignment _captionAlign = HorizontalAlignment.Left;

        //标题
        private Image _captionImage = null;
        private Image _captionBackImage = null;
        private Size _captionImageSize = new Size(24, 24);
        private Point _captionImageOffset = Point.Empty;

        //标题栏控制按钮
        private bool _captionControlButtonShow = true;
        private Image _captionControlExpandImage = null;
        private Image _captionControlCollapseImage = null;
        private Size _captionControlImageSize = new Size(24, 24);
        private int _captionControlButtonOffset = 20;
        private Rectangle _captionControlButtonRectangle = Rectangle.Empty;

        private bool _mouseOverCaptionControl = false;//鼠标滑过控制按钮
        private bool MouseOverCaptionControl
        {
            get { return _mouseOverCaptionControl; }
            set
            {
                if (_mouseOverCaptionControl != value)
                {
                    _mouseOverCaptionControl = value;
                    this.Invalidate();
                }
            }
        }


        //边框
        private bool _showBorder = false;
        private Color _borderColor = Color.FromArgb(203, 203, 203);


        //主容器
        private Panel panel = null;

        private Font _font;


        private int _originalWidth = 0;//折合前的宽度

        #endregion

        #region override

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _captionImage?.Dispose();
                _captionBackImage?.Dispose();
                _captionControlExpandImage?.Dispose();
                _captionControlCollapseImage?.Dispose();
                this._font.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (this._captionControlButtonShow)
                this.MouseOverCaptionControl = this._captionControlButtonRectangle.Contains(PointToClient(Cursor.Position));
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (this._captionControlButtonShow)
                this.MouseOverCaptionControl = this._captionControlButtonRectangle.Contains(PointToClient(Cursor.Position));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left && this._captionControlButtonShow)
            {
                if (this._captionControlButtonRectangle.Contains(e.Location))
                {
                    ExpandCollapseBar();
                    this.Invalidate();
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (this._captionControlButtonShow)
                this.MouseOverCaptionControl = this._captionControlButtonRectangle.Contains(e.Location);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this._captionControlButtonShow)
            {
                CalcControlButtonRectangle();
                this.Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Image controlsImage = null;
            if (this.IsNavbarExpand)
            {
                this.DrawCaption(e.Graphics);

                if (this._captionControlButtonShow)
                {
                    controlsImage = this._captionControlExpandImage == null ? GetControlImage(true) : ((Image)this._captionControlExpandImage.Clone());
                    e.Graphics.DrawImage(controlsImage, this._captionControlButtonRectangle);
                }
            }
            else
            {
                controlsImage = this._captionControlCollapseImage == null ? GetControlImage(false) : ((Image)this._captionControlCollapseImage.Clone());
                e.Graphics.DrawImage(GetControlImage(false), this._captionControlButtonRectangle);
                DrawCollapseBackColor(e.Graphics);
            }

            controlsImage?.Dispose();

            this.DrawBorder(e.Graphics);
        }


        #endregion

        #region methods

        private void CalcControlButtonRectangle()
        {
            if (!_captionControlButtonShow)
            {
                return;
            }
            this._captionControlButtonRectangle =
                new Rectangle(
                    this.Width - this._captionControlImageSize.Width - this._captionControlButtonOffset,
                    (this._captionHeight - this._captionControlImageSize.Height) / 2 - 1,
                    this._captionControlImageSize.Width,
                    this._captionControlImageSize.Height);
        }

        private void ExpandCollapseBar(bool changeStatus = true)
        {
            if (this.IsNavbarExpand)
            {
                _originalWidth = this.Width;
                this.panel.Visible = false;
                this.Width = this._captionControlImageSize.Width + 20;

                this._captionControlButtonRectangle =
                new Rectangle(
                    10,
                    (this._captionHeight - this._captionControlImageSize.Height) / 2 - 1,
                    this._captionControlImageSize.Width,
                    this._captionControlImageSize.Height);
            }
            else
            {
                this.Width = _originalWidth;
                this.panel.Visible = true;
            }
            if (changeStatus)
                this.IsNavbarExpand = !this.IsNavbarExpand;
            this.CaptionControlButtonClick?.Invoke(this, EventArgs.Empty);
        }


        private void DrawCaption(Graphics g)
        {
            if (!this._captionShow)
                return;

            var rectCaption = new Rectangle(0, 0, this.Width, this._captionHeight);
            if (_showBorder)
            {
                rectCaption.Location = new Point(1, 1);
                rectCaption.Size = new Size(rectCaption.Width - 2, rectCaption.Height - 1);
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //背景图
            if (this._captionBackImage != null)
            {
                g.DrawImage(this._captionBackImage, rectCaption);
            }

            //图标和文本
            DrawIconAndText(g);

        }

        private void DrawIconAndText(Graphics g)
        {
            var imgeRect = RectangleF.Empty;
            var textRect = RectangleF.Empty;

            var clipRect = new Rectangle(15, 2, this.Width - 15 * 2, this._captionHeight - 4);

            StringFormat sf = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            };

            var fontSize = TextRenderer.MeasureText(this._caption, this.Font);
            float tolLen = fontSize.Width;

            switch (this._captionAlign)
            {
                default:
                case HorizontalAlignment.Left:
                    if (this._captionImage != null)
                    {
                        imgeRect.X = clipRect.X + this._captionImageOffset.X;
                        imgeRect.Y = clipRect.Y + this._captionImageOffset.Y + (clipRect.Height - this._captionImageSize.Height) / 2f;
                        imgeRect.Size = this._captionImageSize;

                        textRect.X = imgeRect.Right + 5;
                        textRect.Y = clipRect.Y;
                        textRect.Size = new SizeF(clipRect.Width - textRect.X, clipRect.Height - this._captionImageOffset.Y);
                    }
                    else
                    {
                        textRect.X = clipRect.X + this._captionImageOffset.X;
                        textRect.Y = clipRect.Y;
                        textRect.Size = new SizeF(clipRect.Width - textRect.X, clipRect.Height - this._captionImageOffset.Y);
                    }

                    break;
                case HorizontalAlignment.Right:
                case HorizontalAlignment.Center:


                    if (this._captionImage != null)
                    {
                        tolLen += this._captionImageSize.Width + 5;

                        imgeRect.X = clipRect.X + this._captionImageOffset.X + (clipRect.Width - tolLen) / 2f;
                        imgeRect.Y = clipRect.Y + this._captionImageOffset.Y + (clipRect.Height - this._captionImageSize.Height) / 2f;
                        imgeRect.Size = this._captionImageSize;

                        textRect.X = imgeRect.Right + 5;
                        textRect.Y = clipRect.Y;
                        textRect.Size = new SizeF(clipRect.Width - textRect.X, clipRect.Height - this._captionImageOffset.Y);
                    }
                    else
                    {
                        textRect.X = clipRect.X + this._captionImageOffset.X;
                        textRect.Y = clipRect.Y;
                        textRect.Size = new SizeF(clipRect.Width - textRect.X, clipRect.Height - this._captionImageOffset.Y);

                        sf.Alignment = StringAlignment.Center;
                    }

                    break;
            }

            if (this._captionImage != null)
            {
                imgeRect.Y -= 1f;
                g.DrawImage(this._captionImage, imgeRect);
            }

            using (SolidBrush sd = new SolidBrush(this.ForeColor))
            {
                g.DrawString(this._caption, this.Font, sd, textRect, sf);
            }
            sf.Dispose();
        }

        private void DrawBorder(Graphics g)
        {
            if (!this._showBorder)
            {
                return;
            }

            using (Pen p = new Pen(this._borderColor, 1f))
            {
                g.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
            }

        }

        private Color GetColor(Color colorBase, int a, int r, int g, int b)
        {
            int a0 = colorBase.A;
            int r0 = colorBase.R;
            int g0 = colorBase.G;
            int b0 = colorBase.B;

            a = Math.Max(0, Math.Min(255, Math.Abs(a + a0)));
            r = Math.Max(0, Math.Min(255, Math.Abs(r + r0)));
            g = Math.Max(0, Math.Min(255, Math.Abs(g + g0)));
            b = Math.Max(0, Math.Min(255, Math.Abs(b + b0)));

            return Color.FromArgb(a, r, g, b);
        }

        private void DrawCollapseBackColor(Graphics g)
        {
            ColorBlend colorBlend = new ColorBlend(3)
            {
                Colors = new Color[]{
               GetColor(this.BackColor, 0, -8, -8, -8),
               GetColor(this.BackColor, 0, -25, -25, -25),
               GetColor(this.BackColor, 0, -8, -8, -8) },

                Positions = new float[]{
                0.0f,
                0.5f,
                1.0f
            }
            };

            var destRect = new Rectangle(-8, this._captionHeight, this.Width + 15, this.Height - this._captionHeight - 1);
            if (destRect.Height * destRect.Width <= 0)
            {
                return;
            }
            using (LinearGradientBrush lBrush = new LinearGradientBrush(destRect, colorBlend.Colors[0], colorBlend.Colors[2], LinearGradientMode.Horizontal))
            {
                lBrush.InterpolationColors = colorBlend;
                g.FillRectangle(lBrush, destRect);
            }
        }

        private Image GetControlImage(bool expand)
        {
            var size = this._captionControlImageSize;
            var bmp = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                g.Clear(Color.Transparent);
                var color = Color.FromArgb(250, this.ForeColor);
                using (var p = new Pen(color, 1.5f))
                {
                    var space = size.Height / 4;//分四份3间隔
                    var width = size.Width;

                    var x = (size.Width - width) / 2f;
                    if (expand)
                    {
                        if (MouseOverCaptionControl)
                        {
                            g.DrawLine(p, x, space * 1, x + width, space * 1);
                            g.DrawLine(p, x, space * 2, x + width, space * 2);
                            g.DrawLine(p, x, space * 3, x + width, space * 3);
                        }
                        else
                        {
                            g.DrawLine(p, x + width / 2f, space, x + width, space);
                            g.DrawLine(p, x, space * 2, x + width, space * 2);
                            g.DrawLine(p, x + width / 4f, space * 3, x + width, space * 3);
                        }
                    }
                    else
                    {
                        if (MouseOverCaptionControl)
                        {
                            g.DrawLine(p, x, space, x + width / 2f, space);
                            g.DrawLine(p, x, space * 2, x + width, space * 2);
                            g.DrawLine(p, x, space * 3, x + +width * 3 / 4f, space * 3);
                        }
                        else
                        {
                            g.DrawLine(p, x, space * 1, x + width, space * 1);
                            g.DrawLine(p, x, space * 2, x + width, space * 2);
                            g.DrawLine(p, x, space * 3, x + width, space * 3);
                        }
                    }
                }
            }
            return bmp;
        }


        internal void OnGroupItemClick(WNavbarGroupItem item)
        {
            this.GroupItemClick?.Invoke(item, EventArgs.Empty);
        }


        //更新子项选择状态
        internal void RefreshItemSelectedStatus(WNavbarGroup item)
        {
            foreach (WNavbarGroup group in Items)
            {
                if (group != item)
                {
                    foreach (WNavbarGroupItem im in group.Items)
                    {
                        im.IsSelected = false;
                    }
                }
            }

        }


        #endregion
    }
}
