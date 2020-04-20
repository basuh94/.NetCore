using System;
using static System.Console;

namespace class1
{
    public class Class1{
        string Nombre;
        string Apellido;
        int Edad;
        public Class1(string nombre, string apellido, int edad){
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }
        public virtual void  imprimir(){
            WriteLine($" Nombre: {this.Nombre} \n Apellido: {this.Apellido} \n Edad: {this.Edad}");
        }
    }
}
 //dotnet new classlib -o class1 