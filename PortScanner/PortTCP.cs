using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Net;
using static System.Console;


namespace PortScanner
{
    class PortTCP
    {
        static void TcpConnect(string Host, int Port){
            TcpClient tcp = new TcpClient();
            try{
                tcp.Connect(Host, Port); 
                WriteLine($"The port {Port} is active");
                tcp.Close();
            }catch{
                //WriteLine(e.Message);
                //WriteLine($"The port {Port} is close");
                }      
        }
        static void Main(string[] args)
        {
            string Host = "216.30.196.132";
            int PortStart = 1;
            int PortStop = 65535;
           
               
            void start(string host, int PortStart, int PortStop){
                for (int Port = PortStart; Port <= PortStop; Port++)
                {
                    Thread hilo = new Thread(()=>TcpConnect(host, Port));
                    hilo.Start();
                    //hilo.Join();  
                } 
                WriteLine("DONE!"); 
             
            }
            start(Host, PortStart, PortStop);
        }
    }
}

