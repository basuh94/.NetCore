using System;
using static System.Console;
using System.Net.NetworkInformation;
namespace ScanNetwork
{
    class Program
    {
        public static void ShowNetworkInterfaces(){
            IPGlobalProperties ComputerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            WriteLine("Domain Name: {0} \t Host Name: {1}",ComputerProperties.DomainName, ComputerProperties.HostName);

            if (nics == null || nics.Length < 1){
                WriteLine("  No network interfaces found.");
                return;
            }else{
            WriteLine("Number of interfaces: {0}", nics.Length);
            }

            foreach(NetworkInterface adapter in nics){
                IPInterfaceProperties properties = adapter.GetIPProperties();
                WriteLine();
                WriteLine(adapter.Description);
                WriteLine(String.Empty.PadLeft(adapter.Description.Length,'='));
                Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                Console.WriteLine("  Physical Address ........................ : {0}", adapter.GetPhysicalAddress().ToString());
                Console.WriteLine("  Operational status ...................... : {0}", adapter.OperationalStatus);

            }

        }
        static void Main(string[] args){
            Clear();
            ShowNetworkInterfaces();
         
        }
    }
}
