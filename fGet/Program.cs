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
            if (args.Length > 0)
            {
                Console.WriteLine(DownloadUrl(args[0]));
            }
        }

        public static string DownloadUrl(string url)
        {
            string sContents = string.Empty;
            try
            {
                if (url.ToLower().IndexOf("http:") > -1)
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(url);
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
