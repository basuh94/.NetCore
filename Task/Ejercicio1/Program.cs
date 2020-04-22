using System;
using static System.Console;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace Ejercicio1
{
    class Program
    {
        static void MetodoA(){
            WriteLine("Empiezo metodo A");
            Thread.Sleep(3000);
            WriteLine("Metodo A terminado");
        }

        static void MetodoB(){
            WriteLine("Empiezo metodo B");
            Thread.Sleep(2000);
            WriteLine("Metodo B terminado");
        }
        static void MetodoC(){
            WriteLine("Empiezo metodo C");
            Thread.Sleep(1000);
            WriteLine("Metodo C terminado");
        }

        // Tareas Anidadas Metodos
        static void MetodoExterno(){
            WriteLine("Comienza el metodo Externo...");
            var inner = Task.Factory.StartNew(MetodoInterno, TaskCreationOptions.AttachedToParent);// TaskCreationOptions.AttachedToParent Hace un Wait en el MetodoInterno 
            WriteLine("Termina el metodo Externo");
        }

        static void MetodoInterno(){
            WriteLine("Comienza el metodo Interno...");
            Thread.Sleep(2000);
            WriteLine("Termina el metodo Interno");
        }
        static void Main(string[] args)
        {
            var temporizador = Stopwatch.StartNew();
            WriteLine("Corriendo método sincrono en un solo hilo");
            MetodoA();
            MetodoB();
            MetodoC();
            WriteLine($"{temporizador.ElapsedMilliseconds: #,##0} ms transcurridos");


            // Funciones lanzadas desde las tareas
            var temporizadorTask = Stopwatch.StartNew();
            Task TareaA = new Task(MetodoA);
            TareaA.Start();
            Task TareaB = Task.Factory.StartNew(MetodoB);
            Task TareaC = Task.Run(new Action(MetodoC));
            Task[] Tareas = {TareaA,TareaB,TareaC};
            //Task.WaitAll(Tareas);
            Task.WaitAny(Tareas);
            WriteLine($"{temporizadorTask.ElapsedMilliseconds: #,##0} ms transcurridos de las tareas.");

            //Tareas Anidadas 
            var Externo = Task.Factory.StartNew(MetodoExterno);
            Externo.Wait();
            WriteLine("La aplicación de consola se ha detenido");
        }
    }
}
