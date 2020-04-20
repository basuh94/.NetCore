using System;
using static System.Console;
namespace calcularventas
{
    public class ProVentas
    {
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
}
