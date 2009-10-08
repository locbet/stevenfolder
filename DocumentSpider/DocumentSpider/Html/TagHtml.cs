using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DocumentSpider.Html
{
    public class TagHtml : _Tag
    {
        /// <summary>
        /// 取html中匹配的多个值
        /// </summary>
        /// <param name="start">开始Html Tag</param>
        /// <param name="end">结束Html Tag</param>
        /// <param name="html">被匹配的html源</param>
        /// <returns>返回匹配多个的集合值</returns>
        /// <example>
        /// 如果html为:<td>abc</td>
        /// <code>
        /// string a=@"<td>abc</td>";
        /// List<string> result=GetHtmls("<td>","</td>",a);
        /// </code>
        /// </example>
        public static List<string> ParseHtmls(string html,string start, string end)
        {
            List<string> list = new List<string>();
            try
            {
                //匹配URL的模式,并分组
                string pattern = string.Format("{0}(.*?){1}", start, end);

                //满足pattern的匹配集合
                MatchCollection mc = Regex.Matches(html, pattern, CurrentRegexOptions);
                if (mc.Count > 0)
                {
                    foreach (Match match in mc)
                    {
                        GroupCollection gc = match.Groups;
                        list.Add(gc[1].Value);
                    }
                }
            }
            catch { }
            return list;
        }

        /// <summary>
        ///取html中匹配的一个值
        /// </summary>
        /// <param name="start">开始html Tag</param>
        /// <param name="end">结束html Tag</param>
        /// <param name="html">被匹配的html源</param>
        /// <returns>返回单个匹配的值</returns>
        /// <example>
        /// 如果html数据源为:<td>test</td>
        /// <code>
        /// string a=@"<td>test</td>";
        /// string result=ParseHtml("<td>","</td>",a);
        /// </code>
        /// </example>
        public static string ParseHtml(string html,string start, string end)
        {
            string ret = string.Empty;
            try
            {
                //匹配URL的模式,并分组
                string pattern = string.Format("{0}(.*?){1}", start, end);
                Match m = Regex.Match(html, pattern, CurrentRegexOptions);
                ret = m.Groups[1].Value;
            }
            catch { }

            return ret;
        }
    }
}
