using System;
using static System.Console;
using EFCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

//dotnet add package Microsoft.EntityFrameworkCore.Sqlite
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer
//dotnet add package MySQL.Data.EntityFrameworkCore
//dotnet add package Microsoft.EntityFrameworkCore.InMemory


//Herramienta para importar DB
//dotnet add package Microsoft.EntityFrameworkCore.Tools
//dotnet tool install --global dotnet-ef
//dotnet ef dbcontext scaffold "DataSource=C:\SQLite\Northwind.db"
//Microsoft.EntityFrameworkCore.Sqlite -d

namespace EFCore
{
    class Program
    {
        static void QueryingCategories(){
            using (var db = new Northwind()){

                WriteLine("Categorias y los productos que tenemos: \n");
                IQueryable<Category> cats = db.Categories.Include(c => c.Products);
               
                foreach (Category c in cats){
                    WriteLine($"{c.CategoryName}\t tiene \t {c.Products.Count} \t productos. \t {c.Description}");
                }
            }
        }

        static void QueryTerritorios(){
            using (var db = new Northwind()){

                WriteLine("Listado de territorios: \n");
                IQueryable<Territories> Terr = db.Territories.Include(t => t.Region);

                foreach (Territories t in Terr){
                    WriteLine($"{t.TerritoryDescription}\t{t.Region.RegionDescription}{t.}");
                }
            }
        }

        static void QueryRegions(){
            using (var db = new Northwind()){

                WriteLine("Listado de territorios: \n");
                IQueryable<Regions> Reg = db.Regions;

                foreach (Regions r in Reg){
                    WriteLine($"{r.RegionDescription}");
                }
            }
        }


        static void Main(string[] args)
        {
            //QueryingCategories();
            WriteLine("--------------------------------------------------------------");
            QueryTerritorios();
            //QueryRegions();
            //QueryEmplReg();
        }
    }
}
