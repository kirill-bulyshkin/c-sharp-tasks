using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Reflection;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static string website = "https://dev.by/";
        private static int timeoutValue = 1000;
        private static string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string fullPath = Path.Combine(baseFolder, "ConsoleApp1_log.txt");

        static async Task Main(string[] args)
        {
            File.WriteAllText(fullPath, "");

            var task1 = showAsyncTimeOfResponse(website, timeoutValue);
            var task2 = showAsyncTimeOfResponse(website, timeoutValue);

            await Task.WhenAny(task1, task2);
        }

        static async Task showAsyncTimeOfResponse(string url, int timeoutValue)
        {
            var sw = new Stopwatch();
            while (true)
            {
                sw.Restart();
                await client.GetStringAsync(url);
                sw.Stop();
                var msg = $"Response time of the requested website '{website}' is {sw.ElapsedMilliseconds}";

                StreamWriter wrtiter = new StreamWriter(fullPath, true);
                wrtiter.WriteLine(msg);
                wrtiter.Close();

                Console.WriteLine(msg);

                Thread.Sleep(timeoutValue);
            }

        }

    }

}