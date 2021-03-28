using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto livro1 = new Livro("A Guerra dos Tronos", 60, "George R. R. Martin");
            Produto livro2 = new Livro("Musashi", 65, "Eiji Yoshikawa");

            Produto jogo1 = new JogoDigital("Final Fantasy VII Remake", 350, "PS4");
            Produto jogo2 = new JogoDigital("The Legend of Zelda: Breath of the Wild", 300, "Nintendo Switch");

            Produto produto1 = new Produto("iPhone 12 Pro", 7664);

            Produto[] produtos = { jogo1, livro2, produto1 };

            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("-------------------");
                Console.ReadLine();
            }
        }
    }
}
