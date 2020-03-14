using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class EmpeñosDetalle
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int EmpeñoId { get; set; }
        [Required]
        public int ArticuloId { get; set; }
        [Required]
        public string Articulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Monto { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulos { get; set; }
        public EmpeñosDetalle()
        {
            ID = 0;
            EmpeñoId = 0;
        }
        public EmpeñosDetalle(int Id, int reciboId, int articuloId, string articulo, string descripcion, int cantidad, decimal monto)
        {
            ID = Id;
            EmpeñoId = reciboId;
            ArticuloId = articuloId;
            Articulo = articulo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Monto = monto;
        }
    }
}
