using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fGet
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = "";
            var url = "";
            
            if (args.Length > 0)
            {
                foreach (var arg in args.Where(arg => arg.StartsWith("http")))
                {
                    url = arg;
                }
                output = DownloadUrl(url);
            }
            Console.WriteLine(output);
        }

        public static string DownloadUrl(string url)
        {
            var sContents = "";
            try
            {
                if (url.ToLower().IndexOf("http:") > -1)
                {
                    var wc = new System.Net.WebClient();
                    var response = wc.DownloadData(url);
                    sContents = System.Text.Encoding.ASCII.GetString(response);
                }
            }
            catch (Exception)
            {
                sContents = "";
            }
            return sContents;
        }
    }
}
