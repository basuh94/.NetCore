using System;
using static System.Console;

namespace SobreCargaClases
{  
    public class ClaseSobrecargar{
       
        public void operacion(double numero1){
            WriteLine($"Muestro {numero1}");
        }
        public void operacion(double numero1, double numero2){
            WriteLine($"Muestro {numero1} y {numero2}");
        }

        public void operacion(double numero1, double numero2, double numero3){
            WriteLine($"Muestro {numero1}, {numero2} y {numero3}");
        }

    }

    public class nombres{
       
        public void MostrarNombres(string nombre1){
            WriteLine($"Muestro {nombre1}");
        }
        public void MostrarNombres(string nombre1, string nombre2){
            WriteLine($"Muestro {nombre1} y {nombre2}");
        }

        public void MostrarNombres(string nombre1, string nombre2, string nombre3){
            WriteLine($"Muestro {nombre1}, {nombre2} y {nombre3}");
        }

    }

    public class mascotas{
        public void MostrarMascota(string mascota1){
            WriteLine($"Muestro {mascota1}");
        }
        public void MostrarMascota(string mascota1, string mascota2){
            WriteLine($"Muestro {mascota1} y {mascota2}");
        }

        public void MostrarMascota(string mascota1, string mascota2, string mascota3){
            WriteLine($"Muestro {mascota1}, {mascota2} y {mascota3}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           ClaseSobrecargar metodo = new ClaseSobrecargar();
           metodo.operacion(1);
           metodo.operacion(2,9);
           metodo.operacion(4,3,9);
           WriteLine();
           nombres MosNombres = new nombres();
           MosNombres.MostrarNombres("Pablo");
           MosNombres.MostrarNombres("Juan","Pepe");
           MosNombres.MostrarNombres("Luis","Alex","Roberto");
           WriteLine();
           mascotas MosMascota = new mascotas();
           MosMascota.MostrarMascota("Perro");
           MosMascota.MostrarMascota("Saltamontes","Erizo");
           MosMascota.MostrarMascota("Loro","Gato","Serpiente");
        }
    }
}
