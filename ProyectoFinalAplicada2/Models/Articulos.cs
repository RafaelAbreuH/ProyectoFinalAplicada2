using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Inventario { get; set; }
        public Articulos()
        {
            ArticuloId = 0;
            Nombre = string.Empty;
            Inventario = 0;
        }
    }
}
