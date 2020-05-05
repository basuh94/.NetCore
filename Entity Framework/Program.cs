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
      
        static void Main(string[] args)
        {
            Clear();
            QueryEmpleados();
        }
    }
}
