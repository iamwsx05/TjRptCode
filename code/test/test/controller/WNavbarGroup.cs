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

namespace NavbarWinTest
{
    [ToolboxItem(true)]
    public class WNavbarGroup : Control
    {
        public WNavbarGroup() : base()
        {
            SetStyle(ControlStyles.UserPaint |
             ControlStyles.AllPaintingInWmPaint |
             ControlStyles.OptimizedDoubleBuffer |
             ControlStyles.ResizeRedraw |
             ControlStyles.SupportsTransparentBackColor, true);

            base.ForeColor = Color.FromArgb(61, 66, 68);
            base.BackColor = Color.FromArgb(251, 251, 251);

            this._font = new Font("Microsoft YaHei UI", 10f);

            Items = new WNavbarGroupItemCollection(this);

            _captionRectangle = new Rectangle(0, 0, Width, _captionHeight);

            _timerAnimation.Interval = 50;
            _timerAnimation.Tick += _timerAnimation_Tick;
        }


        #region WNavbarItemClolection

        public class WNavbarGroupItemCollection : IList, ICollection, IEnumerable
        {
            private WNavbarGroup owner;

            public WNavbarGroupItemCollection(WNavbarGroup navbarGroup)
            {
                this.owner = navbarGroup ?? throw new ArgumentNullException(nameof(navbarGroup));
            }

            public WNavbarGroupItem this[int index]
            {
                get
                {
                    if (index < 0 || index >= this.Count)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }
                    return (WNavbarGroupItem)this.owner.Controls[index];
                }
                set
                {
                }
            }

            #region IList 成员


            object IList.this[int index]
            {
                get
                {
                    return this[index];
                }
                set
                {

                }
            }

            bool IList.IsReadOnly => false;

            bool IList.IsFixedSize => false;

            object ICollection.SyncRoot => this;

            bool ICollection.IsSynchronized => false;

            int ICollection.Count => this.Count;

            int IList.Add(object groupItem)
            {
                if (groupItem is WNavbarGroupItem)
                {
                    return this.Add((WNavbarGroupItem)groupItem);
                }
                throw new ArgumentException("WNavbarGroupItem", nameof(groupItem));
            }

            bool IList.Contains(object value)
            {
                return value is WNavbarGroupItem && this.Contains((WNavbarGroupItem)value);
            }

            void ICollection.CopyTo(Array array, int index)
            {
                this.CopyTo(array, index);
            }

            int IList.IndexOf(object value)
            {
                if (value is WNavbarGroupItem)
                {
                    return this.IndexOf((WNavbarGroupItem)value);
                }
                throw new ArgumentException("WNavbarGroupItem", nameof(value));
            }

            void IList.Insert(int index, object value)
            {
                if (value is WNavbarGroupItem)
                {
                    this.Insert(index, (WNavbarGroupItem)value);
                    return;
                }
                throw new ArgumentException("WNavbarGroupItem", nameof(value));
            }

            void IList.Remove(object value)
            {
                if (value is WNavbarGroupItem)
                {
                    this.Remove((WNavbarGroupItem)value);
                    return;
                }
                throw new ArgumentException("WNavbarGroupItem", nameof(value));
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            #endregion

            [Browsable(false)]
            public int Count => this.owner.Controls.Count;

            public WNavbarGroupItem this[string key]
            {
                get
                {
                    var index = this.IndexOfKey(key);
                    if (this.owner.IsValidIndex(index))
                    {
                        return this[index];
                    }
                    return null;
                }
            }


            public int Add(WNavbarGroupItem groupItem)
            {
                this.owner.InternalAddItem(groupItem);
                return IndexOf(groupItem);
            }

            public void AddRange(WNavbarGroupItem[] groupItems)
            {
                if (groupItems == null)
                {
                    throw new ArgumentNullException(nameof(groupItems));
                }
                this.owner.InternalAddRange(groupItems);
            }

            public void Clear()
            {
                this.owner.Controls.Clear();
            }

            public void CopyTo(Array array, int index)
            {
                this.owner.Controls.CopyTo(array, index);
            }

            public bool Contains(WNavbarGroupItem groupItem)
            {
                return IndexOf(groupItem) == -1;
            }

            public bool ContainsKey(string key)
            {
                return this.owner.Controls.ContainsKey(key);
            }

            public void Insert(int index, WNavbarGroupItem groupItem)
            {
                this.Add(groupItem);
                this.owner.Controls.SetChildIndex(groupItem, index);
            }

            public void RemoveAt(int index)
            {
                this.owner.RemoveAt(index);
            }

            public void Remove(WNavbarGroupItem groupItem)
            {
                this.owner.Remove(groupItem);
            }

            public IEnumerator GetEnumerator()
            {
                return this.owner.Controls.GetEnumerator();
            }


            public int IndexOf(WNavbarGroupItem groupItem)
            {
                return this.owner.Controls.IndexOf(groupItem);
            }

            public int IndexOfKey(string key)
            {
                if (string.IsNullOrEmpty(key))
                {
                    return -1;
                }
                return this.owner.Controls.IndexOfKey(key);
            }

        }



