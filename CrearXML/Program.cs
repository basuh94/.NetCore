using System;
using System.IO;
using CreateXml;
using LeerXML;
using static System.Console;

namespace CrearXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string ColorFondo = BackgroundColor.ToString();
            string ColorTexto = ForegroundColor.ToString();
            string Anchura = WindowWidth.ToString();
            string Altura = WindowHeight.ToString();
            string RutaFichero = Directory.GetCurrentDirectory();
        
            CrXml create = new CrXml("Configuracion1.xml",ColorFondo,ColorTexto,Anchura,Altura,RutaFichero);
            create.Create();
            LeXML reader = new LeXML("Configuracion1.xml");
            reader.Leer();
        }
    }
}
