using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public int Tipo { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            Descripcion = string.Empty;
            Tipo = 0;
        }
    }

}
