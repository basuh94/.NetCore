using System;
using static System.Console;
using calcularventas;


namespace Clases_Partidas
{

    class Program
    {
        
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
