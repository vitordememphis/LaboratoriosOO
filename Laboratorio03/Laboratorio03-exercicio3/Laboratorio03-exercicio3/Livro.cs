using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_exercicio3
{
    class Livro : Produto
    {
        public string Autor { get; protected set; }

        public Livro(string titulo, double preco, string autor): base(titulo, preco)
        {
            Autor = autor;
        }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo}, obra de {Autor}.");
        }
    }
}
