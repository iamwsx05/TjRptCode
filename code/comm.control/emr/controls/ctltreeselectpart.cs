﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using weCare.Core.Entity;
using Common.Entity;

namespace Common.Controls.Emr
{
    public partial class ctlTreeSelectCheckPart : ctlTreeSelect
    {
        public ctlTreeSelectCheckPart()
        {
            InitializeComponent();

            LoadData();
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();

            LoadData();
        }

        /// <summary>
        /// 原因: 自定义单只在InitializeComponent后调用有效,非自定义单只在OnLoaded后调用后有效,所以2个地方都调
        /// </summary>
        private void LoadData()
        {
            //字典信息处理
            if (!DesignMode && this.DataSource == null)
            {
                this.Properties.PopupFormMinSize = new Size(250, 300);
                this.KeyFieldName = "partCode";
                this.ParentFieldName = "parentCode";
                this.DisplayMember = "partName";
                this.ValueMember = "partCode";
                PopTreeColumnCollection cols = new PopTreeColumnCollection();
                cols.Add(new PopupTreeColumn("partCode", "代码", 100));
                cols.Add(new PopupTreeColumn("partName", "部位名称", 150));
                cols.Add(new PopupTreeColumn("pyCode", "拼音码", 0));
                cols.Add(new PopupTreeColumn("wbCode", "五笔码", 0));
                this.Columns = cols;
                //this.SetToGridMode(); 
            }
        }

        /// <summary>
        /// 重载实现过滤效果
        /// </summary>
        protected override void DoFilter()
        {
            DataTable dtNewSource = null;
            dtNewSource.BeginLoadData();
            DataColumn filterCol = new DataColumn("superFilterCol", Type.GetType("System.String"));
            dtNewSource.Columns.Add(filterCol);
            foreach (DataRow dr in dtNewSource.Rows)
            {
                string filterValue = "";
                foreach (PopupTreeColumn col in base.columns)
                {
                    filterValue += dr[col.FieldName].ToString() + "^";
                }
                dr[filterCol] = filterValue;
            }
            dtNewSource.EndLoadData();
            string filter = this.Text.Trim().Replace("'", "''").Replace("[", "[[]");

            dtNewSource.DefaultView.RowFilter = "superFilterCol like '%" + filter + "%'";
            dtNewSource = dtNewSource.DefaultView.ToTable();
            this.DataSource = dtNewSource;

            if (dtNewSource.Rows.Count > 0)
            {
                base.ctlTreeList.FocusedNode = ctlTreeList.FindNodeByFieldValue(base.ValueMember, dtNewSource.Rows[0][base.ValueMember]);
            }
        }
    }
}
