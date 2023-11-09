using System.ComponentModel.DataAnnotations;

namespace empresa1.Context
{
    public class Departamento
    {
        [Key]
        public int iddepartamento { get; set; }
        public string nombre { get; set; }
        public string area { get; set; }


    }
}