﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entities.Dto.Product
{
    public class ProductoDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(500)]
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public decimal Precio { get; set; }


    }
}
