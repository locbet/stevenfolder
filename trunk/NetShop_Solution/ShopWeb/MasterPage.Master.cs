using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;

namespace ShopWeb
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected override void OnLoad(EventArgs e)
        {
            InitPageData();
            base.OnLoad(e);
        }
        private void InitPageData()
        {
           List<string> lst_hotkeyword= HotKeyWordBLL.GetHotKeyWords();

           this.litKeyWords.Text = "";
        }
    }
}
