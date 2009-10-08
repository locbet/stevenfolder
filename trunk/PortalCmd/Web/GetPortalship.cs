using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using PortalCmd.Core;
using PortalCmd.Core.Html;
using System.Data;

namespace PortalCmd.Web
{
    /// <summary>
    /// 在Portal中查询送取货通知书
    /// </summary>
    public class GetPortalship : BasePortalWeb
    {
        /// <summary>
        /// 在Portal中查询送取货通知书
        /// </summary>
        /// <param name="so">输入SO号，然后在Portal中查询该SO号的送取货通知书信息</param>
        public void ProcessGetPortData(string so, string user, string password)
        {
            //登录
            string usern = user;
            string pwd = password;

            Login(usern, pwd);

            //查询SO号 sample:SO99040130 (single line data) SO98210122 (Mutiline)

            string gethtml = SearchSO(so);
            //提交

            DataTable PortalShipdata = GetShipData(gethtml);

            for (int i = 0; i < PortalShipdata.Rows.Count; i++)
            {

               for (int j = 0; j < 18; j++)
                {
                    Console.WriteLine(PortalShipdata.Rows[i][j].ToString());
                }
   
            }
            

        }

        /// <summary>
        /// 向Portal提交SO号，返回查询结果的html页
        /// </summary>
        /// <param name="so"></param>
        /// <returns></returns>
        public string SearchSO(string so)
        {
            //so = "SO95220266";
            string year = so.Substring(2, 1);
            string month = so.Substring(3, 1);
            string day = so.Substring(4, 2);
            string prefix = "20";

            if (year == "A")
            {
                year = "10";
            }
            else if (year == "B")
            {
                year = "11";
            }
            else
            {
                prefix += "0";
            }

            if (month == "A")
            {
                month = "10";
            }
            else if (month == "B")
            {
                month = "11";
            }
            else if (month == "C")
            {
                month = "12";
            }


            string startdate = prefix + year + "-" + month + "-" + day;
            //string startdate = "2009-5-1";

            string enddate = startdate;
            //string enddate = "2009-6-1";

            //出货流程->送/取货通知书->订单追踪
            //查询SO号的出货信息           

            string url = "http://192.168.3.11:5666/PortalManager?pk=erp&mtb=0&pg=erp_pkl&pl=erp_pkl1&tb=5&pn=erp_pkl009";
            //string postData = string.Format("act=1&po_type=SO&ref_po={0}", so);

            string postData = string.Format("cuno=&cuso=&end={0}&gate=0&house=AC12&pino=&report=1&sono={1}&start={2}&tid=0&upd=N", enddate, so, startdate);
            return spider.PostPage(url, postData);

        }

