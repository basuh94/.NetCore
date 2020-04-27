using System;
using System.Collections.Generic;
using static System.Console;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaDenumeros = new List<int>();
            ListaDenumeros.Add(5);
            ListaDenumeros.Add(33);
            ListaDenumeros.Add(99);
            ListaDenumeros.Insert(1,11); //Añadir un numero en una posición
            ListaDenumeros.Reverse();   //Invertir la lista
            int[]ListaArray = ListaDenumeros.ToArray(); //Convertimos lista en Array

            foreach(int numero in ListaDenumeros){
               WriteLine(numero);
            }
            
            Console.WriteLine("#");

            for (int i = 0; i < ListaArray.Length; i++){
                WriteLine(ListaArray[i]);
            }

            WriteLine("-----------------------------------------------------");

            if(ListaDenumeros.Contains(11)){
                WriteLine($"La lista contine el numero 11 y su indice es: {ListaDenumeros.IndexOf(11)}");     
            }

            List<string> RazaDePerros = new List<String>();
            RazaDePerros.Add("Pastor Aleman");
            RazaDePerros.Add("Bulldog");
            RazaDePerros.Add("Caniche");
            RazaDePerros.Add("Labrador");
            RazaDePerros.Add("Beagle");
            RazaDePerros.Add("Chihuahua");
            RazaDePerros.Add("Boxer");
            RazaDePerros.Add("Husky");
            RazaDePerros.Add("Galgo");

            RazaDePerros.Insert(2,"Burrera");

            foreach (string Raza in RazaDePerros){
                WriteLine($"Raza de perro: {Raza}");
            }

            WriteLine("");
            RazaDePerros.Reverse();

            foreach (string Raza in RazaDePerros){
                WriteLine($"Raza de perro: {Raza}");
            }

            RazaDePerros.RemoveAt(RazaDePerros.Count -1);
            WriteLine("");

            foreach (string Raza in RazaDePerros){
                WriteLine($"Raza de perro: {Raza}");
            }
            WriteLine($"Contar:{RazaDePerros.Count}");
            WriteLine($"Indice de la raza Burrera: {RazaDePerros.IndexOf("Burrera")}");
            
            WriteLine("-----------------------------------------------------");

            Dictionary<string,string> Lenguajes = new Dictionary<string,string>();
            Lenguajes.Add("Java", "Saturado");
            Lenguajes.Add("C#", "Futuro");
            Lenguajes.Add("Python", "Aprendiz");
            Lenguajes.Add("Visual Basic", "Exterminio");
            Lenguajes.Add("Assembler", "Frikis");

            foreach(KeyValuePair<string,string> elemento in Lenguajes){
                WriteLine($"Clave: {elemento.Key} Valor: {elemento.Value}");
            }

            WriteLine("-----------------------------------------------------");

            foreach(var elemento in Lenguajes){
                WriteLine($"Clave: {elemento.Key} Valor: {elemento.Value}");
            }


            Dictionary<int,string> PrefijoTelefono = new Dictionary<int,string>();
            PrefijoTelefono.Add(34,"España");
            PrefijoTelefono.Add(57,"Colombia");
            PrefijoTelefono.Add(53,"Cuba");
            PrefijoTelefono.Add(33,"Francia");
           
            WriteLine("-----------------------------------------------------");

            List<int> Key = new List<int>();
            List<string> Value = new List<String>();

            foreach (var item in PrefijoTelefono)
            {
             WriteLine(item.Key + " " + item.Value);
             Key.Add(item.Key);
             Value.Add(item.Value); 
            }

            Key.Insert(2, 5);
            Value.Insert(2, "ELEMENTO");

            Key.Reverse();
            Value.Reverse();

            PrefijoTelefono.Clear();
            
            for (int i = 0; i < Key.ToArray().Length; i++)
            {
                 PrefijoTelefono.Add(Key.ToArray()[i], Value.ToArray()[i]);

            }
            WriteLine("-----------------------------------------------------");

            foreach (var item in PrefijoTelefono)
            {
                WriteLine(item.Key + " " + item.Value);
                Key.Add(item.Key);
                Value.Add(item.Value); 
            }
            
            PrefijoTelefono.Remove(33);

            WriteLine("-----------------------------------------------------");
            WriteLine($"Contar:{PrefijoTelefono.Count}");
            WriteLine($"Indice: {Key.IndexOf(5)}");

        }
    }
}
