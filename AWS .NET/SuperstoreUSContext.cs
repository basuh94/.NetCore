using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AWS_.NET
{
    public partial class SuperstoreUSContext : DbContext
    {
        public SuperstoreUSContext()
        {
        }

        public SuperstoreUSContext(DbContextOptions<SuperstoreUSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Charts1> Charts1 { get; set; }
        public virtual DbSet<Charts2> Charts2 { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Date_Time> Date_Time { get; set; }
        public virtual DbSet<Decimals> Decimals { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersCentral> OrdersCentral { get; set; }
        public virtual DbSet<OrdersEast> OrdersEast { get; set; }
        public virtual DbSet<OrdersSouth> OrdersSouth { get; set; }
        public virtual DbSet<OrdersWest> OrdersWest { get; set; }
        public virtual DbSet<OrdersWithDictionary> OrdersWithDictionary { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<PeopleMultiple> PeopleMultiple { get; set; }
        public virtual DbSet<PeopleMultiple1> PeopleMultiple1 { get; set; }
        public virtual DbSet<Returns> Returns { get; set; }
        public virtual DbSet<Shapes> Shapes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=ec2-52-14-205-70.us-east-2.compute.amazonaws.com;user=SQL;password=SQL;database=SuperstoreUS");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Charts1>(entity =>
            {
                entity.HasKey(e => e.Chart);

                entity.Property(e => e.Chart).HasMaxLength(50);
            });

            modelBuilder.Entity<Charts2>(entity =>
            {
                entity.HasKey(e => e.Chart);

                entity.Property(e => e.Chart).HasMaxLength(50);
            });

            modelBuilder.Entity<Colors>(entity =>
            {
                entity.HasKey(e => e.Color);

                entity.Property(e => e.Color).HasMaxLength(50);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Segment).HasMaxLength(255);
            });

            modelBuilder.Entity<Date_Time>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTime1).HasColumnType("datetime");

                entity.Property(e => e.DateTime2).HasColumnType("datetime");
            });

            modelBuilder.Entity<Decimals>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Number).HasColumnType("decimal(30, 7)");
            });

            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateType)
                    .HasColumnName("Date Type")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Dictionary1)
                    .HasColumnName("Dictionary")
                    .HasMaxLength(255);

                entity.Property(e => e.ImpliedDecimals).HasColumnName("Implied Decimals");

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.HasIndex(e => new { e.OrderId, e.OrderDate, e.ShipDate, e.ShipMode, e.CustomerName, e.Segment, e.Country, e.City, e.State, e.PostalCode, e.Region, e.ProductId, e.Category, e.SubCategory, e.ProductName, e.Sales, e.Quantity, e.Discount, e.Profit, e.CustomerId })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.Property(e => e.RowId).HasColumnName("Row ID");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order ID")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasColumnName("Postal Code");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.Sales).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Segment).HasMaxLength(255);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("Ship Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipMode)
                    .HasColumnName("Ship Mode")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("Sub-Category")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OrdersCentral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_Central");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order ID")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasColumnName("Postal Code");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.RowId).HasColumnName("Row ID");

                entity.Property(e => e.Sales).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Segment).HasMaxLength(255);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("Ship Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipMode)
                    .HasColumnName("Ship Mode")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("Sub-Category")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OrdersEast>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_East");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order ID")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasColumnName("Postal Code");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.RowId).HasColumnName("Row ID");

                entity.Property(e => e.Sales).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Segment).HasMaxLength(255);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("Ship Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipMode)
                    .HasColumnName("Ship Mode")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("Sub-Category")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OrdersSouth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_South");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasColumnName("Postal Code");

                entity.Property(e => e.Product).HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.RowId).HasColumnName("Row ID");

                entity.Property(e => e.Segment).HasMaxLength(255);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("Ship Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipMode)
                    .HasColumnName("Ship Mode")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("Sub-Category")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OrdersWest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_West");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order ID")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasColumnName("Postal Code");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.RowId).HasColumnName("Row ID");

                entity.Property(e => e.Sales).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Segment).HasMaxLength(255);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("Ship Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipMode)
                    .HasColumnName("Ship Mode")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("Sub-Category")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OrdersWithDictionary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders with Dictionary");

                entity.Property(e => e.Orcate)
                    .HasColumnName("ORCATE")
                    .HasMaxLength(255);

                entity.Property(e => e.Orcity)
                    .HasColumnName("ORCITY")
                    .HasMaxLength(255);

                entity.Property(e => e.Orcsid)
                    .HasColumnName("ORCSID")
                    .HasMaxLength(255);

                entity.Property(e => e.Orcsnm)
                    .HasColumnName("ORCSNM")
                    .HasMaxLength(255);

                entity.Property(e => e.Orctry)
                    .HasColumnName("ORCTRY")
                    .HasMaxLength(255);

                entity.Property(e => e.Ordamt)
                    .HasColumnName("ORDAMT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Orivdt)
                    .HasColumnName("ORIVDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Orordt)
                    .HasColumnName("ORORDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ororid)
                    .HasColumnName("ORORID")
                    .HasMaxLength(255);

                entity.Property(e => e.Orpamt)
                    .HasColumnName("ORPAMT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Orpost)
                    .HasColumnName("ORPOST")
                    .HasMaxLength(255);

                entity.Property(e => e.Orprid)
                    .HasColumnName("ORPRID")
                    .HasMaxLength(255);

                entity.Property(e => e.Orprnm)
                    .HasColumnName("ORPRNM")
                    .HasMaxLength(255);

                entity.Property(e => e.Orqamt)
                    .HasColumnName("ORQAMT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Orregi)
                    .HasColumnName("ORREGI")
                    .HasMaxLength(255);

                entity.Property(e => e.Orroid).HasColumnName("ORROID");

                entity.Property(e => e.Orsamt)
                    .HasColumnName("ORSAMT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Orsbca)
                    .HasColumnName("ORSBCA")
                    .HasMaxLength(255);

                entity.Property(e => e.Orsegm)
                    .HasColumnName("ORSEGM")
                    .HasMaxLength(255);

                entity.Property(e => e.Orshdt)
                    .HasColumnName("ORSHDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Orshmd)
                    .HasColumnName("ORSHMD")
                    .HasMaxLength(255);

                entity.Property(e => e.Orstat)
                    .HasColumnName("ORSTAT")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.HasKey(e => e.Region);

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.Person).HasMaxLength(255);
            });

            modelBuilder.Entity<PeopleMultiple>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("People_Multiple");

                entity.Property(e => e.Person).HasMaxLength(255);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PeopleMultiple1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PeopleMultiple");

                entity.Property(e => e.Person).HasMaxLength(255);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Returns>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Returned).HasMaxLength(255);
            });

            modelBuilder.Entity<Shapes>(entity =>
            {
                entity.HasKey(e => e.Shape);

                entity.Property(e => e.Shape).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
