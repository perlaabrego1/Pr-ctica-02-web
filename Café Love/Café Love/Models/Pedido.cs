using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Café_Love.Models
{
    public class Pedido
    {
                public int Id { get; set; }
        [Display(Name = "Codigo")]//Data Anotation
        
        public string PedidoCode { get; set; }
        [Display(Name = "Pedido")]//Data Anotation
        public string PedidotName { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        public decimal Total { get;set; }
        
    }
}