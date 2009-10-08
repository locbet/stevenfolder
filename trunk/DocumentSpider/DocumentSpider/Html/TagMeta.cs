using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DocumentSpider.Html
{
    public class TagMeta : _Tag
    {
        public static Dictionary<string, string> GetKeyValues(string html)
        {
            string metaKey, metaValue;
            Dictionary<string, string> result = new Dictionary<string, string>();
            string regex = @"<meta\s*(?:(?:\b(\w|-)+\b\s*(?:=\s*(?:""[^""]*""|'[^']*'|[^""'<> ]+)\s*)?)*)/?\s*>";
            string regexkeyvalue = @"(?<name>\b(\w|-)+\b)\s*=\s*(""(?<value>[^""]*)""|'(?<value>[^']*)'|(?<value>[^""'<> ]+)\s*)+";
            RegexOptions regexOptions = RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture;
            MatchCollection metamatchs = Regex.Matches(html, regex, regexOptions);
            foreach (Match metamatch in metamatchs)
            {
                metaKey = String.Empty;
                metaValue = String.Empty;
                // Loop through the attribute/value pairs inside the tag
                MatchCollection submetamatchs = Regex.Matches(metamatch.Value.ToString(), regexkeyvalue, regexOptions);
                foreach (Match submetamatch in submetamatchs)
                {
                    if (!result.ContainsKey(submetamatch.Groups[1].Value))
                    {
                        result.Add(submetamatch.Groups[1].Value, submetamatch.Groups[2].Value);
                    }
                }
            }
            return result;
        }
    }
}
