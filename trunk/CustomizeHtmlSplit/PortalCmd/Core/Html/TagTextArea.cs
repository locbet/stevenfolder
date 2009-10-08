using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PortalCmd.Core.Html
{
    public class TagTextArea : _Tag
    {
        /// <summary>
        /// 匹配按照名字的TextArea框
        /// </summary>
        /// <param name="name"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string TextAreaValue(string name, string html)
        {
            string pattern_name = string.Format("<TEXTAREA([^<>]*)name\\s*=\\s*[\"']?{0}[\"'\\s]+([^<>]*)>(.*?)</TEXTAREA>", name);
            Match m = Regex.Match(html, pattern_name, CurrentRegexOptions);
            return m.Groups[3].Value;
        }
    }
}
