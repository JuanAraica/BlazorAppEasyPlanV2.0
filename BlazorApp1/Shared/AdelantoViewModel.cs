using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class AdelantoViewModel
    {

        public int idAdelanto { get; set; }
        [Required]
        [Display(Name = "Worker ID")]
        public string CedulaTra { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int Monto { get; set; }
        [Required]
        [Display(Name = "Date")]
        public string FechaAdelanto { get; set; }
        [Required]
        [Display(Name = "Transmitter")]
        public string EmisorAdelento { get; set; }
    }
}
