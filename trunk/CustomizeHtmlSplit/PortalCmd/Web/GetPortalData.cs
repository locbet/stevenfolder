using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PortalCmd.Core;
using System.Text.RegularExpressions;
using System.Collections;
using PortalCmd.Core.Html;

namespace PortalCmd.Web
{
    //天心订单号：SO95220266
    //产品编号：22-PMS045*065-009
    //生产通知单号：MN090700026
    //生产状态：提交
    //建立日期：2009-07-09
    //预计交期：2009-07-13
    //生产数量：4096.0 PCS

    /// <summary>
    /// 功能是采用
    /// </summary>
    public class GetPortalData : BasePortalWeb
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="so"></param>
        public void ProcessGetPortData(string so)
        {
            #region ---------登录---------

            Login("yin.zhu", "1234");
            #endregion

            #region -----选择订单---------
            //so = "SO96160045";
            so = "SO95220266";
            string gethtml = SearchSO(so);
            #endregion

            #region  ------选择货品/注册数据-----------
            string data = "act=2&itm=1&po_type=SO&rgt_po=NOTRGT";

            data += "&ref_data=" + TagSelect.SelectedValue("ref_data", gethtml);


            //Dictionary<string, string> ref_data = GetRefData(gethtml);

            //foreach (KeyValuePair<string, string> item in ref_data)
            //{
            //    data += "&ref_data=" + item.Key;
            //    break;
            //}
            data += "&ref_item=" + TagSelect.SelectedValue("ref_item", gethtml);

            //Dictionary<string, string> ref_item = GetRefItem(gethtml);
            //foreach (KeyValuePair<string, string> item in ref_item)
            //{
            //    data += "&ref_item=" + item.Key;
            //    break;
            //}

            string ref_woselected = "";
            //Dictionary<string, string> ref_wo = GetRefWO(gethtml);
            Dictionary<string, string> ref_wo = TagSelect.SelectOptions("ref_wo", gethtml);
            foreach (KeyValuePair<string, string> item in ref_wo)
            {
                //判断是否是close状态,如果是则查询数据
                if (item.Value.Contains("--CLOSE"))
                {
                    ref_woselected = "&ref_wo=" + item.Key;
                    string postdata = data + ref_woselected;
                    string url = "http://192.168.3.11:5666/PortalManager?pk=erp&mtb=1&pg=erp_pmc&pl=erp_p4001&tb=2&pn=erp_p4002";

                    //取得相应的数据 点击下一步
                    string html = spider.PostPage(url, postdata);

                    #region  -------------编辑生产通知书---------------

                    string resulthtml = EditProduceNote(html);

                    #endregion
                    #region --------建立生产通知书(只是取得数据)--------------
                    GetResultData(resulthtml);
                    #endregion

                }
                    //如果是SUBMIT状态，则
                else if (item.Value.Contains("--SUBMIT"))
                {
                    Console.WriteLine(TagHtml.ParseHtml("\\(", "--", item.Value));
                }
            }
            #endregion
        }

        /// <summary>
        /// 查询SO号
        /// </summary> 
        private string SearchSO(string so)
        {
            //生产管理中心->拼版排模->生产通知书
            //查询SO号            
            string url = "http://192.168.3.11:5666/PortalManager?pk=erp&mtb=1&pg=erp_pmc&pl=erp_p4001&tb=2&pn=erp_p4002";
            string postData = string.Format("act=1&po_type=SO&ref_po={0}", so);
            return spider.PostPage(url, postData);
        }


