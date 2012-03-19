using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;
using System.IO;

//实例应用：
//string strXmlFile = Server.MapPath("TestXml.xml"); 
//XmlControl xmlTool = new XmlControl(strXmlFile);
// 数据显视 
// dgList.DataSource = xmlTool.GetData("Book/Authors[ISBN=\"0002\"]"); 
// dgList.DataBind();
// 更新元素内容 
// xmlTool.Replace("Book/Authors[ISBN=\"0002\"]/Content","ppppppp"); 
// xmlTool.Save();
// 添加一个新节点 
// xmlTool.InsertNode("Book","Author","ISBN","0004"); 
// xmlTool.InsertElement("Book/Author[ISBN=\"0004\"]","Content","aaaaaaaaa"); 
// xmlTool.InsertElement("Book/Author[ISBN=\"0004\"]","Title","Sex","man","iiiiiiii"); 
// xmlTool.Save();
// 删除一个指定节点的所有内容和属性 
// xmlTool.Delete("Book/Author[ISBN=\"0004\"]"); 
// xmlTool.Save();
// 删除一个指定节点的子节点 
// xmlTool.Delete("Book/Authors[ISBN=\"0003\"]"); 
// xmlTool.Save();

namespace QX.Common.C_Class
{
    /**/
    /// <summary>
    /// XmlHelper 的摘要说明。
    /// xml操作类
    /// </summary>
    public class XmlHelper
    {
        protected string strXmlFile;
        protected XmlDocument objXmlDoc = new XmlDocument();
        public XmlHelper(string XmlFile)
        {
            try
            {
                objXmlDoc.Load(XmlFile);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            strXmlFile = XmlFile;
        }
        /// <summary>
        /// 查找数据。返回一个DataView 
        /// </summary>
        /// <param name="XmlPathNode"></param>
        /// <returns></returns>
        public DataView GetData(string XmlPathNode,string strWhere,string OrderBy)
        {
            DataView dv;
            DataTable dt;
            try
            {
                DataSet ds = new DataSet();                
                StringReader read = new StringReader(objXmlDoc.SelectSingleNode(XmlPathNode).OuterXml);
                ds.ReadXml(read);
                dv = ds.Tables[0].DefaultView;
                dt = ds.Tables[0].Clone();               
                if (!string.IsNullOrEmpty(strWhere))
                {
                    DataRow[] rows = ds.Tables[0].Select(strWhere);
                    for (int i = 0; i < rows.Length; i++)
                    {
                        dt.ImportRow(rows[i]);
                    }
                }              
                
            }
            catch (Exception)
            {
                
                throw;
            }
            return dt.DefaultView ;
        }
        /// <summary>
        /// //更新节点内容。
        /// </summary>
        /// <param name="XmlPathNode"></param>
        /// <param name="Content"></param>
        public void Replace(string XmlPathNode, string Content)
        {
             
            objXmlDoc.SelectSingleNode(XmlPathNode).InnerText = Content;
        }
        /// <summary>
        /// //删除一个节点。 
        /// </summary>
        /// <param name="Node"></param>
        public void Delete(string Node)
        {
            
            string mainNode = Node.Substring(0, Node.LastIndexOf("/"));
            objXmlDoc.SelectSingleNode(mainNode).RemoveChild(objXmlDoc.SelectSingleNode(Node));
        }
        /// <summary>
        /// //插入一节点和此节点的一子节点。 
        /// </summary>
        /// <param name="MainNode"></param>
        /// <param name="ChildNode"></param>
        /// <param name="Element"></param>
        /// <param name="Content"></param>
        public void InsertNode(string MainNode, string ChildNode, string Element, string Content)
        {
            
            XmlNode objRootNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objChildNode = objXmlDoc.CreateElement(ChildNode);
            objRootNode.AppendChild(objChildNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objChildNode.AppendChild(objElement);
        }
        /// <summary>
        /// //插入一个节点，带一属性。 
        /// </summary>
        /// <param name="MainNode"></param>
        /// <param name="Element"></param>
        /// <param name="Attrib"></param>
        /// <param name="AttribContent"></param>
        /// <param name="Content"></param>
        public void InsertElement(string MainNode, string Element, string Attrib, string AttribContent, string Content)
        {
            
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.SetAttribute(Attrib, AttribContent);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
        }
        /// <summary>
        /// //插入一个节点，不带属性。 
        /// </summary>
        /// <param name="MainNode"></param>
        /// <param name="Element"></param>
        /// <param name="Content"></param>
        public void InsertElement(string MainNode, string Element, string Content)
        {
            
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
        }
        /// <summary>
        /// //保存文檔
        /// </summary>
        public void Save()
        {           
            try
            {
                objXmlDoc.Save(strXmlFile);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            objXmlDoc = null;
        }
    }
}
