using LocalMovieTheaterIncomings.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalMovieTheaterIncomings.Core.Repositories.Interfaces;

public abstract partial class IFoodRepository: DbContext
{
    public IFoodRepository()
    {
    }

    public IFoodRepository(DbContextOptions<IFoodRepository> options)
        : base(options)
    {
    }
        
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MovieTheaterIncomings;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FoodItem>(entity =>
        {
            entity.ToTable("FoodItem");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");

            entity.Property(e => e.FoodName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Saleprice).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
        });
        OnModelCreatingPartial(modelBuilder);
    }
        
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
    public virtual DbSet<FoodItem> FoodItems { get; set; } = null!;

    public abstract IEnumerable<FoodItem> GetAllSold();
}