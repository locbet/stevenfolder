using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Text;

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
            List<string> lst_hotkeyword = new List<string>();//。 HotKeyWordBLL.GetHotKeyWords();

            StringBuilder sb = new StringBuilder();
            foreach (string item in lst_hotkeyword)
            {
                sb.AppendFormat("<a href=\"Search.aspx?keyword={0}\">{1}</a>", HttpUtility.UrlEncode(item), item);
            }
            this.litKeyWords.Text = sb.ToString();

        }
        public string KeyWord
        {
            get
            {
                string _keyword=Request.QueryString["keyword"];
                if (!string.IsNullOrEmpty(_keyword))
                {
                    return _keyword;
                }
                else
                {
                    return "E66";
                }
            }
        }
    }
}
