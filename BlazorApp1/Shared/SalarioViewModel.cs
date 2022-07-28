using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class SalarioViewModel
    {
        public int idSalario { get; set; }
        [Required]
        [Display(Name = "Worker")]
        public string CedulaTra { get; set; }
        [Required]
        [Display(Name = "Name")]
        public double SalarioBruto { get; set; }
        [Required]
        public double Seguro { get; set; }
        public Nullable<double> Adelantos { get; set; }
        public Nullable<double> Otros { get; set; }
        public double SalarioNeto { get; set; }
        public DateOnly PrimeraFecha { get; set; }
        public DateOnly UltimaFecha { get; set; }
        public double TotalDeducciones { get; set; }
        public string FechaSalario { get; set; }
    }
}
