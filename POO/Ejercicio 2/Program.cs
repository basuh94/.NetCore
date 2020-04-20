using System;
using static System.Console;
using System.IO;
using static System.Environment;

namespace Ejercicio_2
{   
    class fichero{
        public string directorio;
        public string nombreMaquina;
        public double TiempoEncendido;
        public string VersionSistema;
        public void EscribirFichero(){

            StreamWriter EscribirFichero;
            EscribirFichero = File.AppendText(directorio+@"\Fichero.txt");
            EscribirFichero.WriteLine($"Nombre Maquina: {nombreMaquina} \t Tiempo Encendido: {TiempoEncendido:N2} \t Version Sistema: {VersionSistema}  ");
            EscribirFichero.Close();
        }
        public fichero(string DIRECTORIO, string NOMBREMAQUINA, double TIEMPOENCENDIDO, string VERSIONOS){
             directorio = DIRECTORIO;
             nombreMaquina = NOMBREMAQUINA;
             TiempoEncendido = TIEMPOENCENDIDO;
             VersionSistema = VERSIONOS;
             
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan elapsedSpan = new TimeSpan(WorkingSet);
            WriteLine(Environment.GetEnvironmentVariable("TEMP"));
            fichero Fichero = new fichero(Environment.GetEnvironmentVariable("TEMP"),Environment.MachineName,elapsedSpan.Hours,Environment.Version.ToString());
            Fichero.EscribirFichero();
        }
    }
}
