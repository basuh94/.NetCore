using System;
using static System.Console;
using System.IO;

namespace FicheroBinari
{
    class Program
    {
        static void Main(string[] args)
        {   //LEER 1 BIT 
            /*BinaryReader fichero;
            string nombrefichero;
            byte datofichero;
            nombrefichero= "ejemplo.bmp";
            fichero = new BinaryReader (File.Open(nombrefichero,FileMode.Open));
            datofichero = fichero.ReadByte();
            WriteLine($"El byte leido es {datofichero}");
            fichero.Close();

            FileStream fichero;
            string nombrefichero;
            byte[] datos;
            int numerodebytesleidos;
            nombrefichero = "ejemplo.bmp";
            fichero = File.OpenRead(nombrefichero);
            datos = new byte[10];
            int posicion = 0;
            int cantidadleer = 10;
            numerodebytesleidos = fichero.Read(datos,posicion,cantidadleer);
            
            if(numerodebytesleidos<10){
                WriteLine("No se ha podido leer todos lo bytes");
            }else{
                WriteLine("El primer byte leido es {0}", datos[0]);
            }

            for (int i = 0; i < datos.Length; i++)
            {
                 WriteLine("Byte {1} leido es {0}", datos[i], i);
            }

            fichero.Close();



            FileStream fichero;
            string nombrefichero;
            byte[] datos;
            int numerodebytesleidos;
            nombrefichero = "besoftware.pcx";
            fichero = File.OpenRead(nombrefichero);
            datos = new byte[70];
            int posicion = 0;
            int cantidadleer = 70;
            numerodebytesleidos = fichero.Read(datos,posicion,cantidadleer);

            var xmin = datos[4]|(datos[5]<<8);
            var xmax = datos[8]|(datos[9]<<8);
            var ymin = datos[6]|(datos[7]<<8);
            var ymax = datos[10]|(datos[11]<<8);
            WriteLine($"Ancho: {xmax-xmin+1}");
            WriteLine($"Alto: {ymax-ymin+1}");

            double colores=(1L<<(datos[3]*datos[65]))+1;
            WriteLine($"Colores: {colores:N0}");
            
            for (int i = 0; i < datos.Length; i++)
            {
                //WriteLine("Byte {1} leido es {0}", datos[i], i);
            }

            fichero.Close(); 
            #demandante de empleo*/
            FileStream Fichero;
            string NombreFichero; 
            int NumeroDeBytesLeidos;
            byte[] Datos;

            NombreFichero = "bsw.gif";
            Datos = new byte[70];
            int Posicion = 0;
            int CantidadLeer = 70;

            Fichero = File.OpenRead(NombreFichero);
            NumeroDeBytesLeidos = Fichero.Read(Datos, Posicion, CantidadLeer);
            var ancho = Datos[6]|(Datos[7]<<8);
            var alto = Datos[8]|(Datos[9]<<8);
      

            WriteLine($"Ancho: {ancho}");
            WriteLine($"Alto: {alto}");

            for (int i = 0; i < Datos.Length; i++)
            {
                //WriteLine("Byte {0} leido es {1}", i, Datos[i]);
            
            }
            Fichero.Close();

        }
    }
}
