using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ReadJasonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var configurationBuilder = new ConfigurationBuilder ();
            configurationBuilder.SetBasePath (Directory.GetCurrentDirectory ());
            configurationBuilder.AddJsonFile ("testdata.json", optional : true, reloadOnChange : true);
 
            IConfigurationRoot configuration = configurationBuilder.Build ();
 
            Console.WriteLine (configuration.GetConnectionString ("SqlDB"));
            Console.WriteLine (configuration.GetConnectionString ("OracleDB"));
            Console.WriteLine (configuration.GetConnectionString ("MangoDB"));
            Console.WriteLine (configuration.GetSection ("ApplicationUnderTest:Qa").Value);
            Console.WriteLine (configuration.GetSection ("ApplicationUnderTest:Stage").Value);
            Console.WriteLine (configuration.GetSection ("ApplicationUnderTest:Prod").Value);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings:SqlDB").Value);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings:OracleDB").Value);
            Console.WriteLine (configuration.GetSection ("Connectionstrings:MangoDB").Value);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings") ["SqlDB"]);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings") ["OracleDB"]);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings") ["MangoDB"]);
        }
    }
}
