using System;
using static System.Console;
using  System.Diagnostics;
using System.IO;

namespace Adelantado{
    class Program{

        static void Main(string[] args){
            WriteLine(@"Analizar Disco C:\ [C] Disco F:\ [F]  Otro directorio [*]");
            var input = ReadKey(true);
            string inicio;
            switch (input.Key)
            {
                case ConsoleKey.C:
                    inicio ="C:\\";
                 break;
                case ConsoleKey.F:
                    inicio ="F:\\";
                    break;
                default:
                    Console.WriteLine("Introduce una ruta especifica: ");
                    inicio = ReadLine();
                    break;
            }
            WriteLine("Que nombre quieres ponerle al log?: ");
            string NombreLog = ReadLine();

            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            static void Directorios(string inicio, string NombreLog){
               
                try{
                    foreach ( string direc in Directory.GetDirectories(@""+inicio+"")){
                            try{
                                foreach(string files in Directory.GetFiles(direc)){
                                    WriteLine(files +" " + new System.IO.FileInfo(files).Length + " Byte");
                                    string FilesCompleto = files +" " + new System.IO.FileInfo(files).Length + " Byte";
                                    EscribirFichero(NombreLog +".txt", FilesCompleto);
                            }
                            Directorios(direc,NombreLog);
                            }catch(Exception e){
                                WriteLine(e.Message);
                            }
                    }
                }catch(Exception e){
                    WriteLine(e.Message);
                }
                  
            }
      
            static void EscribirFichero(string ruta, string linea){
                StreamWriter EscribirFichero;
                EscribirFichero = File.AppendText(ruta);
                EscribirFichero.WriteLine(linea);
                EscribirFichero.Close();

            }
            
            Directorios(inicio,NombreLog);
            
            timeMeasure.Stop();  
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms"); 
        }
    }
}
