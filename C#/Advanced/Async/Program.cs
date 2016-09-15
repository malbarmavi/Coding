using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(GetWebSiteHtml("http://google.com").GetAwaiter().GetResult());
      Console.ReadKey();
    }


    static async Task<String> GetWebSiteHtml(string url) => await new WebClient().DownloadStringTaskAsync(url);
  }
}
