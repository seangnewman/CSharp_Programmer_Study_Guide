using System.Net.Http;

namespace Chapter8_URL
{
    public static class HTMLUtilities
    {
        public static string ReturnHTML(string url)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                using (HttpContent content = response.Content)
                {
                    return content.ReadAsStringAsync().Result;
                }
            }

            return string.Empty;
        }
    }
}
