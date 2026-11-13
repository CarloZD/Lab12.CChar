using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Lab12.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }
        public int DuracionHoras { get; set; }
        public bool Activo { get; set; }

        public int IdInstructor { get; set; }

        [ForeignKey("IdInstructor")]
        [JsonIgnore]
        public Instructor? Instructor { get; set; }
    }
}
