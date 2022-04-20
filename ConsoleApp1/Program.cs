using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        private static string website = "https://dev.by";

        static async Task Main(string[] args)
        {
            var anInstanceofProgramClass = new Program();
            await anInstanceofProgramClass.showAsyncTime(website);
        }

        public async Task showAsyncTime(string url)
        {
            while (true)
            {   
                var sw = new Stopwatch();
                sw.Restart();
                await client.GetStringAsync(url);
                sw.Stop();

                Console.WriteLine($"Response time of the requested website '{website}' is {sw.ElapsedMilliseconds}");

                Thread.Sleep(1000);
            }
        }

    }

}
