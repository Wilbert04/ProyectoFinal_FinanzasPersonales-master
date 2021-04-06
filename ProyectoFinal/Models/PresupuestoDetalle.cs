using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class PresupuestoDetalle
    {
        public int Id { get; set; }
        public int PresupuestoId { get; set; }
        public int CategoriaId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }


        public PresupuestoDetalle()
        {
            Id = 0;
            PresupuestoId = 0;
            CategoriaId = 0;
            Monto = 0;
            Fecha = DateTime.Now;
        }

    }
}
