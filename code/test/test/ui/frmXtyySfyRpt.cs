using Common.Controls;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using RptFunc.Entity;
using RptFunc.Xtyy;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace RptFunc
{
    public partial class frmXtyySfyRpt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmXtyySfyRpt()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
        }

        string filePath = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            ribbonControl.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = ribbonControl;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;
            Init();
        }

        List<EntityDw> lstDw = null;
        #region Init
       
        void Init()
        {
            DateTime dteNow = DateTime.Now;
            this.dteBegin.Text = dteNow.ToString("yyyy-MM") + "-01";
            this.dteEnd.Text = dteNow.ToString("yyyy-MM-dd");
            lstDw = new List<EntityDw>();
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                lstDw = proxy.Service.GetZdDw(); ;
            }
        }
        #endregion



        #region 
        private void iOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                String filepath = f.FileName;//G:\新建文件夹\新建文本文档.txt
                String filename = f.SafeFileName;//新建文本文档.txt
                filePath = filepath;
            }
        }

        private void iState_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {

            }
            else if (tabPane1.SelectedPageIndex == 1)
            {

            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }

        }

        private void iExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                uiHelper.ExportToXls(this.gvTjSfjkmx);
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {

            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }

        #region Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {

            }
            else if (tabPane1.SelectedPageIndex == 1)
            {

            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
            else if (tabPane1.SelectedPageIndex == 4)
            {

            }
            else if (tabPane1.SelectedPageIndex == 5)
            {

            }
        }
        #endregion

        #endregion

        #region GetRowObj
        //public EntityPeItem GetRowObjPeItem()
        //{
        //    if (this.gvPeResult.FocusedRowHandle < 0)
        //        return null;
        //    else
        //    {
        //        EntityPeItem vo = this.gvPeResult.GetRow(this.gvPeResult.FocusedRowHandle) as EntityPeItem;
        //        return vo;
        //    }
        //}


        #endregion

        #region 项目报表
        internal void QueryTjSfJkmx()
        {
            List<EntityTjSfJkmx> data = new List<EntityTjSfJkmx>();
            List<EntityParm> dicParm = new List<EntityParm>();
            string beginTime = this.dteBegin.Text.Replace('-', '.');
            string endTime = this.dteEnd.Text.Replace('-', '.');
            if (beginTime != string.Empty && endTime != string.Empty)
            {
                dicParm.Add(Function.GetParm("chrgDate", beginTime + "|" + endTime));
            }

            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcTjSfjkmx.DataSource = proxy.Service.GetTjSfJkmx(dicParm); ;
                this.gcTjSfjkmx.RefreshDataSource();
            }
        }
        #endregion

        #region
        internal void QueryTjjdb()
        {


        }
        #endregion


        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                QueryTjSfJkmx();
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {
            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {
              
            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }

        private void lueDw_TextChanged(object sender, EventArgs e)
        {
            //string content = lueDw.Text.Trim();

            //if (string.IsNullOrEmpty(content))
            //{
            //    lueDw.ClosePopup();
            //    lueDw.Properties.DataSource = lstDw;
            //    lueDw.Properties.DropDownRows = lstDw.Count;
            //    return;
            //}

            //List<EntityDw> newList = lstDw.FindAll(t => t.lnc_code.Contains(content) || t.lnc_name.Contains(content));
            //lueDw.Properties.DataSource = newList;
            //lueDw.Properties.DropDownRows = newList.Count;
            //lueDw.ShowPopup();
        }

        private void lueDw_EditValueChanged(object sender, EventArgs e)
        {
            //string content = lueDw.Text.Trim();

            //if (string.IsNullOrEmpty(content))
            //{
            //    lueDw.ClosePopup();
            //    lueDw.Properties.DataSource = lstDw;
            //    lueDw.Properties.DropDownRows = lstDw.Count;
            //    return;
            //}

            //List<EntityDw> newList = lstDw.FindAll(t => t.lnc_code.Contains(content) || t.lnc_name.Contains(content));
            //lueDw.Properties.DataSource = newList;
            //lueDw.Properties.DropDownRows = newList.Count;
            //lueDw.ShowPopup();
        }

        private void txtDw_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
