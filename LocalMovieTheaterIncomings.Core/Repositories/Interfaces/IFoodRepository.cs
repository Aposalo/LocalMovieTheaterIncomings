using LocalMovieTheaterIncomings.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalMovieTheaterIncomings.Core.Repositories.Interfaces;

public abstract  partial class IFoodRepository: IDbContextRepository<FoodItem>
{
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
    }
}