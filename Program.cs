using ControleDeEstoque.Models;
namespace ControleDeEstoque;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu menu = new Menu();
        Stock stock = new Stock();

        int userChoice;

        Console.WriteLine("Controle de estoque | Loja de Games - Desenvolvido por Gabriel Rodrigues.");

        do
        {
            userChoice = menu.MenuOptions();
            switch(userChoice)
            {
                case 1:
                    stock.NewProduct();
                break;

                case 2:
                    stock.ListProducts();
                break;

                case 3: 
                    Console.Write("\nDigite o código do produto que deseja remover: ");
                    int productCodeRemove = Convert.ToInt32(Console.ReadLine());
                    stock.RemoveProducts(productCodeRemove);
                break;

                case 4:
                    Console.Write("\nDigite o código do produto que deseja adicionar estoque: ");
                    int productCodeStockAdd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite a quantidade que deseja adicionar ao estoque: ");
                    int productStockAddQuantity = Convert.ToInt32(Console.ReadLine());
                    stock.AddStock(productCodeStockAdd, productStockAddQuantity);
                break;

                case 5:
                    Console.Write("\nDigite o código do produto que deseja remover estoque: ");
                    int productCodeStockRemove = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite a quantidade que deseja remover do estoque: ");
                    int productStockRemoveQuantity = Convert.ToInt32(Console.ReadLine());
                    stock.RemoveStock(productCodeStockRemove, productStockRemoveQuantity);
                break;

                case 0:
                    Console.WriteLine("\nSaindo do programa de estoque...");
                break;
            }
        } while(userChoice != 0);
    }
    
}
