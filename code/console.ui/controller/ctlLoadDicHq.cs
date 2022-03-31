using Common.Controls;
using Common.Entity;
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
    public class ctlLoadDicHq : BaseController
    {
        #region Override

        /// <summary>
        /// UI.Viewer
        /// </summary>
        private frmLoadDicHq Viewer = null;

        /// <summary>
        /// SetUI
        /// </summary>
        /// <param name="child"></param>
        public override void SetUI(frmBase child)
        {
            base.SetUI(child);
            Viewer = (frmLoadDicHq)child;
        }
        #endregion

        #region 变量.属性

        bool isCheck { get; set; }
        bool isImport { get; set; }
        List<int> lstType = new List<int>();

        #endregion

        #region 方法

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        internal void Init()
        {
            Viewer.marqueeProgressBarControlLoad.Visible = false;
        }
        #endregion

        #region SetChecked
        /// <summary>
        /// SetChecked
        /// </summary>
        /// <param name="type"></param>
        internal void SetChecked(int type)
        {
            if (isCheck) return;
            isCheck = true;
            if (type == 0)
            {
                Viewer.chkDept.Checked = Viewer.chkAll.Checked;
                Viewer.chkEmp.Checked = Viewer.chkAll.Checked;
            }
            else
            {
                Viewer.chkAll.Checked = false;
            }
            isCheck = false;
        }
        #endregion

        #region 同步字典(异步线程)
        /// <summary>
        /// 同步字典(异步线程)
        /// </summary>
        internal void ImportData()
        {
            Viewer.btnImport.Visible = false;
            Viewer.marqueeProgressBarControlLoad.Visible = true;
            Viewer.marqueeProgressBarControlLoad.Properties.Stopped = false;

            lstType.Clear();
            if (Viewer.chkDept.Enabled && Viewer.chkDept.Checked) lstType.Add(1);
            if (Viewer.chkEmp.Enabled && Viewer.chkEmp.Checked) lstType.Add(2);
            Viewer.marqueeProgressBarControlLoad.Text = "开始导入数据...";
            Viewer.backgroundWorker.RunWorkerAsync();
        }
        #endregion

        #region ImportData
        /// <summary>
        /// ImportData
        /// </summary>
        /// <param name="isExt"></param>
        internal void AsyncImport()
        {
            if (isImport) return;
            isImport = true;
            int ret = 0;
            string info = string.Empty;
            bool success = false;
            try
            {
                using (ProxyDictionary proxy = new ProxyDictionary())
                {
                    foreach (int typeId in lstType)
                    {
                        switch (typeId)
                        {
                            case 1:
                                info = "科室字典";
                                ret = proxy.Service.ImportDeptInfo();
                                break;
                            case 2:
                                info = "员工字典";
                                ret = proxy.Service.ImportEmpInfo();
                                break;
                            default:
                                break;
                        }
                        if (ret < 0)
                        {
                            Viewer.marqueeProgressBarControlLoad.Text = "导入" + info + "失败。";
                            Viewer.marqueeProgressBarControlLoad.Properties.Stopped = true;
                            return;
                        }
                    }
                    success = true;
                }
            }
            catch (System.Exception ex)
            {
                Viewer.marqueeProgressBarControlLoad.Text = ex.Message;
            }
            finally
            {
                isImport = false;
                if (success) Viewer.marqueeProgressBarControlLoad.Text = "数据成功导入！！";
                Viewer.btnImport.Visible = true;
            }
        }
        #endregion

        #endregion
    }
}
