using System;
using System.Threading;
using static System.Console;

namespace Ejercicio1
{
   
    class Program
    {
        public static void HiloDeTrabajo(){
            WriteLine("Hilo de ejecución secundario iniciado");
            int TiempoDormido = 5000;
            WriteLine($"\t Durmiendo durante {TiempoDormido/100} segundos");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(TiempoDormido/5);
                WriteLine($"Activandose: {i+1}");
            }
        }
        static void Main(string[] args)
        {
           ThreadStart Trabajo = new ThreadStart(HiloDeTrabajo);
           WriteLine("Principal - Creando Hilo de ejecución secundario");
           Thread t = new Thread(Trabajo);
           t.Start();
           t.Join();
           WriteLine("Principal - Hilo de ejecución secundario invocado");
       
        }
    }
}
