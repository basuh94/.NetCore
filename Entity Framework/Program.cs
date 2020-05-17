using System;
using static System.Console;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

//dotnet add package Microsoft.EntityFrameworkCore.Sqlite
//dotnet add package Microsoft.EntityFrameworkCore.Tools
//dotnet tool install --global dotnet-ef
//dotnet ef dbcontext scaffold "DataSource=C:\SQLite\Northwind.db" Microsoft.EntityFrameworkCore.Sqlite -d -o "/carpeta"

namespace Entity_Framework
{
    class Program
    {

        static void QueryEmpleados(){
                
        using (NorthwindContext db = new NorthwindContext()){
                
                List<string> EmleadosRegion = new List<string>();

                var EmplRegi = (from e in db.Employees
                  join et in db.EmployeesTerritories on e.EmployeeId equals et.EmployeeId
                  join t in db.Territories on et.TerritoryId equals t.TerritoryId
                  join r in db.Regions on t.RegionId equals r.RegionId select new{
                        nombre = e.FirstName,
                        apellido =e.LastName,
                        region = r.RegionDescription.Trim(),
                       
                    }).Distinct().ToList();
               
                foreach (var e in EmplRegi){
                    Console.WriteLine($"{e.nombre} {e.apellido} {e.region}");
                    
                }
            }
        }  

        static void QueryClienUSA(){
            
            using (NorthwindContext db = new NorthwindContext()){
                var Query = db.Customers.Where(o => o.Country == "USA").ToList();
                foreach (var c in Query){
                    WriteLine($"Cliente: {c.ContactName.Trim()}  Pais: {c.Country.Trim()}");
                }
            }
        }

        static void EmpleadoCodigo(){

            using (NorthwindContext db = new NorthwindContext()){
            var Query = db.Employees.Where(o => o.EmployeeId == 3 || o.EmployeeId == 5 || o.EmployeeId == 8 ).ToList();
            foreach (var c in Query){
                    WriteLine($"iD: {c.EmployeeId} Nombre: {c.LastName.Trim()}  Apellido: {c.FirstName.Trim()}");
                }
            }
        }

        static void QueryProBer(){

            using (NorthwindContext db = new NorthwindContext()){
            var Query = db.Suppliers.Where(o => o.City == "Berlin").ToList();
            foreach (var c in Query){
                    WriteLine($"Nombre: {c.ContactName.Trim()}  Ciudad: {c.City.Trim()}");
                }
            }
        }

        static void ProductMayID(){

            using (NorthwindContext db = new NorthwindContext()){
            var Query = db.Products.Where(o => o.UnitsInStock > 0  || o.SupplierId == 1 || o.SupplierId == 3 || o.SupplierId == 5 ).ToList();
            foreach (var c in Query){
                    WriteLine($"Nombre Producto: {c.ProductName.Trim()}");
                }
            }
        }

        static void ProducPrecio(){

            using (NorthwindContext db = new NorthwindContext()){
            var Query = db.Products.Where(o => o.UnitPrice >= 0  || o.UnitPrice <= 90 ).ToList();
            foreach (var c in Query){
                    WriteLine($"Nombre Producto: {c.ProductName.Trim()} Precio:{c.UnitPrice}");
                }
            }
        }            
      
        static void Main(string[] args)
        {
            Clear();
            //QueryEmpleados();

            WriteLine("------------------------EJERCICIO1---------------------------");
            QueryClienUSA();

            WriteLine("------------------------EJERCICIO2---------------------------");
            EmpleadoCodigo();

            WriteLine("------------------------EJERCICIO3---------------------------");
            QueryProBer();

            WriteLine("------------------------EJERCICIO4---------------------------");
            ProductMayID();

            WriteLine("------------------------EJERCICIO5---------------------------");
            ProducPrecio();

        }
    }
}
