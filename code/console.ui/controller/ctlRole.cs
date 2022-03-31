using Common.Controls;
using Common.Utils;
using DevExpress.XtraTreeList.Nodes;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Console.Ui
{
    public class ctlRole : BaseController
    {
        #region Override

        /// <summary>
        /// UI.Viewer
        /// </summary>
        private frmRole Viewer = null;

        /// <summary>
        /// SetUI
        /// </summary>
        /// <param name="child"></param>
        public override void SetUI(frmBase child)
        {
            base.SetUI(child);
            Viewer = (frmRole)child;
        }
        #endregion

        #region 变量.属性

        /// <summary>
        /// 数据源.诊间
        /// </summary>
        BindingSource gvDataBindingSourceRole { get; set; }

        #endregion

        #region 方法

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        internal void Init()
        {
            InitRole();
            CreateTree();
            InitFunc();
            if (Viewer.gvRole.RowCount > 0) LoadRoleOper(0);
        }
        #endregion

        #region Func

        #region CreateTree
        /// <summary>
        /// CreateTree
        /// </summary>
        void CreateTree()
        {
            // 树结构
            Viewer.tvFunction.Columns.Clear();
            uiHelper.SetGridCol(Viewer.tvFunction, new string[] { "Funcname" }, new string[] { "功能列表" }, new int[] { 300 });
            Viewer.tvFunction.Columns["Funcname"].AppearanceCell.Font = new Font("宋体", 9);
            Viewer.tvFunction.KeyFieldName = "Funcid";
            Viewer.tvFunction.ParentFieldName = "Parentid";
            Viewer.tvFunction.ImageIndexFieldName = "imageIndex";

            Viewer.tvFunction.OptionsView.ShowFocusedFrame = false;
            Viewer.tvFunction.OptionsView.ShowCheckBoxes = true;
            Viewer.tvFunction.Appearance.FocusedRow.Options.UseBackColor = true;
            Viewer.tvFunction.Appearance.FocusedRow.BackColor = Color.LightGreen;    // Color.LightSkyBlue;
            Viewer.tvFunction.Appearance.FocusedRow.BackColor2 = Color.White;
            Viewer.tvFunction.Appearance.HideSelectionRow.Options.UseBackColor = true;
            Viewer.tvFunction.Appearance.HideSelectionRow.BackColor = Color.LightGreen;  // Color.LightSkyBlue;
            Viewer.tvFunction.Appearance.HideSelectionRow.BackColor2 = Color.White;

            //Viewer.tvDept.MouseClick += new MouseEventHandler(tvDept_MouseClick);
            //Viewer.tvDept.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(tvDept_FocusedNodeChanged);

        }
        #endregion

        #region InitFunc
        /// <summary>
        /// InitFunc
        /// </summary>
        void InitFunc()
        {
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                DataTable dt = proxy.Service.SelectFullTable(new EntityFunction());
                List<EntityFunction> dataFunc = EntityTools.ConvertToEntityList<EntityFunction>(dt);
                dataFunc.Sort();
                Viewer.tvFunction.BeginUpdate();
                Viewer.tvFunction.DataSource = dataFunc;
                Viewer.tvFunction.ExpandAll();
                Viewer.tvFunction.EndUpdate();

            }
        }
        #endregion

        #region CheckNode
        /// <summary>
        /// CheckNode
        /// </summary>
        /// <param name="node"></param>
        internal void CheckNode(TreeListNode node)
        {
            EntityFunction vo = Viewer.tvFunction.GetDataRecordByNode(node) as EntityFunction;
            vo.imageIndex = (node.CheckState == CheckState.Checked ? 1 : 0);
            if (Viewer.gvRole.FocusedRowHandle >= 0)
            {
                if (Function.Int(GetFieldValueStr(Viewer.gvRole, Viewer.gvRole.FocusedRowHandle, EntityCodeRole.Columns.isEdit)) > 0)
                {
                    EntityRoleFunction voFunc = new weCare.Core.Entity.EntityRoleFunction();
                    voFunc.Rolecode = GetFieldValueStr(Viewer.gvRole, Viewer.gvRole.FocusedRowHandle, EntityCodeRole.Columns.roleCode);
                    voFunc.Funcid = vo.Funcid;
                    using (ProxyDictionary proxy = new ProxyDictionary())
                    {
                        int ret = proxy.Service.SaveRoleFunc(voFunc, vo.imageIndex);
                        if (ret < 0)
                        {
                            DialogBox.Msg("权限分配失败。");
                        }
                    }
                }
            }
            Viewer.tvFunction.RefreshNode(node);
        }
        #endregion

        #region InitRoleFunc
        /// <summary>
        /// InitRoleFunc
        /// </summary>
        /// <param name="roleCode"></param>
        internal void InitRoleFunc(string roleCode)
        {
            List<EntityRoleFunction> data = null;
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                data = proxy.Service.LoadRoleFunc(roleCode);
            }
            SetCheckState(Viewer.tvFunction.Nodes, data);
        }

        /// <summary>
        /// SetCheckState
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="lstFunc"></param>
        void SetCheckState(TreeListNodes nodes, List<EntityRoleFunction> lstFunc)
        {
            EntityFunction vo = null;
            foreach (TreeListNode node in nodes)
            {
                vo = Viewer.tvFunction.GetDataRecordByNode(node) as EntityFunction;
                if (lstFunc.Exists(t => t.Funcid == vo.Funcid))
                {
                    node.CheckState = CheckState.Checked;
                    vo.imageIndex = 1;
                }
                else
                {
                    node.CheckState = CheckState.Unchecked;
                    vo.imageIndex = 0;
                }
                if (node.HasChildren)
                {
                    SetCheckState(node.Nodes, lstFunc);
                }
            }
        }
        #endregion

        #endregion

        #region Role

        #region InitRole
        /// <summary>
        /// InitRole
        /// </summary>
        void InitRole()
        {
            this.gvDataBindingSourceRole = new BindingSource();
            Viewer.gcRole.DataSource = this.gvDataBindingSourceRole;
            Refresh();
        }
        #endregion

        #region Refresh
        /// <summary>
        /// Refresh
        /// </summary>
        internal void Refresh()
        {
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                DataTable dt = proxy.Service.SelectFullTable(new EntityCodeRole());
                List<EntityCodeRole> data = EntityTools.ConvertToEntityList<EntityCodeRole>(dt);
                foreach (EntityCodeRole item in data)
                {
                    item.isEdit = 1;    // 不能编辑
                }
                this.gvDataBindingSourceRole.DataSource = data;
            }
            LoadRoleOper(Viewer.gvRole.FocusedRowHandle);
        }
        #endregion

        #region NewRowRole
        /// <summary>
        /// NewRowRole
        /// </summary>
        internal void NewRowRole()
        {
            AppendRow(this.gvDataBindingSourceRole);
        }
        #endregion

        #region DelRowRole
        /// <summary>
        /// DelRowRole
        /// </summary>
        internal void DelRowRole()
        {
            if (Function.Int(GetFieldValueStr(Viewer.gvRole, Viewer.gvRole.FocusedRowHandle, EntityCodeRole.Columns.isEdit)) > 0)
            {
                DialogBox.Msg("已保存的角色，请用工具栏的删除功能。");
                return;
            }
            DeleteRow(Viewer.gvRole, this.gvDataBindingSourceRole, Viewer.gvRole.FocusedRowHandle);
        }
        #endregion

        #region CellValueChanged
        /// <summary>
        /// CellValueChanged
        /// </summary>
        /// <param name="rowHandle"></param>
        internal void CellValueChanged(int rowHandle)
        {
            if (Function.Int(GetFieldValueStr(Viewer.gvRole, rowHandle, EntityCodeRole.Columns.isEdit)) == 1)
            {
                Viewer.gvRole.SetRowCellValue(rowHandle, EntityCodeRole.Columns.isEdit, 2);
            }
        }
        #endregion

        #region LoadRoleOper
        /// <summary>
        /// LoadRoleOper
        /// </summary>
        /// <param name="rowHandle"></param>
        internal void LoadRoleOper(int rowHandle)
        {
            if (rowHandle < 0) return;
            Viewer.gvRole.Columns[EntityCodeRole.Columns.roleCode].OptionsColumn.AllowEdit = true;
            Viewer.gvRole.Columns[EntityCodeRole.Columns.roleCode].OptionsColumn.AllowFocus = true;
            string roleCode = GetFieldValueStr(Viewer.gvRole, rowHandle, "roleCode");
            if (string.IsNullOrEmpty(roleCode)) return;
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                Viewer.gcEmployee.DataSource = proxy.Service.LoadRoleOper(roleCode);
            }
            if (Function.Int(Viewer.gvRole.GetRowCellValue(rowHandle, EntityCodeRole.Columns.isEdit)) > 0)
            {
                Viewer.gvRole.Columns[EntityCodeRole.Columns.roleCode].OptionsColumn.AllowEdit = false;
                Viewer.gvRole.Columns[EntityCodeRole.Columns.roleCode].OptionsColumn.AllowFocus = false;
            }
            InitRoleFunc(roleCode);
        }
        #endregion

        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        internal void Save()
        {
            Viewer.gvRole.CloseEditor();
            if (Viewer.gvRole.RowCount == 0) return;
            List<EntityCodeRole> lstRoleUpdate = new List<weCare.Core.Entity.EntityCodeRole>();
            List<EntityCodeRole> lstRoleNew = new List<weCare.Core.Entity.EntityCodeRole>();
            List<EntityCodeRole> lstRoleAll = new List<weCare.Core.Entity.EntityCodeRole>();

            int status = 0;
            EntityCodeRole vo = null;
            for (int i = 0; i < Viewer.gvRole.RowCount; i++)
            {
                vo = new EntityCodeRole();
                vo.roleCode = GetFieldValueStr(Viewer.gvRole, i, EntityCodeRole.Columns.roleCode);
                vo.roleName = GetFieldValueStr(Viewer.gvRole, i, EntityCodeRole.Columns.roleName);
                vo.innerFlag = "F";

                if (lstRoleAll.Exists(t => t.roleCode == vo.roleCode))
                {
                    DialogBox.Msg("角色编码存在重复值，请检查。");
                    return;
                }
                else
                {
                    lstRoleAll.Add(vo);
                }
                status = Function.Int(GetFieldValueStr(Viewer.gvRole, i, EntityCodeRole.Columns.isEdit));
                if (status == 0)
                {
                    if (string.IsNullOrEmpty(vo.roleCode) || string.IsNullOrEmpty(vo.roleName))
                    {
                        DialogBox.Msg("请输入角色编码和名称.");
                        return;
                    }
                    lstRoleNew.Add(vo);
                }
                else if (status == 1)
                {
                    continue;
                }
                else if (status == 2)
                {
                    lstRoleUpdate.Add(vo);
                }

                if (lstRoleNew.Count == 0 && lstRoleUpdate.Count == 0)
                {
                    DialogBox.Msg("数据无改变.");
                    return;
                }

                ProxyDictionary proxy = new ProxyDictionary();
                int ret = proxy.Service.SaveRole(lstRoleUpdate, lstRoleNew);
                proxy = null;
                if (ret > 0)
                {
                    Refresh();
                    DialogBox.Msg("角色保存成功！");
                }
                else
                {
                    DialogBox.Msg("角色保存失败。");
                }
            }
        }
        #endregion

        #region Del
        /// <summary>
        /// Del
        /// </summary>
        internal void Del()
        {
            Viewer.gvRole.CloseEditor();
            if (Function.Int(GetFieldValueStr(Viewer.gvRole, Viewer.gvRole.FocusedRowHandle, EntityCodeRole.Columns.isEdit)) > 0)
            {
                string roleCode = GetFieldValueStr(Viewer.gvRole, Viewer.gvRole.FocusedRowHandle, EntityCodeRole.Columns.roleCode);
                if (string.IsNullOrEmpty(roleCode))
                {
                    DialogBox.Msg("角色编码为空，不能删除，请重新选择。");
                    return;
                }
                if (roleCode == "00")
                {
                    DialogBox.Msg("系统管理员角色不能删除，请重新选择。");
                    return;
                }
                if (DialogBox.Msg("确定是否删除？", MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProxyDictionary proxy = new ProxyDictionary();
                    int ret = proxy.Service.DelRole(roleCode);
                    proxy = null;
                    if (ret > 0)
                    {
                        Refresh();
                        DialogBox.Msg("删除角色成功！");
                    }
                    else
                    {
                        DialogBox.Msg("删除角色失败。");
                    }
                }
            }
            else
            {
                DialogBox.Msg("未保存的角色，请直接用删除按钮进行删除。");
            }
        }
        #endregion

        #endregion
    }
}
