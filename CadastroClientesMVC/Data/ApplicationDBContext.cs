using CadastroClientesMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastroClientesMVC.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
