using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_exercicio5
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(string nome, double preco) : base(nome)
        {
            Preco = preco;
        }
    }
}
