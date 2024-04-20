using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADSProject.Models
{
    public class Carrera
    {
        public int IdCarrera { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede ser mayor a 3 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser mayor a 40 caracteres.")]
        public string Nombre { get; set; }
    }
}
