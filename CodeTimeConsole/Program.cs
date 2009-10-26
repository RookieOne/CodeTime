using System;
using System.IO;
using System.Net;

namespace CodeTimeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Get();

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        static void Post()
        {
            
        }

        static void Get()
        {
            var request = WebRequest.Create("http://localhost:1198/myZip.zip")
              as HttpWebRequest;

            var response = request.GetResponse();

            var stream = response.GetResponseStream();

            var reader = new StreamReader(stream);

            var fileStream = new FileStream(@"C:\temp\", FileMode.Create);

            var writer = new StreamWriter(fileStream);

            while (!reader.EndOfStream)
            {
                var output = reader.ReadLine();
                Console.WriteLine(output);
            }
        }       
    }
}