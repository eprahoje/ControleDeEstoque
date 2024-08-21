using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public string Developer { get; set; }
        public string Genre { get; set; }
        public string Plataform { get; set; }

        public Product(string name, double price, string developer, string genre, string plataform)
        {
            Name = name;
            Price = price;
            StockQuantity = 0; 
            Developer = developer;
            Genre = genre;
            Plataform = plataform;
        }
    }
}