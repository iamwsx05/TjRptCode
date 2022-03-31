using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using weCare.Core.Utils;

namespace rtpFunc
{
    /*
     *引用 NuGet包 Spire.XLS
     */
    /// <summary>
    /// Excel帮助类
    /// </summary>
    public class ExcelHelper
    {
        /// <summary>
        /// 将Excel以文件流转换DataTable
        /// </summary>
        /// <param name="hasTitle">是否有表头</param>
        /// <param name="path">文件路径</param>
        /// <param name="tableindex">文件簿索引</param>
        public DataTable ExcelToDataTableFormPath(bool hasTitle = true, string path = "", int tableindex = 0)
        {
            //新建Workbook
            Workbook workbook = new Workbook();
            //将当前路径下的文件内容读取到workbook对象里面
            workbook.LoadFromFile(path);
            //得到第一个Sheet页
            Worksheet sheet = workbook.Worksheets[tableindex];
            return SheetToDataTable(hasTitle, sheet);
        }
        /// <summary>
        /// 将Excel以文件流转换DataTable
        /// </summary>
        /// <param name="hasTitle">是否有表头</param>
        /// <param name="stream">文件流</param>
        /// <param name="tableindex">文件簿索引</param>
        public DataTable ExcelToDataTableFormStream(bool hasTitle = true, Stream stream = null, int tableindex = 0)
        {
            //新建Workbook
            Workbook workbook = new Workbook();
            //将文件流内容读取到workbook对象里面
            workbook.LoadFromStream(stream);
            //得到第一个Sheet页
            Worksheet sheet = workbook.Worksheets[tableindex];
            return SheetToDataTable(hasTitle, sheet);
        }

        private DataTable SheetToDataTable(bool hasTitle, Worksheet sheet)
        {

            int iRowCount = sheet.Rows.Length;
            int iColCount = sheet.Columns.Length;
            DataTable dt = new DataTable();
            //try
            //{
                //生成列头
                for (int i = 0; i < iColCount; i++)
                {
                    var name = "column" + i;
                    if (hasTitle)
                    {
                        var txt = sheet.Range[1, i + 1].Text;
                        if (!string.IsNullOrEmpty(txt)) name = txt;
                    }
                    while (dt.Columns.Contains(name)) name = name + "_1";//重复行名称会报错。
                    dt.Columns.Add(new DataColumn(name, typeof(string)));
                }
                //生成行数据
                int rowIdx = hasTitle ? 2 : 1;
                for (int iRow = rowIdx; iRow <= iRowCount; iRow++)
                {
                    DataRow dr = dt.NewRow();
                    
                    for (int iCol = 1; iCol <= iColCount; iCol++)
                    {
                    
                        var cell = sheet.Range[iRow, iCol];
                        dr[iCol - 1] = cell.Value;
                    }
                    dt.Rows.Add(dr);
                }
           // }
            //catch(Exception ex)
            //{
            //    ExceptionLog.OutPutException(ex);
            //}
            
            return RemoveEmpty(dt);
        }

        /// <summary>
        /// 去除空行
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private DataTable RemoveEmpty(DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool rowdataisnull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {
                        rowdataisnull = false;
                    }
                }
                if (rowdataisnull)
                {
                    removelist.Add(dt.Rows[i]);
                }
            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
            return dt;
        }
    }
}
