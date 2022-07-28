using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Server.Models
{
    public class Cliente
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string NombreCliente { get; set; }
        [Required]
        public string Contacto { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Telefono { get; set; }
        public string Email { get; set; }
        [Required]
        public string Proyecto { get; set; }
    }
}
