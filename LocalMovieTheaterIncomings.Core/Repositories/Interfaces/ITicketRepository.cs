using LocalMovieTheaterIncomings.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalMovieTheaterIncomings.Core.Repositories.Interfaces;

public abstract partial class ITicketRepository : DbContext
{
    
    public ITicketRepository()
    {
    }

    public ITicketRepository(DbContextOptions<ITicketRepository> options)
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
    public virtual DbSet<Ticket> Tickets { get; set; } = null!;

    public abstract IEnumerable<Ticket> GetAllSold();
}