        private string EditProduceNote(string html)
        {

            //string data = "";
            StringBuilder data = new StringBuilder();
            data.Append("act=3");

            //彩/黑稿
            data.Append("&ArtNo=" + TagInput.InputValue("ArtNo", html));

            //备库数量
            data.Append("&BackQty=" + TagInput.InputValue("BackQty", html));

            //箱　　麦
            data.Append("&BoxNo=" + TagInput.InputValue("BoxNo", html));
            //建立日期
            data.Append("&create_date=" + TagInput.InputValue("create_date", html));

            //制单员
            data.Append("&creator=" + TagInput.InputValue("creator", html));

            //特备损耗
            data.Append("&ExtraQty=" + TagInput.InputValue("ExtraQty", html));

            //生产车间
            data.Append("&Factory=" + TagSelect.SelectedValue("Factory", html));

            //等级
            data.Append("&level=" + TagSelect.SelectedValue("level", html));

            //材质
            data.Append("&material=" + TagInput.InputValue("material", html));

            //特殊要求
            data.Append("&memo=" + TagTextArea.TextAreaValue("memo", html));

            //订单数量
            data.Append("&OrderQty=" + TagInput.InputValue("OrderQty", html));

            // 分包明细
            data.Append("&PackNo=" + TagInput.InputValue("PackNo", html));

            //附页
            data.Append("&PageNo=" + TagInput.InputValue("PageNo", html));

            //大包
            data.Append("&pk_big=" + TagSelect.SelectedValue("pk_big", html));

            //中包
            data.Append("&pk_middle=" + TagSelect.SelectedValue("pk_middle", html));

            //小包
            data.Append("&pk_small=" + TagSelect.SelectedValue("pk_small", html));

            //包装要求
            data.Append("&pk_spec=" + TagTextArea.TextAreaValue("pk_spec", html));


            //订单类型
            data.Append("&pk_to=" + TagSelect.SelectedValue("pk_to", html));

            //po_type
            data.Append("&po_type=" + TagInput.InputValue("po_type", html));

            //产后业务留样
            data.Append("&ProdAfter=" + TagInput.InputValue("ProdAfter", html));

            //产前样
            data.Append("&ProdBefore=" + TagInput.InputValue("ProdBefore", html));
            //生产数量
            data.Append("&ProdQty=" + TagInput.InputValue("ProdQty", html));
            //损耗率
            data.Append("&ratio=" + TagInput.InputValue("ratio", html));

            //损耗量
            data.Append("&ratio2=" + TagInput.InputValue("ratio2", html));
            //ref_data
            data.Append("&ref_data=" + TagInput.InputValue("ref_data", html));
            //生产相关数量
            data.Append("&ref_qty=" + TagSelect.SelectedValue("ref_qty", html));
            //rgt_po
            data.Append("&rgt_po=" + TagInput.InputValue("rgt_po", html));
            //封样
            data.Append("&sample=" + TagSelect.SelectedValue("sample", html));
            //交期
            data.Append("&ship_date=" + TagInput.InputValue("ship_date", html));
            //通知单号
            data.Append("&wqp_no=" + TagInput.InputValue("wqp_no", html));
            //零成本仓
            data.Append("&ZeroQty=" + TagInput.InputValue("ZeroQty", html));
            //pcs
            List<string> vt = TagInput.InputValues("unit", html);
            foreach (string item in vt)
            {
                data.Append("&unit=" + item);
            }
            //备库量
            vt = TagInput.InputValues("bt_back", html);
            foreach (string item in vt)
            {
                data.Append("&bt_back=" + item);
            }
            //特备损耗
            vt = TagInput.InputValues("bt_extra", html);
            foreach (string item in vt)
            {
                data.Append("&bt_extra=" + item);
            }
            //项次
            vt = TagInput.InputValues("bt_id", html);
            foreach (string item in vt)
            {
                data.Append("&bt_id=" + item);
            }
            //订单数量
            vt = TagInput.InputValues("bt_order", html);
            foreach (string item in vt)
            {
                data.Append("&bt_order=" + item);
            }
            //生产数量
            vt = TagInput.InputValues("bt_ship", html);
            foreach (string item in vt)
            {
                data.Append("&bt_ship=" + item);
            }
            string url = "http://192.168.3.11:5666/PortalManager?pk=erp&mtb=1&pg=erp_pmc&pl=erp_p4001&tb=2&pn=erp_p4002";
            return spider.PostPage(url, data.ToString());
        }
        private void GetResultData(string html)
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
                if (tds.Count > 22)
                {
                    //tds[0];
                    //tds[1];
                    //tds[2];
                    //tds[6];
                    //tds[7];
                    //tds[10];
                    //tds[21];
                    //tds[22];
                    Console.WriteLine("------" + tds[0]);
                    Console.WriteLine("------" + tds[1]);
                    Console.WriteLine("------" + tds[2]);
                    Console.WriteLine("------" + tds[6]);
                    Console.WriteLine("------" + tds[7]);
                    Console.WriteLine("------" + tds[10]);
                    Console.WriteLine("------" + tds[21]);
                    Console.WriteLine("------" + tds[22]);
                }
                    
