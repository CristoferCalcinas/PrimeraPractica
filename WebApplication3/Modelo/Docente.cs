using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication3.Modelo
{
    public class Docente
    {
        [Key]
        public BigInteger idDocente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Ubicacion { get; set; }
        public bool Sexo {  get; set; }
        public string? CI { get; set; }
        public BigInteger idUniversidad { get; set; }

    }
}
