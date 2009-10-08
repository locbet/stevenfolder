#define AV
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using PortalCmd.Core;
using PortalCmd.Web;
using PortalCmd.Core.Html;

namespace PortalCmd
{
    class Program
    {
        static RegexOptions CurrentRegexOptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
        [STAThread()]
        static void Main(string[] args)
        {
#if !AV
            string html = File.ReadAllText("../../HTMLPage0.htm", Encoding.UTF8);

            string source = GetHtml(html);

            Dictionary<string, string> keyvalue = HtmlSplit.TagOptionValue(source);

            foreach (KeyValuePair<string,string> item in keyvalue)
            {
                Console.WriteLine("key=\"{0}\"---value=\"{1}\"", item.Key, item.Value);
            }
#else
            //string html = File.ReadAllText("../../HTMLPage2.htm", Encoding.UTF8);
            //string source = GetHtml3(html);
            //GetPortalData gpd = new GetPortalData();
            //GetPortalship gpd = new GetPortalship();
            //gpd.ProcessGetPortData("SO98210122");
            //Console.WriteLine(gpd.Login());
            //Console.WriteLine(HtmlSplit.TagInputValue("creator", html));


#endif
            #region
            //Stopwatch stopWatch = Stopwatch.StartNew();

            //GetPortalData pw = new GetPortalData();
            //string l = PortalHtml.GetListForData(htmlSOResult);
            //pw.ProcessGetPortData("");

            //stopWatch.Stop();
            //TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            //string elapsedTime = String.Format("小时{0:00}:分钟{1:00}:秒{2:00}.{3:00}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds);
            //Console.WriteLine(elapsedTime);
            #endregion
            Console.ReadLine();
        }


        private static string GetHtml(string html)
        {
            string headtag = "<SELECT name=\"ref_wo\">";
            string endtag = "</SELECT>";
            return TagHtml.ParseHtml(headtag, endtag, html);
        }

        private static string GetHtml2(string html)
        {
            string data = "act=3&";

            //彩/黑稿
            string v = "&ArtNo=" + TagInput.InputValue("ArtNo", html);

            //备库数量
            v = "&BackQty=" + TagInput.InputValue("BackQty", html);

            //箱　　麦
            v = "&BoxNo=" + TagInput.InputValue("BoxNo", html);
            //建立日期
            v = "&create_date=" + TagInput.InputValue("create_date", html);

            //制单员
            v = "&creator=" + TagInput.InputValue("creator", html);

            //特备损耗
            v = "&ExtraQty=" + TagInput.InputValue("ExtraQty", html);

            //生产车间
            v = "&Factory=" + TagSelect.SelectedValue("Factory", html);

            //等级
            v = "&level=" + TagSelect.SelectedValue("level", html);

            //材质
            v = "&material=" + TagInput.InputValue("material", html);

            //特殊要求
            v = "&memo=" + TagTextArea.TextAreaValue("memo", html);

            //订单数量
            v = "&OrderQty=" + TagInput.InputValue("OrderQty", html);

            // 分包明细
            v = "&PackNo=" + TagInput.InputValue("PackNo", html);

            //附页
            v = "&PageNo=" + TagInput.InputValue("PageNo", html);

            //大包
            v = "&pk_big=" + TagSelect.SelectedValue("pk_big", html);

            //中包
            v = "&pk_middle=" + TagSelect.SelectedValue("pk_middle", html);

            //小包
            v = "&pk_small=" + TagSelect.SelectedValue("pk_small", html);

            //包装要求
            v = "&pk_spec=" + TagTextArea.TextAreaValue("pk_spec", html);


            //订单类型
            v = "&pk_to=" + TagSelect.SelectedValue("pk_to", html);

            //po_type
            v = "&po_type=" + TagInput.InputValue("po_type", html);

            //产后业务留样
            v = "&ProdAfter=" + TagInput.InputValue("ProdAfter", html);

            //产前样
            v = "&ProdBefore=" + TagInput.InputValue("ProdBefore", html);
            //生产数量
            v = "&ProdQty=" + TagInput.InputValue("ProdQty", html);
            //损耗率
            v = "&ratio=" + TagInput.InputValue("ratio", html);

            //损耗量
            v = "&ratio2=" + TagInput.InputValue("ratio2", html);
            //ref_data
            v = "&ref_data=" + TagInput.InputValue("ref_data", html);
            //生产相关数量
            v = "&ref_qty=" + TagSelect.SelectedValue("ref_qty", html);
            //rgt_po
            v = "&rgt_po=" + TagInput.InputValue("rgt_po", html);
            //封样
            v = "&sample=" + TagSelect.SelectedValue("sample", html);
            //交期
            v = "&ship_date=" + TagInput.InputValue("ship_date", html);
            //通知单号
            v = "&wqp_no=" + TagInput.InputValue("wqp_no", html);
            //零成本仓
            v = "&ZeroQty=" + TagInput.InputValue("ZeroQty", html);
            //pcs
            //"&unit=" + 
            List<string> vt = TagInput.InputValues("unit", html);
            //备库量
            vt = TagInput.InputValues("bt_back", html);
            //
            vt = TagInput.InputValues("bt_extra", html);
            //
            vt = TagInput.InputValues("bt_id", html);
            vt = TagInput.InputValues("bt_order", html);
            vt = TagInput.InputValues("bt_ship", html);

            return "";
        }

        private static string GetHtml3(string html)
        {
            string formdata = TagForm.GetForm("WizardForm", html);
            List<string> tables = TagTable.Tables(formdata);
            foreach (string item in tables)
            {
                List<string> tds = TagTable.TDs(item);

                //生产通知单号：MN090512035--------0
                //制令单号：MO95230113---------6
                //订单状态：结单--------------21
                //订单品号和货名：(22-PMS045*065-009)PUMA条码贴纸-09新版-----------------1
                //建立日期：2009-05-22--------------22
                //生产完成日期：2009-05-27--------7
                //生产车间：二车间-----------2
                //生产数量：4096.0 罗黑妹----------10

                for (int i = 0; i < tds.Count; i++)
                {
                    Console.WriteLine("---" + i + "---" + tds[i]);
                }
                break;
            }
            return formdata;
        }
    }
}
