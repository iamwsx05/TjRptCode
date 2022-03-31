using Common.Controls;
using Common.Entity;
using System;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System.Collections.Generic;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Hms.Ui
{
    public partial class frmPopup2100502 : frmBasePopup
    {
        public frmPopup2100502()
        {
            InitializeComponent();
        }

        void ButtonInitial()
        {
            RepositoryItemButtonEdit rib = new RepositoryItemButtonEdit();
            rib.TextEditStyle = TextEditStyles.HideTextEditor;
            rib.Buttons[0].Kind = ButtonPredefines.Glyph;
             rib.ButtonClick += rib_ButtonClick; 
            rib.Buttons[0].Caption = "删除";
            rib.Buttons[0].Visible = true;

            gridView1.Columns["F07"].ColumnEdit = rib;
            gridView2.Columns["F02"].ColumnEdit = rib;
            gridView3.Columns["F02"].ColumnEdit = rib;
            gridView4.Columns["F02"].ColumnEdit = rib;
            gridView5.Columns["F03"].ColumnEdit = rib;
            gridView6.Columns["F07"].ColumnEdit = rib;
        }

        void rib_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int rowIndex = gridView1.FocusedRowHandle;
            DialogBox.Msg((gridView1.GetRow(rowIndex) as EntityTest).F01);

            gridView1.DeleteRow(rowIndex);
        }

        private void blbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmPopup2100502_Load(object sender, EventArgs e)
        {
            this.ButtonInitial();
            List<EntityTest> data = new List<EntityTest>();
            data.Add(new EntityTest() { F01 = "AAA", F10 = "1" });
            data.Add(new EntityTest() { F01 = "BBB", F10 = "1" });
            data.Add(new EntityTest() { F01 = "CCC", F10 = "1" });
            data.Add(new EntityTest() { F01 = "DDD", F10 = "0" });
            data.Add(new EntityTest() { F01 = "EEE", F10 = "1" });
            data.Add(new EntityTest() { F01 = "FFF", F10 = "1" });

            this.gridControl1.DataSource = data;
            this.gridControl2.DataSource = data;
            this.gridControl3.DataSource = data;
            this.gridControl4.DataSource = data;
            this.gridControl5.DataSource = data;
            this.gridControl6.DataSource = data;
        }
    }

    public class EntityTest
    {
        public string F01 { get; set; }
        public string F02 { get; set; }
        public string F03 { get; set; }
        public string F04 { get; set; }
        public string F05 { get; set; }
        public string F06 { get; set; }
        public string F07 { get; set; }
        public string F08 { get; set; }
        public string F09 { get; set; }
        public string F10 { get; set; }
    }

}
