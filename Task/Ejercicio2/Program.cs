using System;
using static System.Console;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace Ejercicio2
{
    class Program
    {
        static Random r = new Random();
        static string Mensaje; //Recurso compartido

        static object bloqueador = new object(); // Proteje el procedimiento para que sea secuencial;

        static void MetodoA(){
            lock(bloqueador){
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(r.Next(2000));
                    Mensaje +="A";
                    Write(".");
                    
                }
            }
        }

        static void MetodoB(){
            lock(bloqueador){
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(r.Next(2000));
                    Mensaje +="B";
                    Write("_");
                }
            }
        }
        static void Main(string[] args)
        {
           
           WriteLine("Por favor, espera a que se completen las tareas");
           Stopwatch temporizador = Stopwatch.StartNew();
           Task TareaA = Task.Factory.StartNew(MetodoA);
           Task TareaB = Task.Factory.StartNew(MetodoB);
           Task.WaitAll(new Task[]{TareaA,TareaB});
           WriteLine();
           WriteLine($"Resultado: {Mensaje}");
           WriteLine($"{temporizador.ElapsedMilliseconds: #,##0} transcurridos");
        }
    }
}
