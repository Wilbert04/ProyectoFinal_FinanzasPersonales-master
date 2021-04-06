using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class Cuentas
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        public int CuentaId { get; set; }
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        public int PresupuestoId { get; set; }
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        public string Tipo { get; set; }

        public Cuentas()
        {
            CuentaId = 0;
            Nombre = string.Empty;
            Tipo = string.Empty;
        }
    }
}
