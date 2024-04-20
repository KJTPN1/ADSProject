using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADSProject.Models
{
    public class Materia
    {
        //Kevin Jose Torres Pineda ADS tp17i04001//
        public int IdMateria { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombreMateria { get; set; }
    }
}
