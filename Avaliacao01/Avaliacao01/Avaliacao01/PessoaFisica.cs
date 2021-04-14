using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; private set; }
        public bool VIP { get; private set; }
        public PessoaFisica(long id,string nome,string cpf,Endereco endereco,bool vip,string email)
            : base(id, nome, endereco, email)
        {
            CPF = cpf;
            VIP = vip;
        }
        public override void MostrarDescricao()
        {
            Console.WriteLine($"Nome:{Nome}/n CPF:{CPF}/n Vip:{VIP}/n");
        }
    }
}
