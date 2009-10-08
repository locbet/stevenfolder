using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace PortalCmd.Core
{
    /// <summary>
    /// 模拟操作Web的类,美名:web蜘蛛
    /// </summary>
    public class WebSpider
    {
        //Cookie容器
        private CookieContainer cookieContainer = null;

        public WebSpider()
        {
            cookieContainer = new CookieContainer();
        }
        /// <summary>
        /// Post 方法提交网页数据
        /// </summary>
        /// <param name="strURL">提交的URL</param>
        /// <param name="strArgs">提交数据的参数</param>
        /// <returns>返回UTF-8的html源数据</returns>
        /// <example>
        /// 如登录:"http://192.168.3.11:5666/portalmanager"网站
        /// <code>
        ///  WebSpider pw = new WebSpider();
        /// //登录
        /// string url = "http://192.168.3.11:5666/portalmanager";
        /// string postData = "_ACTION=LOGON&vh_user=adm&vh_password=1111";
        /// pw.PostPage(url, postData);
        /// </code>
        /// </example>
        public string PostPage(string strURL, string strArgs)
        {
            try
            {
                Uri pageUrl = new Uri(strURL);
                string postData = strArgs;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(pageUrl);
                myWebRequest.ContentType = "application/x-www-form-urlencoded";
                myWebRequest.CookieContainer = cookieContainer;
                myWebRequest.Method = "POST";
                myWebRequest.ContentLength = byteArray.Length;
                Stream newStream = myWebRequest.GetRequestStream();
                // Send the data.
                newStream.Write(byteArray, 0, byteArray.Length);
                newStream.Close();

                WebResponse myWebResponse = myWebRequest.GetResponse();

                using (StreamReader sr = new StreamReader(myWebResponse.GetResponseStream(), Encoding.UTF8))
                {
                    string strResult = sr.ReadToEnd();
                    sr.Close();
                    return strResult;
                }
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// Get 方法获取网页数据
        /// </summary>
        /// <param name="strURL">提交的URL</param>
        /// <returns>返回UTF-8的html源数据</returns>
        /// <example>
        /// 提交网址:http://192.168.3.11:5666/PortalManager?pk=erp&mtb=1&pg=erp_pmc&pl=erp_p4001&tb=2&pn=erp_p4002"
        /// <code>
        /// string html = GetPage("http://192.168.3.11:5666/PortalManager?pk=erp&mtb=1&pg=erp_pmc&pl=erp_p4001&tb=2&pn=erp_p4002");
        /// </code>
        /// </example>
        public string GetPage(string strURL)
        {
            try
            {
                Uri pageUrl = new Uri(strURL);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(pageUrl);
                myWebRequest.ContentType = "text/html";
                myWebRequest.Method = "GET";
                myWebRequest.CookieContainer = cookieContainer;

                HttpWebResponse response = (HttpWebResponse)myWebRequest.GetResponse();
                using (System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    string strResult = sr.ReadToEnd();
                    sr.Close();
                    return strResult;
                }
            }
            catch { return ""; }
        }
    }
}