                break;
            }
        }
        /// <summary>
        /// 获取生产通知的号码
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        //private Dictionary<string, string> GetRefWO(string html)
        //{
        //    /*
        //    <SELECT name="ref_wo">
        //      <OPTION value="">--新建生产通知书--</OPTION>
        //      <OPTION value="MN090610787">23-NLCLI1****-001 (MN090610787--CLOSE)</OPTION>
        //      <OPTION value="MN090614092">23-NLCLDFW***-002 (MN090614092--CLOSE)</OPTION>
        //    </SELECT>
        //    */
        //    string headtag = "<SELECT name=\"ref_wo\">";
        //    string endtag = "</SELECT>";
        //    string pattern_1 = string.Format("{0}(.*?){1}", headtag, endtag);
        //    Match m = Regex.Match(html, pattern_1, CurrentRegexOptions);
        //    string source = m.Groups[1].Value;


        //    string pattern_2 = "<OPTION value=\"(.*?)\">(.*?)</OPTION>";

        //    Dictionary<string, string> list = new Dictionary<string, string>();

        //    MatchCollection mc = Regex.Matches(source, pattern_2, CurrentRegexOptions);

        //    for (int i = 0; i < mc.Count; i++)
        //    {
        //        list.Add(mc[i].Groups[1].Value, mc[i].Groups[2].Value);
        //    }
        //    return list;
        //}

        //private Dictionary<string, string> GetRefItem(string html)
        //{
        //    /*
        //    <SELECT onchange="WizardForm.itm.value=this.selectedIndex+1" name="ref_item">
        //      <OPTION value="23-NLCLDFW***-002">(23-NLCLDFW***-002) NLCLDFW NT670B白色胶带</OPTION>
        //      <OPTION value="23-NLCLI1****-001">(23-NLCLI1****-001) NLCLI1 UAE importer label 1</OPTION>
        //    </SELECT>
        //    */
        //    string headtag = "<SELECT onchange=\"WizardForm.itm.value=this.selectedIndex+1\" name=\"ref_item\">";
        //    string endtag = "</SELECT>";
        //    string pattern_1 = string.Format("{0}(.*?){1}", headtag, endtag);
        //    Match m = Regex.Match(html, pattern_1, CurrentRegexOptions);
        //    string source = m.Groups[1].Value;


        //    string pattern_2 = "<OPTION value=\"(.*?)\">(.*?)</OPTION>";

        //    Dictionary<string, string> list = new Dictionary<string, string>();

        //    MatchCollection mc = Regex.Matches(source, pattern_2, CurrentRegexOptions);

        //    for (int i = 0; i < mc.Count; i++)
        //    {
        //        list.Add(mc[i].Groups[1].Value, mc[i].Groups[2].Value);
        //    }
        //    return list;
        //}
        //private Dictionary<string, string> GetRefData(string html)
        //{
        //    /*
        //    <SELECT name="ref_data">
        //      <OPTION value="446415">23-NLCLI1****-001(SO96160045)</OPTION>
        //      <OPTION value="449974">23-NLCLDFW***-002(SO96160045)</OPTION>
        //      <OPTION value="-1">--- 无需批次变量 ---</OPTION>
        //    </SELECT>
        //    */
        //    string headtag = "<SELECT name=\"ref_data\">";
        //    string endtag = "</SELECT>";


        //    string pattern_1 = string.Format("{0}(.*?){1}", headtag, endtag);
        //    Match m = Regex.Match(html, pattern_1, CurrentRegexOptions);
        //    string source = m.Groups[1].Value;


        //    string pattern_2 = "<OPTION value=\"(.*?)\">(.*?)</OPTION>";

        //    Dictionary<string, string> list = new Dictionary<string, string>();

        //    MatchCollection mc = Regex.Matches(source, pattern_2, CurrentRegexOptions);

        //    for (int i = 0; i < mc.Count; i++)
        //    {
        //        list.Add(mc[i].Groups[1].Value, mc[i].Groups[2].Value);
        //    }
        //    return list;
        //}

        ////根据查询出SO的信息填充POST数据            
        //postData = "act=2&itm=1&po_type&SO&ref_data=430014&ref_item=22-PMS045*065-009&ref_wo=MN090512035&rgt_po=NOTRGT";
        //pw.PostPage(url, postData);
        ////File.WriteAllText("111.html", pw.PostPage(url, postData), Encoding.UTF8);

        ////根据读出的数据取得下一步操作数据
        //postData = "act=3&po_type=SO&rgt_po=NOTRGT&ref_data=430014&wqp_no=MN090512035&OrderQty=4096.0&unit=PCS&ProdQty=4096&unit=PCS&BackQty=0.0&unit=PCS&ZeroQty=0.0&unit=PCS&ExtraQty=0.0&ProdBefore=0.0&unit=PCS&ProdAfter=0.0&unit=PCS&material=&sample=1&PageNo=0&ArtNo=0&BoxNo=0&PackNo=0&Factory=%E4%BA%8C%E8%BD%A6%E9%97%B4&pk_to=I&level=G&ship_date=2009-05-27&creator=%E5%B0%B9%E7%AB%B9&create_date=2009-05-22&pk_big=&pk_middle=&pk_small=&pk_spec=&memo=&ref_qty=1&ratio=0&ratio2=0&bt_id=-1&bt_order=0&bt_ship=0&bt_back=0&bt_extra=0&bt_order=24&bt_ship=24&bt_id=7097713&bt_back=0&bt_extra=0&bt_order=146&bt_ship=146&bt_id=7097714&bt_back=0&bt_extra=0&bt_order=239&bt_ship=239&bt_id=7097715&bt_back=0&bt_extra=0&bt_order=195&bt_ship=195&bt_id=7097716&bt_back=0&bt_extra=0&bt_order=82&bt_ship=82&bt_id=7097717&bt_back=0&bt_extra=0&bt_order=43&bt_ship=43&bt_id=7097718&bt_back=0&bt_extra=0&bt_order=162&bt_ship=162&bt_id=7097719&bt_back=0&bt_extra=0&bt_order=240&bt_ship=240&bt_id=7097720&bt_back=0&bt_extra=0&bt_order=173&bt_ship=173&bt_id=7097721&bt_back=0&bt_extra=0&bt_order=51&bt_ship=51&bt_id=7097722&bt_back=0&bt_extra=0&bt_order=9&bt_ship=9&bt_id=7097723&bt_back=0&bt_extra=0&bt_order=85&bt_ship=85&bt_id=7097724&bt_back=0&bt_extra=0&bt_order=173&bt_ship=173&bt_id=7097725&bt_back=0&bt_extra=0&bt_order=157&bt_ship=157&bt_id=7097726&bt_back=0&bt_extra=0&bt_order=80&bt_ship=80&bt_id=7097727&bt_back=0&bt_extra=0&bt_order=7&bt_ship=7&bt_id=7097728&bt_back=0&bt_extra=0&bt_order=6&bt_ship=6&bt_id=7097729&bt_back=0&bt_extra=0&bt_order=80&bt_ship=80&bt_id=7097730&bt_back=0&bt_extra=0&bt_order=166&bt_ship=166&bt_id=7097731&bt_back=0&bt_extra=0&bt_order=170&bt_ship=170&bt_id=7097732&bt_back=0&bt_extra=0&bt_order=108&bt_ship=108&bt_id=7097733&bt_back=0&bt_extra=0&bt_order=5&bt_ship=5&bt_id=7097734&bt_back=0&bt_extra=0&bt_order=22&bt_ship=22&bt_id=7097735&bt_back=0&bt_extra=0&bt_order=46&bt_ship=46&bt_id=7097736&bt_back=0&bt_extra=0&bt_order=46&bt_ship=46&bt_id=7097737&bt_back=0&bt_extra=0&bt_order=21&bt_ship=21&bt_id=7097738&bt_back=0&bt_extra=0&bt_order=4&bt_ship=4&bt_id=7097739&bt_back=0&bt_extra=0&bt_order=81&bt_ship=81&bt_id=7097740&bt_back=0&bt_extra=0&bt_order=216&bt_ship=216&bt_id=7097741&bt_back=0&bt_extra=0&bt_order=242&bt_ship=242&bt_id=7097742&bt_back=0&bt_extra=0&bt_order=157&bt_ship=157&bt_id=7097743&bt_back=0&bt_extra=0&bt_order=82&bt_ship=82&bt_id=7097744&bt_back=0&bt_extra=0&bt_order=114&bt_ship=114&bt_id=7097745&bt_back=0&bt_extra=0&bt_order=225&bt_ship=225&bt_id=7097746&bt_back=0&bt_extra=0&bt_order=234&bt_ship=234&bt_id=7097747&bt_back=0&bt_extra=0&bt_order=141&bt_ship=141&bt_id=7097748&bt_back=0&bt_extra=0&bt_order=64&bt_ship=64&bt_id=7097749&bt_back=0&bt_extra=0";
        //string result = pw.PostPage(url, postData);
        //File.WriteAllText("result.html", result, Encoding.UTF8);        
    }
}