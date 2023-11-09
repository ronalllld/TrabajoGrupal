using System.ComponentModel.DataAnnotations;

namespace empresa1.Models
{
    public class Salario
    {
        [Key]

        public int idsalario { get; set; }

        public string salario { get; set; }

        public DateTime fechainicio { get; set; }

        
    }
}
