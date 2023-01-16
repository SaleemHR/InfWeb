using Microsoft.EntityFrameworkCore;


namespace Lecture0EF;

class MyContext:DbContext{
  //public DbContext(DbContextOptions options);
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       //modelBuilder.Entity<ShoppingCart>().HasKey(_ => new { _.OrderID, _.ProductID });
       
        //modelBuilder.Entity<Product>()
        //    .HasOne<Company>(_ => _._Company)
        //    .WithMany()
        //    .HasForeignKey(_ => _.CompanyID)
        //    .OnDelete(DeleteBehavior.SetNull);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID = postgres; Password = a; Host = localhost; port = 5434; Database = Lecture0EF; Pooling = true");
        //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Debug);
        //optionsBuilder.EnableSensitiveDataLogging();
    }

    public DbSet<Person> Persons { get; set; } = null!;
    public DbSet<Payment> Payments{get;set;} = null!;
  
}