using System;
using static System.Console;
using System.Linq;

namespace Lambda
{
    class Program
    {
        private delegate double OperacionMatematica(double value);
        private delegate bool ValidacionTexto (string texto, int longitud);
       
        static void Main(string[] args)
        {
            OperacionMatematica Potenciaa = (double value) => {return Math.Pow(value,2);}; // Lambda
            OperacionMatematica Suma = value => value + value; // Lambda Evolución
            OperacionMatematica Mitad = delegate (double value){return value / 2;}; // Delegate

            ValidacionTexto EsElCorrecto = (string texto, int longitud) => texto.Length < longitud;

            int[] Numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var TomarPrimerosNumero = Numeros.TakeWhile( (n, index)=> n >= index );
            
           
            WriteLine(Potenciaa(2));
            WriteLine(Mitad(3));
            WriteLine(Suma(3));

            WriteLine("La longitud de texto es mayor que el numero: " + EsElCorrecto("Ejemplo",5));
            WriteLine("La longitud de texto es menor que el numero: " + EsElCorrecto("Ejemplo",8));

            WriteLine(string.Join(", ", TomarPrimerosNumero));
           

        }
    }
}
