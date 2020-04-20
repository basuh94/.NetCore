using System;
using static System.Console;

namespace DiaseSemana{
    class Program{
        enum Semana  {Lunes = 1, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo};
        static void Main(string[] args){
            WriteLine("Introduce el dia de la semana:");
            string sDayNum = ReadLine();
            try{
                int iDayNum = int.Parse(sDayNum);
                if(iDayNum > 7 || iDayNum <= 0){
                    WriteLine($"{iDayNum} no es un dia de la semana");   
                }else{
                    foreach (var day in Enum.GetValues(typeof(Semana))){
                        string nsDayNum = string.Format("{0:D}",day);
                        int isDayNum = int.Parse(nsDayNum);    
                        if(iDayNum == isDayNum && iDayNum >= 6){
                            WriteLine($"El {day} es fin de semana!");
                        }else if(iDayNum == isDayNum && iDayNum < 6){
                            WriteLine($"El {day} se trabaja!");
                        }
                    }
                }  
            }
            catch (System.Exception){
                WriteLine("No has introducido un numero");   
            }                             
        }
    }
}
