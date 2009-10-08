using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PortalCmd.Core;
using System.Text.RegularExpressions;

namespace PortalCmd.Web
{
    public class BasePortalWeb
    {
        protected RegexOptions CurrentRegexOptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
        protected WebSpider spider = null;
        public BasePortalWeb()
        {
            spider = new WebSpider();
        }
        /// <summary>
        /// 登录Portal
        /// </summary>
        public virtual string Login(string username, string password)
        {
            string url = "http://192.168.3.11:5666/PortalManager";
            string postData = string.Format("_ACTION=LOGON&vh_user={0}&vh_password={1}", username, password); ;
            return spider.PostPage(url, postData);
        }        
    }
}
