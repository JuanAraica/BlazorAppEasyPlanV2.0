using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string NombreCliente { get; set; }
        [Required]
        [Display(Name = "Contact")]
        public string Contacto { get; set; }
        [Required]
        [Display(Name = "Direction")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public int Telefono { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Project")]
        public string Proyecto { get; set; }
    }
}
