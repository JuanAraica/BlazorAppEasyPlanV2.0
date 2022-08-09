using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Server.Models
{
    [Table("Jornada", Schema = "dbo")]
    public class Jornada
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idJornada { get; set; }
        public string CedulaTra { get; set; }
        [Required]
        public string TipoJornada { get; set; }
        [Required]
        public TimeOnly HoraInicio { get; set; }
        [Required]
        public  TimeOnly HoraFin { get; set; }
        public Nullable<double> PrecioHoraRegular { get; set; }
        public Nullable<double> PrecioHoraExtra { get; set; }
        public Nullable<int> CantidadHorasRegulares { get; set; }
        public Nullable<int> CantidadHorasExtras { get; set; }
        public Nullable<double> ValorTotalHoraExtra { get; set; }
        public Nullable<double> ValorTotalHorasRegulares { get; set; }
        public Nullable<double> PrecioDia { get; set; }
        [Required]
        public string UnidadMedida { get; set; }
        public Nullable<double> PrecioUnidadMedida { get; set; }
        public Nullable<double> ValorTotalUnidadMedida { get; set; }
        public Nullable<double> PrecioMetro { get; set; }
        public Nullable<double> PrecioPaquete { get; set; }
        public string LaborExtra { get; set; }
        public Nullable<double> PrecioLaborExtra { get; set; }
        [Required]
        public string FechaJornada { get; set; }
        public double SalarioJornada { get; set; }
        public string Observacion { get; set; }
        public string nombreJornada { get; set; }
    }
}
