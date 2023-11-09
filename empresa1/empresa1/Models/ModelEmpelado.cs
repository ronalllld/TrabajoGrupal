using System.ComponentModel.DataAnnotations;

namespace empresa1.Context
{
    public class Empelado
    {
        [Key]
        public long idempleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string genero { get; set; }
        public string fechanacimiento { get; set; }
    }
}