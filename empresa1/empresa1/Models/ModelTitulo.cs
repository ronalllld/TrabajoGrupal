using System.ComponentModel.DataAnnotations;

namespace empresa1.Context
{
    public class Titulo
    {
        [Key]
        public long idtitulo { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }


    }
}