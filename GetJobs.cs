using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CraigslistSpammer
{
    class GetJobs
    {

        public void Find(string url)
        {
            WebClient w = new WebClient();
            string s = w.DownloadString(url);

            foreach (LinkItem i in LinkFinder.Find(s))
            {
                Debug.WriteLine(i);
            }
        }

        public struct LinkItem
        {
            public string Href;

            public override string ToString()
            {
                return Href;
            }
        }
    }

    static class LinkFinder
    {
        public static List<CraigslistSpammer.GetJobs.LinkItem> Find(string file)
        {
            List<CraigslistSpammer.GetJobs.LinkItem> list = new List<CraigslistSpammer.GetJobs.LinkItem>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                CraigslistSpammer.GetJobs.LinkItem i = new CraigslistSpammer.GetJobs.LinkItem();

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.Href = m2.Groups[1].Value;
                }

                // 4.
                // Remove inner tags from text.
                //string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                //RegexOptions.Singleline);
                ////i.Text = t;

                list.Add(i);
            }
            return list;
        }
    }

}

    