        /// <summary>
        /// 分析html页中的内容，取出送取货通知书信息。
        /// </summary>
        /// <param name="html">要分析的html源</param>
        /// <returns>送取货通知书信息list, Dictionary类型</returns>
        public DataTable GetShipData(string html)
        {
            #region
            /*
            <!-- Start DB HTML Table -->
            <table border="0" cellspacing="2" cellpadding="2">
              <tr class="HeaderRow">
                <th nowrap>序号</th>
                <th nowrap>客户</th><th nowrap>客户编号</th><th nowrap>订单号</th><th nowrap>客户订单号</th><th nowrap>订单日期</th><th nowrap>协商交期</th>
                <th nowrap>品号</th>
                <th nowrap>币别</th>
                <th nowrap>金额</th>
                <th nowrap>接单處理</th>
                <th nowrap>送取货通知单号</th>
                <th nowrap>销货单号</th>
                <th nowrap>实际发货日期</th>
                <th nowrap>发货方式</th>
                <th nowrap>发货公司</th>
                <th nowrap>快递单号</th>
                <th nowrap>发票号</th>
              </tr>
              <tr class="OddRow">
                <td nowrap >1</td>
                <td nowrap >台湾美声</td><td nowrap>PM001-15</td><td nowrap>SO98210122</td><td nowrap>PM001-15-010</td><td nowrap>8月21日</td><td nowrap>8月25日</td>
                <td nowrap >22-PMS045*065-010</td>
                <td nowrap align="right">RMB</td>
                <td nowrap align="right">139.59</td>
                <td nowrap >二车间</td>
                <td nowrap >PN090805034</td>
                <td nowrap >SA98310129</td>
                <td nowrap align="center">08-31</td>
                <td nowrap >业务自提</td>
                <td nowrap >&nbsp;</td>
                <td nowrap >&nbsp;</td>
                <td nowrap >ACE08651</td>
              </tr>
              <tr class="EvenRow">
                <td nowrap >2</td>
                <td nowrap >&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td>
                <td nowrap >22-PMS045*065-010</td>
                <td nowrap align="right">RMB</td>
                <td nowrap align="right">139.59</td>
                <td nowrap >二车间</td>
                <td nowrap >PN090805036</td>
                <td nowrap >SA98310129</td>
                <td nowrap align="center">08-31</td>
                <td nowrap >业务自提</td>
                <td nowrap >&nbsp;</td>
                <td nowrap >吴</td>
                <td nowrap >ACE08651</td>
              </tr>
             </table>
             <!-- End DB HTML Table -->
             */
            #endregion


            //取得Table表数据
            string htmlsource = TagHtml.ParseHtml("<!-- Start DB HTML Table -->", "<!-- End DB HTML Table -->", html);

            #region
            /*
            //string headtag0 = "<!-- Start DB HTML Table --><table border=\"0\" cellspacing=\"2\" cellpadding=\"2\">";
            //string endtag0 = "</table><!-- End DB HTML Table -->";

            //取得表头数据
            string headsource = HtmlSplit.ParseHtml("<tr class=\"HeaderRow\">", "</tr>", htmlsource);
            //取得表头的每个栏位值
            List<string> headList = HtmlSplit.ParseHtmls("<th nowrap>", "</th>", headsource);


            //取得表身的每行数据 放于 bodysource list中
            string headtag = "((<tr class=\"OddRow\">)|(<tr class=\"EvenRow\">))";
            string endtag = "</tr>";
            List<string> Bodysource = HtmlSplit.ShipParseHtmls(headtag, endtag, htmlsource);

                
                //string pattern_21 = string.Format("{0}(.*?){1}", headtag, endtag);
                //Match m2 = Regex.Match(htmlsource, pattern_21, CurrentRegexOptions);
                //string source2 = m2.Groups[1].Value;
                //string pattern_2 = "<OPTION value=\"(.*?)\">(.*?)</OPTION>";
            //取得表身bodysource中的每一行每一个栏位的数据
            foreach (var item in Bodysource)
            {
                
            }
            string pattern_22 = "<td nowrap\\s*\n*[^>]*>(.*?)</td>";
            MatchCollection mc2 = Regex.Matches(source2, pattern_22, CurrentRegexOptions);

            

            

            Dictionary<string, string> list = new Dictionary<string, string>();
            if (headList.Count > 0)
            {

                for (int i = 0; i < mc2.Count; i++)
                {
                    list.Add(headList[i] , mc2[i].Groups[1].Value);
                }
            }
            */
            #endregion


            //定义一个 Datatable 类存放取出的Table数据
            DataTable shiptable = new DataTable();


            List<string> trs = TagTable.TRs(htmlsource);
            foreach (string item in trs)
            {
                List<string> ths = TagTable.THs(item);

                for (int i = 0; i < ths.Count; i++)
                {
                    shiptable.Columns.Add(ths[i]);
                }

                List<string> tds = TagTable.TDs(item);
                Int32 count = 0;
                DataRow myRows = shiptable.NewRow();

                foreach (string items in tds)
                {

                    myRows[count] = items;
                    count++;
                    if (count == 17)
                    {
                        shiptable.Rows.Add(myRows);
                        count = 0;
                        myRows = shiptable.NewRow();
                    }
                    //Console.WriteLine(items);
                }
                
            }

            return shiptable;
        }



    }
}
