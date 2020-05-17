using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Globalization;



namespace Entity_Framework
{
    class Program
    {
        enum Posicion {Top, Mid, Bot, Val};
        static StreamWriter Fichero;
        static void FreightEmpleados(int año) {
            Console.WriteLine("Empleados en orden descendente según Apellido Nombre");
            Console.WriteLine($"Mostrando Freight de Orders de cada uno del año {año}");
            Console.WriteLine();
            using (var db = new NorthwindContext()) {

                var OrdersEmpleados = db.Orders
                .Where(o => o.ShippedDate.Value.Year == año)
                .OrderBy(o => o.ShippedDate.Value)
                .ToList()
                .GroupBy(o => o.EmployeeId)
                .Join(
                    db.Employees,
                    o => o.Key,
                    e => e.EmployeeId,
                    (o, e) => new
                    {
                        MonthOrders = o.GroupBy(o => o.ShippedDate.Value.Month),
                        Employee = e
                    }
                )
                .OrderByDescending(e => e.Employee.LastName+" "+e.Employee.FirstName);

                int izq;
                int fila;
                int filaInicial;
                int filaFinal;
                foreach (var e in OrdersEmpleados) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{e.Employee.FirstName} {e.Employee.LastName} ({e.MonthOrders.Sum(mo => mo.Count())} orders)");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    filaInicial = Console.CursorTop;
                    filaFinal = filaInicial+1;
                    foreach (var mo in e.MonthOrders) {
                        izq = (mo.Key-1)*8;
                        fila = filaInicial;
                        Console.SetCursorPosition(izq, fila++);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"{CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mo.Key), 8}");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        foreach (var o in mo) {
                            Console.SetCursorPosition(izq, fila++);
                            Console.WriteLine($"{o.Freight,8:0.00}");
                        }
                        if (filaFinal < fila)
                            filaFinal = fila;
                    }
                    Console.SetCursorPosition(0, filaFinal++);
                    Console.WriteLine(new string('-', Console.WindowWidth-1));
                    foreach (var mo in e.MonthOrders) {
                        izq = (mo.Key-1)*8;
                        Console.SetCursorPosition(izq, filaFinal);
                        Console.WriteLine($"{mo.Sum(o => o.Freight),8:0.00}");
                    }
                    Console.SetCursorPosition(0, filaFinal+2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($" TOTAL: {e.MonthOrders.Sum(mo => mo.Sum(o => o.Freight)),10:N2}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
            }
        }
        static void ViajesShips() {
            Console.WriteLine("Viajes de cada ship");
            using (var db = new NorthwindContext()) {
                var OrdersShips = db.Orders
                .ToList()
                .GroupBy(o => o.ShipName);
                ImprimirLineaTabla(Posicion.Top);
                ImprimirLineaTabla("Nombre ship", "N.Viajes", "Freight total");
                ImprimirLineaTabla(Posicion.Mid);
                foreach (var s in OrdersShips) {
                    ImprimirLineaTabla(
                        s.Key,
                        s.Count(),
                        s.Sum(o => o.Freight)
                    );
                }
                ImprimirLineaTabla(Posicion.Bot);
            }
        }
        static void TotalProductos(int año) {
            Console.WriteLine($"Productos pedidos en {año}");
            Console.WriteLine();
            using (var db = new NorthwindContext()) {
                var OrdersAño = db.Orders
                .Where(o => o.OrderDate.Value.Year == año)
                .Include(o => o.OrderDetails);
                // Console.WriteLine($"Total pedidos: {OrdersAño.Count():N0}");
                Console.WriteLine($"Total productos pedidos: {OrdersAño.Sum(o => o.OrderDetails.Sum(od => od.Quantity)):N0}");
                Console.WriteLine($"Importe total: {OrdersAño.Sum(o => o.OrderDetails.Sum(od => (od.Quantity * od.UnitPrice * (1-od.Discount)))):N2} euros");
            }
        }
        static void TotalClientes(int año) {
            Console.WriteLine($"Clientes en {año}");
            Console.WriteLine();
            string nombre_fichero = $"clientes{año}.txt";
            Fichero = new StreamWriter(nombre_fichero);
            using (var db = new NorthwindContext()) {
                var OrdersClientes = db.Orders
                .Where(o => o.ShippedDate.Value.Year == año)
                .Where(o => !string.IsNullOrEmpty(o.CustomerId))
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .ToList()
                .GroupBy(o => o.Customer);
                foreach (var c in OrdersClientes) {
                    string nombre_cliente = $"{c.Key.CompanyName, -35} ({c.Key.ContactName})";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(nombre_cliente);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Fichero.WriteLine(nombre_cliente);
                    ImprimirLineaTabla(Posicion.Top);
                    ImprimirLineaTabla("Nombre producto", "Cantidad", "Importe total");
                    ImprimirLineaTabla(Posicion.Mid);
                    foreach (var o in c) {
                        // Console.WriteLine($"{o.OrderId} {o.ShippedDate.Value.ToString("dd/MM/yyyy")}");
                        foreach (var od in o.OrderDetails) {
                            ImprimirLineaTabla(od.Product.ProductName, od.Quantity, od.Quantity * od.UnitPrice * (1-od.Discount));
                        }
                    }
                    ImprimirLineaTabla(Posicion.Mid);
                    ImprimirLineaTabla(
                        "TOTAL",
                        c.Sum(o => o.OrderDetails.Sum(od => od.Quantity)),
                        c.Sum(o => o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice * (1-od.Discount)))
                    );
                    ImprimirLineaTabla(Posicion.Bot);
                    Console.WriteLine();
                    Fichero.WriteLine();
                }
            }
            Fichero.Close();
            Fichero = null;
            Console.WriteLine($"Datos guardados en {nombre_fichero}");
        }
        static void ImprimirLineaTabla(Posicion pos, object o1, object o2, object o3) {
            char izq, sep, der;
            switch(pos) {
                case Posicion.Top:
                    izq = '┌';
                    sep = '┬';
                    der = '┐';
                    break;
                case Posicion.Mid:
                    izq = '├';
                    sep = '┼';
                    der = '┤';
                    break;
                case Posicion.Bot:
                    izq = '└';
                    sep = '┴';
                    der = '┘';
                    break;
                default:
                    izq = '│';
                    sep = '│';
                    der = '│';
                    break;
            }
            int align1 = 35,
                align2 = 9,
                align3 = 14;
            if (o1.GetType() == typeof(string))
                align1 = -align1;
            if (o2.GetType() == typeof(string))
                align2 = -align2;
            if (o3.GetType() == typeof(string))
                align3 = -align3;
            string format = "{3}{0,"+align1+"}{4}{1,"+align2+"}{4}{2,"+align3+":N2}{5}";
            string salida = string.Format(format, o1, o2, o3, izq, sep, der);
            Console.WriteLine(salida);
            if (Fichero != null)
                Fichero.WriteLine(salida);
        }
        static void ImprimirLineaTabla(object o1, object o2, object o3) {
            ImprimirLineaTabla(Posicion.Val, o1, o2, o3);
        }
        static void ImprimirLineaTabla(Posicion pos) {
            ImprimirLineaTabla(pos,
                new string('─', 35),
                new string('─', 9),
                new string('─', 14)
            );
        }
        static void Main(string[] args)
        {
            
            // FreightEmpleados(1997);
            ViajesShips();
            // TotalProductos(1998);
            // TotalClientes(1997);
           
        }
    }
}
