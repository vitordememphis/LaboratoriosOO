using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    abstract class ItemLoja : IItemRelatorio
    {
        public long Id { get; private set; }
        public PessoaJuridica Fornecedor { get; private set; }
        public float PrecoCompra { get; private set; }
        public float PrecoVenda { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public ItemLoja(long id, PessoaJuridica fornecedor, float precoCompra,float precoVenda, int quantidadeEstoque)
        {
            Id = id;
            Fornecedor = fornecedor;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public virtual void MostrarDescricao()
        {

        }
        public void MostrarQuantidadeEstoque()
        {
            if (QuantidadeEstoque > 0)
                Console.WriteLine($" Há {QuantidadeEstoque} undade(s) restantes.");
            else
                Console.WriteLine("O estoque acabou.");
        }
    }
}
