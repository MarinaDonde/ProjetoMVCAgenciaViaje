using Microsoft.EntityFrameworkCore;

namespace AgenciaViaje.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }

        public DbSet<Contato> Contatos { get; set; }
    }
}
