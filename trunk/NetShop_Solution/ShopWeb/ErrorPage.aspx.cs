using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopWeb._WebUI;

namespace ShopWeb
{
    public partial class ErrorPage : BasePage
    {
        protected override void ProcessPage()
        {
            Exception objExp = Server.GetLastError();
            if (objExp != null)
            {
                Log.Error(string.Format("\r\n客户机IP:{0}\r\n错误地址:{1}\r\n异常信息:{2}", Request.UserHostAddress, Request.Url, objExp.Message), objExp);
            }
        }
    }
}