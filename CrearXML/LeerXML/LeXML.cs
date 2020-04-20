using System;
using static System.Console;
using System.Xml;

namespace LeerXML
{
    public class LeXML
    {
        public string NombreXMl;

        public LeXML(string nombreXML){
            this.NombreXMl = nombreXML;
        }
        public void Leer(){
            XmlReader xmlReader = XmlReader.Create(this.NombreXMl);
            while(xmlReader.Read()){
                switch(xmlReader.NodeType){
                    
                    case XmlNodeType.Element: 
                        Console.Write("<" + xmlReader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: 
                        Console.WriteLine ("\t"+xmlReader.Value);
                        break;
                    case XmlNodeType.EndElement: 
                        Console.Write("</" + xmlReader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }

            
        }
    }
}
