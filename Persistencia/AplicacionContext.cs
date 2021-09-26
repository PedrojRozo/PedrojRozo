using Microsoft.EntityFrameworkCore;
using Dominio;
namespace Persistencia
{
    public class AplicacionContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Persona> persona { get; set; }
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = Team2;Integrated Security = True";
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
    }
}