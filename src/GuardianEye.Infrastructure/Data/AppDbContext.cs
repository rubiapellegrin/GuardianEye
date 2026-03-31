using GuardianEye.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GuardianEye.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Esse comando mágico varre o seu projeto de Infra 
        // e aplica todas as configurações que herdam de IEntityTypeConfiguration
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

}