using System;
using static System.Console;
using System.Collections;
using static System.Environment;


namespace Ejercicio1
{
    class Persona { // Clase
        public string Nombre;
        public int Edad;
        public string NIF;
        void Cumpleaños(){ //Metodo
            Edad++;
        }
        public Persona(string nombre, int edad, string nif){  //Constructor
            Nombre = nombre;
            Edad = edad;
            NIF = nif;
        }
    }
    class coches{
        public string marca;
        public string modelo;
        public string matricula;
        public string bastidor;
        
        public coches(string Marca, string Modelo, string Matricula, string Bastidor){
            marca = Marca;
            modelo = Modelo;
            matricula = Matricula;
            bastidor = Bastidor;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Clear();
           /*Persona niño = new Persona("Pablo", 10, "232847dk");
           Persona niño1 = new Persona("Pepe", 20, "22323447Af");
           Persona niño2 = new Persona("Juan", 30, "328912sdsDd");
           WriteLine($"{niño.Nombre} {niño.Edad} {niño.NIF}");
           WriteLine($"{niño1.Nombre} {niño1.Edad} {niño1.NIF}");
           WriteLine($"{niño2.Nombre} {niño2.Edad} {niño2.NIF}");
            coches coche = new coches("Seat", "Ibiza", "K120D", "11133329DK");
            coches coche1 = new coches("Opel", "Corsa", "Z160R", "112344USK");
            coches coche2 = new coches("Renault", "Clio", "H129S", "1327128YJ");
            coches coche3 = new coches("Coche", "Picapiedras", "P4BL0", "P1C4P13DR4");
            
            WriteLine($"Coche 1:{coche.marca} {coche.modelo} {coche.matricula} {coche.bastidor}");
            WriteLine($"Coche 2:{coche1.marca} {coche1.modelo} {coche1.matricula} {coche1.bastidor}");
            WriteLine($"Coche 3:{coche2.marca} {coche2.modelo} {coche2.matricula} {coche2.bastidor}");
            WriteLine($"Coche 4:{coche3.marca} {coche3.modelo} {coche3.matricula} {coche3.bastidor}");*/

          

        Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);

        Console.WriteLine("ExitCode: {0}", Environment.ExitCode);

        Console.WriteLine("HasShutdownStarted: {0}", Environment.HasShutdownStarted);

        Console.WriteLine("MachineName: {0}", Environment.MachineName);

        Console.WriteLine("NewLine: {0}  first line{0}  second line{0}  third line", Environment.NewLine);

        Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());

        Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);

        Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);

        Console.WriteLine("TickCount: {0}", Environment.TickCount);
      
        Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);

        Console.WriteLine("UserInteractive: {0}", Environment.UserInteractive);

        Console.WriteLine("UserName: {0}", Environment.UserName);

        Console.WriteLine("Version: {0}", Environment.Version.ToString());

        Console.WriteLine("WorkingSet: {0}", Environment.WorkingSet);
        
        Console.WriteLine("Direcotrio Temporal: {0}", Environment.GetEnvironmentVariable("TEMP"));

        Console.WriteLine("GetLogicalDrives: {0}", Environment.GetLogicalDrives());

        TimeSpan elapsedSpan = new TimeSpan(WorkingSet);
        WriteLine("Minuto Encendidos: {0:N2}",elapsedSpan.TotalMinutes);
            
            

        }
            
    }
}

