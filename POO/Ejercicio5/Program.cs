using System;
using static System.Console;

namespace Ejercicio5
{
    public abstract class fabrica{
        public string Marca;
        public string Matricula;
        public double Kilometros;
        public int Ruedas;

        public fabrica(string marca, string matricula, double kilometros, int ruedas){
            this.Marca = marca;
            this.Matricula = matricula;
            this.Kilometros = kilometros;
        }
        public abstract void imprimirdatos();
         
    }
    public class coche:fabrica{
        public DateTime FechaITV;
        public coche(string marca, string matricula, double kilometros, int ruedas, DateTime fechaITV):base(marca, matricula,kilometros,ruedas){
            this.FechaITV = fechaITV;
        }
        public override void imprimirdatos(){
            WriteLine($" Modelo: {Marca} \n Matricula: {Matricula} \n Kilometros: {Kilometros} \n FechaITV: {FechaITV}");
        }
    }

    public class moto:fabrica{
        public string Casco;
        public moto(string marca, string matricula, double kilometros, int ruedas, string casco):base(marca, matricula,kilometros,ruedas){
            this.Casco = casco;
        }
        public override void imprimirdatos(){
            WriteLine($" Modelo: {Marca} \n Matricula: {Matricula} \n Kilometros: {Kilometros} \n Casco: {Casco}");
        }
    }

    public class SP:coche{
        public string LicenciaSP;
        public SP(string marca, string matricula, double kilometros, int ruedas, DateTime fechaITV, string licenciaSP):base(marca, matricula,kilometros,ruedas,fechaITV){
            this.LicenciaSP = licenciaSP;
        }
        public override void imprimirdatos(){
            WriteLine($" Modelo: {Marca} \n Matricula: {Matricula} \n Kilometros: {Kilometros} \n FechaITV: {FechaITV} \n LicenciaSP: {LicenciaSP}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            WriteLine("----------------COCHE------------------");
            coche Coche = new coche("Renault Clio","394958D",20,4,DateTime.Parse("03/01/2005"));
            Coche.imprimirdatos();
            WriteLine("----------------MOTO------------------");
            moto Moto = new moto("Yamaha","23847D",10230123,2,"SI");
            Moto.imprimirdatos();
            WriteLine("-------------VEHICULO SP---------------");
            SP Camion = new SP("Camion Mercedes","111377D",32784872.4,8,DateTime.Parse("13/06/2019"),"1238405K");
            Camion.imprimirdatos();
        }
    }
}
