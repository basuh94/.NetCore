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
        static void TcpConnect(string host, int portStart, int portStop){
            int Port;
            
            for (Port = portStart ; Port <= portStop; Port++)
            {
                TcpClient tcp = new TcpClient();
                try{
                    tcp.Connect(host, Port); 
                    WriteLine($"The port {Port} is active");
                    tcp.Close();
                }catch{
                    //WriteLine(e.Message);
                }  
            }    
        }
        static void Main(string[] args)
        {
            string Host = "216.30.196.132";
            int PortStart = 22;
            int PortStop = 65535;
            int NumThread =200;
               
            void run(){
                TcpConnect(Host,PortStart,PortStop);
            }
            
            void start(int numThread){
                ThreadStart delegadoth = new ThreadStart(run);
                Thread hilo = new Thread(delegadoth);
                hilo.Start();
            }
            start(NumThread);
        }
    }
}

