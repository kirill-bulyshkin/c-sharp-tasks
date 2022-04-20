// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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
        //private static async Task ProcessRepositories()
        //{
        //    //client.defaultrequestheaders.accept.clear();
        //    //client.defaultrequestheaders.accept.add(
        //    //new mediatypewithqualityheadervalue("application/vnd.github.v3+json"));
        //    //client.defaultrequestheaders.add("user-agent", ".net foundation repository reporter");

        //    var stringTask = client.GetStringAsync("https://dev.by");

        //    var msg = await stringTask;
        //    Console.Write(msg);
        //}

        static async Task Main(string[] args)
        {
            //await ProcessRepositories();
            var anInstanceofProgramClass = new Program();
            await anInstanceofProgramClass.showAsyncTime("https://dev.by");
            //await showAsyncTime("https://dev.by");
        }

        public async Task showAsyncTime(string url)
        {
            var sw = new Stopwatch();
            sw.Restart();
            await client.GetStringAsync(url);
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);
        }

    }
}
