using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class WorkerViewModel
    {

        public string Id { get; set; }
        [Required]
        [Display(Name = "ID ")]
        public string CedulaTra { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Position")]
        public string Puesto { get; set; }
        [Required]
        [Display(Name = "Age")]
        public int Edad { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Telefono { get; set; }
        [Display(Name = "E-mail")]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateOnly FechaNacimiento { get; set; }
        [Required]
        [Display(Name = "Nationality")]
        public string Nacionalidad { get; set; }
        [Required]
        [Display(Name = "City")]
        public string Ciudad { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Hiring date")]
        public DateOnly FechaEmpleo { get; set; }
        [Required]
        [Display(Name = "Employer")]
        public string Empleador { get; set; }
        [Display(Name = "Dismissal date")]
        public DateOnly FechaDespido { get; set; }
        [Display(Name = "Onset of disability")]
        public DateOnly InicioIncapacidad { get; set; }
        [Display(Name = "End of disability")]
        public DateOnly FinalIncapacidad { get; set; }
        [Display(Name = "Ailments")]
        public string Padecimientos { get; set; }
        [Required]
        [Display(Name = "State")]
        public string Estado { get; set; }
        [Display(Name = "Observation")]
        public string Observacion { get; set; }
    }
}
