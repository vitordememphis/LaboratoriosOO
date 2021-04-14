using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    class Caderno : ItemLoja
    {
        public int QuantidadeFolhas { get; private set; }
        public Caderno(long id, int quantidadeFolhas,PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque)
            : base(id, fornecedor, precoCompra, precoVenda, quantidadeEstoque)
        {
            QuantidadeFolhas = quantidadeFolhas;
        }
        public override void MostrarDescricao()
        {
            Console.WriteLine($"Caderno {QuantidadeFolhas} folhas.");
        }
    }
}
