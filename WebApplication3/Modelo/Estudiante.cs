using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication3.Modelo
{
    public class Estudiante
    {
        [Key]
        public BigInteger idEstudiante { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public BigInteger Edad {  get; set; }
        public bool Sexo { get; set; }
        public BigInteger idUniversidad { get; set; }
    }
}
