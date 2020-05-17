using System;

namespace SOLID
{
    class Program
    {
    /////FORMA CORRECTA
        public abstract class Forma{
            public abstract double Area();
        }
        public class Rectangulo: Forma{
            public double Altura;
            public double Anchura;
            public override double Area(){
                return Altura * Anchura;
            }
        }
        public class Circulo: Forma{
            public double Radio;
            public override double Area(){
                return Radio * Radio * Math.PI;
            }
        }
        public class CalcularArea{
            public double AreaTotal(Forma[] arrFormas){
                double Area = 0;
                foreach (var objFormas in arrFormas){
                    Area += objFormas.Area();
                }
                return Area;
            }
        }

    // 2 FORMA CORRECTA
        public abstract class Pajaro{
            public abstract void Comer();
            public abstract void Dormir();
        }

        public interface IPajaroVolador{
            void Volar(){
                Console.WriteLine("Este pajaro Vuela");
            }
        }

        public interface IPajaroNadador{
            void Nadar(){
                 Console.WriteLine("Este pajaro Nada");
            }
        }

        public class Aguila: Pajaro, IPajaroVolador{
           
            public override void Comer(){
                Console.WriteLine("Este pajaro Comer");
            }

            public override void Dormir(){
                Console.WriteLine("Este pajaro Duerme");
            }
        }

        public class Pinguino: Pajaro, IPajaroNadador{
            public override void Comer(){
                Console.WriteLine("Este pajaro Comer");
            }

            public override void Dormir(){
                Console.WriteLine("Este pajaro Duerme");
            }
        }

        public class Pato: Pajaro, IPajaroVolador, IPajaroNadador{
            public override void Comer(){
                Console.WriteLine("Este pajaro Comer");
            }

            public override void Dormir(){
                Console.WriteLine("Este pajaro Duerme");
            }
        }

        static void Main(string[] args)
        {
        
        }
    }
}
