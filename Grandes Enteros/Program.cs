using System;
using System.Numerics;
using static System.Console;
using System.Text.RegularExpressions;

namespace Grandes_Enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            var ElMasGrande = ulong.MaxValue;
            Console.WriteLine($"{ElMasGrande,40:N0}");

            var AtomosEnElUniverso = BigInteger.Parse("123456789012345678901234567890");
            Console.WriteLine($"{AtomosEnElUniverso,40:N0}");
                   
            string cadena = "WASHINGTON";
             for (int i = 0; i < cadena.Length; i++){
                 WriteLine(cadena[i]);
             }

            string Ciudades = "Granada,Malaga,Madrid,Barcelona,Tegucigalpa,Nueva York";
            string [] ArrayDeCiudades = Ciudades.Split(',');
            foreach(string item in ArrayDeCiudades){
                WriteLine(item);
            }

            string NombreCompleto = "Pablo Ramos";
            int DondeEstaElEspacio = NombreCompleto.IndexOf(" ");
            string Nombre = NombreCompleto.Substring(startIndex:0, length: DondeEstaElEspacio);
            string Apellido = NombreCompleto.Substring(startIndex: DondeEstaElEspacio+1);
            WriteLine($"{Apellido}, {Nombre} {DondeEstaElEspacio}"); 

            string Empresa = "Microsoft";
            bool ComienzaPorM = Empresa.StartsWith("M");
            bool ContieneN = Empresa.Contains("N");

            WriteLine($"La empresa empieza por M: {ComienzaPorM}, Contiene N: {ContieneN}");

            string frase = " Hesternocleidhomastohideo es un güeso ";
            
            frase =  frase.TrimStart();
            frase = frase.TrimEnd();
            frase = frase.Replace("güeso", "musculo");
            frase = frase.Insert(frase.Length," ");
            frase = frase.Insert(frase.Length,"de");
            frase = frase.Insert(frase.Length," ");
            frase = frase.Insert(frase.Length,"la");
            frase = frase.Insert(frase.Length," ");
            frase = frase.Insert(frase.Length,"cabeza");

            for (int i = 0; i < frase.Length; i++){
               if(frase[i]=='h' || frase[i]=='H' ){
                   WriteLine($"Posicion de la 'H': {i+1}"); 
               }
            }

            frase = frase.Replace("h",string.Empty);
            frase = frase.Replace("H",string.Empty);

            WriteLine(frase);*/
            
            Write("Introduce el valor:");
            string Entrada = ReadLine();
            //var ComprobadorEdad = new Regex(@"\d{2}$");
            //var ComprobadorEdad = new Regex(@"a");
            //var ComprobadorEdad = new Regex(@"hola");
            //var ComprobadorEdad = new Regex(@"^[0-9]{2}$"); 
            //var ComprobadorEdad = new Regex(@"[A-Z]{4,}$");
            //var ComprobadorEdad = new Regex(@"[A-Za-z]{4,}$");
            //var ComprobadorEdad = new Regex(@"[A-Z]{2}\d{3}");
            //var ComprobadorEdad = new Regex(@"^d.g$");
            //var ComprobadorEdad = new Regex(@"^d\.g$");

            //var Comprobar = new Regex(@"^[A-B]\d{9}$");
            //var Comprobar = new Regex(@"^[6-9][0-9]{2} [0-9]{3} [0-9]{3}");
            //var Comprobar = new Regex(@"^[6-9][0-9]{2} [0-9]{3} [0-9]{3}");
            var Comprobar = new Regex(@"^www\.[a-z0-9]+\.(com|es|net|info)$");
            if(Comprobar.IsMatch(Entrada)){
                WriteLine("Es correcto");
            }else{
                WriteLine($"No es valido: {Entrada}");
            }

        }
    }
}
