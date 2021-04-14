using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    class Livro : ItemLoja
    {
        public string Titulo { get; private set; }
        public EnumGenero Genero { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
        public Livro(long id, string titulo, EnumGenero genero, string autor, string editora, PessoaJuridica fornecedor,
            float precoCompra, float precoVenda, int quantidadeEstoque)
            : base(id, fornecedor, precoCompra, precoVenda, quantidadeEstoque)
        {
            Titulo = titulo;
            Genero = genero;
            Autor = autor;
            Editora = editora;
        }
        public override void MostrarDescricao()
        {
            Console.WriteLine($"Título:{Titulo}/n Gênero:{Genero}/n Autor:{Autor}/n Editora:{Editora}");
        }
    }
}
