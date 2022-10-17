using LocalMovieTheaterIncomings.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalMovieTheaterIncomings.Core.Repositories.Interfaces;

public abstract partial class ITicketRepository : IDbContextRepository<Ticket>
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.ToTable("Ticket");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");

            entity.Property(e => e.MovieName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Saleprice).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.StudioCutPercentage).HasColumnType("decimal(18, 0)");
        });
    }
}