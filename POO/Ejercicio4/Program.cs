using System;
using static System.Console;

namespace Ejercicio4
{
    public abstract class Revista{
        protected double PrecioVenta;
        protected double CosteFabrica;
        protected string Titulo;
        public Revista(string titulo, double precio, double costo){
            this.Titulo = titulo;
            this.CosteFabrica= costo;
            this.PrecioVenta = precio;
        }
        public abstract string imprimirdatos();
    }
    public class Libro : Revista{
        public Libro(string titulo, double precio, double costo):base(titulo, precio, costo){

        }
        public override string imprimirdatos(){
            return "Libro: " + Titulo +", Precio: " + PrecioVenta;
        }
    }

    public class DVD : Revista{
        public DVD(string titulo, double precio, double costo):base(titulo, precio, costo){

        }
        public override string imprimirdatos(){
            return "Libro: " + Titulo +", Precio: " + PrecioVenta;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            Libro libro = new Libro("parara",23.23,10.1);
            DVD dvd = new DVD("OHOOHOH",23.33,16.1);
            WriteLine($"{libro.imprimirdatos()}");
            WriteLine($"{dvd.imprimirdatos()}");

            WriteLine("Presiona <enter> para terminar.");
            ReadLine();

            SetCursorPosition(1,10);
        }
    }
}
