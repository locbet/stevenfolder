using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace ShopWeb._WebUI
{
    public abstract class BasePage : System.Web.UI.Page
    {
        protected static readonly ILog Log = LogManager.GetLogger(typeof(BasePage));

        public BasePage()
        {
        }
        protected abstract void PageLoad(EventArgs e);
        protected override void OnLoad(EventArgs e)
        {
            PageLoad(e);
            base.OnLoad(e);
        }
    }
}