using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    abstract class Pessoa : IItemRelatorio
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Email { get; private set; }
        public Pessoa(long id,string nome, Endereco endereco, string email)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }
        public virtual void MostrarDescricao()
        {

        }
    }
}
