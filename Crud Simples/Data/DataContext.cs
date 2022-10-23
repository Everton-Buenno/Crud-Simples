using Crud_Simples.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Simples.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
