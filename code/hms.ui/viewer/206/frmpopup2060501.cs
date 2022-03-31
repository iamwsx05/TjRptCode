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
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class frmPopup2060501 : frmBasePopup
    {
        public frmPopup2060501(EntityDicDientIngredient _dicDientIngredient = null)
        {
            InitializeComponent();
            dicDientIngredient = _dicDientIngredient;
        }

        #region var/propery
        List<EntityDicIngredientClassify> lstDicIngredientClassify { get; set; }
        EntityDicDientIngredient dicDientIngredient = null;
        public bool IsRequireRefresh = false;
        #endregion

        #region methods
        internal void Init()
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                lstDicIngredientClassify = proxy.Service.GetDicIngredientClassify();
            }
            cboClassify.Properties.Items.Add("请选择......");
            if (lstDicIngredientClassify != null)
            {
                foreach (var vo in lstDicIngredientClassify)
                    cboClassify.Properties.Items.Add(vo.classifyName);
            }

            if (dicDientIngredient != null)
            {
                this.Text = "查看/编辑原料";
                txtName.Text = dicDientIngredient.names;
                cboClassify.Text = lstDicIngredientClassify.FindAll(r=>r.classifyId == dicDientIngredient.lstClassify[0]).FirstOrDefault().classifyName;
                txtOtherName.Text = dicDientIngredient.otherName;
                txtRemaks.Text = dicDientIngredient.remaks;
                txtEatPercent.Text = dicDientIngredient.eatPercent.ToString() ;
                txtWater.Text = dicDientIngredient.water.ToString();
                txtKCal.Text = dicDientIngredient.kCal.ToString();
                txtkj.Text = dicDientIngredient.kj.ToString();
                txtProteint.Text = dicDientIngredient.proteint.ToString();
                txtFat.Text = dicDientIngredient.fat.ToString();
                txtCho.Text = dicDientIngredient.cho.ToString();
                txtBrxxw.Text = dicDientIngredient.brxxw.ToString();
                txtDgc.Text = dicDientIngredient.dgc.ToString();
                txtAsh.Text = dicDientIngredient.ash.ToString();
                txtVitaminsA.Text = dicDientIngredient.vitaminsA.ToString();
                txtThiamin.Text = dicDientIngredient.thiamin.ToString();
                txtRiboflavin.Text = dicDientIngredient.riboflavin.ToString();
                txtNiacin.Text = dicDientIngredient.niacin.ToString();
                txtVitaminsC.Text = dicDientIngredient.vitaminsC.ToString();
                txtVitaminsE.Text = dicDientIngredient.vitaminsE.ToString();
                txtCa.Text = dicDientIngredient.ca.ToString();
                txtP.Text = dicDientIngredient.p.ToString();
                txtK.Text = dicDientIngredient.k.ToString();
                txtNa.Text = dicDientIngredient.na.ToString();
                txtMg.Text = dicDientIngredient.mg.ToString();
                txtFe.Text = dicDientIngredient.fe.ToString();
                txtZn.Text = dicDientIngredient.zn.ToString();
                txtSe.Text = dicDientIngredient.se.ToString();
                txtCu.Text = dicDientIngredient.cu.ToString();
                txtMn.Text = dicDientIngredient.mn.ToString();
                txtI.Text = dicDientIngredient.i.ToString();
                txtF.Text = dicDientIngredient.f.ToString();
                txtCr.Text = dicDientIngredient.cr.ToString();
                txtMu.Text = dicDientIngredient.mu.ToString();
                txtVitaminsD.Text = dicDientIngredient.vitaminsD.ToString();
                txtVitaminsB6.Text = dicDientIngredient.vitaminsB6.ToString();
                txtVitaminsB12.Text = dicDientIngredient.vitaminsB12.ToString();
                txtVitaminsB5.Text = dicDientIngredient.vitaminsB5.ToString();
                txtVitaminsB9.Text = dicDientIngredient.vitaminsB9.ToString();
                txtVitaminsH.Text = dicDientIngredient.vitaminsH.ToString();
                txtDanjian.Text = dicDientIngredient.vitaminsB12.ToString();
            }
        }
        #endregion

        #region event
        private void frmPopup2060501_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void cboClassify_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClassify.SelectedIndex == 0)
                cboClassify.Text = string.Empty;

        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboClassify.Text.Trim()))
            {
                DialogBox.Msg("请选择食物分类！");
                cboClassify.Focus();
                return;
            }

            int affect = -1;
            if (dicDientIngredient == null)
                dicDientIngredient = new EntityDicDientIngredient();
            else if (string.IsNullOrEmpty(dicDientIngredient.id))
                dicDientIngredient = new EntityDicDientIngredient();
            dicDientIngredient.names = txtName.Text;
            dicDientIngredient.lstClassify = new List<int>();
            dicDientIngredient.lstClassify.Add(lstDicIngredientClassify.FindAll(r => r.classifyName == cboClassify.Text.Trim()).FirstOrDefault().classifyId);
            dicDientIngredient.otherName = txtOtherName.Text;
            dicDientIngredient.remaks = txtRemaks.Text ;
            dicDientIngredient.eatPercent = Function.Dec(txtEatPercent.Text)   ;
            dicDientIngredient.water = Function.Dec(txtWater.Text);
            dicDientIngredient.kCal = Function.Dec(txtKCal.Text);
            dicDientIngredient.kj = Function.Dec(txtkj.Text);
            dicDientIngredient.proteint = Function.Dec(txtProteint.Text);
            dicDientIngredient.fat = Function.Dec(txtFat.Text);
            dicDientIngredient.cho = Function.Dec(txtCho.Text);
            dicDientIngredient.brxxw = Function.Dec(txtBrxxw.Text);
            dicDientIngredient.dgc = Function.Dec(txtDgc.Text);
            dicDientIngredient.ash = Function.Dec(txtAsh.Text);
            dicDientIngredient.vitaminsA = Function.Dec(txtVitaminsA.Text);
            dicDientIngredient.thiamin = Function.Dec(txtThiamin.Text);
            dicDientIngredient.riboflavin = Function.Dec(txtRiboflavin.Text);
            dicDientIngredient.niacin = Function.Dec(txtNiacin.Text);
            dicDientIngredient.vitaminsC = Function.Dec(txtVitaminsC.Text);
            dicDientIngredient.vitaminsE = Function.Dec(txtVitaminsE.Text);
            dicDientIngredient.ca = Function.Dec(txtCa.Text);
            dicDientIngredient.p = Function.Dec(txtP.Text);
            dicDientIngredient.k = Function.Dec(txtK.Text);
            dicDientIngredient.na = Function.Dec(txtNa.Text);
            dicDientIngredient.mg = Function.Dec(txtMg.Text);
            dicDientIngredient.fe = Function.Dec(txtFe.Text);
            dicDientIngredient.zn = Function.Dec(txtZn.Text);
            dicDientIngredient.se = Function.Dec(txtSe.Text);
            dicDientIngredient.cu = Function.Dec(txtCu.Text);
            dicDientIngredient.mn = Function.Dec(txtMn.Text);
            dicDientIngredient.i = Function.Dec(txtI.Text);
            dicDientIngredient.f = Function.Dec(txtF.Text);
            dicDientIngredient.cr = Function.Dec(txtCr.Text);
            dicDientIngredient.mu = Function.Dec(txtMu.Text);
            dicDientIngredient.vitaminsD = Function.Dec(txtVitaminsD.Text);
            dicDientIngredient.vitaminsB6 = Function.Dec(txtVitaminsB6.Text);
            dicDientIngredient.vitaminsB12 = Function.Dec(txtVitaminsB12.Text);
            dicDientIngredient.vitaminsB5 = Function.Dec(txtVitaminsB5.Text);
            dicDientIngredient.vitaminsB9 = Function.Dec(txtVitaminsB9.Text);
            dicDientIngredient.vitaminsH = Function.Dec(txtVitaminsH.Text);
            dicDientIngredient.vitaminsB12 = Function.Dec(txtDanjian.Text);
            using (ProxyHms proxy = new ProxyHms())
            {
                affect = proxy.Service.SaveDicIngredient(ref dicDientIngredient);
            }
            if (affect < 0)
            {
                DialogBox.Msg("保存失败 !");
            }
            else
                this.IsRequireRefresh = true;
        }
    }
}
