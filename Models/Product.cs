using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        // [Key] ->Anotacion si la propiedad no se llama Id ejemplo ProductId 
        public int Id { get; set; } // Seria la llave primaria 
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]

        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; } // seria la llave foranea
        public Category Category { get; set; } // Propiedad de navegacion

    }
}
