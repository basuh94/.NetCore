using System;
using static System.Console;
namespace calculos
{
    public class calcular
    {
        public int Lado;
        public calcular(int lado){
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
}
