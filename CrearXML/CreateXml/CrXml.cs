using System;
using System.Xml;
using static System.Console;

namespace CreateXml
{
    public class CrXml
    {
        string NameXML;
        string ColorFondo;
        string ColorTexto;
        string Anchura;
        string Altura;
        string RutaFichero;
        public CrXml(string nameXML, string colorfondo, string colortexto, string anchura, string altura, string rutafichero){
            this.NameXML = nameXML;
            this.ColorFondo = colorfondo;
            this.ColorTexto = colortexto;
            this.Anchura = anchura;
            this.Altura = altura;
            this.RutaFichero = rutafichero;  
        }
        public void Create(){
            
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode rootNode = xmlDoc.CreateElement("Configuracion");
            xmlDoc.AppendChild(rootNode);

            XmlNode ColorFondo = xmlDoc.CreateElement("ColorFondo");
            ColorFondo.InnerText = this.ColorFondo;
            rootNode.AppendChild(ColorFondo);

            XmlNode ColorTexto = xmlDoc.CreateElement("ColorTexto");
            ColorTexto.InnerText = this.ColorTexto;
            rootNode.AppendChild(ColorTexto);

            XmlNode Anchura = xmlDoc.CreateElement("Anchura");
            Anchura.InnerText = this.Anchura;
            rootNode.AppendChild(Anchura);

            XmlNode Altura = xmlDoc.CreateElement("Altura");
            Altura.InnerText = this.Altura;
            rootNode.AppendChild(Altura);

            XmlNode RutaFichero = xmlDoc.CreateElement("RutaFichero");
            RutaFichero.InnerText = this.RutaFichero;
            rootNode.AppendChild(RutaFichero);


            xmlDoc.Save(this.NameXML);

            
        }
    }
}
