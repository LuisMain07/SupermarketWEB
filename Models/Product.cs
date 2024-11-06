using SupermarketWEB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketWEB.Models
{
    public class Product
    {
        //[Key] --► Anotacion si la propiedad no se llama id, Ejemplo ProductId

        public int Id { get; set; } //Sera la llave primaria

        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; } // Sera la llave foranea

        public Category? Category { get; set; } // Propiedad de navegacion
    }
}
