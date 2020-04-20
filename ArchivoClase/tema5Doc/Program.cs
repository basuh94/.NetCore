using System;
using class1;
using static System.Console;

namespace tema5Doc
{
    public class ClassHija:Class1{
        string DNI;
        string Nombre;
        string Apellido;
        int Edad;

        public ClassHija(string nombre, string apellido, int edad, string dni):base(nombre, apellido, edad){
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }
        public override void  imprimir(){
            WriteLine($" Nombre: {Nombre} \n Apellido: {Apellido} \n Edad: {Edad} \n DNI:{DNI}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            Class1 ClasePadre = new Class1("Pablo", "Ramos", 25);
            ClasePadre.imprimir();
            WriteLine("-----------------------------");

            ClassHija ClaseHija = new ClassHija("Ale", "Cortes", 40, "1239485k");
            ClaseHija.imprimir();
        }
    }
}
