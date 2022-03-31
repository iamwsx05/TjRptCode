using Common.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frmPopup206040101 : frmBasePopup
    {
        public frmPopup206040101(List<EntityDicDientIngredient> _lstDicDientIngredientTemp = null)
        {
            InitializeComponent();
            lstDicDientIngredientTemp = _lstDicDientIngredientTemp;
        }

        #region var/propery

        List<EntityDicDientIngredient> lstDicDientIngredient { get; set; }
        public List<EntityDicDientIngredient> lstDicDientIngredientTemp { get; set; }
        List<EntityDicIngredientClassify> lstClassify { get; set; }

        #endregion

        #region methods
        internal void Init()
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                cboClassify.Properties.Items.Add("请选择...");
                lstDicDientIngredient = proxy.Service.GetDicDietIngredient();
                gcData.DataSource = lstDicDientIngredient;
                lstClassify = proxy.Service.GetIngredientClassify();

                if(lstClassify != null && lstClassify.Count > 0)
                {
                    foreach(var str in lstClassify)
                    {
                        cboClassify.Properties.Items.Add(str.classifyName);
                    }
                }
            }

            if(lstDicDientIngredientTemp != null)
            {
                foreach(var vo in lstDicDientIngredientTemp)
                {
                    int i = gvData.FindRow(lstDicDientIngredient.FindAll(r=>r.id == vo.id).FirstOrDefault());
                    gvData.SelectRow(i);
                }
            }
        }
        #endregion

        #region event
        private void frmPopup206040101_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void gvData_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                if(gvData.IsRowSelected(e.RowHandle))
                    gvData.UnselectRow(e.RowHandle);
                else
                    gvData.SelectRow(e.RowHandle);
            }    
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            List<EntityDicDientIngredient> lstTemp = new List<EntityDicDientIngredient>();
            lstTemp = lstDicDientIngredient;
            string classfyName = cboClassify.Text;
            string name = txtName.Text;
            if(!string.IsNullOrEmpty(classfyName))
            {
                int classifyId = lstClassify.FindAll(r => r.classifyName == classfyName).FirstOrDefault().classifyId;
                if (classifyId > 0)
                {
                    lstTemp = lstTemp.FindAll(r => r.lstClassify.Contains(classifyId));
                }
            }
            
            if(!string.IsNullOrEmpty(name))
            {
                lstTemp = lstTemp.FindAll(r => r.names.Contains(name) || r.otherName.Contains(name));
            }

            gcData.DataSource = lstTemp;
            gcData.RefreshDataSource();
        }

        private void cboClassify_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit cbo = sender as DevExpress.XtraEditors.ComboBoxEdit;

            if(cbo.SelectedIndex == 0)
            {
                cbo.Text = string.Empty;
            }
        }

        private void cboClassify_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit cbo = sender as DevExpress.XtraEditors.ComboBoxEdit;

            if (cbo.SelectedIndex == -1)
            {
                cbo.Text = string.Empty;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(gvData.SelectedRowsCount > 0)
            {
                lstDicDientIngredientTemp = new List<EntityDicDientIngredient>();
                int [] selectArr = this.gvData.GetSelectedRows();
                for (int i = 0; i < selectArr.Length; i++)
                {
                    lstDicDientIngredientTemp.Add((this.gvData.GetRow(selectArr[i]) as EntityDicDientIngredient));
                }
            }

            this.Close();
        }

        #endregion
    }
}
