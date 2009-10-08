using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DocumentSpider.Html
{
    public class TagInput : _Tag
    {
        /// <summary>
        /// 匹配按照名字的输入框
        /// </summary>
        /// <param name="name"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string InputValue(string html,string name)
        {
            string pattern_name = string.Format("<input([^<>]*)name\\s*=\\s*[\"']?{0}[\"'\\s]+([^<>]*)", name);

            string pattern_value = "value\\s*=\\s*[\"']?([^\"']*)[\"']?";

            Match m = Regex.Match(html, pattern_name, CurrentRegexOptions);

            Match mvalue = Regex.Match(m.Groups[1].Value, pattern_value, CurrentRegexOptions);
            if (!mvalue.Success)
            {
                mvalue = Regex.Match(m.Groups[2].Value, pattern_value, CurrentRegexOptions);
            }
            return mvalue.Groups[1].Value;
        }
        public static List<string> InputValues(string html,string name)
        {
            List<string> list = new List<string>();
            string pattern_name = string.Format("<INPUT([^<>]*)name\\s*=\\s*[\"']?{0}[\"'\\s]+([^<>]*)", name);

            string pattern_value = "value\\s*=\\s*[\"']?([^\"']*)[\"']?";

            MatchCollection mc = Regex.Matches(html, pattern_name, CurrentRegexOptions);

            foreach (Match m in mc)
            {
                Match mvalue = Regex.Match(m.Groups[1].Value, pattern_value, CurrentRegexOptions);
                if (!mvalue.Success)
                {
                    mvalue = Regex.Match(m.Groups[2].Value, pattern_value, CurrentRegexOptions);
                }
                list.Add(mvalue.Groups[1].Value);
            }

            return list;
        }
    }
}