using System;
using System.IO;
using static System.Console;
using static System.IO.Directory;
using static System.Environment;
using static System.IO.Path;
using System.Net;
using System.Net.NetworkInformation;

namespace CosasOvidadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            //OutputFileSystemInfo();
            RecursosDeRed();

            OutputFileSystemInfo();
        }

        static void OutputFileSystemInfo(){
            WriteLine("{0,-33} {1}", "Path.PathSeparator", PathSeparator);
            WriteLine("{0,-33} {1}", "Path.DirectorySeparatorChar", DirectorySeparatorChar);
            WriteLine("{0,-33} {1}", "Path.GetCurrentDirectory()", GetCurrentDirectory());
            WriteLine("{0,-33} {1}", "Path.CurrentDirectory", CurrentDirectory);
            WriteLine("{0,-33} {1}", "Path.SystemDirectory", SystemDirectory);
            WriteLine("{0,-33} {1}", "Path.GetTempPath()", GetTempPath());
            WriteLine("GetFolderPath(SpecialFolder");
            WriteLine("{0,-33} {1}", ".System)", GetFolderPath(SpecialFolder.System));
            WriteLine("{0,-33} {1}", ".ApplicationData)", GetFolderPath(SpecialFolder.ApplicationData));
            WriteLine("{0,-33} {1}", ".MyDocuments)", GetFolderPath(SpecialFolder.MyDocuments));
            WriteLine("{0,-33} {1}", ".Personal)", GetFolderPath(SpecialFolder.Personal));
        }

        static void RecursosDeRed(){
            Write("Introduce una url válida:");
            string url = ReadLine();
            if(string.IsNullOrWhiteSpace(url)){
                url = "https://www.disney.es";
            }
            var uri = new Uri(url);
            WriteLine($"URL: {url}");
            WriteLine($"Scheme: {uri.Scheme}");
            WriteLine($"Port: {uri.Port}");
            WriteLine($"Host: {uri.Host}");
            WriteLine($"Path: {uri.AbsolutePath}");
            WriteLine($"Query: {uri.Query}");

            // Obtener la direccion ip del host
            IPHostEntry entrada = Dns.GetHostEntry(uri.Host);
            WriteLine($"{entrada.HostName} tiene la siguiente dirección:");
            foreach (IPAddress direccion in entrada.AddressList)
            {
                WriteLine($" {direccion}");
            }

            try
            {
                var ping = new Ping();
                WriteLine("Pinging al servidor. Por favor espera...");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
