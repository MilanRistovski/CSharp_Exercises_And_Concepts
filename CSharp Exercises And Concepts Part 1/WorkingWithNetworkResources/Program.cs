using System;
using System.Net;
using System.Net.NetworkInformation;

namespace WorkingWithNetworkResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid web address:");
            string url = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(url))
            {
                url = "https://world.episerver.com/cms/?q=pagetype";
            }
            var uri = new Uri(url);

            Console.WriteLine($"URL: {url}");
            Console.WriteLine($"Scheme: {uri.Scheme}");
            Console.WriteLine($"Port: {uri.Port}; Host: {uri.Host}; Path:{uri.AbsolutePath}; Query: {uri.Query}");

            IPHostEntry entry = Dns.GetHostEntry(uri.Host);
            Console.WriteLine($"{entry.HostName} has the following IP adresses:");
            foreach (IPAddress address in entry.AddressList)
            {
                Console.WriteLine($"{address}");
            }

            // SERVER PINGING

            try
            {
                var ping = new Ping();
                Console.WriteLine("Pinging server, please wait...");
                PingReply reply = ping.Send(uri.Host);
                Console.WriteLine($"{uri.Host} was pinged and replied: {reply.Status}");

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Reply from {reply.Address} took {reply.RoundtripTime}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType().ToString()} says {ex.Message}");
            }
        }
    }
}
