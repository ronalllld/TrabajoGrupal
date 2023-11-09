using empresa1.Models;
using empresa1.Models1;
using Microsoft.EntityFrameworkCore;

namespace Empresa1.Context
{
    public class Aplication_Context : DbContext
    {
        public Aplication_Context(DbContextOptions<Aplication_Context> options)
            : base(options) { }


        public DbSet<Salario> salario { get; set; }
        public DbSet<Departamento> departamento { get; set; }


    }
}