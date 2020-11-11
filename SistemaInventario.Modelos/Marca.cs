﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaInventario.Modelos
{
   public class Marca
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre Marca")]
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}
