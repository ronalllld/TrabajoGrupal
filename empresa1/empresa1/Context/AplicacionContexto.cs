using Microsoft.EntityFrameworkCore;

namespace empresa1.Context
{
    public class Aplication_Context : DbContext
    {
        public Aplication_Context(DbContextOptions<Aplication_Context> options)
            : base(options) { }

        public DbSet<Empelado> empleado { get; set; }

    }
}
