using System;
using System.Threading;
using static System.Console;

namespace Ejercicio2
{
    class Program
    {
        public static void HiloDeTrabajo(){
            try{
                WriteLine("Hilo de ejecución secundario iniciado.");
                WriteLine("Hilo de ejecución secundario iniciado - Contando lentamente hasta 10");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Write($"{i+1}...");
                }
                WriteLine("\nHilo de ejecución secundario terminado.");
            }
            finally{
                WriteLine("Hilo de ejecución secundario - Aquí termina este hilo");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart Trabajo = new ThreadStart(HiloDeTrabajo);
            WriteLine("Principal - Creando Hilo de ejecución secundario");
            Thread t = new Thread(Trabajo);
            t.Start();
            WriteLine("Principal inactivo durante 2 segundos");
            Thread.Sleep(2000);
            WriteLine($"\nPrincipal - Vuelve a la vida");
        }
    }
}
