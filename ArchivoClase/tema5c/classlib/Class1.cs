using System;
using static System.Console;

namespace classlib
{
    public class ClassPadre
    {
        string Nombre;
        string Apellido;
        int Edad;
        public ClassPadre(string nombre, string apellido, int edad){
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }
        public virtual void  imprimir(){
            WriteLine($" Nombre: {this.Nombre} \n Apellido: {this.Apellido} \n Edad: {this.Edad}");
        }
        
    }
}
