using System;
using static System.Console;

namespace Ejercicio3
{
    class Persona { // Clase Padre
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
    class Trabajador:Persona { //Clase Hija de Persona Rescata las propiedades de el constructor.
        public int Sueldo;
        public Trabajador(string nombre, int edad, string nif, int sueldo):base(nombre,edad,nif){
            this.Sueldo = sueldo;
        }
    }
    public class ClasePadre {
        public virtual void show(){ //Virtual para que se pueda heredar desde una clase hija
            SetCursorPosition(2,10);
            WriteLine("CLASE PADRE");
        }   
    }
    public class ClaseHija:ClasePadre{
        public override void show(){ // override para poder heredar de la clase padre 
            SetCursorPosition(3,5);
            WriteLine("CLASE HIJA");
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
           Clear();
           ClasePadre objeto1 = new ClasePadre();
           objeto1.show();
           objeto1 = new ClaseHija();
           objeto1.show();
           SetCursorPosition(1,10);
        }
    }
}
