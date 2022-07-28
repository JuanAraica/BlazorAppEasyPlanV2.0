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
        public string NombreCliente { get; set; }
        [Required]
        [Display(Name = "")]
        public string Contacto { get; set; }
        [Required]
        [Display(Name = "")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "")]
        public int Telefono { get; set; }
        [Display(Name = "")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "")]
        public string Proyecto { get; set; }
    }
}
