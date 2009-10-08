using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PortalCmd.Core.Html
{
    public class TagTable : _Tag
    {
        public static List<string> Tables(string html)
        {
            List<string> tables = new List<string>();
            string pattern_name = string.Format("<table([^<>]*)>(.*?)</table>");
            MatchCollection mc = Regex.Matches(html, pattern_name, CurrentRegexOptions);

            foreach (Match m in mc)
            {
                tables.Add(m.Groups[2].Value);
            }
            return tables;
        }
        public static List<string> TDs(string html)
        {
            List<string> tables = new List<string>();
            string pattern_name = string.Format("<td([^<>]*)>(.*?)</td>");
            MatchCollection mc = Regex.Matches(html, pattern_name, CurrentRegexOptions);

            foreach (Match m in mc)
            {
                tables.Add(m.Groups[2].Value);
            }
            return tables;
        }
        public static List<string> TRs(string html)
        {
            List<string> tables = new List<string>();
            string pattern_name = string.Format("<tr([^<>]*)>(.*?)</tr>");
            MatchCollection mc = Regex.Matches(html, pattern_name, CurrentRegexOptions);

            foreach (Match m in mc)
            {
                tables.Add(m.Groups[2].Value);
            }
            return tables;
        }
        public static List<string> THs(string html)
        {
            List<string> tables = new List<string>();
            string pattern_name = string.Format("<th([^<>]*)>(.*?)</th>");
            MatchCollection mc = Regex.Matches(html, pattern_name, CurrentRegexOptions);

            foreach (Match m in mc)
            {
                tables.Add(m.Groups[2].Value);
            }
            return tables;
        }
    }
}
