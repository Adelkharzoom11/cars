using AutoPartsStore;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Part> Parts { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // تعيين سلسلة الاتصال بقاعدة البيانات
        optionsBuilder.UseSqlServer("your_connection_string_here");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // تعريف علاقة "One-to-Many" بين القطع والموردين باستخدام المفتاح الخارجي
        modelBuilder.Entity<Part>()
            .HasOne(p => p.Supplier)
            .WithMany(s => s.Parts)
            .HasForeignKey(p => p.SupplierId);

        // تعريف علاقة "Many-to-Many" بين القطع والسيارات باستخدام جدول وسيط
        modelBuilder.Entity<Part>()
            .HasMany(p => p.Cars)
            .WithMany(c => c.Parts)
            .UsingEntity(j => j.ToTable("CarPart"));

        // تعريف علاقة "One-to-Many" بين المبيعات والسيارات باستخدام المفتاح الخارجي
        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Car)
            .WithMany(c => c.Sales)
            .HasForeignKey(s => s.CarId);

        // تعريف علاقة "One-to-Many" بين المبيعات والعملاء باستخدام المفتاح الخارجي
        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Customer)
            .WithMany(c => c.Sales)
            .HasForeignKey(s => s.CustomerId);
    }
}
