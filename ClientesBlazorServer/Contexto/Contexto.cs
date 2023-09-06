using Microsoft.EntityFrameworkCore;
using ClientesBlazorServer.Models;

namespace ClientesBlazorServer.Contexto
{
    public class Contexto: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> options): base(options) { }
    }
}
