using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_exercicio3
{
    class JogoDigital : Produto
    {
        public string Plataforma { get; protected set; }

        public JogoDigital(string titulo, double preco, string plataforma): base(titulo,preco)
        {
            Plataforma = plataforma;
        }
        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo}, jogo para {Plataforma}.");
        }
    }
}
