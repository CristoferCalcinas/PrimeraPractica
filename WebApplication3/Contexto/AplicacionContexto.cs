using Microsoft.EntityFrameworkCore;
using WebApplication3.Modelo;

namespace WebApplication3.Contexto
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions<AplicacionContexto> options):base(options) { }
        public DbSet<Universidad> universidad { get; set; }
        public DbSet<Estudiante> estudiante { get; set; }
        public DbSet<Docente> docente { get; set; }
        public DbSet<Materias> materias { get; set; }
    }
}
