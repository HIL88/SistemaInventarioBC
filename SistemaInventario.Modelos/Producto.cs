﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name ="Numero de Serie")]
        public String NumeroSerie { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Descripcion")]
        public String Descripcion { get; set; }

        [Required]
        [Range(1,1000)]
        [Display(Name = "Precio")]
        public double Precio { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Costo")]
        public double Costo { get; set; }


        public  string ImagenUrl { get; set; }

        //Foreing Keys

        [Required]
        public  int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        //recursividad

        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set; }

    }
}
