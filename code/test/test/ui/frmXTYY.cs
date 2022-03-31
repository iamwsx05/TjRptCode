using Common.Controls;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using RptFunc.Xtyy;
using rtpFunc;
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
    public partial class frmXTYY : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmXTYY()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
        }

        string filePath = string.Empty;
        List<EntityPeItem> dataPeItem = null;
        List<EntityLisItem> lstResult = null;
        List<EntityDyTjyjymxxm> lstDyTjjy = null;
        List<EntityZdzh> lstZdzh = null;

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

        #region Init
        void Init()
        {
            using (ProxyRptFunc proxy = new ProxyRptFunc())
            {
                lstDyTjjy = proxy.Service.GetDyTjyjymxxm();
                lstZdzh = proxy.Service.GetZdzh();
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
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {

            }
            else if (tabPane1.SelectedPageIndex == 2)
            {

            }
        }

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

        #region 
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
       
        #endregion



        #region GetRowObj
        public EntityPeItem GetRowObjPeItem()
        {
            if (this.gvPeResult.FocusedRowHandle < 0)
                return null;
            else
            {
                EntityPeItem vo = this.gvPeResult.GetRow(this.gvPeResult.FocusedRowHandle) as EntityPeItem;
                return vo;
            }
        }

        public EntityLisItem GetRowObjLisItem()
        {
            if (this.gvLisResult.FocusedRowHandle < 0)
                return null;
            else
            {
                EntityLisItem vo = this.gvLisResult.GetRow(this.gvLisResult.FocusedRowHandle) as EntityLisItem;
                return vo;
            }
        }
        #endregion

        #region event

        #region 检验结果对应
        private void btnSearchPeitem_Click(object sender, EventArgs e)
        {
            try
            {
                lstResult = new List<EntityLisItem>();
                #region 体检
                dataPeItem = new List<EntityPeItem>();
                dataPeItem.Clear();
                string regNo = txtRegNo.Text;
                if (string.IsNullOrEmpty(regNo))
                    return;
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"exec dbo.proc_get_recitem_query '{0}'";
                sql = string.Format(sql, regNo);
                DataTable dt = svc.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityPeItem vo = Function.Row2Model<EntityPeItem>(dr);
                        if (vo == null)
                            return;
                        vo.refLowUp = vo.ref_lower + "-" + vo.ref_uppper;
                        EntityDyTjyjymxxm voDy = lstDyTjjy.Find(r => r.pe_item == vo.item_code);
                        if (voDy != null)
                            vo.lisCode = voDy.as_item;
                        dataPeItem.Add(vo);
                    }
                }
                #endregion

                #region 检验
                EntityYwDjxx voDjxx = null;
                using (ProxyRptFunc proxy = new ProxyRptFunc())
                {
                    voDjxx = proxy.Service.GetYwdjxx(regNo);
                }

                if (voDjxx == null)
                    return;
                string dteFrom = voDjxx.reg_date.Replace('.', '-') + " 00:00:00";
                string dteTo = DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59"; ;
                Service proxyXtsvc = new Service();
                string res = proxyXtsvc.GetPatientsInfo(regNo, dteFrom, dteTo, "109");
                if (res == "-1")
                {
                    MessageBox.Show("获取报告失败！");
                    return;
                }

                XmlDocument document = new XmlDocument();
                document.LoadXml(res);
                DataTable dtSource = null;
                DataSet ds = Function.ReadXml(res);
                dt = ds.Tables["PatInfo"];
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (dtSource == null) dtSource = dt.Clone();
                    dtSource.Merge(dt);
                    dtSource.AcceptChanges();
                }
                List<EntityPatinfo> lisPat = null;
                if (dt != null && dt.Rows.Count > 0)
                {
                    lisPat = new List<EntityPatinfo>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityPatinfo patInfo = Function.Row2Model<EntityPatinfo>(dr);
                        if (lisPat.Any(r => r.lismain_repno == patInfo.lismain_repno))
                            continue;
                        lisPat.Add(patInfo);
                    }
                }

                if (lisPat == null)
                    return;

                foreach (var vo in lisPat)
                {
                    res = proxyXtsvc.GetResultInfo(vo.lismain_repno);
                    if (res == "-1")
                    {
                        MessageBox.Show("获取报告失败！");
                        return;
                    }
                    Log.Output("GetResultInfo-->" + Environment.NewLine + res);
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(res);
                    dtSource = null;
                    DataSet dsLis = Function.ReadXml(res);
                    dt = dsLis.Tables["ResultInfo"];
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (dtSource == null) dtSource = dt.Clone();
                        dtSource.Merge(dt);
                        dtSource.AcceptChanges();
                    }
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            EntityLisItem voLis = new EntityLisItem();
                            voLis.lisCode = dr["lisresult_order_id"].ToString().Split('_')[1];
                            EntityZdzh voZdzh = lstZdzh.Find(r => r.comb_code == voLis.lisCode);
                            if (voZdzh == null)
                                MessageBox.Show("无项目-->" + voLis.lisCode);
                            else
                                voLis.lisName = voZdzh.comb_name;
                            voLis.itemCode = dr["lisresult_item_id"].ToString();
                            voLis.itemName = dr["lisresult_item_cname"].ToString();
                            voLis.result = dr["llisresult_result"].ToString();
                            voLis.refLow = dr["lisresult_ref_min"].ToString();
                            voLis.refUp = dr["lisresult_ref_max"].ToString();
                            voLis.unit = dr["lisresult_unit"].ToString();
                            voLis.resultTime = dr["lisresult_time"].ToString();
                            voLis.refLowUp = dr["lisresult_ref_range"].ToString();
                            lstResult.Add(voLis);
                        }
                    }
                }
                #endregion

                this.gcPeResult.DataSource = dataPeItem;
                this.gcPeResult.RefreshDataSource();
                this.gcLisResult.DataSource = lstResult.OrderBy(t => t.lisCode);
                this.gcLisResult.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPe2Lis_Click(object sender, EventArgs e)
        {
            EntityLisItem lisVo = GetRowObjLisItem();
            EntityPeItem peVo = GetRowObjPeItem();
            if (lisVo == null || peVo == null)
                return;

            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"insert into dyTjyjymxxm values (?, ?, ?,?,'001','检验科')";
                IDataParameter[] parm = svc.CreateParm(4);
                parm[0].Value = peVo.item_code;
                parm[1].Value = peVo.item_name;
                parm[2].Value = lisVo.itemCode;
                parm[3].Value = lisVo.itemName;
                int affect = svc.ExecSql(sql, parm);
                if (affect > 0)
                {
                    MessageBox.Show("对应成功");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelDy_Click(object sender, EventArgs e)
        {
            EntityPeItem peVo = GetRowObjPeItem();
            if (peVo == null)
                return;

            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"delete from dyTjyjymxxm where pe_item = ? ";
                IDataParameter parm = svc.CreateParm();
                parm.Value = peVo.item_code;
                int affect = svc.ExecSql(sql, parm);
                if (affect > 0)
                {
                    MessageBox.Show("删除成功！！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #endregion

        

       
        
    }
}
