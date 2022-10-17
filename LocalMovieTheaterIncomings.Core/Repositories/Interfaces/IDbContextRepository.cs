using Microsoft.EntityFrameworkCore;

namespace LocalMovieTheaterIncomings.Core.Repositories.Interfaces;

public abstract class IDbContextRepository<T> : DbContext where T : class
{
    public IDbContextRepository()
    {
    }

    public IDbContextRepository(DbContextOptions<IDbContextRepository<T>> options)
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
    
    public virtual DbSet<T> Items { get; set; } = null!;

    public abstract IEnumerable<T> GetAllSold();
}