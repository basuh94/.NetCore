using System;
using System.IO;
using static System.Console;
using static System.Environment;

namespace Ejercicio7
{
    class Program
    {
        class ProVentas{
            public double[] Ventas = new double[12];
            public string Vendedor;
            public double Venta;
            public double Total;
            public ProVentas(string vendedor, double venta){
                this.Vendedor = vendedor;
                this.Venta = venta;
            }

            public void CalcularVentas(){
                int m = 1;
                Ventas[0] = this.Venta;
                DateTime mes = DateTime.Parse("01/01/2020");

                WriteLine($"----VENDEDOR: {this.Vendedor}----");
                WriteLine($"Ventas de {mes.ToString("MMMM")}: {Ventas[0]}$");
                for (int i = 1; i < Ventas.Length; i++)
                {   
                    m++;
                    var random = new Random();
                    mes = DateTime.Parse("01/"+m+"/2020");
                    Ventas[i]= random.Next(0,10000);
                    WriteLine($"Ventas de {mes.ToString("MMMM")}: {Ventas[i]}$");
                }
            }
            public double CalcularTotal(){
                
                for (int i = 0; i < Ventas.Length; i++)
                {
                    this.Total = Total + Ventas[i];
                }
                return Total;
            }
        }
        static void Main(string[] args)
        {
            string Vendedor; 
            double Venta=0;
            double Total = 0;
            int i=0;
            int m=0;

            Clear();        
            while(true){
                WriteLine("Introduce los valores del vendedor: ");
                WriteLine("Nombre: ");
                Vendedor = ReadLine();
                WriteLine("Primera Venta: ");
                Venta = double.Parse(ReadLine());
                ProVentas calcular = new ProVentas(Vendedor,Venta);
                calcular.CalcularVentas();
                Total= Total + calcular.CalcularTotal();
                i++;
                if(i==3){
                    WriteLine("Quieres seguir añadiendo Vendedores SI[1] NO[0]?");
                    m = int.Parse(ReadLine());
                    if(m==0){
                        WriteLine($"El Total de dinero de todos los vendedores:{Total}");
                        break;
                    }else{
                        i=2;
                    }     
                }       

            }
        }
    }
}
