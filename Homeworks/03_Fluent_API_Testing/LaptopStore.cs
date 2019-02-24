namespace _03_Fluent_API_Testing
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LaptopStore : DbContext
    {
        public LaptopStore() : base("name=LaptopStore")
        {

        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // To set mthe name of the table manually:
            modelBuilder.Entity<Laptop>().ToTable("Notebooks");

            // To not create a table for one of the classes:
            modelBuilder.Ignore<Phone>();

            // Resetting the primary key
            modelBuilder.Entity<Laptop>().HasKey(x => x.IdentificationNumber);
            // or, for more than one column
            //modelBuilder.Entity<Laptop>().HasKey(x => new { x.IdentificationNumber, x.Name});

            // In order to manually set the name of the column in the table
            modelBuilder.Entity<Laptop>().Property(x => x.Name).HasColumnName("LaptopName");

            // If we dont want to include one of the properties into table, then
            modelBuilder.Entity<Laptop>().Ignore(x => x.Discount);

            // If we want to set the property NOT NULL
            modelBuilder.Entity<Laptop>().Property(x => x.Name).IsRequired();
            // If we want to set the propery NULL-able
            //modelBuilder.Entity<Laptop>().Property(x => x.Name).IsOptional();

            // If we want to set the maximum length of the string
            modelBuilder.Entity<Laptop>().Property(x => x.Name).HasMaxLength(50);

            // If we want to set the string type as unicode
            modelBuilder.Entity<Laptop>().Property(x => x.Name).IsUnicode(true);// or false

            // if we want to manually set the precision of decimal value
            modelBuilder.Entity<Laptop>().Property(x => x.Price).HasPrecision(10, 4);

            // if we want to manually set the type of the column for given property
            modelBuilder.Entity<Laptop>().Property(x => x.Name).HasColumnType("varchar");

            // If we want to present the properties of a class in two different tables
            modelBuilder.Entity<Company>().Map(m =>
            {
                m.Properties(x => new { x.Id, x.Name, x.Director });
                m.ToTable("CompanyInfo");
            }).Map(m =>
            {
                m.Properties(x => new { x.Id, x.Country, x.City, x.Street, x.Phone, x.Email });
                m.ToTable("CompanyContacts");
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}