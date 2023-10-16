using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication3.Modelo
{
    public class Materias
    {
        [Key]
        public BigInteger idMateria {  get; set; }
        public string Nombre { get; set; }
        public BigInteger idDocente { get; set; }
    }
}
