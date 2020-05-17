using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

// dotnet ef dbcontext scaffold "server=ec2-52-14-205-70.us-east-2.compute.amazonaws.com;user=SQL;password=SQL;database=SuperstoreUS" Microsoft.EntityFrameworkCore.SqlServer

namespace AWS_.NET
{
    class Program
    {   
        static void Query1(){
            using(SuperstoreUSContext db = new SuperstoreUSContext()){
                var MaxCompra = db.OrdersWest.Max( o => o.Profit );
                var MinCompra = db.OrdersWest.Min( o => o.Profit );

                var ClienteMasCompra = db.OrdersWest.Where( o => o.Profit == MaxCompra ).ToList();
                foreach (var o in ClienteMasCompra){
                    Console.WriteLine($"Nombre: {o.CustomerName} \t Ganancias: {o.Profit}$");
                }
                var ClienteMenosCompra = db.OrdersWest.Where( o => o.Profit == MinCompra ).ToList();
                foreach (var o in ClienteMenosCompra){
                    Console.WriteLine($"Nombre: {o.CustomerName} \t Ganancias: {o.Profit}$");
                }
            }
           
        }

        static void Main(string[] args)
        {
            Query1();
        }
        
    }
}
