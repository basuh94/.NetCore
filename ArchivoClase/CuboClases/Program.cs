using System;
using calculos;
using static System.Console;

namespace CuboClases
{
    class Program
    {
        static void Main(string[] args)
        {
          calcular cubo = new calcular(3);
          cubo.superficie();
          cubo.Volumen();
        }
    }
}
