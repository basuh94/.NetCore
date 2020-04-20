using System;
using static System.Console;
using System.Threading;

namespace Vetana
{
    class Program
    {
        static void Main(string[] args)
        {
            string FechaPro = DateTime.Now.ToString("12/03/2020");
            string Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            string NombreProyec="Marco para pantalla MSDOS";
            string Desarrollador =Environment.UserName;

            int Ancho = 90;
            int Alto = 30;

            int ColumOriginal, RowOriginal;
            ColumOriginal = CursorTop;
            RowOriginal = CursorLeft;

            Clear();
    
            //SetWindowSize(Ancho, Alto);           
            SetCursorPosition(0,0);
            Write("╔"); 
            for (int i = 1; i < Ancho; i++)
            {
                SetCursorPosition(i, 0);
                Write("═");
            }
            
            SetCursorPosition(Ancho,  0);
                Write("╗"); 

            for (int i = 1; i < Alto; i++)
            {
                SetCursorPosition(0, i);
                Write("║");
            }

            SetCursorPosition(0, Alto);
            Write("╚"); 

            for (int i = 1; i < Ancho; i++)
            {
                SetCursorPosition(i, Alto);
                Write("═");
            }

            SetCursorPosition(Ancho, Alto);
            Write("╝");

            for (int i = 1; i < Alto; i++)
            {
                SetCursorPosition(Ancho, i);
                Write("║");
            }

            SetCursorPosition(0,6);
            Write("╠");

            for (int i = 1; i < Ancho; i++)
            {
                SetCursorPosition(i,6);
                Write("═");
            }

            SetCursorPosition(Ancho,6);
            Write("╣");

            SetCursorPosition(2,1);
            WriteLine($"Fecha proyecto: {FechaPro}");

            SetCursorPosition(2,3);
            WriteLine($"Nombre proyecto: {NombreProyec}");

            SetCursorPosition(2,5);
            WriteLine($"Desarrollador: {Desarrollador}");

            SetCursorPosition(80,1);
            WriteLine($"{Fecha}");
            

            SetCursorPosition(0,30);
            Sonido();
        //Sonido Ventana
        static void Sonido(){
            int beepgen1, beepgen2, beepgen3, beepgen4, beepgen5, beepgen6, beepgen7, beepgen8, beepgenn1, beepgenn2, beepgenn3, beepgenn4, beepgenn5, beepgenn6, beepgenn7, beepgenn8;
            Random randomgen = new Random();

            beepgen1 = (randomgen.Next(37, 7000));
            beepgen2 = (randomgen.Next(37, 6000));
            beepgen3 = (randomgen.Next(37, 6000));
            beepgen4 = (randomgen.Next(37, 7000));
            beepgen5 = (randomgen.Next(37, 8000));
            beepgen6 = (randomgen.Next(37, 7000));
            beepgen7 = (randomgen.Next(37, 7000));
            beepgen8 = (randomgen.Next(37, 5000));
            beepgenn1 = (randomgen.Next(50, 200));
            beepgenn2 = (randomgen.Next(50, 250));
            beepgenn3 = (randomgen.Next(50, 300));
            beepgenn4 = (randomgen.Next(50, 200));
            beepgenn5 = (randomgen.Next(50, 250));
            beepgenn6 = (randomgen.Next(50, 200));
            beepgenn7 = (randomgen.Next(50, 300));
            beepgenn8 = (randomgen.Next(50, 250));

            Console.Beep(beepgen1, beepgenn1);
            Console.Beep(beepgen2, beepgenn2);
            Console.Beep(beepgen3, beepgenn3);
            Console.Beep(beepgen4, beepgenn4);
            Console.Beep(beepgen5, beepgenn5);
            Console.Beep(beepgen6, beepgenn6);
            Console.Beep(beepgen7, beepgenn7);
            Console.Beep(beepgen8, beepgenn8);
        }


        

        }
    }
}
