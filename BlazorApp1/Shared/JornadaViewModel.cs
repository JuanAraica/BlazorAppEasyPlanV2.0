using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class JornadaViewModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Worker ID")]
        public string CedulaTra { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string TipoJornada { get; set; }
        [Required]
        [Display(Name = "Start Time")]
        public TimeOnly HoraInicio { get; set; }
        [Required]
        [Display(Name = "End Time")]
        public  TimeOnly HoraFin { get; set; }
        [Display(Name = "Price Regular Hour")]
        public Nullable<double> PrecioHoraRegular { get; set; }
        [Display(Name = "Price Extra Hour")]
        public Nullable<double> PrecioHoraExtra { get; set; }
        [Display(Name = "Regular Hours")]
        public Nullable<int> CantidadHorasRegulares { get; set; }
        [Display(Name = "Extra Hours")]
        public Nullable<int> CantidadHorasExtras { get; set; }
        [Display(Name = "Total Price Extras Hours")]
        public Nullable<double> ValorTotalHoraExtra { get; set; }
        [Display(Name = "Total Price Regular Hours")]
        public Nullable<double> ValorTotalHorasRegulares { get; set; }
        [Display(Name = "Price for Day")]
        public Nullable<double> PrecioDia { get; set; }
        [Display(Name = "Unit of Measurement")]
        [Required]
        public string UnidadMedida { get; set; }
        [Display(Name = "Unit of Measurement's Price")]
        public Nullable<double> PrecioUnidadMedida { get; set; }
        [Display(Name = "Price Total Unit of Measurement")]
        public Nullable<double> ValorTotalUnidadMedida { get; set; }
        [Display(Name = "Metro Price")]
        public Nullable<double> PrecioMetro { get; set; }
        [Display(Name = "Package Price")]
        public Nullable<double> PrecioPaquete { get; set; }
        [Display(Name = "Extra Labor")]
        public string LaborExtra { get; set; }
        [Display(Name = "Price Extra Labor")]
        public Nullable<double> PrecioLaborExtra { get; set; }
        [Required]
        [Display(Name = "Date")]
        public string FechaJornada { get; set; }
        [Display(Name = "day salary")]
        public double SalarioJornada { get; set; }
        [Display(Name = "Observation")]
        public string Observacion { get; set; }
        [Display(Name = "Name")]
        public string nombreJornada { get; set; }
    }
}
