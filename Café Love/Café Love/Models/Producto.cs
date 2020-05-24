using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Café_Love.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Display(Name = "Codigo")]//Data Anotation
        public string ProductoCode { get; set; }
        
        [Display(Name = "Producto")]//Data Anotation
        public string ProductoName { get; set; }
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

    }
}