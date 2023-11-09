using empresa1.Context;
using Microsoft.EntityFrameworkCore;

namespace Empresa1.Context
{
    public class Aplication_Context : DbContext
    {
        public Aplication_Context(DbContextOptions<Aplication_Context> options)
            : base(options) { }


        public DbSet<Departamento> departamento { get; set; }
        public DbSet<Titulo> titulo { get; set; }
        public DbSet<Seguro> seguro { get; set; }
        public DbSet<Salario> salario { get; set; }


    }
}