using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; private set; }
        public PessoaJuridica(long id, string nome, string cnpj, Endereco endereco, string email) : base(id,nome,endereco,email)
        {
            CNPJ = cnpj;
        }
        public override void MostrarDescricao()
        {
            Console.WriteLine($"Nome:{Nome}/n CNPJ:{CNPJ}/n");
        }
    }
}
