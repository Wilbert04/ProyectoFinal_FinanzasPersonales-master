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
        public int CuentaId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Cuentas()
        {
            CuentaId = 0;
            Nombre = string.Empty;
            Tipo = string.Empty;
        }
    }
}
