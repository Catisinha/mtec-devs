using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Data;

namespace MtecDevs.Data;

public class AppDbContext: IdentityDbContext
{
    public AppDbContext(DbContextOptions opcoes): base (opcoes)
    {
    }

    public DbSet <Usuario> Usuarios { get; set; }
    public DbSet <TipoDev> TipoDevs { get; set; }
}