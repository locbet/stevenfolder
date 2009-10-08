using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DocumentSpider.Html;

namespace WebSpiderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = File.ReadAllText("../../TestHtmls/Page0.htm", Encoding.UTF8);
            //string source = GetHtml(html);
            Dictionary<string, string> keyvalue = TagSelect.SelectOptions(html, "ref_wo");

            foreach (KeyValuePair<string, string> item in keyvalue)
            {
                Console.WriteLine("key=\"{0}\"---value=\"{1}\"", item.Key, item.Value);
            }
            //  Console.WriteLine(source);

            Dictionary<string, string> kvs = TagMeta.GetKeyValues(html);
            foreach (KeyValuePair<string,string> item in kvs)
            {
                Console.WriteLine("key=\"{0}\"---value=\"{1}\"", item.Key, item.Value);
            }
            Console.ReadLine();
        }
        private static string GetHtml(string html)
        {
            string headtag = "<SELECT name=\"ref_wo\">";
            string endtag = "</SELECT>";

            return TagHtml.ParseHtml(html, headtag, endtag);
        }
    }
}
