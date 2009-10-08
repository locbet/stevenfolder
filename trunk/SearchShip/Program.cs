using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Xml;
using PortalCmd.Web;

namespace SearchShip
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            if (args.Length > 0)
            {
                try
                {
                    #region
                    //guid#Username#password#SO;
                    //string arguments = string.Format("{0}#{1}#{2}#{3}", condition.ID.ToString().ToLower(), condition.UserName, condition.Password, condition.SO);ss
                    string FullStr = args[0];
                    //string FullStr = "guid-001#AC12.SA#1234#SO99040130";  //sample:SO99040130 (single line data) SO98210122 (Mutiline)
                    string[] stringSeparators = new string[] { "#" };

                    string[] strShip = FullStr.Split(stringSeparators, StringSplitOptions.None);

                    string ShipGuid = strShip[0];
                    string ShipUser = strShip[1];
                    string ShipPWD = strShip[2];
                    string ShipSO = strShip[3];

                    
                    Console.WriteLine("start..MSMQProcessShip.exe");
                    Console.WriteLine("Start..Query Portal Ship. Please waiting...");

                    GetPortalship SearchShip = new GetPortalship();
                    SearchShip.Login(ShipUser, ShipPWD);

                    //string gethtml = SearchSO(so);
                    string getShiphtml = SearchShip.SearchSO(ShipSO);

                    DataTable PortalShipdata = SearchShip.GetShipData(getShiphtml);

                    //准备XML文档的查询结果
                    string fullpath = System.Configuration.ConfigurationManager.AppSettings["AnswerFolder"];
                    string newshipfile = fullpath + "\\" + ShipGuid + ".xml";
                    #region
                    //<?xml version="1.0" encoding="utf-8" ?>
                    //<root>
                    //  <Shipment counts="1">
                    //      <itemGuid value="1">
                    //          <Cust></Cust>
                    //          <CustNo></CustNo>
                    //          <OrderNo></OrderNo>
                    //          <Cust_OrderNo></Cust_OrderNo>
                    //          <OrderDate></OrderDate>
                    //          <NegotiateDate></NegotiateDate>
                    //          <ProductNo></ProductNo>
                    //          <MoneyType></MoneyType>
                    //          <Amount></Amount>
                    //          <PrintShop></PrintShop>
                    //          <ShippingNo></ShippingNo>
                    //          <SA_NO></SA_NO>
                    //          <ExactShipDate></ExactShipDate>
                    //          <ShippingType></ShippingType>
                    //          <ShipCompany></ShipCompany>
                    //          <ExpressNo></ExpressNo>
                    //          <Invoice></Invoice>
                    //      </items>
                    //  </Shipment>
                    //</root>
                    #endregion

                    XmlDocument xmldoc = new XmlDocument();

                    if (File.Exists(newshipfile))
                    {
                        string newfile = fullpath + "\\" + ShipGuid + "_old.xml";
                        File.Copy(newshipfile, newfile, true);
                        File.Delete(newshipfile);
                    }
                    //加入XML的声明段落
                    XmlNode xmlnode = xmldoc.CreateXmlDeclaration("1.0", "utf-8", "");
                    xmldoc.AppendChild(xmlnode);
                    XmlElement xmlelem = xmldoc.CreateElement("", "root", "");
                    xmldoc.AppendChild(xmlelem);
                    xmldoc.Save(newshipfile);

                    // 设定XmlNodeReader对象来打开XML文件reader = new XmlNodeReader ( doc ) ;
                    XmlNode root = xmldoc.SelectSingleNode("//root");

                    XmlElement xmlSubNode = xmldoc.CreateElement("", "Shipment", "");
                    XmlAttribute a = xmldoc.CreateAttribute("", "counts", "");
                    a.Value = Convert.ToString(PortalShipdata.Rows.Count);
                    xmlSubNode.Attributes.Append(a);

                    for (int i = 0; i < PortalShipdata.Rows.Count; i++)
                    {

                        //for (int j = 0; j < 18; j++)
                        //{
                        //0
                        XmlElement itemGuid = xmldoc.CreateElement("", "itemGuid", "");
                        XmlAttribute attr = xmldoc.CreateAttribute("", "value", "");
                        attr.Value = PortalShipdata.Rows[i][0].ToString();
                        itemGuid.Attributes.Append(attr);
                        //1
                        XmlElement Cust_Name = xmldoc.CreateElement("", "Cust", "");
                        Cust_Name.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][1].ToString()));
                        itemGuid.AppendChild(Cust_Name);
                        //2
                        XmlElement Cust_No = xmldoc.CreateElement("", "CustNo", "");
                        Cust_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][2].ToString()));
                        itemGuid.AppendChild(Cust_No);
                        //3
                        XmlElement Order_No = xmldoc.CreateElement("", "OrderNo", "");
                        Order_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][3].ToString()));
                        itemGuid.AppendChild(Order_No);
                        //4
                        XmlElement CustOrder_No = xmldoc.CreateElement("", "Cust_OrderNo", "");
                        CustOrder_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][4].ToString()));
                        itemGuid.AppendChild(CustOrder_No);
                        //5
                        XmlElement Order_Date = xmldoc.CreateElement("", "OrderDate", "");
                        Order_Date.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][5].ToString()));
                        itemGuid.AppendChild(Order_Date);
                        //6
                        XmlElement Negotiate_Date = xmldoc.CreateElement("", "NegotiateDate", "");
                        Negotiate_Date.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][6].ToString()));
                        itemGuid.AppendChild(Negotiate_Date);
                        //7
                        XmlElement Prod_No = xmldoc.CreateElement("", "ProductNo", "");
                        Prod_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][7].ToString()));
                        itemGuid.AppendChild(Prod_No);
                        //8
                        XmlElement Money_type = xmldoc.CreateElement("", "MoneyType", "");
                        Money_type.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][8].ToString()));
                        itemGuid.AppendChild(Money_type);
                        //9
                        XmlElement _Amount = xmldoc.CreateElement("", "Amount", "");
                        _Amount.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][9].ToString()));
                        itemGuid.AppendChild(_Amount);
                        //10
                        XmlElement Print_Shop = xmldoc.CreateElement("", "PrintShop", "");
                        Print_Shop.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][10].ToString()));
                        itemGuid.AppendChild(Print_Shop);
                        //11
                        XmlElement Shipping_No = xmldoc.CreateElement("", "ShippingNo", "");
                        Shipping_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][11].ToString()));
                        itemGuid.AppendChild(Shipping_No);
                        //12
                        XmlElement SA_No = xmldoc.CreateElement("", "SA_NO", "");
                        SA_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][12].ToString()));
                        itemGuid.AppendChild(SA_No);
                        //13
                        XmlElement Exact_ShipDate = xmldoc.CreateElement("", "ExactShipDate", "");
                        Exact_ShipDate.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][13].ToString()));
                        itemGuid.AppendChild(Exact_ShipDate);
                        //14
                        XmlElement Shipping_Type = xmldoc.CreateElement("", "ShippingType", "");
                        Shipping_Type.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][14].ToString()));
                        itemGuid.AppendChild(Shipping_Type);
                        //15
                        XmlElement Ship_Company = xmldoc.CreateElement("", "ShipCompany", "");
                        Ship_Company.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][15].ToString()));
                        itemGuid.AppendChild(Ship_Company);

                        //16
                        XmlElement Express_No = xmldoc.CreateElement("", "ExpressNo", "");
                        Express_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][16].ToString()));
                        itemGuid.AppendChild(Express_No);
                        //17
                        XmlElement Invoice_No = xmldoc.CreateElement("", "Invoice", "");
                        Invoice_No.AppendChild(xmldoc.CreateTextNode(PortalShipdata.Rows[i][17].ToString()));
                        itemGuid.AppendChild(Invoice_No);

                        xmlSubNode.AppendChild(itemGuid);
                        //Console.WriteLine(PortalShipdata.Rows[i][j].ToString());
                        //}

                    }

                    root.AppendChild(xmlSubNode);

                    xmldoc.AppendChild(root);
                    xmldoc.Save(newshipfile);

                    string arguments = ShipGuid + ".xml";
                    
                    Console.WriteLine("ok");
                    Console.WriteLine("Start...UpPortalShipToServer.exe");

                    string upXmlToSRVEXE = System.Configuration.ConfigurationManager.AppSettings["UpXmlToServerEXE"];

                    Process.Start(new ProcessStartInfo(upXmlToSRVEXE, arguments));

                    //Process.Start("MSMQProcessShip.exe");
                    
                    //string filecontent = File.ReadAllText(fullpath, Encoding.UTF8);
                    //ServiceRef.ServiceSoapClient ssc = new UpXmlToServer.ServiceRef.ServiceSoapClient();
                    #endregion
                    
                }
                catch (Exception ex)
                {
                    File.WriteAllText("error.txt", ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("arg error");
            }
        }

        #region
        //public class xmlHelper
        //{
        //    private string newordersfile;
        //    private string historyordersfile;

        //    public xmlHelper(string xmlpathfolder)
        //    {
        //        //<?xml version="1.0" encoding="utf-8" ?>
        //        //<orders>
        //        //  <orderitem>
        //        //    <itemGuid></itemGuid>
        //        //    <billCompany></billCompany>
        //        //    <shipCompany></shipCompany>
        //        //    <buyerPO></buyerPO>
        //        //    <orderDate></orderDate>
        //        //    <dueDate></dueDate>
        //        //    <excelFile></excelFile>
        //        //    <comment></comment>
        //        //  </orderitem>
        //        //</orders>
        //        newordersfile = xmlpathfolder + "\\neworder.xml";
        //        historyordersfile = xmlpathfolder + "\\history.xml";
        //        if (!File.Exists(newordersfile))
        //        {
        //            XmlDocument xmldoc = new XmlDocument();
        //            //加入XML的声明段落
        //            XmlNode xmlnode = xmldoc.CreateXmlDeclaration("1.0", "utf-8", "");
        //            xmldoc.AppendChild(xmlnode);
        //            XmlElement xmlelem = xmldoc.CreateElement("", "orders", "");
        //            xmldoc.AppendChild(xmlelem);
        //            xmldoc.Save(newordersfile);
        //        }
        //        if (!File.Exists(historyordersfile))
        //        {
        //            XmlDocument xmldoc = new XmlDocument();
        //            //加入XML的声明段落
        //            XmlNode xmlnode = xmldoc.CreateXmlDeclaration("1.0", "utf-8", "");
        //            xmldoc.AppendChild(xmlnode);
        //            XmlElement xmlelem = xmldoc.CreateElement("", "orders", "");
        //            xmldoc.AppendChild(xmlelem);
        //            xmldoc.Save(historyordersfile);
        //        }
        //    }
        //    public Guid AddNewOrder(OrderItem item)
        //    {
        //        if (item.OrderId != Guid.Empty)
        //        {
        //            return AddRecord(item, newordersfile);
        //        }
        //        else
        //        {
        //            return Guid.Empty;
        //        }
        //    }
        //    public Guid AddRecord(OrderItem item, string filename)
        //    {
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load(filename);

        //        XmlNode curr = doc.SelectSingleNode("//orders/orderitem[@orderguid='" + item.OrderId + "']");
        //        if (curr != null)
        //        {
        //            return item.OrderId;
        //        }
        //        // 设定XmlNodeReader对象来打开XML文件reader = new XmlNodeReader ( doc ) ;
        //        XmlNode root = doc.SelectSingleNode("//orders");

        //        XmlElement xmlnode = doc.CreateElement("", "orderitem", "");
        //        XmlAttribute a = doc.CreateAttribute("", "orderguid", "");
        //        a.Value = item.OrderId.ToString();
        //        xmlnode.Attributes.Append(a);

        //        //0
        //        XmlElement itemGuid = doc.CreateElement("", "itemGuid", "");
        //        itemGuid.AppendChild(doc.CreateTextNode(item.OrderId.ToString()));
        //        //1
        //        XmlElement billCompany = doc.CreateElement("", "billCompany", "");
        //        billCompany.AppendChild(doc.CreateTextNode(item.BillCompany));
        //        //2
        //        XmlElement shipCompany = doc.CreateElement("", "shipCompany", "");
        //        shipCompany.AppendChild(doc.CreateTextNode(item.ShipCompany));
        //        //3
        //        XmlElement buyerPO = doc.CreateElement("", "buyerPO", "");
        //        buyerPO.AppendChild(doc.CreateTextNode(item.PO));
        //        //4
        //        XmlElement orderDate = doc.CreateElement("", "orderDate", "");
        //        orderDate.AppendChild(doc.CreateTextNode(item.OrderDate.ToString()));
        //        //5
        //        XmlElement dueDate = doc.CreateElement("", "dueDate", "");
        //        dueDate.AppendChild(doc.CreateTextNode(item.DueDate.ToString("yyyy-MM-dd")));
        //        //6
        //        XmlElement excelFile = doc.CreateElement("", "excelFile", "");
        //        excelFile.AppendChild(doc.CreateTextNode(item.ExcelFile));
        //        //7
        //        XmlElement comment = doc.CreateElement("", "comment", "");
        //        comment.AppendChild(doc.CreateTextNode(item.Comment));

        //        xmlnode.AppendChild(itemGuid);
        //        xmlnode.AppendChild(billCompany);
        //        xmlnode.AppendChild(shipCompany);
        //        xmlnode.AppendChild(buyerPO);
        //        xmlnode.AppendChild(orderDate);
        //        xmlnode.AppendChild(dueDate);
        //        xmlnode.AppendChild(excelFile);
        //        xmlnode.AppendChild(comment);

        //        root.AppendChild(xmlnode);

        //        doc.AppendChild(root);
        //        doc.Save(filename);
        //        return item.OrderId;
        //    }
        //    public void AddHistoryOrder(OrderItem item)
        //    {
        //        if (item.OrderId != Guid.Empty)
        //        {
        //            AddRecord(item, historyordersfile);
        //        }
        //    }

        //    public List<OrderItem> GetNewOrders()
        //    {
        //        List<OrderItem> orderitems = new List<OrderItem>();
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load(newordersfile);
        //        XmlNodeList nodeList = doc.SelectNodes("//orders/orderitem");
        //        foreach (XmlNode item in nodeList)
        //        {
        //            OrderItem i = new OrderItem();
        //            XmlNodeList childList = item.ChildNodes;
        //            i.OrderId = new Guid(childList[0].InnerText);
        //            i.BillCompany = childList[1].InnerText;
        //            i.ShipCompany = childList[2].InnerText;
        //            i.PO = childList[3].InnerText;
        //            i.OrderDate = Convert.ToDateTime(childList[4].InnerText);
        //            i.DueDate = Convert.ToDateTime(childList[5].InnerText);
        //            i.ExcelFile = childList[6].InnerText;
        //            i.Comment = childList[7].InnerText;
        //            orderitems.Add(i);
        //        }
        //        return orderitems;
        //    }

        //    public OrderItem GetNewOrders(Guid itemGuid, bool isremove)
        //    {
        //        OrderItem i = new OrderItem();
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load(newordersfile);
        //        XmlNode root = doc.SelectSingleNode("//orders");
        //        XmlNode curr = doc.SelectSingleNode("//orders/orderitem[@orderguid='" + itemGuid + "']");
        //        if (curr == null)
        //        {
        //            return null;
        //        }
        //        XmlNodeList childList = curr.ChildNodes;
        //        i.OrderId = new Guid(childList[0].InnerText);
        //        i.BillCompany = childList[1].InnerText;
        //        i.ShipCompany = childList[2].InnerText;
        //        i.PO = childList[3].InnerText;
        //        i.OrderDate = Convert.ToDateTime(childList[4].InnerText);
        //        i.DueDate = Convert.ToDateTime(childList[5].InnerText);
        //        i.ExcelFile = childList[6].InnerText;
        //        i.Comment = childList[7].InnerText;
        //        if (isremove)
        //        {
        //            curr.ParentNode.RemoveChild(curr);
        //            //XmlNode c = doc.SelectSingleNode("//orders/orderitem[@orderguid='" + Guid.Empty + "']");
        //            //if (c != null)
        //            //{
        //            //    c.ParentNode.RemoveChild(c);
        //            //}
        //            doc.Save(newordersfile);
        //        }
        //        return i;
        //    }
        //    public List<OrderItem> GetHistoryOrders()
        //    {
        //        List<OrderItem> orderitems = new List<OrderItem>();
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load(historyordersfile);
        //        XmlNodeList nodeList = doc.SelectNodes("//orders/orderitem");
        //        foreach (XmlNode item in nodeList)
        //        {
        //            OrderItem i = new OrderItem();
        //            XmlNodeList childList = item.ChildNodes;
        //            i.OrderId = new Guid(childList[0].InnerText);
        //            i.BillCompany = childList[1].InnerText;
        //            i.ShipCompany = childList[2].InnerText;
        //            i.PO = childList[3].InnerText;
        //            i.OrderDate = Convert.ToDateTime(childList[4].InnerText);
        //            i.DueDate = Convert.ToDateTime(childList[5].InnerText);
        //            i.ExcelFile = childList[6].InnerText;
        //            i.Comment = childList[7].InnerText;
        //            orderitems.Add(i);
        //        }
        //        return orderitems;
        //    }
        //}

        #endregion


    }
}
