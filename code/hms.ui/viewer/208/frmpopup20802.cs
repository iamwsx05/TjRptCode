using Common.Controls;
using Common.Utils;
using System;
using System.Collections.Generic;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Hms.Ui
{
    /// <summary>
    /// 体检项目
    /// </summary>
    public partial class frmPopup20802 : frmBasePopup
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frmPopup20802()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="_peItemVo"></param>
        public frmPopup20802(EntityDicPeItem _peItemVo)
        {
            InitializeComponent();
            PeItemVo = _peItemVo;
        }
        #endregion

        #region var/property

        List<EntityDicPeDepartment> lstPeDept = null;

        public EntityDicPeItem PeItemVo { get; set; }

        /// <summary>
        /// 是否要求刷新
        /// </summary>
        public bool IsRequireRefresh { get; set; }

        #endregion

        #region method

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        void Init()
        {
            try
            {
                uiHelper.BeginLoading(this);

                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    lstPeDept = EntityTools.ConvertToEntityList<EntityDicPeDepartment>(proxy.Service.SelectFullTable(new EntityDicPeDepartment()));
                    if (lstPeDept != null)
                    {
                        foreach (EntityDicPeDepartment item in lstPeDept)
                        {
                            item.pyCode = SpellCodeHelper.GetPyCode(item.deptName);
                            item.wbCode = SpellCodeHelper.GetWbCode(item.deptName);
                        }
                    }
                }

                #region lue
                // lueDept
                this.lueDept.Properties.PopupWidth = 170;
                this.lueDept.Properties.PopupHeight = 350;
                this.lueDept.Properties.ValueColumn = EntityDicPeDepartment.Columns.deptId;
                this.lueDept.Properties.DisplayColumn = EntityDicPeDepartment.Columns.deptName;
                this.lueDept.Properties.Essential = false;
                this.lueDept.Properties.IsShowColumnHeaders = true;
                this.lueDept.Properties.ColumnWidth.Add(EntityDicPeDepartment.Columns.deptId, 50);
                this.lueDept.Properties.ColumnWidth.Add(EntityDicPeDepartment.Columns.deptName, 120);
                this.lueDept.Properties.ColumnHeaders.Add(EntityDicPeDepartment.Columns.deptId, "编码");
                this.lueDept.Properties.ColumnHeaders.Add(EntityDicPeDepartment.Columns.deptName, "名称");
                this.lueDept.Properties.ShowColumn = EntityDicPeDepartment.Columns.deptId + "|" + EntityDicPeDepartment.Columns.deptName;
                this.lueDept.Properties.IsUseShowColumn = true;
                this.lueDept.Properties.FilterColumn = EntityDicPeDepartment.Columns.deptId + "|" + EntityDicPeDepartment.Columns.deptId + "|" + EntityDicPeDepartment.Columns.pyCode + "|" + EntityDicPeDepartment.Columns.wbCode;
                if (lstPeDept != null)
                {
                    this.lueDept.Properties.DataSource = lstPeDept.ToArray();
                    this.lueDept.Properties.SetSize();
                }

                #endregion

                if (this.PeItemVo != null)
                {
                    this.txtItemName.Text = this.PeItemVo.itemName;
                    this.txtMinAge.Text = this.PeItemVo.minValue.ToString();
                    this.txtMaxAge.Text = this.PeItemVo.maxValue.ToString();
                    this.cboSex.SelectedIndex = this.PeItemVo.gender;
                    //this.txtRang1.Text = this.PeItemVo.refRange;
                    this.txtUnit.Text = this.PeItemVo.unit;
                    this.txtRef.Text = this.PeItemVo.refRange;
                    this.cboCompare.SelectedIndex = this.PeItemVo.isCompare;
                    this.cboImport.SelectedIndex = this.PeItemVo.isMain;
                    this.txtSortNo.Text = this.PeItemVo.sortNo.ToString();
                    this.txtIntroduce.Text = this.PeItemVo.itemInfo;

                    if (!string.IsNullOrEmpty(this.PeItemVo.deptId) && this.PeItemVo.deptId != "")
                    {
                        this.lueDept.SetDisplayText<EntityDicPeDepartment>(this.PeItemVo.deptName); 
                    }
                }
            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        void Save()
        {
            EntityDicPeItem itemVo = new EntityDicPeItem();
            itemVo.itemName = this.txtItemName.Text.Trim();
            if (this.lueDept.Properties.DBRow != null)
            {
                itemVo.deptId = (this.lueDept.Properties.DBRow as EntityDicPeDepartment).deptId;
            }
            itemVo.minValue = Function.Dec(this.txtMinAge.Text);
            itemVo.maxValue = Function.Dec(this.txtMaxAge.Text);
            itemVo.refRange = this.txtRef.Text.Trim();
            itemVo.gender = this.cboSex.SelectedIndex;
            //itemVo.displayPosition = "displayPosition";
            itemVo.unit = this.txtUnit.Text.Trim();
            itemVo.itemInfo = this.txtIntroduce.Text.Trim();
            itemVo.isCompare = this.cboCompare.SelectedIndex;
            itemVo.isMain = this.cboImport.SelectedIndex;
            itemVo.sortNo = Function.Int(this.txtSortNo.Text);

            if (this.PeItemVo != null)
            {
                itemVo.itemId = this.PeItemVo.itemId;
            }
            if (string.IsNullOrEmpty(itemVo.itemName))
            {
                DialogBox.Msg("项目名称不能为空，请填写。");
                this.txtItemName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(itemVo.deptId))
            {
                DialogBox.Msg("项目科室不能为空，请选择。");
                this.lueDept.Focus();
                return;
            }

            string itemId = string.Empty;
            using (ProxyHms proxy = new ProxyHms())
            {
                if (proxy.Service.SavePeItem(itemVo, out itemId) > 0)
                {
                    if (this.PeItemVo == null)
                    {
                        this.PeItemVo = new EntityDicPeItem() { itemId = itemId };
                    }
                    this.IsRequireRefresh = true;
                    DialogBox.Msg("保存体检项目成功！");
                }
                else
                {
                    DialogBox.Msg("保存体检项目失败。");
                }
            }
        }
        #endregion

        #endregion

        #region event

        private void frmPopup20802_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void blbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Save();
        }

        private void blbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
