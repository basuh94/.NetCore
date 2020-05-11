using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        public class Portatil{
            public string Marca;
            public string CPU;
            public int Memoria = 4;
            public int SSD;
            public int HDD;
            public double Precio;
        }
        static void Main(string[] args)
        {
            /*
            var valores = new List<int> {1,2,3,4,5,6,7,8,9,0};
            var SumaDeValores = valores.Sum();
            var Pares = valores.Where(x => x % 2 == 0).ToList(); //ToList para poder generar una lista y recorrerla.

            foreach (int valor in Pares){
                WriteLine($"Numero par: {valor}");
            }

            WriteLine($"\nLa suma de todos los valores: {SumaDeValores}");
            */

            var portatiles = new List<Portatil>{

                new Portatil{Marca = "Samsung", CPU="i3", Memoria=8, SSD=1000, Precio=674},
                new Portatil{Marca = "Thosiba", CPU="i5", Memoria=16, SSD=512, Precio=470},
                new Portatil{Marca = "HP", CPU="i3", Memoria=4, SSD=0, HDD=500, Precio=320},
                new Portatil{Marca = "Acer", CPU="i3", Memoria=4, SSD=128, Precio=200},
                new Portatil{Marca = "Asus", CPU="i7", Memoria=8, SSD=250, Precio=995},
                new Portatil{Marca = "Slimbook", CPU="i7", Memoria=16, SSD=512, HDD=1000, Precio=1500}
                
            };

            //SELECT
            var NombrePortatiles = portatiles.Select(x => x.Marca).ToList(); 
            foreach (var n in NombrePortatiles){
                WriteLine($"Marca: {n}");
            }

            WriteLine("---------------------------------------");
            
            var NombreVariosPortatiles = portatiles.Select(x => new{x.Marca, x.CPU, x.Precio} ).ToList(); 
            foreach (var n in NombreVariosPortatiles){
                WriteLine($"Marca:{n.Marca} CPU:{n.CPU} Precio:{n.Precio}$");
            }

            
            WriteLine("---------------------------------------");

            //WHERE
            var PortatilesBaratos = portatiles.Where(z => z.Precio < 500).ToList();
            foreach(var n in PortatilesBaratos){
                WriteLine($"Marca:{n.Marca} Precio:{n.Precio}$");
            }
            
            WriteLine("---------------------------------------");

            var Portatilei7 = portatiles.Where(z => (z.Precio >= 500 && z.CPU=="i7")).ToList();
                                        //.Where(z => z.CPU == "i7");
            foreach(var n in Portatilei7){
                WriteLine($"Marca:{n.Marca} CPU:{n.CPU} Precio:{n.Precio}$");
            }
            
            WriteLine("---------------------------------------");

            //ORDERBY
            var PortatilesOrdenadosASC = portatiles.OrderBy(x => x.Marca).ToList();
             foreach (var n in PortatilesOrdenadosASC){
                WriteLine($"Marca: {n.Marca}");
            }

            WriteLine("---------------------------------------");

            var PortatilesOrdenadosDES = portatiles.OrderByDescending(x => x.Marca).ToList();
            foreach (var n in PortatilesOrdenadosDES){
                WriteLine($"Marca: {n.Marca}");
            }

            WriteLine("---------------------------------------");

            var PortatilesMasCaros = portatiles.OrderByDescending(x => x.Precio).ToList();
            foreach (var n in PortatilesMasCaros){
                WriteLine("Marca: {0,-15} Precio: {1}", n.Marca,n.Precio);
            }
            
            WriteLine("---------------------------------------");

            
            //FIRST -  LAST
            var PortatilMasCaro = PortatilesMasCaros.First();
            var PortatilMasBarato = PortatilesMasCaros.Last();
            WriteLine($"El Portátil más caro: {PortatilMasCaro.Marca}");
            WriteLine($"El Portátil más barato: {PortatilMasBarato.Marca}");
            
            WriteLine("---------------------------------------");

            //SUM
            var SumaPrecioPortatil = portatiles.Sum(x => x.Precio); 
            WriteLine($"La suma de todos los precios es: {SumaPrecioPortatil}");
            
            WriteLine("---------------------------------------");
            
            //MAX - MIN

            var SSDMayor = portatiles.Max(x => x.SSD);
            var NombreSSDMayor = portatiles.Where(x => x.SSD == SSDMayor).Select(x => x.Marca);
            var SSDMenor = portatiles.Min(x => x.SSD);
            WriteLine($"El SSD MAYOR : {SSDMayor} y su marca es {string.Join(" ", NombreSSDMayor)}");
            WriteLine($"El SSD MENOR: {SSDMenor}");

            WriteLine("---------------------------------------");

            // AVERAGE
            var PrecioMedio = portatiles.Average(x => x.Precio);
            WriteLine($"El precio medio de los portatiles es {PrecioMedio}");

            WriteLine("---------------------------------------");

            //SINTAXIS SQL CON LINQ
            var PortatilesCon8Gb = from portatil in portatiles
                                    where portatil.Memoria >= 8
                                    orderby portatil.Precio
                                    select portatil;
            
            foreach(var n in PortatilesCon8Gb){
                WriteLine("Marca: {0, -15} Precio: {1, -15} Memoria: {2}", n.Marca, n.Precio, n.Memoria);
            }
        }
    }
}
