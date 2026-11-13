using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Lab12.Models
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }
        public DateTime FechaMatricula { get; set; }
        public string Estado { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal MontoTotal { get; set; }

        public int IdEstudiante { get; set; }

        [ForeignKey("IdEstudiante")]
        [JsonIgnore]
        public Estudiante? Estudiante { get; set; }

        public int IdCurso { get; set; }

        [ForeignKey("IdCurso")]
        [JsonIgnore]
        public Curso? Curso { get; set; }
    }
}
