using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Menu
    {
        public int MenuOptions()
        {
            Console.WriteLine(@"
            [1] Novo
            [2] Listar produtos
            [3] Remover produtos
            [4] Entrada estoque
            [5] Saída estoque
            [0] Sair");

            Console.Write(">> ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            return userChoice;

        }
    }
}