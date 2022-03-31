using Common.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using weCare.Core.Entity;
using Hms.Entity;
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class frmPopup2060401 : frmBasePopup
    {
        public frmPopup2060401(EntityDicCai _cai=null)
        {
            InitializeComponent();
            cai = _cai;
        }

        #region var/propery
        public EntityDicCai cai = null;
        public List<EntityDicDientIngredient> lstDicDientIngredient { get; set; }
        public List<EntityDicDientIngredient> lstCaiDientIngredient { get; set; }
        public List<EntityDisplayDicCaiRecipe> lstDicCaiRecipe { get; set; }
        public List<EntityDisplayDicCaiRecipe> lstSelectCaiRecipe { get; set; }

        public bool IsRequireRefresh = false;
        #endregion

        #region methods
        /// <summary>
        /// 
        /// </summary>
        void Init()
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                lstDicDientIngredient = proxy.Service.GetDicDietIngredient();
                lstDicCaiRecipe = proxy.Service.GetDicCaiRecipe();
                gdlueCaiRecipe.Properties.DataSource = lstDicCaiRecipe;
                if (cai != null)
                {
                    txtName.Text = cai.names;
                    memMethods.Text = cai.methods;
                    if (cai.breakfast == "1")
                        chkMeals.Items[0].CheckState = CheckState.Checked;
                    if (cai.lunch == "1")
                        chkMeals.Items[1].CheckState = CheckState.Checked;
                    if (cai.dinner == "1")
                        chkMeals.Items[2].CheckState = CheckState.Checked;
                    if (cai.other == "1")
                        chkMeals.Items[3].CheckState = CheckState.Checked;

                    //菜分类
                    if(cai.lstCaiSlaveId != null)
                    {
                        string slaveName = string.Empty;
                        foreach (var strId in cai.lstCaiSlaveId)
                        {
                            slaveName += lstDicCaiRecipe.FindAll(r=>r.caiSlaveId== strId).FirstOrDefault().caiSlaveName + "、";
                        }
                        if (!string.IsNullOrEmpty(slaveName))
                            slaveName = slaveName.TrimEnd('、');
                        txtSlaveName.Text = slaveName;
                    }

                    //菜原料
                    cai.lstCaiIngredient = proxy.Service.GetCaiIngredient(cai.id);
                    if (cai.lstCaiIngredient != null && cai.lstCaiIngredient.Count > 0)
                    {
                        lstCaiDientIngredient = new List<EntityDicDientIngredient>();
                        foreach (var vo in cai.lstCaiIngredient)
                        {
                            EntityDicDientIngredient dientIngredient = lstDicDientIngredient.FindAll(r => r.ingredientId == vo.ingredietId).FirstOrDefault();
                            dientIngredient.weight = vo.weight;
                            lstCaiDientIngredient.Add(dientIngredient);
                        }
                    }

                    this.gcData.DataSource = lstCaiDientIngredient;
                    this.gcData.RefreshDataSource();
                } 
            }
        }


        #region GetRowObject
        /// <summary>
        /// GetRowObject
        /// </summary>
        /// <returns></returns>
        EntityDicDientIngredient GetRowObject()
        {
            if (this.gvData.FocusedRowHandle < 0) return null;
            return gvData.GetRow(gvData.FocusedRowHandle) as EntityDicDientIngredient;
        }
        #endregion

        #endregion

        #region event

        private void frmPopup2060401_Load(object sender, EventArgs e)
        {
            if(cai != null)
            {
                this.Text = "查看/编辑菜品";
            }

            Init();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPopup206040101 frm = new frmPopup206040101(lstCaiDientIngredient);
            frm.ShowDialog();
            if(frm.lstDicDientIngredientTemp.Count > 0)
            {
                lstCaiDientIngredient = frm.lstDicDientIngredientTemp;
                 
                this.gcData.DataSource = lstCaiDientIngredient;
                this.gcData.RefreshDataSource();
            }
        }
        
        private void gvlueCaiRecipe_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (gvlueCaiRecipe.IsRowSelected(e.RowHandle))
                    gvlueCaiRecipe.UnselectRow(e.RowHandle);
                else
                    gvlueCaiRecipe.SelectRow(e.RowHandle);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int affect = -1;
            if (string.IsNullOrEmpty(cai.id))
                cai = new EntityDicCai();
            cai.names = this.txtName.Text;
            if(chkMeals.Items[0].CheckState == CheckState.Checked)
                cai.breakfast = "1";
            else
                cai.breakfast = "2";
            if (chkMeals.Items[1].CheckState == CheckState.Checked)
                cai.lunch = "1";
            else
                cai.lunch = "2";
            if (chkMeals.Items[2].CheckState == CheckState.Checked)
                cai.dinner = "1";
            else
                cai.dinner = "2";
            if (chkMeals.Items[3].CheckState == CheckState.Checked)
                cai.other = "1";
            else
                cai.other = "2";
            cai.methods = memMethods.Text;

            //菜分类
            if(lstSelectCaiRecipe != null )
            {
                cai.lstCaiSlaveId = new List<string>();
                foreach(EntityDisplayDicCaiRecipe vo in lstSelectCaiRecipe)
                {
                    cai.lstCaiSlaveId.Add(vo.caiSlaveId);
                }
            }
            //菜原料
            if (lstCaiDientIngredient !=null )
            {
                cai.lstCaiIngredient = new List<EntityDicCaiIngredient>();
                foreach(EntityDicDientIngredient vo in lstCaiDientIngredient)
                {
                    EntityDicCaiIngredient caiDient = new EntityDicCaiIngredient();
                    caiDient.ingredietId = vo.ingredientId;
                    caiDient.ingredietName = vo.ingredietName;
                    caiDient.weight = vo.weight;
                    cai.lstCaiIngredient.Add(caiDient);
                    cai.kCal += (vo.kCal * vo.weight) / 100;
                    cai.PROTEIN += (vo.proteint * vo.weight) / 100;
                    cai.FAT += (vo.fat * vo.weight) / 100;
                    cai.CHO += (vo.cho * vo.weight) / 100;
                    cai.BRXXW += (vo.brxxw * vo.weight) / 100;
                    cai.DGC += (vo.dgc * vo.weight) / 100;
                    cai.ASH += (vo.ash * vo.weight) / 100;
                    cai.vitaminA += (vo.vitaminsA * vo.weight) / 100;
                    cai.THIAMIN += (vo.thiamin * vo.weight) / 100;
                    cai.RIBOFLAVIN += (vo.riboflavin * vo.weight) / 100;
                    cai.NIACIN += (vo.niacin * vo.weight) / 100;
                    cai.vitaminC += (vo.vitaminsC * vo.weight) / 100;
                    cai.vitaminE += (vo.vitaminsE * vo.weight) / 100;
                    cai.CA += (vo.ca * vo.weight) / 100;
                    cai.P += (vo.p * vo.weight) / 100;
                    cai.K += (vo.k * vo.weight) / 100;
                    cai.NA += (vo.na * vo.weight) / 100;
                    cai.MG += (vo.mg * vo.weight) / 100;
                    cai.FE += (vo.fe * vo.weight) / 100;
                    cai.SE += (vo.se * vo.weight) / 100;
                    cai.CU += (vo.cu * vo.weight) / 100;
                    cai.MN += (vo.mn * vo.weight) / 100;
                    cai.I += (vo.i * vo.weight) / 100;
                    cai.F += (vo.f * vo.weight) / 100;
                    cai.CR += (vo.cr * vo.weight) / 100;
                    cai.MU += (vo.mu * vo.weight) / 100;
                    cai.vitaminD += (vo.vitaminsD * vo.weight) / 100;
                    cai.vitaminB6 += (vo.vitaminsB6 * vo.weight) / 100;
                    cai.vitaminB9 += (vo.vitaminsB9 * vo.weight) / 100;
                    cai.vitaminH += (vo.vitaminsH * vo.weight) / 100;
                    cai.DANJIAN += (vo.danjian * vo.weight) / 100;
                }
            }

            using (ProxyHms proxy = new ProxyHms())
            {
                affect = proxy.Service.SaveDicCai(ref cai);
            }
            if (affect < 0)
            {
                DialogBox.Msg("保存失败 !");
            }
            else
                this.IsRequireRefresh = true;
        }
        
        private void gvData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvData.RowCount > 0 && e.RowHandle >= 0)
            {
                if (gvData.FocusedColumn.FieldName == "weight")
                {
                    EntityDicDientIngredient vo = GetRowObject();
                    vo.weight = Function.Dec(gvData.GetRowCellValue(gvData.FocusedRowHandle, "weight"));
                }
            }
        }
        
        private void repBtnDientIngredDel_Click(object sender, EventArgs e)
        {
            EntityDicDientIngredient vo = GetRowObject();
            if (vo != null)
            {
                lstCaiDientIngredient = gcData.DataSource as List<EntityDicDientIngredient>;
                int idx = lstCaiDientIngredient.FindIndex(r => r.id == vo.id);
                if (idx >= 0)
                {
                    lstCaiDientIngredient.RemoveAt(idx);
                    gcData.DataSource = lstCaiDientIngredient;
                    gcData.RefreshDataSource();
                }
            }
        }

        private void btnMainNutrition_Click(object sender, EventArgs e)
        {
            frmPopup206040102 frm = new frmPopup206040102(lstCaiDientIngredient);
            frm.ShowDialog();
        }

        private void gvlueCaiRecipe_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string caiSlaveStr = string.Empty;
            if (gvlueCaiRecipe.SelectedRowsCount > 0)
            {
                lstSelectCaiRecipe = new List<EntityDisplayDicCaiRecipe>();
                int[] selectArr = this.gvlueCaiRecipe.GetSelectedRows();
                for (int i = 0; i < selectArr.Length; i++)
                {
                    EntityDisplayDicCaiRecipe vo = (this.gvlueCaiRecipe.GetRow(selectArr[i]) as EntityDisplayDicCaiRecipe);
                    lstSelectCaiRecipe.Add(vo);
                    caiSlaveStr += vo.caiSlaveName + "、";
                }
            }
            if (!string.IsNullOrEmpty(caiSlaveStr))
                caiSlaveStr = caiSlaveStr.TrimEnd('、');
            this.txtSlaveName.Text = caiSlaveStr;
        }
        

        private void gdlueCaiRecipe_Click(object sender, EventArgs e)
        {
            if(lstSelectCaiRecipe == null)
            {
                //菜分类
                if (cai != null)
                {
                    foreach (var strId in cai.lstCaiSlaveId)
                    {
                        for (int i = 0; i < gvlueCaiRecipe.RowCount; i++)
                        {
                            EntityDisplayDicCaiRecipe vo = gvlueCaiRecipe.GetRow(i) as EntityDisplayDicCaiRecipe;
                            if (vo.caiSlaveId == strId)
                                gvlueCaiRecipe.SelectRow(i);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
