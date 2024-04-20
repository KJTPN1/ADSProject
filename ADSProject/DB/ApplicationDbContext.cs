using ADSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ADSProject.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
            
        }

        //Con un DbSet se indica a EntityFrameworkCore cuales van a ser las tablas que yo quiero tener
        //en la base de datos
        //y tambien le diremos en base a que modelos o entidades vamos a basar dichas tablas, por ejemplo

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
