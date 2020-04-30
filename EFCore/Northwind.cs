using Microsoft.EntityFrameworkCore;

namespace EFCore{
    //esto maneja la conexión con la base de datos
    public class Northwind : DbContext{
        //estas  propiedades mapean las tablas de la base de datos

        public DbSet<Category> Categories{get; set;}
        public DbSet<Product> Products{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            string ruta = @"C:\SQLite\Northwind.db";
            optionsBuilder.UseSqlite($"Filename={ruta}");
            //string ruta2 = System.IO.Path.Combine (System.Environment.CurrentDirectory, "Northwind.db");
        }

        /*protected override void OnModelCreating (ModelBuilder modelBuilder){
            modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired() //NOT NULL
            .HasMaxLength(15);
        }*/

        
    }
}