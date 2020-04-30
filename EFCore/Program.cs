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
                WriteLine("Categorias y los productos que tenemos: ");
            
                IQueryable<Category> cats = db.Categories.Include(c => c.Products);
                IQueryable<Product> pro = db.Products.Include(p => p.Category);
                

                foreach (Category c in cats){
                    WriteLine($"{c.CategoryName}\t tiene \t {c.Products.Count} \t productos. \t {c.Description}");
                }

                foreach (Product p in pro){
                    WriteLine($" ID: {p.ProductID} \n Nombre: {p.ProductName}\t Stok: {p.Stock} \t ");
                }
            }
        }
        static void Main(string[] args)
        {
           QueryingCategories();
        }
    }
}
