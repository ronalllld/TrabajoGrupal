using System.ComponentModel.DataAnnotations;

namespace empresa1.Models1
{
    public class Departamento
    {
        [Key]
        public int iddepartamento { get; set; }
        public string nombre { get; set; }
        public string area { get; set; }


    }
}