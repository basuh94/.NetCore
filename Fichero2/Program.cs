using System;
using static System.Console;
using System.IO;



namespace Fichero2
{
    class Program
    {
        struct Peliculas{
            public DateTime Fecha;
            public double tamaño;
            public string nombre;
        }
        static void LeerFichero(string ruta){
            StreamReader LeerFichero;
            LeerFichero = File.OpenText(ruta);
            //string Linea;
        }

        static void EscribirFichero(string ruta, DateTime Fecha, double tamaño, string nombre){
            StreamWriter EscribirFichero;
            string FechaTrans = Fecha.ToString("dd/MM/yyyy  hh:mm");
            EscribirFichero = File.AppendText(ruta);
            EscribirFichero.WriteLine($"{FechaTrans}\t\t{tamaño:N0} {nombre}");
            EscribirFichero.Close();

        }
        static void Main(string[] args)
        {   
    
            var numero = ReadKey(true);
            Peliculas peli;
            string ruta = "Disney2.txt";
        
            switch (numero.KeyChar){
                case '1':
                    WriteLine("Introduce los parametos indicados para añadir en el archivo: ");
                    WriteLine("Introduce la fecha: ");
                    peli.Fecha = DateTime.Parse(ReadLine());
                    WriteLine ("Introduce el tamaño del archivo");
                    peli.tamaño = double.Parse(ReadLine());
                    WriteLine("Introduce el nombre de la Pelicula");
                    peli.nombre = ReadLine();
                    EscribirFichero(ruta,peli.Fecha,peli.tamaño,peli.nombre);

                    break;
                case '2':
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Esa opción no existe!");
                    break;
      }
            
            
        }

    }
}
