using System;
using System.IO;
using static System.Console;
using static System.Environment;



namespace Ejercicio6
{
    class Program
    {   
        public class cubo {
            public int Lado;
            public cubo(int lado){
                this.Lado = lado;  
            }
            public void superficie(){
               int calsuperficie = 6 * this.Lado * this.Lado;
               WriteLine($"Lado: {Lado}");
               WriteLine($"Superficie: {calsuperficie}");  
            }

            public void Volumen(){
                int calvolumen = Lado * Lado * Lado;
                WriteLine($"Volumen: {calvolumen}");  
            }
        }
        
        public class calcular {
            double Numero1;
            double Numero2;
            double Result;
            public calcular(double numero1, double numero2){
                this.Numero1 = numero1;
                this.Numero2 = numero2;
            }

            public void suma(){
                this.Result = this.Numero1 + this.Numero2;
                WriteLine($"La suma de {Numero1} y {Numero2} es = {Result}");
            }

            public void resta(){
                this.Result = this.Numero1 - this.Numero2;
                WriteLine($"La resta de {Numero1} y {Numero2} es = {Result}");
            }

            public void multiplicar(){
                this.Result = this.Numero1 * this.Numero2;
                WriteLine($"La multiplicacion de los numero {Numero1} y {Numero2} da el resultado = {Result}");
            }

             public void division(){
                this.Result = this.Numero1 / this.Numero2;
                WriteLine($"La division de los numero {Numero1} y {Numero2} da el resultado = {Result} con resto {Numero1%Numero2}");
            }


        }
        static void Main(string[] args)
        {   Clear();
            /*cubo Cubo = new cubo(2);
            Cubo.superficie();
            Cubo.Volumen();*/

            WriteLine("Introduce el primer valor");
            double numero1 = double.Parse(ReadLine());
            WriteLine("Introduce el segundo valor");
            double numero2 = double.Parse(ReadLine());

            calcular Calcular =  new calcular(numero1,numero2);
            Calcular.suma();
            Calcular.resta();
            Calcular.multiplicar();
            Calcular.division();

        }
    }
}
