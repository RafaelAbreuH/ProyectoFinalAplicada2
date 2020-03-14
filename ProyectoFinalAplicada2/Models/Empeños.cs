using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Empeños
    {
        [Key]
        public int EmpeñoId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public string NombredeCliente { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal MontoTotal { get; set; }
        [Required]
        public decimal Abono { get; set; }
        [Required]
        public DateTime UltimaFechadeVigencia { get; set; }
        [Required]
        public virtual ICollection<EmpeñosDetalle> Detalle { get; set; }

        public Empeños()
        {
            this.Detalle = new List<EmpeñosDetalle>();
            EmpeñoId = 0;
            ClienteId = 0;
            NombredeCliente = string.Empty;
            Fecha = DateTime.Now;
            MontoTotal = 0;
            Abono = 0;
            UltimaFechadeVigencia = DateTime.Now;
        }
    }
}
