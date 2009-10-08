using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DocumentSpider.Html
{
   public class TagSelect:_Tag
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        private static Dictionary<string, string> Options(string html)
        {
            string pattern = "<OPTION([^<>]*)value=\"([^\"]*)\"([^<>]*)>(.*?)</OPTION>";

            Dictionary<string, string> list = new Dictionary<string, string>();

            MatchCollection mc = Regex.Matches(html, pattern, CurrentRegexOptions);
            for (int i = 0; i < mc.Count; i++)
            {
                list.Add(mc[i].Groups[2].Value, mc[i].Groups[4].Value);
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string OptionValue(string html)
        {
            string pattern = "<OPTION([^<>]*)value=\"([^\"]*)\"([^<>]*)>(.*?)</OPTION>";
            MatchCollection mc = Regex.Matches(html, pattern, CurrentRegexOptions);
            for (int i = 0; i < mc.Count; i++)
            {
                if (mc[i].Groups[0].Value.IndexOf("selected", StringComparison.OrdinalIgnoreCase) > 0)
                {
                    return mc[i].Groups[2].Value;
                }
            }
            if (mc.Count > 0)
            {
                return mc[0].Groups[2].Value;
            }
            return "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string InnerHtml(string html, string name)
        {
            string pattern_name = string.Format("<SELECT([^<>]*)name\\s*=\\s*[\"']?{0}[\"'\\s]+([^<>]*)>(.*?)</SELECT>", name);
            Match m = Regex.Match(html, pattern_name, CurrentRegexOptions);
            return m.Groups[3].Value;
        }

        public static Dictionary<string, string> SelectOptions(string html,string name)
        {
            string pattern_name = string.Format("<SELECT([^<>]*)name\\s*=\\s*[\"']?{0}[\"'\\s]+([^<>]*)>(.*?)</SELECT>", name);
            Match m = Regex.Match(html, pattern_name, CurrentRegexOptions);
            string options = m.Groups[3].Value;
            return Options(options);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string SelectedValue(string html,string name)
        {
            string newhtml = InnerHtml(name, html);
            return OptionValue(newhtml);
        }
    }
}
