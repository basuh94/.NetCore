using System;
using System.IO;
using static System.Console;
using System.Threading;


namespace Fichero
{
    class Program
    {
        static void LeerFichero(char letra){
            //WriteLine(letra);
            StreamReader WficheroLeer;
            WficheroLeer=File.OpenText(@"docu\"+letra+".txt");
            WriteLine(WficheroLeer.ReadToEnd());
            WficheroLeer.Close();
        }
        static void Main(string[] args)
        {
            Clear();
            
            /*StreamWriter fichero;
            fichero = File.CreateText("MiPrimerArchivo.txt");
            fichero.WriteLine("Esto es una línea");
            fichero.Write("Esto es otra sin saltar de línea. ");
            fichero.WriteLine("Y la última saltando después");
            fichero.Close();

            
            StreamReader Fichero;
            string linea;
            Fichero = File.OpenText("MiPrimerArchivo.txt");
            linea = Fichero.ReadLine();

            WriteLine(linea);
            WriteLine(Fichero.ReadLine());
            Fichero.Close();

            StreamWriter Fichero;
            StreamReader Rfichero;
            string Linea;
            string RutaFichero1 = @"F:\.Net\Fichero\MiPrimerArchivo.txt";

            Fichero = File.CreateText(RutaFichero1);
            Fichero.WriteLine("Esto es una prueba");
            Fichero.Close();


            Fichero = File.AppendText(RutaFichero1);
            Fichero.WriteLine("Segunda linea!");
            Fichero.Close();
            
            Rfichero = File.OpenText(RutaFichero1);
            Linea = Rfichero.ReadToEnd();
            Write(Linea);

            StreamReader fichero;
            string nombreFichero;
            
            while(true){
                WriteLine("Introduce el nombre del fichero: ");
                nombreFichero = ReadLine();

                if(nombreFichero == "salida"){
                    break;
                }

                if(File.Exists(nombreFichero)){
                    fichero = File.OpenText(nombreFichero);
                    WriteLine("La primera linea es: {0}", fichero.ReadLine());
                    fichero.Close();
                }else{
                    WriteLine("No Existe");
                }
            }
            StreamReader fichero;
            string nombreFichero;
            string linea;

            WriteLine("Introduce el nombre del fichero");
            nombreFichero = ReadLine();

            try
            {
                fichero = File.OpenText(nombreFichero);
                do 
                {
                    linea = fichero.ReadLine();
                    if(linea != null)
                        WriteLine(linea);
                
                }while(linea != null);
                fichero.Close();
            }
            catch(Exception exp){
                WriteLine("Ha habido un error {0}", exp.Message);
                return;
            }*/


            StreamReader Fichero;
            StreamWriter Wfichero;
            string linea;
            int count=0;
            char letra='1';

            Fichero = File.OpenText("disney.txt");
            Wfichero = File.CreateText(@"docu\"+letra+".txt");
            
            do {
                linea = Fichero.ReadLine();
                if(linea != null){
                   
                    if(char.Parse(linea.Substring(0, 1).ToUpper())!=letra){
                        
                        Wfichero.Close();
                        LeerFichero(letra);
                        letra = char.Parse(linea.Substring(0, 1).ToUpper());
                        Wfichero = File.CreateText(@"docu\"+letra+".txt");
                        WriteLine(letra);       
                        //break; 
                                 
                    }       
                    Wfichero.WriteLine(linea.Replace('.',' '));
                    //WriteLine(linea);
                    count ++;     
                }
            }while(linea != null);
                
                Wfichero.Close();
                LeerFichero('Z');
                Fichero.Close();
                

            WriteLine("Numero de lineas: {0} ",count);



            
        }
    }
}
