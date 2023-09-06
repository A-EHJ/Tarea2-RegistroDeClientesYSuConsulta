using Microsoft.EntityFrameworkCore;
using ClientesBlazorServer.Models;

namespace ClientesBlazorServer.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> options): base(options) { }
    }
}
