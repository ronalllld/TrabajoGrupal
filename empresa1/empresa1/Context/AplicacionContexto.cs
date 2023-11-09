using Microsoft.EntityFrameworkCore;

namespace empresa1.Context
{
    public class Aplication_Context : DbContext
    {
        public Aplication_Context(DbContextOptions<Aplication_Context> options)
            : base(options) { }
        public DbSet<Departamento> departamento { get; set; }

        public DbSet<Empelado> empleado { get; set; }

        public DbSet<Titulo> titulo { get; set; }
        

    }
}
