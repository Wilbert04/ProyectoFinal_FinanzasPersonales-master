using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class Presupuestos
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        public int PresupuestoId { get; set; }

        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El campo Categoria no puede estar vacío.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacío.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo Monto no puede estar vacío.")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo Fecha no puede estar vacío.")]
        public DateTime Fecha { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuarios Usuarios { get; set; }

        public virtual List<PresupuestoDetalle> Detalle { get; set; }

        public Presupuestos()
        {

            this.Detalle = new List<PresupuestoDetalle>();
        }
    }

}
