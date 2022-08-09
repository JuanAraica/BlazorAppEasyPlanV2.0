using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace BlazorApp1.Server.Models
{
    [Table("Salario", Schema = "dbo")]
    public class Salario
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string CedulaTra { get; set; }
        [Required]
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
