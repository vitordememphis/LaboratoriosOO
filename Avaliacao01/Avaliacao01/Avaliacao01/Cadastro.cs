using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    class Cadastro
    {
        List<PessoaFisica> Clientes { get; set; }
        List<PessoaJuridica> Fornecedores { get; set; }
        public Cadastro(List<PessoaFisica> clientes, List<PessoaJuridica> fornecedores)
        {
            Clientes = clientes;
            Fornecedores = fornecedores;
        }
        public void relacionarClientes()
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                Clientes[i].MostrarDescricao();
            }
        }
        public void relacionarFornecedores()
        {
            for (int i = 0; i < Fornecedores.Count; i++)
            {
                Fornecedores[i].MostrarDescricao();
            }
        }
        public void AdicionarClientes(PessoaFisica cliente)
        {
            Clientes.Add(cliente);
        }
        public void RemoverClientes(PessoaFisica cliente)
        {
            Clientes.Remove(cliente);
        }
        public void AdicionarFornecedor(PessoaJuridica fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }
        public void RemoverFornecedor(PessoaJuridica fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }

    }
}
