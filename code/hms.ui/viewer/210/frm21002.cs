using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System.Drawing;
using System.Linq;
using weCare.Core.Utils;

namespace Hms.Ui
{
    /// <summary>
    /// 短信库
    /// </summary>
    public partial class frm21002 : frmBaseMdi
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frm21002()
        {
            InitializeComponent();
        }
        #endregion

        #region var/property

        /// <summary>
        /// 短信模板数据源
        /// </summary>
        List<EntityDicMessageContent> dataSourceMsgContent { get; set; }

        #endregion

        #region method

        #region init
        /// <summary>
        /// init
        /// </summary>
        void Init()
        {
            this.RefreshData();
            if (this.tvMsgType.Nodes.Count > 0)
            {
                List<TreeListNode> list = new List<TreeListNode>();
                GetChildNodes(this.tvMsgType.Nodes[0], ref list);
                if (list.Count > 0)
                {
                    FilterData(list[0]);
                    this.tvMsgType.FocusedNode = list[0];
                }
            }
        }
        #endregion

        #region ScrollRow
        /// <summary>
        /// ScrollRow
        /// </summary>
        /// <param name="sId"></param>
        void ScrollRow(decimal sId)
        {
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                this.gridView.UnselectRow(i);
            }
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                if ((this.gridView.GetRow(i) as EntityDicMessageContent).sId == sId)
                {
                    this.gridView.FocusedRowHandle = i;
                    this.gridView.SelectRow(i);
                    break;
                }
            }
        }
        #endregion

        #region GetChildNodes
        /// <summary>
        /// GetChildNodes
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="list"></param>
        void GetChildNodes(TreeListNode parentNode, ref List<TreeListNode> list)
        {
            if (parentNode.Nodes.Count > 0)
            {
                foreach (TreeListNode node in parentNode.Nodes)
                {
                    list.Add(node);
                    if (node.Nodes.Count > 0)
                    {
                        GetChildNodes(node, ref list);
                    }
                }
            }
        }
        #endregion

        #region LoadSmsContent
        /// <summary>
        /// LoadSmsContent
        /// </summary>
        void LoadSmsContent()
        {
            dataSourceMsgContent = null;
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                dataSourceMsgContent = EntityTools.ConvertToEntityList<EntityDicMessageContent>(proxy.Service.SelectFullTable(new EntityDicMessageContent()));
            }
        }
        #endregion

        #region InitCatalog
        /// <summary>
        /// InitCatalog
        /// </summary>
        void InitCatalog()
        {
            List<EntityDicMessageType> dataSourceMsgCatalog = null;
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                dataSourceMsgCatalog = EntityTools.ConvertToEntityList<EntityDicMessageType>(proxy.Service.SelectFullTable(new EntityDicMessageType()));
            }
            if (dataSourceMsgCatalog != null)
            {
                // 树结构
                tvMsgType.Columns.Clear();
                uiHelper.SetGridCol(tvMsgType, new string[] { "typeName" }, new string[] { "短信模板" }, new int[] { 200 });
                tvMsgType.Columns["typeName"].AppearanceCell.Font = new Font("宋体", 9);
                tvMsgType.KeyFieldName = "typeId";
                tvMsgType.ParentFieldName = "parentId";
                tvMsgType.ImageIndexFieldName = "tmpNo";

                tvMsgType.OptionsView.FocusRectStyle = DrawFocusRectStyle.None;
                tvMsgType.Appearance.FocusedRow.Options.UseBackColor = true;
                tvMsgType.Appearance.FocusedRow.BackColor = Color.LightGreen;    // Color.LightSkyBlue;
                tvMsgType.Appearance.FocusedRow.BackColor2 = Color.White;
                tvMsgType.Appearance.HideSelectionRow.Options.UseBackColor = true;
                tvMsgType.Appearance.HideSelectionRow.BackColor = Color.LightGreen;  // Color.LightSkyBlue;
                tvMsgType.Appearance.HideSelectionRow.BackColor2 = Color.White;

                tvMsgType.BeginUpdate();
                tvMsgType.DataSource = dataSourceMsgCatalog;

                tvMsgType.MouseClick -= new MouseEventHandler(tvMsgType_MouseClick);
                tvMsgType.MouseClick += new MouseEventHandler(tvMsgType_MouseClick);
                tvMsgType.MouseDoubleClick -= new MouseEventHandler(tvMsgType_MouseDoubleClick);
                tvMsgType.MouseDoubleClick += new MouseEventHandler(tvMsgType_MouseDoubleClick);

                tvMsgType.ExpandAll();
                tvMsgType.EndUpdate();
            }
        }
        #endregion

        #region 树事件
        /// <summary>
        /// 树操作中
        /// </summary>
        bool isTreeDoing { get; set; }
        /// <summary>
        /// tvCases_MouseClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tvMsgType_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (isTreeDoing) return;
                isTreeDoing = true;
                if (e.Button == MouseButtons.Left)
                {
                    FilterData(tvMsgType.CalcHitInfo(e.Location).Node);
                }
            }
            catch (Exception ex)
            {
                Log.Output(ex.Message);
            }
            finally
            {
                isTreeDoing = false;
            }
        }
        /// <summary>
        /// tvCases_MouseDoubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tvMsgType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (isTreeDoing) return;
                isTreeDoing = true;
                if (e.Button == MouseButtons.Left)
                {
                    FilterData(tvMsgType.CalcHitInfo(e.Location).Node);
                }
            }
            catch (Exception ex)
            {
                Log.Output(ex.Message);
            }
            finally
            {
                isTreeDoing = false;
            }
        }
        #endregion

        #region FilterData
        /// <summary>
        /// FilterData
        /// </summary>
        /// <param name="p"></param>
        void FilterData(TreeListNode node)
        {
            EntityDicMessageType typeVo = (EntityDicMessageType)this.tvMsgType.GetDataRecordByNode(node);
            if (this.dataSourceMsgContent != null && typeVo != null)
            {
                List<EntityDicMessageContent> tmpData = this.dataSourceMsgContent.FindAll(t => t.typeId == typeVo.typeId);
                if (tmpData != null && tmpData.Count > 0)
                {
                    foreach (EntityDicMessageContent item in tmpData)
                    {
                        item.typeName = typeVo.typeName;
                    }
                }
                this.gridControl.DataSource = tmpData;
            }
        }
        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        public override void New()
        {
            TreeListNode node = this.tvMsgType.FocusedNode;
            if (node.HasChildren)
            {
                DialogBox.Msg("请选择子节点。");
            }
            else
            {
                EntityDicMessageContent newVo = new EntityDicMessageContent();
                newVo.typeId = (this.tvMsgType.GetDataRecordByNode(node) as EntityDicMessageType).typeId;
                newVo.typeName = (this.tvMsgType.GetDataRecordByNode(node) as EntityDicMessageType).typeName;
                frmPopup21002 frm = new frmPopup21002(newVo);
                frm.ShowDialog();
                if (frm.IsRequireRefresh)
                {
                    this.LoadSmsContent();
                    this.FilterData(node);
                    this.ScrollRow(frm.smsVo.sId);
                }
            }
        }
        #endregion

        #region Edit
        /// <summary>
        /// Edit
        /// </summary>
        public override void Edit()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                frmPopup21002 frm = new frmPopup21002(this.gridView.GetRow(this.gridView.GetSelectedRows()[0]) as EntityDicMessageContent);
                frm.ShowDialog();
                if (frm.IsRequireRefresh)
                {
                    this.LoadSmsContent();
                    this.FilterData(this.tvMsgType.FocusedNode);
                    this.ScrollRow(frm.smsVo.sId);
                }
            }
            else
            {
                DialogBox.Msg("请选择要编辑的记录.");
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Delete
        /// </summary>
        public override void Delete()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                if (DialogBox.Msg("是否删除所选行记录？", MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                this.gridView.DeleteSelectedRows();
                bool isRequireRefresh = false;
                for (int i = this.gridView.RowCount - 1; i >= 0; i--)
                {
                    if (this.gridView.IsRowSelected(i))
                    {
                        using (ProxyHms proxy = new ProxyHms())
                        {
                            if (proxy.Service.DeleteMessageTemplate((this.gridView.GetRow(i) as EntityDicMessageContent).sId) > 0)
                            {
                                this.gridView.DeleteRow(i);
                                isRequireRefresh = true;
                            }
                            else
                            {
                                DialogBox.Msg("删除记录失败。");
                                break;
                            }
                        }
                    }
                }
                if (isRequireRefresh)
                    this.LoadSmsContent();
            }
            else
            {
                DialogBox.Msg("请选择需要删除的记录。");
            }
        }
        #endregion

        #region search
        /// <summary>
        /// search
        /// </summary>
        public override void Search()
        {

        }
        #endregion

        #region Export
        /// <summary>
        /// Export
        /// </summary>
        public override void Export()
        {
            uiHelper.ExportToXls(this.gridView);
        }
        #endregion

        #region Print
        /// <summary>
        /// Print
        /// </summary>
        public override void Preview()
        {
            uiHelper.Print(this.gridControl);
        }
        #endregion

        #region RefreshData
        /// <summary>
        /// RefreshData
        /// </summary>
        public override void RefreshData()
        {
            uiHelper.BeginLoading(this);
            this.InitCatalog();
            this.LoadSmsContent();
            uiHelper.CloseLoading(this);
        }
        #endregion

        #endregion

        #region event

        private void frm21002_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void frm21002_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.Delete();
            }
            else if (e.KeyCode == Keys.Print)
            {
                this.Preview();
            }
            else if (e.KeyCode == Keys.E)
            {
                this.Export();
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Appearance.ForeColor = Color.Gray;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }

        #endregion

    }
}
