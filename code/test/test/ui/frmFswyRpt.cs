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
    public partial class frmFswyRpt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmFswyRpt()
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
        List<EntityXmfl> lstXmfl = null;
        List<EntityZdzy> lstZy = null;
        List<EntityZdzh> lstZdzh = null;

        #region Init
        void Init()
        {
            DateTime dteNow = DateTime.Now;
            this.dteBegin.Text = dteNow.ToString("yyyy-MM") + "-01";
            this.dteEnd.Text = dteNow.ToString("yyyy-MM-dd");
            lstDw = new List<EntityDw>();
            lstXmfl = new List<EntityXmfl>();
            lstZy = new List<EntityZdzy>();
            lstZdzh = new List<EntityZdzh>();

            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                lstDw = proxy.Service.GetZdDw();
                lstXmfl = proxy.Service.GetZdXmfl();
                lstZy = proxy.Service.GetZdZy();
                lstZdzh = proxy.Service.GetZdzh();
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

            this.lueXmfl.Properties.PopupWidth = this.lueDw.Width;
            this.lueXmfl.Properties.PopupHeight = 400;
            this.lueXmfl.Properties.ValueColumn = EntityXmfl.Columns.cls_code;
            this.lueXmfl.Properties.DisplayColumn = EntityXmfl.Columns.cls_name;
            this.lueXmfl.Properties.Essential = false;
            this.lueXmfl.Properties.IsShowColumnHeaders = true;
            this.lueXmfl.Properties.ColumnWidth.Add(EntityXmfl.Columns.cls_code, 70);
            this.lueXmfl.Properties.ColumnWidth.Add(EntityXmfl.Columns.cls_name, this.lueDw.Width - 70);
            this.lueXmfl.Properties.ColumnHeaders.Add(EntityXmfl.Columns.cls_code, "编码");
            this.lueXmfl.Properties.ColumnHeaders.Add(EntityXmfl.Columns.cls_name, "名称");
            this.lueXmfl.Properties.ShowColumn = EntityXmfl.Columns.cls_code + "|" + EntityXmfl.Columns.cls_name;
            this.lueXmfl.Properties.IsUseShowColumn = true;
            this.lueXmfl.Properties.FilterColumn = EntityXmfl.Columns.cls_code + "|" + EntityXmfl.Columns.cls_name;
            if (lstXmfl != null)
            {
                this.lueXmfl.Properties.DataSource = lstXmfl.ToArray();
                this.lueXmfl.Properties.SetSize();
            }

            this.lueYwfl.Properties.PopupWidth = this.lueDw.Width;
            this.lueYwfl.Properties.PopupHeight = 400;
            this.lueYwfl.Properties.ValueColumn = EntityZdzy.Columns.job_code;
            this.lueYwfl.Properties.DisplayColumn = EntityZdzy.Columns.job_name;
            this.lueYwfl.Properties.Essential = false;
            this.lueYwfl.Properties.IsShowColumnHeaders = true;
            this.lueYwfl.Properties.ColumnWidth.Add(EntityZdzy.Columns.job_code, 70);
            this.lueYwfl.Properties.ColumnWidth.Add(EntityZdzy.Columns.job_name, this.lueDw.Width - 70);
            this.lueYwfl.Properties.ColumnHeaders.Add(EntityZdzy.Columns.job_code, "编码");
            this.lueYwfl.Properties.ColumnHeaders.Add(EntityZdzy.Columns.job_name, "名称");
            this.lueYwfl.Properties.ShowColumn = EntityZdzy.Columns.job_code + "|" + EntityZdzy.Columns.job_name;
            this.lueYwfl.Properties.IsUseShowColumn = true;
            this.lueYwfl.Properties.FilterColumn = EntityZdzy.Columns.job_code + "|" + EntityZdzy.Columns.job_name;
            if (lstZy != null)
            {
                this.lueYwfl.Properties.DataSource = lstZy.ToArray();
                this.lueYwfl.Properties.SetSize();
            }

            this.lueComb.Properties.PopupWidth = this.lueComb.Width;
            this.lueComb.Properties.PopupHeight = 400;
            this.lueComb.Properties.ValueColumn = EntityZdzh.Columns.comb_code;
            this.lueComb.Properties.DisplayColumn = EntityZdzh.Columns.comb_name;
            this.lueComb.Properties.Essential = false;
            this.lueComb.Properties.IsShowColumnHeaders = true;
            this.lueComb.Properties.ColumnWidth.Add(EntityZdzh.Columns.comb_code, 70);
            this.lueComb.Properties.ColumnWidth.Add(EntityZdzh.Columns.comb_name, this.lueDw.Width - 70);
            this.lueComb.Properties.ColumnHeaders.Add(EntityZdzh.Columns.comb_code, "编码");
            this.lueComb.Properties.ColumnHeaders.Add(EntityZdzh.Columns.comb_name, "名称");
            this.lueComb.Properties.ShowColumn = EntityZdzh.Columns.comb_code + "|" + EntityZdzh.Columns.comb_name;
            this.lueComb.Properties.IsUseShowColumn = true;
            this.lueComb.Properties.FilterColumn = EntityZdzh.Columns.comb_code + "|" + EntityZdzh.Columns.comb_name;
            if (lstZy != null)
            {
                this.lueComb.Properties.DataSource = lstZdzh.ToArray();
                this.lueComb.Properties.SetSize();
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

            //lblFile.Text = filePath;
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
        /// <summary>
        /// 
        /// </summary>
        internal void QueryTjjdb()
        {
            List<EntityItemRpt> data = new List<EntityItemRpt>();

            string lncCode = string.Empty;
            string lncName = this.lueDw.Text;
            string patName = this.txtPatName.Text;
            string regNo = this.txtRegNo.Text;
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
            if (!string.IsNullOrEmpty(patName))
            {
                dicParm.Add(Function.GetParm("patName", patName));
            }
            if (!string.IsNullOrEmpty(regNo))
            {
                dicParm.Add(Function.GetParm("regNo", regNo));
            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcTjjdb.DataSource = proxy.Service.GetTjjdb2(dicParm) ;
                this.gcTjjdb.RefreshDataSource();
            }

        }
        #endregion

        #region 挂账分类报表
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
                this.gcDwgz.DataSource = proxy.Service.GetTjgzflRpt(dicParm).OrderBy( i => i.lnc_name);
                this.gcDwgz.RefreshDataSource();
            }
        }

        #endregion

        #region 异常报表
        /// <summary>
        /// 
        /// </summary>
        internal void QueryTjYcRpt()
        {
            List<EntityItemRpt> data = new List<EntityItemRpt>();

            string lncCode = string.Empty;
            string lncName = this.lueDw.Text;
            string cls_name = this.lueXmfl.Text;
            string cls_code = string.Empty;
            string regNo = this.txtRegNo.Text;
            string ycgjz = this.txtYcgjz.Text;
            string ycgjzF = this.txtYcgjzF.Text;
            if (!string.IsNullOrEmpty(lncName))
            {
                EntityDw dw = lstDw.Find(r => r.lnc_name == lncName);
                if (dw != null)
                    lncCode = dw.lnc_code;
            }
            if (!string.IsNullOrEmpty(cls_name))
            {
                EntityXmfl vo = lstXmfl.Find(r => r.cls_name == cls_name);
                if (vo != null)
                    cls_code = vo.cls_code;
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
            if (!string.IsNullOrEmpty(regNo))
            {
                dicParm.Add(Function.GetParm("regNo", regNo));
            }
            if (!string.IsNullOrEmpty(cls_code))
            {
                dicParm.Add(Function.GetParm("xmfl", cls_code));
            }
            if (!string.IsNullOrEmpty(ycgjz))
            {

                if(ycgjz.Contains("+"))
                {
                    string[] strArr = ycgjz.Split('+');

                    foreach (var vo in strArr)
                    {
                        dicParm.Add(Function.GetParm("ycgjz", vo));
                    }
                }
                else
                    dicParm.Add(Function.GetParm("ycgjz", ycgjz));
            }
            if (!string.IsNullOrEmpty(ycgjzF))
            {
                dicParm.Add(Function.GetParm("ycgjzF", ycgjzF));
            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcTjXmYcRpt.DataSource = proxy.Service.GetYcjgRpt(dicParm);
                this.gcTjXmYcRpt.RefreshDataSource();
            }

        }
        #endregion

        #region 分类报表
        /// <summary>
        /// 
        /// </summary>
        internal void QueryTjywflRpts()
        {
            List<EntityTjywflRpt> data = new List<EntityTjywflRpt>();
            string lncName = this.lueDw.Text;
            string lncCode = string.Empty;
            string jobCodoe = string.Empty;
            string jobName = this.lueYwfl.Text;
            string patName = this.txtPatName.Text;
            string regNo = this.txtRegNo.Text;

            if (!string.IsNullOrEmpty(lncName))
            {
                EntityDw dw = lstDw.Find(r => r.lnc_name == lncName);
                if (dw != null)
                    lncCode = dw.lnc_code;
            }
            if (!string.IsNullOrEmpty(jobName))
            {
                EntityZdzy zy = lstZy.Find(r => r.job_name == jobName);
                if (zy != null)
                    jobCodoe = zy.job_code;
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
            if (!string.IsNullOrEmpty(jobCodoe))
            {
                dicParm.Add(Function.GetParm("jobName", jobCodoe));
            }
            if (!string.IsNullOrEmpty(regNo))
            {
                dicParm.Add(Function.GetParm("regNo", regNo));
            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcTjYwflRpt.DataSource = proxy.Service.GetTjywflRpts(dicParm);
                this.gcTjYwflRpt.RefreshDataSource();
            }
        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        internal void QueryGzlRpts()
        {
            List<EntityGzlRpt> data = new List<EntityGzlRpt>();
            string lncName = this.lueDw.Text;
            string lncCode = string.Empty;
            string jobCodoe = string.Empty;
            string jobName = this.lueYwfl.Text;
            string patName = this.txtPatName.Text;
            string regNo = this.txtRegNo.Text;
            string combCode = string.Empty;
            string combName = this.lueComb.Text;

            if (!string.IsNullOrEmpty(lncName))
            {
                EntityDw dw = lstDw.Find(r => r.lnc_name == lncName);
                if (dw != null)
                    lncCode = dw.lnc_code;
            }
            if (!string.IsNullOrEmpty(jobName))
            {
                EntityZdzy zy = lstZy.Find(r => r.job_name == jobName);
                if (zy != null)
                    jobCodoe = zy.job_code;
            }

            if (!string.IsNullOrEmpty(combName))
            {
                EntityZdzh vo = lstZdzh.Find(r => r.comb_name == combName);
                if (vo != null)
                    combCode = vo.comb_code;
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
            if (!string.IsNullOrEmpty(jobCodoe))
            {
                dicParm.Add(Function.GetParm("jobName", jobCodoe));
            }
            if (!string.IsNullOrEmpty(combCode))
            {
                dicParm.Add(Function.GetParm("combCode", combCode));
            }
            if (!string.IsNullOrEmpty(regNo))
            {
                dicParm.Add(Function.GetParm("regNo", regNo));
            }
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                this.gcGzlRpt.DataSource = proxy.Service.GetGzlRpts(dicParm);
                this.gcGzlRpt.RefreshDataSource();
            }
        }
        #region 工作量统计报表

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
            else if (tabPane1.SelectedPageIndex == 3)
            {
                QueryTjYcRpt();
            }
            else if (tabPane1.SelectedPageIndex == 4)
            {
                QueryTjywflRpts();
            }
            else if (tabPane1.SelectedPageIndex == 5)
            {
                QueryGzlRpts();
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
                uiHelper.ExportToXls(this.gvDwgz, true);
            }
            else if (tabPane1.SelectedPageIndex == 3)
            {
                uiHelper.ExportToXls(this.gvTjXmYcRpt, true);
            }
            else if (tabPane1.SelectedPageIndex == 4)
            {
                uiHelper.ExportToXls(this.gvTjYwflRpt, true);
            }
            else if (tabPane1.SelectedPageIndex == 5)
            {
                uiHelper.ExportToXls(this.gvGzlRpt, true);
            }
        }

        private void gvTjjdb_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvTjjdb.GetRowCellValue(e.RowHandle, "reg_no") == null)
            {
                e.Appearance.BackColor = System.Drawing.Color.Red;
            }
            gvTjjdb.Invalidate();
        }

        private void gvTjYwflRpt_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvTjYwflRpt.GetRowCellValue(e.RowHandle, "reg_date") == null)
            {
                e.Appearance.BackColor = System.Drawing.Color.Red;
            }
            gvTjYwflRpt.Invalidate();
        }

        private void gvGzlRpt_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvGzlRpt.GetRowCellValue(e.RowHandle, "reg_date") == null)
            {
                e.Appearance.BackColor = System.Drawing.Color.Red;
            }
            gvGzlRpt.Invalidate();
        }
    }
}
