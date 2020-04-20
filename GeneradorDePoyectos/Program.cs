using System;
using static System.Console;
using System.Diagnostics;


namespace GeneradorDePoyectos
{
    class Program
    {    
        static void proyecto(string[] args, string ruta){    
            WriteLine("Creando proyecto " + args[0]+"...");
            ProcessStartInfo project = new ProcessStartInfo("powershell.exe");
            project.WorkingDirectory = ruta;
            project.CreateNoWindow = true;
            project.Arguments =$@"dotnet new console -n {args[0]} | dotnet new classlib -o {args[0]}\{args[1]}";
            Process proceso = Process.Start(project);
            proceso.WaitForExit();
            WriteLine("Proyecto creado!");       
        }
     
        static void Main(string[] args)
        {   
            string ruta=@"F:\.Net\";
            proyecto(args,ruta);
            
        }
    }
}
