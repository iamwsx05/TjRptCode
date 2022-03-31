using Common.Controls;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Console.Ui
{
    public class ctlDepartment : BaseController
    {
        #region Override

        /// <summary>
        /// UI.Viewer
        /// </summary>
        private frmDepartment Viewer = null;

        /// <summary>
        /// SetUI
        /// </summary>
        /// <param name="child"></param>
        public override void SetUI(frmBase child)
        {
            base.SetUI(child);
            Viewer = (frmDepartment)child;
        }
        #endregion

        #region 变量.属性

        /// <summary>
        /// isInit
        /// </summary>
        bool isInit { get; set; }

        /// <summary>
        /// 科室.数据源
        /// </summary>
        List<EntityCodeDepartment> DataSourceDept { get; set; }

        /// <summary>
        /// 数据源.诊间
        /// </summary>
        BindingSource gvDataBindingSourceRoom { get; set; }

        /// <summary>
        /// 数据源.专科
        /// </summary>
        BindingSource gvDataBindingSourceExpert { get; set; }

        #endregion

        #region 方法

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        internal void Init()
        {
            isInit = true;
            Viewer.txtDeptCode.Tag = null;
            InitRoom();
            InitExpert();
            CreateTree();
            LoadDataSource();
            SetEditValueChangedEvent(Viewer.plTop);
            SetEditValueChangedEvent(Viewer.gvRoom);
            SetEditValueChangedEvent(Viewer.gvExpert);
            isInit = false;

        }
        #endregion

        #region PauseRedraw/StartRedraw
        /// <summary>
        /// PauseRedraw
        /// </summary>
        internal void PauseRedraw()
        {
            Function.SuspendLayout(Viewer.gcRoom.Handle);
            Function.SuspendLayout(Viewer.gcExpert.Handle);
            Function.SuspendLayout(Viewer.plTop.Handle);
            Function.SuspendLayout(Viewer.Handle);
        }
        /// <summary>
        /// StartRedraw
        /// </summary>
        internal void StartRedraw()
        {
            Function.ResumeLayout(Viewer.gcRoom.Handle);
            Function.ResumeLayout(Viewer.gcExpert.Handle);
            Function.ResumeLayout(Viewer.plTop.Handle);
            Function.ResumeLayout(Viewer.Handle);
            Viewer.Refresh();

        }
        #endregion

        #region dept

        #region CreateTree
        /// <summary>
        /// CreateTree
        /// </summary>
        void CreateTree()
        {
            // 树结构
            Viewer.tvDept.Columns.Clear();
            uiHelper.SetGridCol(Viewer.tvDept, new string[] { "deptName" }, new string[] { "科室列表" }, new int[] { 200 });
            Viewer.tvDept.Columns["deptName"].AppearanceCell.Font = new Font("宋体", 9);
            Viewer.tvDept.KeyFieldName = "deptCode";
            Viewer.tvDept.ParentFieldName = "parent";
            Viewer.tvDept.ImageIndexFieldName = "imageIndex";

            Viewer.tvDept.OptionsView.ShowFocusedFrame = false;
            Viewer.tvDept.Appearance.FocusedRow.Options.UseBackColor = true;
            Viewer.tvDept.Appearance.FocusedRow.BackColor = Color.LightGreen;    // Color.LightSkyBlue;
            Viewer.tvDept.Appearance.FocusedRow.BackColor2 = Color.White;
            Viewer.tvDept.Appearance.HideSelectionRow.Options.UseBackColor = true;
            Viewer.tvDept.Appearance.HideSelectionRow.BackColor = Color.LightGreen;  // Color.LightSkyBlue;
            Viewer.tvDept.Appearance.HideSelectionRow.BackColor2 = Color.White;

            //Viewer.tvDept.MouseClick += new MouseEventHandler(tvDept_MouseClick);
            Viewer.tvDept.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(tvDept_FocusedNodeChanged);

            // lueParent
            Viewer.lueParent.Properties.PopupWidth = 160;
            Viewer.lueParent.Properties.PopupHeight = 300;
            Viewer.lueParent.Properties.ValueColumn = EntityCodeDepartment.Columns.deptCode;
            Viewer.lueParent.Properties.DisplayColumn = EntityCodeDepartment.Columns.deptName;
            Viewer.lueParent.Properties.Essential = false;
            Viewer.lueParent.Properties.IsShowColumnHeaders = true;
            Viewer.lueParent.Properties.ColumnWidth.Add(EntityCodeDepartment.Columns.deptCode, 60);
            Viewer.lueParent.Properties.ColumnWidth.Add(EntityCodeDepartment.Columns.deptName, 100);
            Viewer.lueParent.Properties.ColumnHeaders.Add(EntityCodeDepartment.Columns.deptCode, "编码");
            Viewer.lueParent.Properties.ColumnHeaders.Add(EntityCodeDepartment.Columns.deptName, "名称");
            Viewer.lueParent.Properties.ShowColumn = EntityCodeDepartment.Columns.deptCode + "|" + EntityCodeDepartment.Columns.deptName;
            Viewer.lueParent.Properties.IsUseShowColumn = true;
            Viewer.lueParent.Properties.FilterColumn = EntityCodeDepartment.Columns.deptCode + "|" + EntityCodeDepartment.Columns.deptName + "|" + EntityCodeDepartment.Columns.pyCode + "|" + EntityCodeDepartment.Columns.wbCode;

        }
        #endregion

        #region tvDept_MouseClick
        /// <summary>
        /// tvCases_MouseClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //void tvDept_MouseClick(object sender, MouseEventArgs e)
        //{
        //    try
        //    {
        //        if (isTreeDoing) return;
        //        isTreeDoing = true;
        //        if (e.Button == MouseButtons.Left)
        //        {
        //            LoadDeptInfo(Viewer.tvDept.CalcHitInfo(e.Location).Node);
        //        }
        //    }
        //    finally
        //    {
        //        isTreeDoing = false;
        //    }
        //}
        #endregion

        #region tvDept_FocusedNodeChanged
        /// <summary>
        /// 树操作中
        /// </summary>
        bool isTreeDoing { get; set; }
        /// <summary>
        /// tvDept_FocusedNodeChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvDept_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (Viewer.ValueChanged)
            {
                if (DialogBox.Msg("是否保存数据？", MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Save(false);
                    return;
                }
            }

            if (isInit) return;
            try
            {
                if (isTreeDoing) return;
                isTreeDoing = true;
                LoadDeptInfo(e.Node);
            }
            finally
            {
                isTreeDoing = false;
            }
        }
        #endregion

        #region LoadDeptInfo
        /// <summary>
        /// LoadDeptInfo
        /// </summary>
        /// <param name="node"></param>
        void LoadDeptInfo(TreeListNode node)
        {
            if (node == null) return;
            uiHelper.BeginLoading(Viewer);
            this.PauseRedraw();
            try
            {
                EntityCodeDepartment deptVo = (EntityCodeDepartment)Viewer.tvDept.GetDataRecordByNode(node);
                SetMainInfo(deptVo);
            }
            finally
            {
                this.StartRedraw();
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
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                this.isInit = true;
                DataSourceDept = proxy.Service.LoadDeptInfo();
                Viewer.tvDept.BeginUpdate();
                Viewer.tvDept.DataSource = DataSourceDept;
                Viewer.tvDept.ExpandAll();
                Viewer.tvDept.EndUpdate();

                if (DataSourceDept == null)
                    Viewer.lueParent.Properties.DataSource = null;
                else
                {
                    EntityCodeDepartment[] data = new EntityCodeDepartment[DataSourceDept.Count + 1];
                    for (int i = 0; i < DataSourceDept.Count; i++)
                    {
                        data[i] = DataSourceDept[i];
                    }
                    EntityCodeDepartment vo = new EntityCodeDepartment();
                    vo.deptCode = "&";
                    vo.deptName = "全院";
                    data[data.Length - 1] = vo;
                    Viewer.lueParent.Properties.DataSource = data;
                }
                Viewer.lueParent.Properties.SetSize();
                this.isInit = false;
            }
        }
        #endregion

        #region SetMainInfo
        /// <summary>
        /// SetMainInfo
        /// </summary>
        /// <param name="vo"></param>
        void SetMainInfo(EntityCodeDepartment vo)
        {
            if (vo == null)
            {
                Viewer.txtDeptCode.Tag = null;
                Viewer.txtDeptCode.Text = string.Empty;
                Viewer.txtDeptName.Text = string.Empty;
                Viewer.lueParent.Properties.DBValue = null;
                Viewer.lueParent.Text = string.Empty;
                Viewer.cboType.SelectedIndex = -1;
                Viewer.cboType.Text = string.Empty;
                Viewer.cboLevel.SelectedIndex = -1;
                Viewer.cboLevel.Text = string.Empty;
                Viewer.cboLeaf.SelectedIndex = 1;
                Viewer.cboIsBk.Text = string.Empty;
                Viewer.cboIsBk.SelectedIndex = 0;
                Viewer.txtXh.Text = string.Empty;
                InitRoom();
                InitExpert();
            }
            else
            {
                Viewer.txtDeptCode.Tag = vo;
                Viewer.txtDeptCode.Text = vo.deptCode;
                Viewer.txtDeptName.Text = vo.deptName;
                Viewer.txtXh.Text = vo.xh.ToString();
                Viewer.lueParent.Properties.DBValue = vo.parent;
                SetLueParent(vo.parent);
                if (Function.Int(vo.type) > 0)
                {
                    Viewer.cboType.SelectedIndex = Function.Int(vo.type) - 1;
                }
                else
                {
                    Viewer.cboType.SelectedIndex = -1;
                    Viewer.cboType.Text = string.Empty;
                }
                if (Function.Int(vo.grade) > 0)
                {
                    Viewer.cboLevel.SelectedIndex = Function.Int(vo.grade) - 1;
                }
                else
                {
                    Viewer.cboLevel.SelectedIndex = -1;
                    Viewer.cboLevel.Text = string.Empty;
                }
                Viewer.cboLeaf.SelectedIndex = (!string.IsNullOrEmpty(vo.leafFlag) && vo.leafFlag.ToUpper() == "T") ? 1 : 0;
                Viewer.cboIsBk.SelectedIndex = Function.Int(vo.isBk);

                #region room、expert

                using (ProxyDictionary proxy = new ProxyDictionary())
                {
                    this.gvDataBindingSourceRoom.DataSource = proxy.Service.LoadDeptRoom(vo.deptCode);
                    this.gvDataBindingSourceExpert.DataSource = proxy.Service.LoadDeptExpert(vo.deptCode);
                }
                #endregion

            }
            Viewer.ValueChanged = false;
        }

        #region SetLueParent
        /// <summary>
        /// SetLueParent
        /// </summary>
        /// <param name="deptCode"></param>
        void SetLueParent(string deptCode)
        {
            Viewer.lueParent.Properties.ForbidPoput = true;
            if (DataSourceDept != null && DataSourceDept.Count > 0)
            {
                if (DataSourceDept.Any(t => t.deptCode == deptCode))
                {
                    Viewer.lueParent.Text = (DataSourceDept.FirstOrDefault(t => t.deptCode == deptCode)).deptName;
                }
                else
                {
                    Viewer.lueParent.Text = (deptCode == "&" ? "全院" : string.Empty);
                }
            }
            else
            {
                Viewer.lueParent.Text = (deptCode == "&" ? "全院" : string.Empty);
            }
            Viewer.lueParent.Properties.DisplayValue = Viewer.lueParent.Text;
            Viewer.lueParent.Properties.ForbidPoput = false;
        }
        #endregion
        #endregion

        #endregion

        #region room

        #region InitRoom
        /// <summary>
        /// InitRoom
        /// </summary>
        void InitRoom()
        {
            this.gvDataBindingSourceRoom = new BindingSource();
            this.gvDataBindingSourceRoom.DataSource = new List<EntityDicDeptRoom>();
            Viewer.gcRoom.DataSource = this.gvDataBindingSourceRoom;
        }
        #endregion

        #region NewRowRoom
        /// <summary>
        /// NewRowRoom
        /// </summary>
        internal void NewRowRoom()
        {
            AppendRow(this.gvDataBindingSourceRoom);
        }
        #endregion

        #region DelRowRoom
        /// <summary>
        /// DelRowRoom
        /// </summary>
        internal void DelRowRoom()
        {
            DeleteRow(Viewer.gvRoom, this.gvDataBindingSourceRoom, Viewer.gvRoom.FocusedRowHandle);
        }
        #endregion

        #endregion

        #region expert

        #region InitExpert
        /// <summary>
        /// InitExpert
        /// </summary>
        void InitExpert()
        {
            this.gvDataBindingSourceExpert = new BindingSource();
            this.gvDataBindingSourceExpert.DataSource = new List<EntityDicDeptReg>();
            Viewer.gcExpert.DataSource = this.gvDataBindingSourceExpert;
        }
        #endregion

        #region NewRowExpert
        /// <summary>
        /// NewRowRoom
        /// </summary>
        internal void NewRowExpert()
        {
            AppendRow(this.gvDataBindingSourceExpert);
        }
        #endregion

        #region DelRowRoom
        /// <summary>
        /// DelRowRoom
        /// </summary>
        internal void DelRowExpert()
        {
            DeleteRow(Viewer.gvExpert, this.gvDataBindingSourceExpert, Viewer.gvExpert.FocusedRowHandle);
        }
        #endregion

        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        internal void New()
        {
            SetMainInfo(null);
        }
        #endregion

        #region GetOrigDept
        /// <summary>
        /// GetOrigDept
        /// </summary>
        /// <returns></returns>
        EntityCodeDepartment GetOrigDept()
        {
            if (Viewer.txtDeptCode.Tag == null) return null;
            return Viewer.txtDeptCode.Tag as EntityCodeDepartment;
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        /// <param name="isExit">是否窗体退出时</param>
        internal void Save(bool isExit)
        {
            // 1.main
            EntityCodeDepartment mainVo = new EntityCodeDepartment();
            mainVo.deptCode = Viewer.txtDeptCode.Text.Trim();
            mainVo.deptName = Viewer.txtDeptName.Text.Trim();
            mainVo.parent = Viewer.lueParent.Properties.DBValue;
            mainVo.type = Convert.ToString(Viewer.cboType.SelectedIndex + 1);
            mainVo.grade = Viewer.cboLevel.SelectedIndex + 1;
            mainVo.leafFlag = Viewer.cboLeaf.Text == "是" ? "T" : "F";
            mainVo.isBk = Viewer.cboIsBk.SelectedIndex;
            mainVo.xh = Function.Int(Viewer.txtXh.Text);

            #region 校验

            if (string.IsNullOrEmpty(mainVo.deptCode))
            {
                DialogBox.Msg("请输入科室编码。");
                Viewer.txtDeptCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(mainVo.deptName))
            {
                DialogBox.Msg("请输入科室名称");
                Viewer.txtDeptName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(mainVo.parent))
            {
                DialogBox.Msg("请选择父级科室");
                Viewer.lueParent.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Viewer.cboType.Text))
            {
                DialogBox.Msg("请选择科室类型");
                Viewer.cboType.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Viewer.cboLevel.Text))
            {
                DialogBox.Msg("请选择科室级别");
                Viewer.cboLevel.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Viewer.cboLeaf.Text))
            {
                DialogBox.Msg("请指定是否为末级科室");
                Viewer.cboLeaf.Focus();
                return;
            }
            #endregion

            EntityCodeDepartment deptOrig = null;
            if (Viewer.txtDeptCode.Tag != null)
            {
                deptOrig = Viewer.txtDeptCode.Tag as EntityCodeDepartment;
            }

            List<string> lstKey = new List<string>();
            // 2.room
            Viewer.gvRoom.CloseEditor();
            List<EntityDicDeptRoom> lstDeptRoom = this.gvDataBindingSourceRoom.DataSource as List<EntityDicDeptRoom>;
            for (int i = lstDeptRoom.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(lstDeptRoom[i].roomCode) && !string.IsNullOrEmpty(lstDeptRoom[i].roomName))
                {
                    lstDeptRoom[i].deptCode = mainVo.deptCode;
                    lstDeptRoom[i].status = 1;
                    if (lstKey.IndexOf(lstDeptRoom[i].roomCode) >= 0)
                    {
                        DialogBox.Msg("诊室编号不能重复，请检查。");
                        Viewer.gcRoom.Focus();
                        return;
                    }
                    else
                    {
                        lstKey.Add(lstDeptRoom[i].roomCode);
                    }
                }
                else
                {
                    lstDeptRoom.RemoveAt(i);
                }
            }

            // 3.expert
            lstKey.Clear();
            Viewer.gvExpert.CloseEditor();
            List<EntityDicDeptReg> lstDeptExpert = this.gvDataBindingSourceExpert.DataSource as List<EntityDicDeptReg>;
            if (lstDeptExpert != null)
            {
                for (int i = lstDeptExpert.Count - 1; i >= 0; i--)
                {
                    if (!string.IsNullOrEmpty(lstDeptExpert[i].regCode) && !string.IsNullOrEmpty(lstDeptExpert[i].regName))
                    {
                        lstDeptExpert[i].deptCode = mainVo.deptCode;
                        lstDeptExpert[i].status = 1;
                        if (lstKey.IndexOf(lstDeptExpert[i].regCode) >= 0)
                        {
                            DialogBox.Msg("专科号编号不能重复，请检查。");
                            Viewer.gcExpert.Focus();
                            return;
                        }
                        else
                        {
                            lstKey.Add(lstDeptExpert[i].regCode);
                        }
                    }
                    else
                    {
                        lstDeptExpert.RemoveAt(i);
                    }
                }
            }

            ProxyDictionary proxy = new ProxyDictionary();
            int ret = proxy.Service.SaveDepartment(mainVo, deptOrig, lstDeptRoom, lstDeptExpert);
            proxy = null;
            if (ret > 0)
            {
                Viewer.ValueChanged = false;
                // 刷新树 
                if (!isExit)
                {
                    Viewer.txtDeptCode.Tag = mainVo;
                    Refresh();
                }
                DialogBox.Msg("保存成功！");
            }
            else
            {
                DialogBox.Msg("保存失败。");
            }
        }
        #endregion

        #region Del
        /// <summary>
        /// Del
        /// </summary>
        internal void Del()
        {
            EntityCodeDepartment vo = Viewer.txtDeptCode.Tag as EntityCodeDepartment;
            if (vo == null || string.IsNullOrEmpty(vo.deptCode)) return;

            if (DialogBox.Msg("是否删除当前科室？", MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProxyDictionary proxy = new ProxyDictionary();
                int ret = proxy.Service.DelDepartment(vo.deptCode);
                proxy = null;
                if (ret > 0)
                {
                    // 刷新树
                    SetMainInfo(null);
                    Refresh();
                    Viewer.ValueChanged = false;
                    DialogBox.Msg("删除成功！");
                }
                else
                {
                    DialogBox.Msg("删除失败。");
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
            uiHelper.BeginLoading(Viewer);
            try
            {
                EntityCodeDepartment vo = null;
                if (Viewer.txtDeptCode.Tag != null)
                {
                    vo = Viewer.txtDeptCode.Tag as EntityCodeDepartment;
                }
                LoadDataSource();
                if (vo != null)
                {
                    Viewer.tvDept.SetFocusedNode(Viewer.tvDept.FindNodeByKeyID(vo.deptCode));
                }
            }
            finally
            {
                uiHelper.CloseLoading(Viewer);
            }
        }
        #endregion

        #endregion
    }
}
