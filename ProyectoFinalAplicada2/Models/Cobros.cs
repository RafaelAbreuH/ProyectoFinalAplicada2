using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        [Required]
        public int EmpeñoId { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Abono { get; set; }

        public Cobros()
        {
            CobroId = 0;
            EmpeñoId = 0;
            Fecha = DateTime.Now;
            Abono = 0;
        }
    }
}
