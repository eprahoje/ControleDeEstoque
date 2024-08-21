using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Stock
    {
        private List<Product> products = new List<Product>();

        public void NewProduct()
        {
            Console.Write("Informe o nome do produto: ");
            string name = Console.ReadLine();

            Console.Write("Infome o preço: ");
            double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o desenvolvedor: ");
            string developer = Console.ReadLine();

            Console.Write("Informe o Gênero: ");
            string genre = Console.ReadLine();

            Console.Write("Informe a plataforma para qual foi desenvolvido: ");
            string plataform = Console.ReadLine();

            Product productInfo = new Product(name, price, developer, genre, plataform);
            products.Add(productInfo);

            Console.WriteLine("\nJogo adicionado!");

        }

        public void ListProducts()
        {
            for(int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"\nCódigo: {i + 1}. Nome: {products[i].Name} | Preço: R$ {products[i].Price.ToString("F2", CultureInfo.InvariantCulture)} | Desenvolvedor: {products[i].Developer} | Gênero: {products[i].Genre} | Plataforma: {products[i].Plataform} | {products[i].StockQuantity} em estoque");
            }
            if(products.Count == 0)
            {
                Console.WriteLine("\nNenhum produto cadastrado! Por favor, cadastre um novo produto");
            }
        }

        public void RemoveProducts(int code)
        {
            if(code >= 1 && code <= products.Count)
            {
                products.RemoveAt(code - 1);
                Console.WriteLine("\nProduto Removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nCódigo do produto informado não é válido. Tente novamente.");
            }
        }

        public void AddStock(int code, int quantity)
        {
            if(code >= 1 && code <= products.Count)
            {
                products[code - 1].StockQuantity += quantity;
                Console.WriteLine($"\nEstoque de {quantity} adicionado ao produto: {products[code - 1].Name}.");
            }
            else
            {
                Console.WriteLine("\nCódigo do produto informado não é válido. Tente novamente.");
            }          
        }

        public void RemoveStock(int code, int quantity)
        {
            if(code >= 1 && code <= products.Count)
            {
                if(products[code - 1].StockQuantity >= quantity)
                {
                    products[code - 1].StockQuantity -= quantity;
                    Console.WriteLine($"\nEstoque de {quantity} removido do produto: {products[code - 1].Name}."); 
                }
                else
                {
                    Console.WriteLine("\nQuantidade informada maior que a quantidade disponível no estoque! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("\nCódigo do produto informado não é válido. Tente novamente.");
            }     
        }

    }
}