        private void RemoveAt(int index)
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            this.Controls.RemoveAt(index);

            RefreshGroupHeight();
        }

        private void Remove(WNavbarGroupItem item)
        {
            int id = this.Controls.IndexOf(item);
            if (IsValidIndex(id))
            {
                this.RemoveAt(id);
            }
        }

        private void InternalAddItem(WNavbarGroupItem item)
        {
            item.Dock = DockStyle.Top;
            item.Parent = this;
            this.Controls.Add(item);
            item.BringToFront();

            RefreshGroupHeight();
        }

        private void InternalAddRange(WNavbarGroupItem[] items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }
            foreach (var item in items)
            {
                this.InternalAddItem(item);
            }
        }


        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < this.Controls.Count;
        }

        private bool CompareString(string s1, string s2, bool ignoreCase)
        {
            return s1 != null && s2 != null && s1.Length == s2.Length && string.Compare(s1, s2, ignoreCase, System.Globalization.CultureInfo.InvariantCulture) == 0;
        }



        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new Control.ControlCollection Controls
        {
            get
            {
                return base.Controls;
            }
        }

        #endregion

        #region public

        protected override Size DefaultSize => new Size(210, 45);

        public override Rectangle DisplayRectangle
        {
            get
            {
                var rect = base.DisplayRectangle;
                rect.Y = rect.Y + _captionHeight + 1;
                rect.Height = rect.Height - _captionHeight;
                return rect;
            }
        }

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

        [Browsable(false)]
        public override DockStyle Dock { get => base.Dock; set => base.Dock = value; }

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

        [Browsable(true), Category("Custom"), DefaultValue(45), Description("获取或设置标题栏高度,也即收缩后的高度."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public int CaptionHeight
        {
            get { return _captionHeight; }
            set
            {
                if (_captionHeight != value)
                {
                    _captionHeight = value;
                    _captionRectangle = new Rectangle(0, 0, Width, _captionHeight);

                    RefreshGroupHeight();

                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(false), Description("获取或设置当前组的展开状态."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public bool IsExpand
        {
            get { return _isExpand; }
            set
            {
                if (_isExpand != value)
                {
                    _isExpand = value;

                    this.Height = !_isExpand ? _captionHeight : _expandHeight;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Color), "211, 211, 222"), Description("获取或设置组的展开状态时的背景色."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Color ExpandColor
        {
            get { return _expandColor; }
            set
            {
                if (_expandColor != value)
                {
                    _expandColor = value;
                    if (_isExpand)
                    {
                        this.Invalidate();
                    }
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Color), "211, 211, 222"), Description("获取或设置组鼠标滑过时的组标头的背景色."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Color MouseOverColor
        {
            get { return _mouseOverColor; }
            set
            {
                if (_mouseOverColor != value)
                {
                    _mouseOverColor = value;
                }
            }
        }

        [Browsable(true), Category("Custom"), Description("获取或设置组标题鼠标滑过或选中时的字体颜色."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Color MouseOverForeColor
        {
            get { return _mouseOverForeColor; }
            set
            {
                if (_mouseOverForeColor != value)
                {
                    _mouseOverForeColor = value;
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(false), Description("获取或设置是否显示标题栏的分割线."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public bool IsShowSeparator
        {
            get { return _isShowBorder; }
            set
            {
                if (_isShowBorder != value)
                {
                    _isShowBorder = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), Description("获取或设置标题栏的分割线颜色."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Color CaptionSeparatorColor
        {
            get { return _borderColor; }
            set
            {
                if (_borderColor != value)
                {
                    _borderColor = value;
                    if (_isShowBorder)
                    {
                        this.Invalidate();
                    }
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(typeof(Point), "0,0"), Description("获取或设置标题文本偏移量"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
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


        [Browsable(true), Category("Custom"), DefaultValue(null), Description("获取或设置标题栏显示的图标"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
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

        [Browsable(true), Category("Custom"), DefaultValue(typeof(Size), "20,20"), Description("获取或设置标题栏显示的图标大小"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
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


        [Browsable(true), Category("Custom"), DefaultValue(typeof(Point), "0,0"), Description("获取或设置标题栏显示的图标偏移量"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
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

        [Browsable(true), Category("Custom"), DefaultValue(null), Description("鼠标滑过或展开时标题栏显示的图标"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Image ImageMouseOver
        {
            get { return _imageMouseOver; }
            set
            {
                if (value != _imageMouseOver)
                {
                    _imageMouseOver = value;
                    this.Invalidate();
                }
            }
        }




        [Browsable(true), Category("Custom"), DefaultValue(20), Description("获取或设置标题栏左右两侧的边距."), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public int CaptionMargin
        {
            get { return _leftRightMargin; }
            set
            {
                if (_leftRightMargin != value)
                {
                    _leftRightMargin = value;
                    this.Invalidate();
                }
            }
        }


        [Browsable(true), Category("Custom"), DefaultValue(typeof(Size), "16,16"), Description("获取或设置标题栏右侧控制图标的大小"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Size ImageControlSize
        {
            get { return _imageControlSize; }
            set
            {
                if (value != _imageControlSize)
                {
                    _imageControlSize = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(null), Description("获取或设置标题栏右侧展开状态时的图标"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Image ImageExpand
        {
            get { return _imageExpand; }
            set
            {
                if (value != _imageExpand)
                {
                    _imageExpand = value;
                    if (_isExpand)
                    {
                        this.Invalidate();
                    }
                }
            }
        }

        [Browsable(true), Category("Custom"), DefaultValue(null), Description("获取或设置标题栏右侧收缩状态时的图标"), RefreshProperties(RefreshProperties.Repaint), NotifyParentProperty(true)]
        public Image ImageCollapse
        {
            get { return _imageCollapse; }
            set
            {
                if (value != _imageCollapse)
                {
                    _imageCollapse = value;
                    if (!_isExpand)
                    {
                        this.Invalidate();
                    }
                }
            }
        }


        [Browsable(true),
            Category("Custom"),
            Description("获取或设置组中的子项，当从设计器中编辑此项后，请从所在窗体Designer.cs中（控件的Items.AddRange方法）手工调整子项顺序,然后项目上右键》清理》重新生成，否则运行时控件顺序会颠倒，未找到其他解决方法."),
            RefreshProperties(RefreshProperties.All),
            NotifyParentProperty(true),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
            Editor(typeof(WNavbarGroupItemCollectionEditor), typeof(UITypeEditor)),
            Localizable(true)]
        public WNavbarGroupItemCollection Items { get; }


        [Browsable(true), Category("Custom"), Description("是否启用展开和折叠动画")]
        public bool EnableExpandCollapseAnimation { get; set; } = true;

        [Browsable(true), Category("Custom"), Description("用户点击组中的按钮时触发该事件")]
        public event EventHandler ItemClick;

        #endregion

        #region private

        private int _captionHeight = 45;//标题栏高度,也是收缩后的高度

        private Rectangle _captionRectangle = Rectangle.Empty;//标题栏
        private int _expandHeight = 45;

        private bool _isExpand = false;//是否呈展开状态
        private Color _expandColor = Color.FromArgb(211, 211, 222);// Color.FromArgb(138, 138, 167);//展开后标题颜色
        private Color _mouseOverColor = Color.FromArgb(211, 211, 222);

        private Color _mouseOverForeColor = Color.FromArgb(61, 66, 68);//展开后标题字体颜色


        private bool _isShowBorder = false;
        private Color _borderColor = Color.FromArgb(203, 203, 203);

        private Image _image = null;
        private Size _imageSize = new Size(20, 20);
        private Point _imageOffset = new Point(0, 0);
        private Point _textOffset = new Point(0, 0);
        private Image _imageMouseOver = null;


        private int _leftRightMargin = 20;//左右余量

        private Size _imageControlSize = new Size(16, 16);
        private Image _imageExpand = null;
        private Image _imageCollapse = null;


        private Timer _timerAnimation = new Timer();
        private int _animationStep = 50;//动画幅度


        private bool _mouseOverCaption = false;//鼠标滑过

        private bool MouseOverCaption
        {
            get { return _mouseOverCaption; }
            set
            {
                if (_mouseOverCaption != value)
                {
                    _mouseOverCaption = value;
                    this.Invalidate();
                }
            }
        }

        private Font _font;


        #endregion

        #region override

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _imageMouseOver?.Dispose();
                _image?.Dispose();
                _imageExpand?.Dispose();
                _imageCollapse?.Dispose();

                this.Controls.Clear();

                _timerAnimation.Enabled = false;
                _timerAnimation.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            var pt = PointToClient(Cursor.Position);
            MouseOverCaption = _captionRectangle.Contains(pt);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            var pt = PointToClient(Cursor.Position);
            MouseOverCaption = _captionRectangle.Contains(pt);
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _mouseOverCaption = _captionRectangle.Contains(e.Location);
                if (_mouseOverCaption)
                {
                    if (EnableExpandCollapseAnimation)
                    {
                        if (!_timerAnimation.Enabled)
                        {

                            _isExpand = !_isExpand;
                            var s = 0.21f * 1000;//展开或收缩总耗时
                            var b = s / _timerAnimation.Interval;
                            var l = _expandHeight / b;
                            _animationStep = (int)l;
                            _timerAnimation.Enabled = true;
                            this.Invalidate();
                        }
                    }
                    else
                    {
                        IsExpand = !IsExpand;
                        this.Height = !_isExpand ? _captionHeight : _expandHeight;
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            MouseOverCaption = _captionRectangle.Contains(e.Location);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;

            DrawBackground(g);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            DrawImageAndText(g);

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (!_timerAnimation.Enabled)
            {
                RefreshGroupHeight();
            }
            _captionRectangle = new Rectangle(0, 0, Width, _captionHeight);
            this.Invalidate();
        }

        #endregion

        #region methods

        private void _timerAnimation_Tick(object sender, EventArgs e)
        {
            if (!_isExpand)//折叠
            {
                var h = this.Height;
                h -= _animationStep;
                if (h <= _captionHeight)
                {
                    h = _captionHeight;
                    _timerAnimation.Enabled = false;
                }
                this.Height = h;
            }
            else
            {
                var h = this.Height;
                h += _animationStep;
                if (h >= _expandHeight)
                {
                    h = _expandHeight;
                    _timerAnimation.Enabled = false;
                }
                this.Height = h;
            }
        }


        private void DrawImageAndText(Graphics g)
        {
            var rectImage = new RectangleF(_imageOffset, _imageSize);
            rectImage.X = rectImage.X + _leftRightMargin;
            rectImage.Y = rectImage.Y + (_captionHeight - rectImage.Height) / 2f;

            var rectText = new Rectangle(_textOffset.X, _textOffset.Y, this.Width - (int)rectImage.Right, _captionHeight);
            rectText.X = rectText.X + (int)rectImage.Right + 5;
            if (_image != null)
            {
                rectImage.Y -= 0.8f;
                if (this._imageMouseOver != null && (this._mouseOverCaption || this._isExpand))
                {
                    g.DrawImage(_imageMouseOver, rectImage);
                }
                else
                {
                    g.DrawImage(_image, rectImage);
                }
            }
            else
            {
                rectImage.Size = SizeF.Empty;

                rectText = new Rectangle(_textOffset.X, _textOffset.Y, this.Width - (int)rectImage.Right, _captionHeight);
                rectText.X = rectText.X + _leftRightMargin;
            }


            var foreColor = (this._mouseOverCaption || this._isExpand) ? this._mouseOverForeColor : this.ForeColor;
            using (var sd = new SolidBrush(foreColor))
            {
                using (var format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Center;

                    g.DrawString(this.Text, this.Font, sd, rectText, format);
                }
            }

            //右侧控制图标

            Image img = _isExpand ?
                (_imageExpand == null ? GetContorlImage(_isExpand) : (Image)_imageExpand.Clone()) :
                (_imageCollapse == null ? GetContorlImage(_isExpand) : (Image)_imageCollapse.Clone());

            var rectControl = new RectangleF(this.Width - _leftRightMargin - _imageControlSize.Width, (_captionHeight - _imageControlSize.Height) / 2f, _imageControlSize.Width, _imageControlSize.Height);
            g.DrawImage(img, rectControl);
            img.Dispose();
        }

        private Image GetContorlImage(bool expand)
        {
            var size = _imageControlSize;
            var bmp = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                g.Clear(Color.Transparent);

                using (var p = new Pen(this.ForeColor, 2f))
                {
                    PointF[] ps = new PointF[3];

                    var w = 12;//三角高宽
                    var h = 6;

                    if (expand)
                    {
                        ps[0] = new PointF((size.Width - w) / 2f, (size.Height - h) / 2f + h);
                        ps[1] = new PointF((size.Width - w) / 2f + w / 2f, (size.Height - h) / 2f);
                        ps[2] = new PointF((size.Width - w) / 2f + w, (size.Height - h) / 2 + h);
                    }
                    else
                    {
                        ps[0] = new PointF((size.Width - w) / 2f, (size.Height - h) / 2f);
                        ps[1] = new PointF((size.Width - w) / 2f + w / 2f, (size.Height - h) / 2f + h);
                        ps[2] = new PointF((size.Width - w) / 2f + w, (size.Height - h) / 2);
                    }

                    g.DrawLines(p, ps);
                }
            }
            return bmp;
        }

        private void DrawBackground(Graphics g)
        {
            var c = this.BackColor;
            if (_isExpand)
            {
                c = _expandColor;
            }
            else
            {
                if (_mouseOverCaption)
                {
                    c = _mouseOverColor;
                }
            }
            using (var sd = new SolidBrush(c))
            {
                g.FillRectangle(sd, _captionRectangle);
            }

            if (_isShowBorder)
            {
                using (var p = new Pen(_borderColor, 1f))
                {
                    g.DrawLine(p, _captionRectangle.X, _captionRectangle.Bottom - 1, _captionRectangle.Right, _captionRectangle.Bottom - 1);
                }
            }
        }

        //子项高度变化更新展开高度
        internal void RefreshGroupHeight()
        {
            var eh = _captionHeight;
            for (int i = 0; i < this.Items.Count; i++)
            {
                eh += this.Items[i].Height;
            }
            _expandHeight = eh + (this.Items.Count > 0 ? 2 : 0);

            this.Height = _isExpand ? _expandHeight : _captionHeight;
        }

        //更新子项选择状态,互斥型.
        internal void RefreshItemSelectedStatus(WNavbarGroupItem item)
        {
            foreach (WNavbarGroupItem im in Items)
            {
                if (im != item)
                {
                    im.IsSelected = false;
                }
            }

            //更新父级菜单其他子项选择项           
            if (this.Parent?.Parent is WNavbar parent)
            {
                parent?.RefreshItemSelectedStatus(this);
            }
        }

        //项点击事件
        internal void OnItemClick(WNavbarGroupItem item)
        {
            this.ItemClick?.Invoke(item, EventArgs.Empty);
            if (this.Parent?.Parent is WNavbar navbar)
            {
                navbar?.OnGroupItemClick(item);
            }
        }


        #endregion


    }

    //属性编辑器
    public class WNavbarGroupCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public WNavbarGroupCollectionEditor(Type type) : base(type)
        {

        }

        protected override bool CanSelectMultipleInstances()
        {
            return false;
        }

        protected override Type CreateCollectionItemType()
        {
            return typeof(WNavbarGroup);
        }

        protected override void DestroyInstance(object instance)
        {
            base.DestroyInstance(instance);
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
            return base.SetItems(editValue, value);
        }

    }
}
