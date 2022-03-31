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
    public partial class frmXtyyRpt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmXtyyRpt()
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
            this.lblFile.Text = string.Empty;
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

            this.lueDw.Properties.PopupWidth = this.lueDw.Width;
            this.lueDw.Properties.PopupHeight = 600;
            this.lueDw.Properties.ValueColumn = EntityDw.Columns.lnc_code;
            this.lueDw.Properties.DisplayColumn = EntityDw.Columns.lnc_name;
            this.lueDw.Properties.Essential = false;
            this.lueDw.Properties.IsShowColumnHeaders = true;
            this.lueDw.Properties.ColumnWidth.Add(EntityDw.Columns.lnc_code, 70);
            this.lueDw.Properties.ColumnWidth.Add(EntityDw.Columns.lnc_name, this.lueDw.Width - 70);
            this.lueDw.Properties.ColumnHeaders.Add(EntityDw.Columns.lnc_code, "编码");
            this.lueDw.Properties.ColumnHeaders.Add(EntityDw.Columns.lnc_name, "名称");
            this.lueDw.Properties.ShowColumn = EntityDw.Columns.lnc_code + "|" + EntityDw.Columns.lnc_name;
            this.lueDw.Properties.IsUseShowColumn = true;
            this.lueDw.Properties.FilterColumn = EntityDw.Columns.lnc_code + "|" + EntityDw.Columns.lnc_name;
            if (lstDw != null)
            {
                this.lueDw.Properties.DataSource = lstDw.ToArray();
                this.lueDw.Properties.SetSize();
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

            lblFile.Text = filePath;
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
                //uiHelper.ExportToXls(this.gvTJxm);
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
        internal void QueryItemRpt()
        {
            List<EntityItemRpt> data = new List<EntityItemRpt>();

            string lncCode = string.Empty;
            string lncName = this.lueDw.Text;
            if (!string.IsNullOrEmpty(lncName))
            {
                EntityDw dw = lstDw.Find(r=>r.lnc_name == lncName);
                if (dw != null)
                    lncCode = dw.lnc_code;
            }

            List<EntityParm> dicParm = new List<EntityParm>();
            string beginTime = this.dteBegin.Text.Replace('-', '.') ;
            string endTime = this.dteEnd.Text.Replace('-', '.') ;
            if (beginTime != string.Empty && endTime != string.Empty)
            {
                dicParm.Add(Function.GetParm("regDate", beginTime + "|" + endTime));
            }
            if (!string.IsNullOrEmpty(lncCode))
            {
                dicParm.Add(Function.GetParm("lncCode", lncCode));
            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcItemRpt.DataSource = proxy.Service.GetItemRpt(dicParm); ;
                this.gcItemRpt.RefreshDataSource();
            }

            if (!string.IsNullOrEmpty(lncName))
                this.gvItemRpt.GroupPanelText = "体检单位：" + lncName + "    " + beginTime + "~" + endTime;
            else
                this.gvItemRpt.GroupPanelText = beginTime + "~" + endTime;

           
        }
        #endregion

        #region 体检进度表
        internal void QueryTjjdb()
        {
            List<EntityItemRpt> data = new List<EntityItemRpt>();

            string lncCode = string.Empty;
            string lncName = this.lueDw.Text;
            if (!string.IsNullOrEmpty(lncName))
            {
                EntityDw dw = lstDw.Find(r => r.lnc_name == lncName);
                if (dw != null)
                    lncCode = dw.lnc_code;
            }

            List<EntityParm> dicParm = new List<EntityParm>();
            string beginTime = this.dteBegin.Text.Replace('-', '.');
            string endTime = this.dteEnd.Text.Replace('-', '.');
            if (beginTime != string.Empty && endTime != string.Empty)
            {
                dicParm.Add(Function.GetParm("regDate", beginTime + "|" + endTime));
            }
            if (!string.IsNullOrEmpty(lncCode))
            {
                dicParm.Add(Function.GetParm("lncCode", lncCode));
            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcTjjdb.DataSource = proxy.Service.GetTjjdb(dicParm).OrderBy(t=>t.flg) ;
                this.gcTjjdb.RefreshDataSource();
            }

        }
        #endregion

        #region
        internal void QueryTjgzflb()
        {
            List<EntityTjdwgzfl> data = new List<EntityTjdwgzfl>();
            string lncCode = string.Empty;
            string lncName = this.lueDw.Text;
            if (!string.IsNullOrEmpty(lncName))
            {
                EntityDw dw = lstDw.Find(r => r.lnc_name == lncName);
                if (dw != null)
                    lncCode = dw.lnc_code;
            }
            List<EntityParm> dicParm = new List<EntityParm>();
            string beginTime = this.dteBegin.Text.Replace('-', '.');
            string endTime = this.dteEnd.Text.Replace('-', '.');
            if (beginTime != string.Empty && endTime != string.Empty)
            {
                dicParm.Add(Function.GetParm("regDate", beginTime + "|" + endTime));
            }
            if (!string.IsNullOrEmpty(lncCode))
            {
                dicParm.Add(Function.GetParm("lncCode", lncCode));
            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcDwgz.DataSource = proxy.Service.GetTjgzflRpt(dicParm); ;
                this.gcDwgz.RefreshDataSource();
            }
        }

        #endregion


        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                QueryItemRpt();
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {
                QueryTjjdb();
            }
            else if (tabPane1.SelectedPageIndex == 2)
            {
                QueryTjgzflb();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                uiHelper.ExportToXls(this.gvItemRpt,true);
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {
                uiHelper.ExportToXls(this.gvTjjdb, true);
            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }
    }
}
