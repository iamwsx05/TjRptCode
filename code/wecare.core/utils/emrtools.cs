using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using weCare.Core.Entity;

namespace weCare.Core.Utils
{
    public class EmrTool
    {
        #region 变量

        public const string EVENT_STRING_SPLITER = "##";

        public const char CONTROL_ITEMS_SPLITER = ';';

        #endregion

        #region GetBasicFieldXml

        public static string GetBasicFieldXml(string designXml)
        {
            StringBuilder fieldXml = new StringBuilder();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(designXml);

            XmlNodeList nodelist = doc["eflayout"].GetElementsByTagName("ctrl");
            if (nodelist == null || nodelist.Count == 0)
            {
                return string.Empty;
            }
            string item = string.Empty;
            string[] items = null;
            foreach (XmlNode node in nodelist)
            {
                try
                {
                    if (Function.Int(node.Attributes["itemtype"].Value) == 6)
                    {
                        fieldXml.AppendLine("<fields>");
                        fieldXml.AppendLine("<fieldname>" + node.Attributes["itemname"].Value.Trim() + "</fieldname>");
                        fieldXml.AppendLine("<fielddesc>" + node.Attributes["itemcaption"].Value.Trim() + "</fielddesc>");
                        fieldXml.AppendLine("<fieldtype>" + (node.Attributes["ctrlname"].Value.Trim().IndexOf("时间") >= 0 ? "1" : "0") + "</fieldtype>");
                        fieldXml.AppendLine("<referencetype>1</referencetype>");
                        fieldXml.AppendLine("<nullflag>1</nullflag>");
                        fieldXml.AppendLine("<elementitems></elementitems>");

                        item = node.Attributes["items"].Value.Trim();
                        if (!string.IsNullOrEmpty(item)) items = item.Split(new string[] { EmrTool.EVENT_STRING_SPLITER }, StringSplitOptions.None);
                        if (node.Attributes["ctrltype"].Value.Trim().IndexOf("ctlRichTextBox") >= 0 && items != null && items.Length > 4)
                        {
                            fieldXml.AppendLine("<defaultrows>" + Function.Int(items[3]) + "</defaultrows>");
                        }
                        else
                        {
                            fieldXml.AppendLine("<defaultrows></defaultrows>");
                        }

                        fieldXml.AppendLine("<qctype>0</qctype>");
                        fieldXml.AppendLine("<sortno>" + node.Attributes["top"].Value + "</sortno>");
                        fieldXml.AppendLine("</fields>");
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.Message;
                    fieldXml.Clear();
                }
            }
            nodelist = null;
            doc = null;
            if (fieldXml.Length > 0)
            {
                fieldXml.Insert(0, "<caseplus>" + Environment.NewLine);
                fieldXml.Append("</caseplus>");
                return fieldXml.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion

        #region 获取XmlData结构

        static string XmlElement(string element, string val, bool isCdata)
        {
            if (string.IsNullOrEmpty(val)) val = "";
            if (isCdata && val != "")
                return "<" + element + ">" + "<![CDATA[" + val + "]]>" + "</" + element + ">";
            else
                return "<" + element + ">" + val + "</" + element + ">";
        }

        public static string GetXmlData(string layoutXml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(layoutXml);
            XmlNodeList nodelist = doc["eflayout"].GetElementsByTagName("ctrl");
            if (nodelist != null && nodelist.Count > 0)
            {
                List<string> lstParentName = new List<string>();
                EntityNodeCtrl ctrl = null;
                List<EntityNodeCtrl> data = new List<EntityNodeCtrl>();
                foreach (XmlNode node in nodelist)
                {
                    if (node.Attributes["itemtype"].Value == "1" || node.Attributes["itemtype"].Value == "2")
                    {
                        ctrl = new EntityNodeCtrl();
                        ctrl.ParentName = node.Attributes["parentnode"].Value;
                        ctrl.FieldName = node.Attributes["itemname"].Value;
                        if (node.Attributes["ctrltype"].Value.StartsWith("Common.Controls.Emr.ctlCheckBox"))
                        {
                            ctrl.value = node.Attributes["checked"].Value;
                        }
                        else
                        {
                            ctrl.IsCdata = true;
                            ctrl.value = node.Attributes["ctrlText"].Value;
                        }
                        data.Add(ctrl);

                        if (!string.IsNullOrEmpty(ctrl.ParentName) && lstParentName.IndexOf(ctrl.ParentName) < 0)
                        {
                            lstParentName.Add(ctrl.ParentName);
                        }
                    }
                }
                if (data.Count > 0)
                {
                    StringBuilder xml = new StringBuilder();
                    xml.AppendLine("<FormData>");
                    foreach (EntityNodeCtrl item in data)
                    {
                        if (string.IsNullOrEmpty(item.ParentName))
                            xml.AppendLine(XmlElement(item.FieldName, item.value, item.IsCdata));
                    }
                    if (lstParentName.Count > 0)
                    {
                        List<EntityNodeCtrl> tmp = null;
                        foreach (string parentName in lstParentName)
                        {
                            tmp = data.FindAll(t => t.ParentName == parentName);
                            if (tmp != null)
                            {
                                xml.AppendLine("<" + parentName + ">");
                                foreach (EntityNodeCtrl item in tmp)
                                {
                                    xml.AppendLine(XmlElement(item.FieldName, item.value, item.IsCdata));
                                }
                                xml.AppendLine("</" + parentName + ">");
                            }
                        }
                    }
                    xml.AppendLine("</FormData>");
                    return xml.ToString();
                }
            }
            doc = null;
            return string.Empty;
        }

        public static string GetXmlData(List<EntityNodeCtrl> data, List<string> lstParentName, string tableXmlData)
        {
            if (data.Count > 0 || !string.IsNullOrEmpty(tableXmlData))
            {
                data.Sort();
                StringBuilder xml = new StringBuilder();
                xml.AppendLine("<FormData>");
                foreach (EntityNodeCtrl item in data)
                {
                    if (string.IsNullOrEmpty(item.ParentName))
                    {
                        xml.AppendLine(XmlElement(item.FieldName, item.value, item.IsCdata));
                    }
                }
                if (lstParentName.Count > 0)
                {
                    List<EntityNodeCtrl> tmp = null;
                    foreach (string parentName in lstParentName)
                    {
                        tmp = data.FindAll(t => t.ParentName == parentName);
                        if (tmp != null)
                        {
                            xml.AppendLine("<" + parentName + ">" + System.Environment.NewLine);
                            foreach (EntityNodeCtrl item in tmp)
                            {
                                xml.AppendLine(XmlElement(item.FieldName, item.value, item.IsCdata));
                            }
                            xml.AppendLine("</" + parentName + ">" + System.Environment.NewLine);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(tableXmlData) && tableXmlData.Trim() != "")
                { 
                    int pos1 = tableXmlData.IndexOf("<Table>");
                    int pos2 = tableXmlData.LastIndexOf("</Table>");
                    if (pos1 >= 0 && pos2 > 0)
                    {
                        xml.AppendLine(tableXmlData.Substring(pos1, pos2 - pos1 + 8) + System.Environment.NewLine);
                    }
                }
                xml.AppendLine("</FormData>");
                return xml.ToString();
            }
            return string.Empty;
        }

        #region 递归读取XML所有节点
        /// <summary>
        /// 递归读取XML所有节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="data"></param>
        static void RecuXmlNodes(XmlNode node, ref List<EntityNodeCtrl> data)
        {
            if (node.HasChildNodes)
            {
                if (node.ChildNodes.Count == 1 && node.ChildNodes[0].Name.IndexOf("#cdata-section") >= 0)
                {
                    EntityNodeCtrl vo = new EntityNodeCtrl();
                    vo.FieldName = node.Name;
                    vo.value = node.InnerText;
                    data.Add(vo);
                }
                else
                {
                    foreach (XmlNode item in node.ChildNodes)
                    {
                        RecuXmlNodes(item, ref data);
                    }
                }
            }
            else
            {
                if (node.NodeType == XmlNodeType.Text)
                {
                    EntityNodeCtrl vo = new EntityNodeCtrl();
                    vo.FieldName = node.ParentNode.Name;
                    vo.value = node.Value;
                    data.Add(vo);
                }
            }
        }
        #endregion

        public static List<EntityNodeCtrl> GetXmlNodes(string xmlData)
        {
            List<EntityNodeCtrl> data = new List<EntityNodeCtrl>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            XmlNode rootNode = doc.FirstChild;
            RecuXmlNodes(rootNode, ref data);
            return data;
        }

        #endregion

    }
}
