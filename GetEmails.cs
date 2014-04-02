using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CraigslistSpammer
{
    class GetEmails
    {
        List<string> urls = null;
        public GetEmails(List<string> data)
        {
            urls = data;
        }

        public List<string> Retrieve()
        {
            List<string> data = null;
            foreach (var item in urls)
            {
                string x = "http://seattle.craigslist.org" + item;

                if (IsValidUrl(x))
                    data = Addresses(x);
            }
            return data;
        }

        private List<string> Addresses(string url)
        {
            List<string> list = new List<string>();
           
            WebClient w = new WebClient();

             string file = w.DownloadString(url);
        
            // 1.
            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<li.*?>.*?</li>)",
                RegexOptions.Singleline);

            // 2.
            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                string i = null;

                // 3.
                // Get href attribute.
                Match m2 = Regex.Match(value, @"value=""(.*?)""",
                    RegexOptions.Singleline);
                if (m2.Success)
                {
                    i = m2.Groups[1].Value;
                }

                list.Add(i);
            }
            return list;
        }


        private bool IsValidUrl(string url)
        {
            try
            {
                WebRequest req = WebRequest.Create(url);
                WebResponse res = req.GetResponse();
                return true;

            }
            catch
            {
              
                return false;
                
            }
        }

    }
}
