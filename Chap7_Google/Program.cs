using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chap7_Google
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> htmlString = ReturnHTML;

            string name = "https://www.google.com";

            Console.WriteLine(htmlString(name));

        }

        public  static string ReturnHTML( string url)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                    using(HttpContent content = response.Content)
                {
                    return content.ReadAsStringAsync().Result;
                }
            }

            return string.Empty;
        }
    }
}
