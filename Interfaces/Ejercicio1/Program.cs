using System;

namespace Ejercicio1
{
    public interface IProducto
    {
        void CalcularImpuesto(double imp);
        void CalcularGanacias();
        void MuestraInformacion();
    }
    public class CTelevisor: IProducto {
        double Costo;
        double Impuesto;
        double Ganancias;
        string Descripcion;
        public CTelevisor(){
            this.Costo = 400.0;
            this.Descripcion = "Esto es una descripcion";
        }

        public void ColocarCosto(double costo){
            this.Costo = costo;
        }

        public  void CalcularGanacias(){
            this.Ganancias = Costo*15/100;
            this.Ganancias = Costo-Ganancias;
        }
        public void CalcularImpuesto(double imp){
            this.Impuesto = Costo * imp;
            
        }

        public void MuestraInformacion(){
            Console.WriteLine("PRODUCTO TELEVISOR");
            Console.WriteLine(Descripcion);
            Console.WriteLine($"Costo: {Costo} Ganancias:{Costo-Ganancias} Impuesto: {Math.Round(Impuesto,2)}");
            Console.WriteLine("--------------------------------");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            CTelevisor miTv = new CTelevisor();
            miTv.CalcularImpuesto(0.21);
            miTv.CalcularGanacias();
            miTv.MuestraInformacion();
            miTv.ColocarCosto(576.20);
            miTv.CalcularGanacias();
            miTv.CalcularImpuesto(0.21);
            miTv.MuestraInformacion();
        }
    }
}
