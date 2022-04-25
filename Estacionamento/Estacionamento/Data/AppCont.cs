using Estacionamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Data
{
    public class AppCont : DbContext
    {
        
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
