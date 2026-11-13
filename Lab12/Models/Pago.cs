using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Lab12.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; } = string.Empty;
        public string EstadoPago { get; set; } = string.Empty;

        public int IdMatricula { get; set; }

        [ForeignKey("IdMatricula")]
        [JsonIgnore]
        public Matricula? Matricula { get; set; }
    }
}
