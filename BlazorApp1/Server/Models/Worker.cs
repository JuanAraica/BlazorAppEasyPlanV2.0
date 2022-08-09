using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Server.Models
{
    [Table("Worker", Schema = "dbo")]

    public class Worker
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CedulaTra { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Puesto { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public string Telefono { get; set; }
        public string Correo { get; set; }
        [Required]
        public DateOnly FechaNacimiento { get; set; }
        [Required]
        public string Nacionalidad { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public DateOnly FechaEmpleo { get; set; }
        [Required]
        public string Empleador { get; set; }
        public DateOnly FechaDespido { get; set; }
        public DateOnly InicioIncapacidad { get; set; }
        public DateOnly FinalIncapacidad { get; set; }
        public string Padecimientos { get; set; }
        [Required]
        public string Estado { get; set; }
        public string Observacion { get; set; }
    }
}
