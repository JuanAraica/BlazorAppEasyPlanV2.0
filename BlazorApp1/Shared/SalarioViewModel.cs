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
        public int Id { get; set; }
        [Required]
        [Display(Name = "Worker ID")]
        public string CedulaTra { get; set; }
        [Required]
        [Display(Name = "Gross salary")]
        public double SalarioBruto { get; set; }
        [Required]
        [Display(Name = "C.C.S.S.")]
        public double Seguro { get; set; }
        [Display(Name = "Advances")]
        public Nullable<double> Adelantos { get; set; }
        [Display(Name = "Other charges")]
        public Nullable<double> Otros { get; set; }
        [Display(Name = "Net salary")]
        public double SalarioNeto { get; set; }
        [Display(Name = "First date")]
        public DateOnly PrimeraFecha { get; set; }
        [Display(Name = "Last date")]
        public DateOnly UltimaFecha { get; set; }
        [Display(Name = "Total deductions")]
        public double TotalDeducciones { get; set; }
        [Display(Name = "Date")]
        public string FechaSalario { get; set; }
    }
}
