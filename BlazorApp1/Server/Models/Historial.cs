using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorApp1.Server.Models
{
    [Table("Historial", Schema = "dbo")]

    public class Historial
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idRegistro { get; set; }
        public string Registro { get; set; }
        public string fecha { get; set; }
    }
}
