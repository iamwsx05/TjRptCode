using Common.Controls;
using Common.Entity;
using Common.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Console.Ui
{
    public class ctlEmployee : BaseController
    {
        #region Override

        /// <summary>
        /// UI.Viewer
        /// </summary>
        private frmEmployee Viewer = null;

        /// <summary>
        /// SetUI
        /// </summary>
        /// <param name="child"></param>
        public override void SetUI(frmBase child)
        {
            base.SetUI(child);
            Viewer = (frmEmployee)child;
        }
        #endregion

        #region 变量.属性

        /// <summary>
        /// 职工列表
        /// </summary>
        List<EntityOperatorDisp> DataSourceEmpList { get; set; }

        /// <summary>
        /// 职务数据源
        /// </summary>
        List<EntityCodeDuty> DataSourceDuty { get; set; }

        /// <summary>
        /// 人员类型
        /// </summary>
        List<EntityCodeOperatorClass> DataSourceClass { get; set; }

        /// <summary>
        /// 角色数据源
        /// </summary>
        List<EntityCodeRole> DataSourceRole { get; set; }

        /// <summary>
        /// oper.dept
        /// </summary>
        List<EntityDefDeptemployee> DataSourceOperDept { get; set; }

        /// <summary>
        /// oper.role
        /// </summary>
        List<EntityDefOperatorRole> DataSourceOperRole { get; set; }

        /// <summary>
        /// isInit
        /// </summary>
        bool isInit { get; set; }

        /// <summary>
        /// 科室.数据源
        /// </summary>
        List<EntityCodeDepartment> DataSourceDept { get; set; }

        #endregion

        #region 方法

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        internal void Init()
        {
            #region dic
            DataTable dt = null;
            DataSourceDuty = new List<EntityCodeDuty>();
            DataSourceClass = new List<EntityCodeOperatorClass>();
            DataSourceRole = new List<EntityCodeRole>();
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                dt = proxy.Service.SelectFullTable(new EntityCodeDuty());
                DataSourceDuty.AddRange(EntityTools.ConvertToEntityList<EntityCodeDuty>(dt));
                dt = proxy.Service.SelectFullTable(new EntityCodeOperatorClass());
                DataSourceClass.AddRange(EntityTools.ConvertToEntityList<EntityCodeOperatorClass>(dt));
                dt = proxy.Service.SelectFullTable(new EntityCodeRole());
                DataSourceRole.AddRange(EntityTools.ConvertToEntityList<EntityCodeRole>(dt));
            }
            #endregion
            isInit = true;
            LoadList();
            InitLue();
            SetEditValueChangedEvent(Viewer.plMain);
            CreateTreeDept();
            LoadDataSourceDept();
            isInit = false;
        }
        #endregion

        #region dept

        #region CreateTree
        /// <summary>
        /// CreateTree
        /// </summary>
        void CreateTreeDept()
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

            Viewer.tvDept.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(tvDept_FocusedNodeChanged);

        }
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
                FilterDept(((EntityCodeDepartment)Viewer.tvDept.GetDataRecordByNode(e.Node)).deptCode);
            }
            finally
            {
                isTreeDoing = false;
            }
        }
        #endregion

        #region LoadDataSourceDept
        /// <summary>
        /// LoadDataSourceDept
        /// </summary>
        void LoadDataSourceDept()
        {
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                this.isInit = true;
                DataSourceDept = proxy.Service.LoadDeptInfo();
                Viewer.tvDept.BeginUpdate();
                Viewer.tvDept.DataSource = DataSourceDept;
                Viewer.tvDept.ExpandAll();
                Viewer.tvDept.EndUpdate();
                this.isInit = false;
            }
        }
        #endregion

        #region FilterDept
        /// <summary>
        /// FilterDept
        /// </summary>
        /// <param name="deptCode"></param>
        void FilterDept(string deptCode)
        {
            if (DataSourceEmpList != null)
            {
                if (string.IsNullOrEmpty(deptCode))
                    Viewer.gcEmployee.DataSource = DataSourceEmpList;
                else
                {
                    Viewer.colDeptName.Visible = false;
                    Viewer.gcEmployee.DataSource = DataSourceEmpList.FindAll(t => t.deptCode == deptCode);
                }
            }
        }
        #endregion

        #endregion

        #region InitLue
        /// <summary>
        /// InitLue
        /// </summary>
        void InitLue()
        {
            // lueDuty
            Viewer.lueDuty.Properties.PopupWidth = 130;
            Viewer.lueDuty.Properties.PopupHeight = 200;
            Viewer.lueDuty.Properties.ValueColumn = EntityCodeDuty.Columns.dutyCode;
            Viewer.lueDuty.Properties.DisplayColumn = EntityCodeDuty.Columns.dutyName;
            Viewer.lueDuty.Properties.Essential = false;
            Viewer.lueDuty.Properties.IsShowColumnHeaders = true;
            Viewer.lueDuty.Properties.ColumnWidth.Add(EntityCodeDuty.Columns.dutyCode, 45);
            Viewer.lueDuty.Properties.ColumnWidth.Add(EntityCodeDuty.Columns.dutyName, 85);
            Viewer.lueDuty.Properties.ColumnHeaders.Add(EntityCodeDuty.Columns.dutyCode, "编码");
            Viewer.lueDuty.Properties.ColumnHeaders.Add(EntityCodeDuty.Columns.dutyName, "名称");
            Viewer.lueDuty.Properties.ShowColumn = EntityCodeDuty.Columns.dutyCode + "|" + EntityCodeDuty.Columns.dutyName;
            Viewer.lueDuty.Properties.IsUseShowColumn = true;
            //Viewer.lueDuty.Properties.FilterColumn = EntityCodeDuty.Columns.dutyCode + "|" + EntityCodeDuty.Columns.dutyName;
            if (DataSourceDuty != null && DataSourceDuty.Count > 0) Viewer.lueDuty.Properties.DataSource = DataSourceDuty.ToArray();
            Viewer.lueDuty.Properties.SetSize();

            // lueRank
            Viewer.lueRank.Properties.PopupWidth = 160;
            Viewer.lueRank.Properties.PopupHeight = 200;
            Viewer.lueRank.Properties.ValueColumn = EntityCodeRank.Columns.rankCode;
            Viewer.lueRank.Properties.DisplayColumn = EntityCodeRank.Columns.rankName;
            Viewer.lueRank.Properties.Essential = false;
            Viewer.lueRank.Properties.IsShowColumnHeaders = true;
            Viewer.lueRank.Properties.ColumnWidth.Add(EntityCodeRank.Columns.rankCode, 50);
            Viewer.lueRank.Properties.ColumnWidth.Add(EntityCodeRank.Columns.rankName, 110);
            Viewer.lueRank.Properties.ColumnHeaders.Add(EntityCodeRank.Columns.rankCode, "编码");
            Viewer.lueRank.Properties.ColumnHeaders.Add(EntityCodeRank.Columns.rankName, "名称");
            Viewer.lueRank.Properties.ShowColumn = EntityCodeRank.Columns.rankCode + "|" + EntityCodeRank.Columns.rankName;
            Viewer.lueRank.Properties.IsUseShowColumn = true;
            //Viewer.lueRank.Properties.FilterColumn = EntityCodeRank.Columns.rankCode + "|" + EntityCodeRank.Columns.rankName;
            if (GlobalDic.DataSourceRank != null && GlobalDic.DataSourceRank.Count > 0) Viewer.lueRank.Properties.DataSource = GlobalDic.DataSourceRank.ToArray();
            Viewer.lueRank.Properties.SetSize();

            // lueType
            Viewer.lueType.Properties.PopupWidth = 130;
            Viewer.lueType.Properties.PopupHeight = 180;
            Viewer.lueType.Properties.ValueColumn = EntityCodeOperatorClass.Columns.clsCode;
            Viewer.lueType.Properties.DisplayColumn = EntityCodeOperatorClass.Columns.clsName;
            Viewer.lueType.Properties.Essential = false;
            Viewer.lueType.Properties.IsShowColumnHeaders = true;
            Viewer.lueType.Properties.ColumnWidth.Add(EntityCodeOperatorClass.Columns.clsCode, 45);
            Viewer.lueType.Properties.ColumnWidth.Add(EntityCodeOperatorClass.Columns.clsName, 85);
            Viewer.lueType.Properties.ColumnHeaders.Add(EntityCodeOperatorClass.Columns.clsCode, "编码");
            Viewer.lueType.Properties.ColumnHeaders.Add(EntityCodeOperatorClass.Columns.clsName, "名称");
            Viewer.lueType.Properties.ShowColumn = EntityCodeOperatorClass.Columns.clsCode + "|" + EntityCodeOperatorClass.Columns.clsName;
            Viewer.lueType.Properties.IsUseShowColumn = true;
            //Viewer.lueRank.Properties.FilterColumn = EntityCodeRank.Columns.rankCode + "|" + EntityCodeRank.Columns.rankName;
            if (DataSourceClass != null && DataSourceClass.Count > 0) Viewer.lueType.Properties.DataSource = DataSourceClass.ToArray();
            Viewer.lueType.Properties.SetSize();
        }
        #endregion

        #region LoadList
        /// <summary>
        /// LoadList
        /// </summary>
        void LoadList()
        {
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                DataSourceEmpList = proxy.Service.LoadEmpInfo();
                DataSourceEmpList.Sort();
                Viewer.gcEmployee.DataSource = DataSourceEmpList;
            }
        }
        #endregion

        #region SetMainInfo
        /// <summary>
        /// SetMainInfo
        /// </summary>
        /// <param name="mainVo"></param>
        /// <param name="plusVo"></param>
        void SetMainInfo(EntityCodeOperator mainVo, EntityPlusOperator plusVo)
        {
            if (mainVo == null)
            {
                Viewer.txtEmpNo.Tag = null;
                Viewer.txtEmpNo.Text = string.Empty;
                Viewer.txtEmpName.Text = string.Empty;
                Viewer.cboSex.Text = string.Empty;
                Viewer.dtmBirth.Text = string.Empty;
                Viewer.lueDuty.Text = string.Empty;
                Viewer.lueRank.Text = string.Empty;
                Viewer.txtPwd.Text = string.Empty;
                Viewer.lueType.Text = string.Empty;
                Viewer.lueTeacher.Text = string.Empty;
                Viewer.txtCakey.Text = string.Empty;
                Viewer.txtContactTel.Text = string.Empty;
                Viewer.txtContactAddr.Text = string.Empty;
                //Viewer.cboStatus.Text = string.Empty;
                Viewer.cboStatus.SelectedIndex = 2;
            }
            else
            {
                Viewer.txtEmpNo.Tag = mainVo;
                Viewer.txtEmpNo.Text = mainVo.operCode;
                Viewer.txtEmpName.Text = mainVo.operName;
                Viewer.cboSex.Text = string.Empty;
                if (string.IsNullOrEmpty(plusVo.birth))
                    Viewer.dtmBirth.EditValue = null;
                else
                    Viewer.dtmBirth.EditValue = Function.Datetime(plusVo.birth);
                Viewer.lueDuty.Properties.DBValue = plusVo.dutyCode;
                SetLueDuty(plusVo.dutyCode);
                Viewer.lueRank.Properties.DBValue = plusVo.rankCode;
                SetLueRank(plusVo.rankCode);
                Viewer.txtPwd.Text = mainVo.pwd;
                Viewer.lueType.Properties.DBValue = plusVo.clsCode;
                SetLueClass(plusVo.clsCode);
                Viewer.lueTeacher.Text = string.Empty;
                Viewer.txtCakey.Text = mainVo.ukey;
                Viewer.txtContactTel.Text = plusVo.tel;
                Viewer.txtContactAddr.Text = plusVo.addr;
                if (mainVo.disable == "F")
                    Viewer.cboStatus.SelectedIndex = 1;
                else if (mainVo.disable == "T")
                    Viewer.cboStatus.SelectedIndex = 2;
                else
                    Viewer.cboStatus.SelectedIndex = 0;
                Viewer.cboSex.SelectedIndex = Function.Int(plusVo.sex);
            }
            Viewer.ValueChanged = false;
        }

        #region SetLueDuty
        /// <summary>
        /// SetLueDuty
        /// </summary>
        /// <param name="dutyCode"></param>
        void SetLueDuty(string dutyCode)
        {
            if (string.IsNullOrEmpty(dutyCode)) return;
            Viewer.lueDuty.Properties.ForbidPoput = true;
            if (DataSourceDuty != null && DataSourceDuty.Count > 0)
            {
                if (DataSourceDuty.Any(t => t.dutyCode.Trim() == dutyCode.Trim()))
                    Viewer.lueDuty.Text = (DataSourceDuty.FirstOrDefault(t => t.dutyCode.Trim() == dutyCode.Trim())).dutyName;
                else
                    Viewer.lueDuty.Text = string.Empty;
            }
            Viewer.lueDuty.Properties.DisplayValue = Viewer.lueDuty.Text;
            Viewer.lueDuty.Properties.ForbidPoput = false;
        }
        #endregion

        #region SetLueRank
        /// <summary>
        /// SetLueRank
        /// </summary>
        /// <param name="rankCode"></param>
        void SetLueRank(string rankCode)
        {
            if (string.IsNullOrEmpty(rankCode)) return;
            Viewer.lueRank.Properties.ForbidPoput = true;
            if (GlobalDic.DataSourceRank != null && GlobalDic.DataSourceRank.Count > 0)
            {
                if (GlobalDic.DataSourceRank.Any(t => t.rankCode.Trim() == rankCode.Trim()))
                    Viewer.lueRank.Text = (GlobalDic.DataSourceRank.FirstOrDefault(t => t.rankCode.Trim() == rankCode.Trim())).rankName;
                else
                    Viewer.lueRank.Text = string.Empty;
            }
            Viewer.lueRank.Properties.DisplayValue = Viewer.lueDuty.Text;
            Viewer.lueRank.Properties.ForbidPoput = false;
        }
        #endregion

        #region SetLueClass
        /// <summary>
        /// SetLueClass
        /// </summary>
        /// <param name="clsCode"></param>
        void SetLueClass(string clsCode)
        {
            if (string.IsNullOrEmpty(clsCode)) return;
            Viewer.lueType.Properties.ForbidPoput = true;
            if (DataSourceClass != null && DataSourceClass.Count > 0)
            {
                if (DataSourceClass.Any(t => t.clsCode.Trim() == clsCode.Trim()))
                    Viewer.lueType.Text = (DataSourceClass.FirstOrDefault(t => t.clsCode.Trim() == clsCode.Trim())).clsName;
                else
                    Viewer.lueType.Text = string.Empty;
            }
            Viewer.lueType.Properties.DisplayValue = Viewer.lueType.Text;
            Viewer.lueType.Properties.ForbidPoput = false;
        }
        #endregion

        #endregion

        #region LoadPlus
        /// <summary>
        /// LoadPlus
        /// </summary>
        /// <param name="rowHandle"></param>
        internal void LoadPlus(int rowHandle)
        {
            if (IsLoading) return;
            IsLoading = true;
            try
            {
                string operCode = GetFieldValueStr(Viewer.gvEmployee, rowHandle, EntityOperatorDisp.Columns.operCode);
                if (string.IsNullOrEmpty(operCode)) return;

                EntityCodeOperator mainVo = null;
                EntityPlusOperator plusVo = null;
                using (ProxyDictionary proxy = new ProxyDictionary())
                {
                    proxy.Service.LoadCodeOperatorAndPlus(operCode, out mainVo, out plusVo);
                }
                LoadOperDept(operCode, plusVo.deptCode);
                LoadOperRole(operCode);
                SetMainInfo(mainVo, plusVo);
            }
            finally
            {
                IsLoading = false;
            }
        }
        #endregion

        #region LoadOperDept
        /// <summary>
        /// LoadOperDept
        /// </summary>
        /// <param name="operCode"></param>
        /// <param name="deptCode"></param>
        void LoadOperDept(string operCode, string deptCode)
        {
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                DataSourceOperDept = proxy.Service.LoadOperatorDept(operCode);
            }
            if (DataSourceOperDept != null && DataSourceOperDept.Count > 0)
            {
                foreach (EntityDefDeptemployee item in DataSourceOperDept)
                {
                    if (GlobalDic.DataSourceDepartment.Any(t => t.deptCode.Trim() == item.deptCode.Trim()))
                    {
                        item.deptName = GlobalDic.DataSourceDepartment.FirstOrDefault(t => t.deptCode.Trim() == item.deptCode.Trim()).deptName;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(deptCode))
                {
                    DataSourceOperDept = new List<EntityDefDeptemployee>();
                    EntityDefDeptemployee vo1 = new EntityDefDeptemployee();
                    vo1.deptCode = deptCode;
                    if (GlobalDic.DataSourceDepartment.Any(t => t.deptCode == deptCode))
                        vo1.deptName = GlobalDic.DataSourceDepartment.FirstOrDefault(t => t.deptCode == deptCode).deptName;
                    DataSourceOperDept.Add(vo1);
                }
            }
            Viewer.gcDept.DataSource = DataSourceOperDept;
        }
        #endregion

        #region LoadOperRole
        /// <summary>
        /// LoadOperRole
        /// </summary>
        /// <param name="operCode"></param>
        void LoadOperRole(string operCode)
        {
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                DataSourceOperRole = proxy.Service.LoadOperatorRole(operCode);
            }
            foreach (EntityDefOperatorRole item in DataSourceOperRole)
            {
                if (DataSourceRole.Any(t => t.roleCode == item.roleCode))
                {
                    item.roleName = DataSourceRole.FirstOrDefault(t => t.roleCode == item.roleCode).roleName;
                }
            }
            Viewer.gcRole.DataSource = DataSourceOperRole;
        }
        #endregion

        #region GetOperOrig
        /// <summary>
        /// GetOperOrig
        /// </summary>
        /// <returns></returns>
        EntityCodeOperator GetOperOrig()
        {
            if (Viewer.txtEmpNo.Tag == null)
                return null;
            else
                return Viewer.txtEmpNo.Tag as EntityCodeOperator;
        }

        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        internal void New()
        {
            SetMainInfo(null, null);
            Viewer.gcDept.DataSource = null;
            Viewer.gcRole.DataSource = null;
        }
        #endregion

        #region NewOperDept
        /// <summary>
        /// NewOperDept
        /// </summary>
        internal void NewOperDept()
        {
            EntityCodeOperator vo = GetOperOrig();
            if (vo == null)
            {
                DialogBox.Msg("请先保存职工主信息。");
                return;
            }
            frmNew frm = new frmNew(EntityTools.ConvertToDataTable<EntityCodeDepartment>(GlobalDic.DataSourceDepartment), "deptCode", "deptCode", "deptName");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.lstNo.Count > 0)
                {
                    bool isDefault = false;
                    foreach (int index in frm.lstNo)
                    {
                        EntityDefDeptemployee vo1 = new EntityDefDeptemployee();
                        vo1.operCode = vo.operCode;
                        vo1.deptCode = GlobalDic.DataSourceDepartment[index].deptCode;
                        if (Viewer.gvDept.RowCount == 0 && isDefault == false)
                        {
                            vo1.defaultFlag = 1;
                            isDefault = true;
                        }
                        else
                        {
                            vo1.defaultFlag = 0;
                        }
                        using (ProxyDictionary proxy = new ProxyDictionary())
                        {
                            if (proxy.Service.SaveOperatorDept(vo1) < 0)
                            {
                                DialogBox.Msg("保存职工所属科室失败。");
                                return;
                            }
                        }
                    }
                    LoadOperDept(vo.operCode, string.Empty);
                }
            }
        }
        #endregion

        #region DelOperDept
        /// <summary>
        /// DelOperDept
        /// </summary>
        internal void DelOperDept()
        {
            if (Viewer.gvDept.FocusedRowHandle < 0) return;
            if (DialogBox.Msg("是否删除？", MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EntityDefDeptemployee vo = DataSourceOperDept[Viewer.gvDept.FocusedRowHandle];
                if (vo != null)
                {
                    using (ProxyDictionary proxy = new ProxyDictionary())
                    {
                        if (proxy.Service.DelOperatorDept(vo) > 0)
                        {
                            LoadOperDept(vo.operCode, string.Empty);
                            DialogBox.Msg("删除成功!");
                        }
                        else
                        {
                            DialogBox.Msg("删除失败。");
                        }
                    }
                }
            }
        }
        #endregion

        #region 设默认科室
        /// <summary>
        /// 设默认科室
        /// </summary>
        internal void SetDefaultDept()
        {
            EntityCodeOperator vo = GetOperOrig();
            if (vo == null)
            {
                DialogBox.Msg("请先保存职工主信息。");
                return;
            }
            if (Viewer.gvDept.RowCount <= 0 || Viewer.gvDept.FocusedRowHandle < 0) return;
            int rowHandle = Viewer.gvDept.FocusedRowHandle;
            EntityDefDeptemployee defVo = new EntityDefDeptemployee();
            defVo.operCode = vo.operCode;
            defVo.deptCode = GetFieldValueStr(Viewer.gvDept, rowHandle, EntityDefDeptemployee.Columns.deptCode);
            defVo.defaultFlag = 1;
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                if (proxy.Service.UpdateOperatorDeptDefault(defVo) < 0)
                {
                    DialogBox.Msg("设置职工默认科室失败。");
                    return;
                }
                else
                {
                    List<EntityDefDeptemployee> data = Viewer.gcDept.DataSource as List<EntityDefDeptemployee>;
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (i == rowHandle)
                            data[i].defaultFlag = 1;
                        else
                            data[i].defaultFlag = 0;
                    }
                    Viewer.gvDept.RefreshData();
                    Viewer.gvDept.Invalidate();
                    DialogBox.Msg("设置职工默认科室成功！");
                }
            }
        }
        #endregion

        #region RowCellStyleEmp
        /// <summary>
        /// RowCellStyleEmp
        /// </summary>
        /// <param name="e"></param>
        internal void RowCellStyleEmp(DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column == Viewer.gvEmployee.FocusedColumn && e.RowHandle == Viewer.gvEmployee.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(251, 165, 8);
                e.Appearance.BackColor2 = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.Transparent;
                e.Appearance.BackColor2 = Color.Transparent;
            }
            Viewer.gvEmployee.Invalidate();
        }
        #endregion

        #region RowCellStyleDept
        /// <summary>
        /// RowCellStyleDept
        /// </summary>
        /// <param name="e"></param>
        internal void RowCellStyleDept(DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (GetFieldValueStr(Viewer.gvDept, e.RowHandle, EntityDefDeptemployee.Columns.defaultFlag) == "1")
            {
                e.Appearance.ForeColor = System.Drawing.Color.Blue;
            }
            Viewer.gvDept.Invalidate();
        }
        #endregion

        #region NewOperRole
        /// <summary>
        /// NewOperRole
        /// </summary>
        internal void NewOperRole()
        {
            EntityCodeOperator vo = GetOperOrig();
            if (vo == null)
            {
                DialogBox.Msg("请先保存职工主信息。");
                return;
            }
            frmNew frm = new frmNew(EntityTools.ConvertToDataTable<EntityCodeRole>(DataSourceRole), "roleCode", "roleCode", "roleName");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.lstNo.Count > 0)
                {
                    foreach (int index in frm.lstNo)
                    {
                        EntityDefOperatorRole vo1 = new EntityDefOperatorRole();
                        vo1.operCode = vo.operCode;
                        vo1.roleCode = DataSourceRole[index].roleCode;
                        using (ProxyDictionary proxy = new ProxyDictionary())
                        {
                            if (proxy.Service.SaveOperatorRole(vo1) < 0)
                            {
                                DialogBox.Msg("保存职工所属角色失败。");
                                return;
                            }
                        }
                    }
                    LoadOperRole(vo.operCode);
                }
            }
        }
        #endregion

        #region DelOperRole
        /// <summary>
        /// DelOperRole
        /// </summary>
        internal void DelOperRole()
        {
            if (Viewer.gvRole.FocusedRowHandle < 0) return;
            if (DialogBox.Msg("是否删除？", MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EntityDefOperatorRole vo = DataSourceOperRole[Viewer.gvRole.FocusedRowHandle];
                if (vo != null)
                {
                    using (ProxyDictionary proxy = new ProxyDictionary())
                    {
                        if (proxy.Service.DelOperatorRole(vo) > 0)
                        {
                            LoadOperRole(vo.operCode);
                            DialogBox.Msg("删除成功!");
                        }
                        else
                        {
                            DialogBox.Msg("删除失败。");
                        }
                    }
                }
            }
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        /// <param name="isExit"></param>
        internal void Save(bool isExit)
        {
            // 1.main
            EntityCodeOperator mainVo = new EntityCodeOperator();
            mainVo.operCode = Viewer.txtEmpNo.Text.Trim();
            mainVo.operName = Viewer.txtEmpName.Text.Trim();
            mainVo.pwd = Viewer.txtPwd.Text;
            if (mainVo.pwd != string.Empty)
            {
                if (1 != 1)
                {
                    mainVo.pwd = (new clsSymmetricAlgorithm()).Encrypt(mainVo.pwd, clsSymmetricAlgorithm.enmSymmetricAlgorithmType.DES);
                }
            }
            if (Viewer.cboStatus.SelectedIndex == 2)
                mainVo.disable = "T";
            else if (Viewer.cboStatus.SelectedIndex == 1)
                mainVo.disable = "F";
            else
                mainVo.disable = "F";
            mainVo.ukey = Viewer.txtCakey.Text.Trim();
            mainVo.innerFlag = "T";

            EntityPlusOperator plusVo = new EntityPlusOperator();
            plusVo.operCode = mainVo.operCode;
            plusVo.pyCode = SpellCodeHelper.GetPyCode(mainVo.operName);
            plusVo.wbCode = SpellCodeHelper.GetWbCode(mainVo.operName);
            plusVo.clsCode = Viewer.lueType.Properties.DBValue;
            plusVo.dutyCode = Viewer.lueDuty.Properties.DBValue;
            plusVo.rankCode = Viewer.lueRank.Properties.DBValue;
            if (!string.IsNullOrEmpty(plusVo.clsCode)) plusVo.clsCode = plusVo.clsCode.Trim();
            if (!string.IsNullOrEmpty(plusVo.dutyCode)) plusVo.dutyCode = plusVo.dutyCode.Trim();
            if (!string.IsNullOrEmpty(plusVo.rankCode)) plusVo.rankCode = plusVo.rankCode.Trim();
            if (Viewer.gvDept.RowCount > 0)
                plusVo.deptCode = GetFieldValueStr(Viewer.gvDept, 0, EntityDefDeptemployee.Columns.deptCode);
            else
                plusVo.deptCode = "&";
            plusVo.birth = Viewer.dtmBirth.Text;
            plusVo.tel = Viewer.txtContactTel.Text.Trim();
            plusVo.addr = Viewer.txtContactAddr.Text.Trim();
            plusVo.sex = Viewer.cboSex.SelectedIndex.ToString();

            #region 校验

            if (string.IsNullOrEmpty(mainVo.operCode))
            {
                DialogBox.Msg("请输入职工编码。");
                Viewer.txtEmpNo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(mainVo.operName))
            {
                DialogBox.Msg("请输入职工名称");
                Viewer.txtEmpName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(plusVo.rankCode))
            {
                DialogBox.Msg("请选择职工职称");
                Viewer.lueRank.Focus();
                return;
            }

            if (string.IsNullOrEmpty(plusVo.clsCode))
            {
                DialogBox.Msg("请选择职工类型");
                Viewer.lueType.Focus();
                return;
            }
            #endregion

            // 1.main
            EntityCodeOperator operOrig = new EntityCodeOperator();
            if (Viewer.txtEmpNo.Tag != null)
            {
                operOrig = Viewer.txtEmpNo.Tag as EntityCodeOperator;
            }

            ProxyDictionary proxy = new ProxyDictionary();
            int ret = proxy.Service.SaveOperator(mainVo, plusVo, operOrig);
            proxy = null;
            if (ret > 0)
            {
                Viewer.ValueChanged = false;
                // 刷新树 
                if (!isExit)
                {
                    Viewer.txtEmpNo.Tag = mainVo;
                    Refresh();
                    FindDept(plusVo.deptCode);
                    for (int i = 0; i < Viewer.gvEmployee.RowCount; i++)
                    {
                        if (GetFieldValueStr(Viewer.gvEmployee, i, EntityOperatorDisp.Columns.operCode) == mainVo.operCode)
                        {
                            Viewer.gvEmployee.FocusedRowHandle = i;
                            break;
                        }
                    }
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
            EntityCodeOperator vo = GetOperOrig();
            if (vo == null)
            {
                DialogBox.Msg("请先选择需要删除的职工。");
                return;
            }
            if (vo.operCode == "00")
            {
                DialogBox.Msg("系统管理员默认账号不能删除。");
                return;
            }
            if (DialogBox.Msg("是否删除当前职工记录？", MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ProxyDictionary proxy = new ProxyDictionary())
                {
                    if (proxy.Service.DelOperator(vo.operCode) > 0)
                    {
                        Viewer.ValueChanged = false;
                        New();
                        LoadList();
                        DialogBox.Msg("删除成功!");
                    }
                    else
                    {
                        DialogBox.Msg("删除失败。");
                    }
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
            LoadList();
        }
        #endregion

        #region FindEmp
        /// <summary>
        /// FindEmp
        /// </summary>
        /// <param name="val"></param>
        internal void FindEmp(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                DialogBox.Msg("请输入快速查找条件。");
                Viewer.txtFind.Focus();
                return;
            }

            if (DataSourceEmpList != null)
            {
                Viewer.colDeptName.Visible = true;
                Viewer.gcEmployee.DataSource = DataSourceEmpList;
                int index = DataSourceEmpList.FindIndex(t => t.operCode == val || t.operName.StartsWith(val) || t.pyCode.StartsWith(val) || t.wbCode.StartsWith(val));
                if (index >= 0)
                {
                    Viewer.gvEmployee.FocusedRowHandle = index;
                }
            }
        }
        #endregion

        #region 查找表单
        /// <summary>
        /// 查找表单
        /// </summary>
        /// <param name="val"></param>
        internal void FindDept(string deptCode)
        {
            if (string.IsNullOrEmpty(deptCode)) return;
            EntityCodeDepartment deptVo = null;
            for (int i = 0; i < Viewer.tvDept.AllNodesCount; i++)
            {
                deptVo = (EntityCodeDepartment)Viewer.tvDept.GetDataRecordByNode(Viewer.tvDept.GetNodeByVisibleIndex(i));
                if (deptVo.deptCode == deptCode)
                {
                    Viewer.tvDept.SetFocusedNode(Viewer.tvDept.GetNodeByVisibleIndex(i));
                    FilterDept(deptCode);
                    break;
                }
            }
        }
        #endregion

        #endregion
    }
}
