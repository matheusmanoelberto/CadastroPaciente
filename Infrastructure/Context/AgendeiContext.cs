using CadastroPaciente.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CadastroPaciente.Infrastructure.Context;
public class AgendeiContext : DbContext
{
    public AgendeiContext(DbContextOptions<AgendeiContext> options) :base(options)
    {
        base.ChangeTracker.LazyLoadingEnabled = false;
    }

    public DbSet<Domain.Entities.ProviderEntity> Providers { get; set; }
   
    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Domain.Entities.ProviderEntity>(new ProviderMapping().Configure);
    }
}