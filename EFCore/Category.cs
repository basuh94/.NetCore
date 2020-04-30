using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore{
    public class Category{
        //Estas propiedades formatear los campos en la base de datos
        public int CategoryID {get; set;}
        public string CategoryName {get; set;}
        [Column(TypeName = "ntext")]
        public string Description {get; set;}
        public virtual ICollection<Product> Products {get; set;}
        public Category(){  
            // Inicializamos como una lista vacía para poder añadir productos 
            this.Products = new List<Product>();
        }
    }
}



