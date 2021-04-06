using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class Usuarios
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir un Nombre.")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Cedula no puede estar vacío.")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El campo Telefono no puede estar vacío.")]
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Fecha = DateTime.Now;
        }

    }
}
