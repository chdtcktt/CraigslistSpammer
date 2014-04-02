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

        public static List<string> Find(string url)
        {
            WebClient w = new WebClient();
            string file = w.DownloadString(url); 


            List<string> list = new List<string>();

            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                string i = null;

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                RegexOptions.Singleline);
                if (m2.Success)
                {
                    i = m2.Groups[1].Value;
                }

                list.Add(i);
            }
            return list;
        }
    }

}

    
