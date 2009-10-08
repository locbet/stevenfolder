﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PortalCmd.Core.Html
{
    public class TagForm : _Tag
    {
        public static string GetForm(string name, string html)
        {
            string pattern_name = string.Format("<FORM([^<>]*)name\\s*=\\s*[\"']?{0}[\"'\\s]+([^<>]*)>(.*?)</FORM>", name);
            Match m = Regex.Match(html, pattern_name, CurrentRegexOptions);
            return m.Groups[3].Value;
        }
    }
}
