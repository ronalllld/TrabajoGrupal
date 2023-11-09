using empresa1.Models;
using Microsoft.EntityFrameworkCore;

namespace Empresa1.Context
{
    public class Aplication_Context : DbContext
    {
        public Aplication_Context(DbContextOptions<Aplication_Context> options)
            : base(options) { }


        public DbSet<Salario> salario { get; set; }


    }
}