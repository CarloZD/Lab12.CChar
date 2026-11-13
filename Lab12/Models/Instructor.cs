using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class Instructor
    {
        [Key]
        public int IdInstructor { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Especialidad { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Activo { get; set; }
    }
}
