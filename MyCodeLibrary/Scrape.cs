using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            //WebClient client = new WebClient();
            //return client.DownloadString(url);
            return GetWebpage(url);

           
        }
        public string ScrapeWebpage(string url, string filepath, string reply)
        {
            //  WebClient client = new WebClient();


            //string reply = client.DownloadString(url);

            File.WriteAllText(filepath,
reply);

            string reply = GetWebpage(url);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new();
            return client.DownloadString(url);
        }
    }
}
