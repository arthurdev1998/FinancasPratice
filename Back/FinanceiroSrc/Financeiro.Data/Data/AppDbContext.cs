using Financeiro.Data.Configurations.ApplicationUsers;
using Financeiro.Data.Configurations.Categorias;
using Financeiro.Data.Configurations.Despesas;
using Financeiro.Data.Configurations.SistemasFinanceiros;
using Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<SistemaFinanceiro> SistemaFinanceiros { get; set; }
    public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiros { get; set; }
    public DbSet<Despesa> Despesas { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

        base.OnModelCreating(builder);
    }

}