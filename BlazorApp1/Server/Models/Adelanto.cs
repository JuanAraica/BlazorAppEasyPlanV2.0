using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Server.Models
{
    [Table("Adelanto", Schema = "dbo")]

    public class Adelanto
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string CedulaTra { get; set; }
        [Required]
        public double Monto { get; set; }
        [Required]
        public string FechaAdelanto { get; set; }
        [Required]
        public string EmisorAdelanto { get; set; }
    }
}
