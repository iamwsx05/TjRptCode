using Common.Controls;
using Common.Utils;
using Common.Entity;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Console.Ui
{
    public class ctlReport : BaseController
    {
        #region Override

        /// <summary>
        /// UI.Viewer
        /// </summary>
        private frmReport Viewer = null;

        /// <summary>
        /// SetUI
        /// </summary>
        /// <param name="child"></param>
        public override void SetUI(frmBase child)
        {
            base.SetUI(child);
            Viewer = (frmReport)child;
        }
        #endregion

        #region 变量.属性

        /// <summary>
        /// 数据源
        /// </summary>
        List<EntitySysReport> DataSourceRpt { get; set; }

        bool isInit { get; set; }
        bool isSave { get; set; }
        XtraReport xr { get; set; }

        #endregion

        #region 方法

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        internal void Init()
        {
            this.isInit = true;
            Viewer.txtSql.Document.HighlightingStrategy = ICSharpCode.TextEditor.Document.HighlightingStrategyFactory.CreateHighlightingStrategy("TSQL");
            Viewer.txtSql.Encoding = System.Text.Encoding.Default;
            Viewer.txtSql.TextEditorProperties.IsIconBarVisible = false;
            Viewer.txtSql.TextEditorProperties.ShowInvalidLines = false;
            Viewer.txtSql.TextEditorProperties.ShowSpaces = true;
            Viewer.txtSql.TextEditorProperties.ShowTabs = true;
            Viewer.txtSql.ShowVRuler = true;
            Viewer.txtSql.AutoScroll = true;
            Viewer.txtSql.VRulerRow = 2000;

            CreateTree();
            LoadDataSource();
            SetEditValueChangedEvent(Viewer.pcBackGround);
            SetEditValueChangedEvent(Viewer.txtSql);

            if (DataSourceRpt != null && DataSourceRpt.Count > 0)
            {
                LoadRptInfo(Viewer.tvRport.FindNodeByKeyID(DataSourceRpt[0].rptId));
            }

            this.isInit = false;
        }
        #endregion

        #region CreateTree
        /// <summary>
        /// CreateTree
        /// </summary>
        void CreateTree()
        {
            // 树结构
            Viewer.tvRport.Columns.Clear();
            uiHelper.SetGridCol(Viewer.tvRport, new string[] { "rptName" }, new string[] { "报表列表" }, new int[] { 200 });
            Viewer.tvRport.Columns["rptName"].AppearanceCell.Font = new Font("宋体", 9);
            Viewer.tvRport.KeyFieldName = "rptId";
            Viewer.tvRport.ParentFieldName = "";
            Viewer.tvRport.ImageIndexFieldName = "imageIndex";

            Viewer.tvRport.OptionsView.ShowFocusedFrame = false;
            Viewer.tvRport.Appearance.FocusedRow.Options.UseBackColor = true;
            Viewer.tvRport.Appearance.FocusedRow.BackColor = Color.LightGreen;    // Color.LightSkyBlue;
            Viewer.tvRport.Appearance.FocusedRow.BackColor2 = Color.White;
            Viewer.tvRport.Appearance.HideSelectionRow.Options.UseBackColor = true;
            Viewer.tvRport.Appearance.HideSelectionRow.BackColor = Color.LightGreen;  // Color.LightSkyBlue;
            Viewer.tvRport.Appearance.HideSelectionRow.BackColor2 = Color.White;
            Viewer.tvRport.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(tvRport_FocusedNodeChanged);
        }
        #endregion

        #region tvRport_FocusedNodeChanged
        /// <summary>
        /// 树操作中
        /// </summary>
        bool isTreeDoing { get; set; }
        /// <summary>
        /// tvDept_FocusedNodeChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvRport_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (Viewer.ValueChanged && !isSave)
            {
                if (DialogBox.Msg("是否保存数据？", MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Save();
                    return;
                }
            }

            if (isInit) return;
            try
            {
                if (isTreeDoing) return;
                isTreeDoing = true;
                LoadRptInfo(e.Node);
            }
            finally
            {
                isTreeDoing = false;
            }
        }
        #endregion

        #region LoadRptInfo
        /// <summary>
        /// LoadDeptInfo
        /// </summary>
        /// <param name="node"></param>
        void LoadRptInfo(TreeListNode node)
        {
            if (node == null) return;
            uiHelper.BeginLoading(Viewer);
            try
            {
                EntitySysReport rptVo = (EntitySysReport)Viewer.tvRport.GetDataRecordByNode(node);
                SetMainInfo(rptVo);
            }
            finally
            {
                uiHelper.CloseLoading(Viewer);
            }
        }
        #endregion

        #region LoadDataSource
        /// <summary>
        /// LoadDataSource
        /// </summary>
        void LoadDataSource()
        {
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                this.isInit = true;
                DataTable dt = proxy.Service.SelectFullTable(new EntitySysReport());
                DataSourceRpt = EntityTools.ConvertToEntityList<EntitySysReport>(dt);
                Viewer.tvRport.BeginUpdate();
                Viewer.tvRport.DataSource = DataSourceRpt;
                Viewer.tvRport.ExpandAll();
                Viewer.tvRport.EndUpdate();
                this.isInit = false;
            }
        }
        #endregion

        #region SetMainInfo
        /// <summary>
        /// SetMainInfo
        /// </summary>
        /// <param name="vo"></param>
        void SetMainInfo(EntitySysReport vo)
        {
            uiHelper.BeginLoading(Viewer);
            if (vo == null)
            {
                Viewer.txtRptNo.Tag = null;
                Viewer.txtRptNo.Text = string.Empty;
                Viewer.txtRptName.Text = string.Empty;
                Viewer.txtSql.Text = string.Empty;
            }
            else
            {
                Viewer.txtRptNo.Tag = vo;
                Viewer.txtRptNo.Text = vo.rptNo;
                Viewer.txtRptName.Text = vo.rptName;
                Viewer.txtSql.Text = vo.rptSql;
            }
            Viewer.txtSql.Refresh();
            xr = new XtraReport();
            if (vo != null && vo.rptFile != null && vo.rptFile.Length > 0)
            {
                MemoryStream stream = new MemoryStream(vo.rptFile);
                xr.LoadLayout(stream);
                xr.DataSource = GetDataSource();
            }
            this.Viewer.ucPrintControl.PrintingSystem = xr.PrintingSystem;
            xr.CreateDocument();
            Viewer.ValueChanged = false;
            uiHelper.CloseLoading(Viewer);
        }
        #endregion

        #region GetDataSource
        /// <summary>
        /// GetDataSource
        /// </summary>
        /// <returns></returns>
        DataTable GetDataSource()
        {
            string Sql = Viewer.txtSql.Text.Trim();
            if (string.IsNullOrEmpty(Sql))
            {
                return new DataTable("数据源");
            }
            using (ProxyFrame proxy = new ProxyFrame())
            {
                return proxy.Service.GetRptDataTable(Sql);
            }
        }
        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        internal void New()
        {
            SetMainInfo(null);
            Viewer.txtRptNo.Focus();
        }
        #endregion

        #region Delete
        /// <summary>
        /// Delete
        /// </summary>
        internal void Delete()
        {
            EntitySysReport reportVo = Viewer.txtRptNo.Tag as EntitySysReport;
            if (reportVo == null || reportVo.rptId == 0) return;
            if (DialogBox.Msg("是否删除当前报表？", MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ProxyFrame proxy = new ProxyFrame())
                {
                    int ret = proxy.Service.DeleteReport(reportVo.rptId);
                    if (ret > 0)
                    {
                        SetMainInfo(null);
                        Viewer.tvRport.Nodes.Remove(Viewer.tvRport.FocusedNode);
                        DialogBox.Msg("删除成功！");
                    }
                    else
                    {
                        DialogBox.Msg("删除失败。");
                    }
                }
            }
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        internal bool Save()
        {
            if (isSave) return false;
            isSave = true;
            try
            {
                bool isNew = false;
                EntitySysReport reportVo = null;
                if (Viewer.txtRptNo.Tag == null)
                {
                    reportVo = new EntitySysReport();
                    reportVo.creatorId = GlobalLogin.objLogin.EmpNo;
                    reportVo.createDate = Utils.ServerTime();
                    isNew = true;
                }
                else
                {
                    reportVo = Viewer.txtRptNo.Tag as EntitySysReport;
                }
                reportVo.rptNo = Viewer.txtRptNo.Text.Trim();
                reportVo.rptName = Viewer.txtRptName.Text.Trim();
                reportVo.rptSql = Viewer.txtSql.Text.Trim();

                if (string.IsNullOrEmpty(reportVo.rptNo))
                {
                    DialogBox.Msg("请输入报表编号。");
                    Viewer.txtRptNo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(reportVo.rptName))
                {
                    DialogBox.Msg("请输入报表名称。");
                    Viewer.txtRptName.Focus();
                    return false;
                }
                reportVo.pyCode = SpellCodeHelper.GetPyCode(reportVo.rptName);
                reportVo.wbCode = SpellCodeHelper.GetWbCode(reportVo.rptName);
                reportVo.type = 1;
                reportVo.status = 1;

                using (ProxyFrame proxy = new ProxyFrame())
                {
                    if (proxy.Service.SaveReport(ref reportVo) > 0)
                    {
                        Viewer.txtRptNo.Tag = reportVo;
                        if (isNew)
                        {
                            (Viewer.tvRport.DataSource as List<EntitySysReport>).Add(reportVo);
                            Viewer.tvRport.RefreshDataSource();
                            Viewer.tvRport.FocusedNode = Viewer.tvRport.FindNodeByKeyID(reportVo.rptId);
                        }
                        else
                        {
                            int index = (Viewer.tvRport.DataSource as List<EntitySysReport>).FindIndex(t => t.rptId == reportVo.rptId);
                            (Viewer.tvRport.DataSource as List<EntitySysReport>)[index] = reportVo;
                            Viewer.tvRport.RefreshDataSource();
                        }
                        DialogBox.Msg("保存报表成功！");
                    }
                    else
                    {
                        DialogBox.Msg("保存报表失败。");
                    }
                }
                Viewer.ValueChanged = false;
            }
            catch (Exception ex)
            {
                DialogBox.Msg(ex.Message);
                return false;
            }
            finally
            {
                isSave = false;
            }
            return true;
        }
        #endregion

        #region Design
        /// <summary>
        /// Design
        /// </summary>
        internal void Design()
        {
            EntitySysReport rptVo = Viewer.txtRptNo.Tag as EntitySysReport;
            if (rptVo == null)
            {
                DialogBox.Msg("请保存报表。");
                return;
            }
            if (string.IsNullOrEmpty(rptVo.rptSql))
            {
                DialogBox.Msg("请书写报表数据源(Sql)");
                return;
            }
            if (Viewer.ValueChanged)
            {
                if (this.Save() == false)
                {
                    return;
                }
            }
            DataTable dt = GetDataSource();
            if (dt == null)
            {
                DialogBox.Msg("书写的Sql不能正确构造出数据源，请检查Sql是否正确。");
                return;
            }
            rptVo.dataSource = dt;
            using (frmReportDesigner frm = new frmReportDesigner(rptVo))
            {
                frm.ShowDialog();
                if (frm.IsSave)
                {
                    int index = (Viewer.tvRport.DataSource as List<EntitySysReport>).FindIndex(t => t.rptId == rptVo.rptId);
                    (Viewer.tvRport.DataSource as List<EntitySysReport>)[index] = rptVo;
                    SetMainInfo(rptVo);
                }
            }
        }
        #endregion

        #region Refresh
        /// <summary>
        /// Refresh
        /// </summary>
        internal void Refresh()
        {
            LoadDataSource();
            EntitySysReport reportVo = Viewer.txtRptNo.Tag as EntitySysReport;
            if (reportVo != null)
            {
                Viewer.tvRport.FocusedNode = Viewer.tvRport.FindNodeByKeyID(reportVo.rptId);
            }
        }
        #endregion

        #endregion

    }
}
