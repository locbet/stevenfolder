using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace ShopWeb._WebUI
{
    public class BasePage : System.Web.UI.Page
    {
        protected static readonly ILog Log = LogManager.GetLogger(typeof(BasePage));

        public BasePage()
        {
            //Trace.Warn("ctor");
        }
        protected override void OnLoad(EventArgs e)
        {
            //Trace.Warn("ProcessPage");
            ProcessPage();
            base.OnLoad(e);
        }
        protected virtual string ShowHeader()
        {
            //Trace.Warn("ShowHeader");
            return "";
        }
        protected virtual string ShowFooter()
        {
            //Trace.Warn("ShowFooter");
            return "";
        }
        protected virtual void ProcessPage()
        {

        }
    }
}