using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Estado estadoBobNelson = new Estado("Distrito Federal", "DF");
            Cidade cidadeBobNelson = new Cidade("Brasília",estadoBobNelson);
            Bairro bairroBobNelson = new Bairro("Bairro Jardim das Oliveiras");
            Endereco enderecoBobNelson = new Endereco(23, "Rua das Classes", bairroBobNelson, cidadeBobNelson);
            PessoaFisica bobNelson = new PessoaFisica(100, "Bob Nelson", "111.222.333-99", enderecoBobNelson, false, "bobNelson@gmail.com");

            Estado estadoTestolfoRocha = new Estado("Goiás", "GO");
            Cidade cidadeTestolfoRocha = new Cidade("Rio Verde", estadoTestolfoRocha);
            Bairro bairroTestolfoRocha = new Bairro("Bairro Operarios");
            Endereco enderecoTestolfoRocha = new Endereco(4, "Avenida Abstrata", bairroTestolfoRocha, cidadeTestolfoRocha);
            PessoaFisica testolfoRocha = new PessoaFisica(200, "Testolfo Rocha", "444.555.666-11", enderecoTestolfoRocha, true, "testolfoRocha26@gmail.com");

            Estado estadoBeloTeste = new Estado("Minas Gerais", "MG");
            Cidade cidadeBeloTeste = new Cidade("Belo Horizonte", estadoBeloTeste);
            Bairro bairroBeloTeste = new Bairro("Bairro Monges Unidos");
            Endereco enderecoBeloTeste = new Endereco(26, "Vale das Heranças", bairroBeloTeste, cidadeBeloTeste);
            PessoaFisica beloTeste = new PessoaFisica(200, "Belo Teste", "999.888.777-72", enderecoBeloTeste, true, "Testebelo@gmail.com");

            Estado estadoLivrosAssociados = new Estado("Rio de Janeiro", "RJ");
            Cidade cidadeLivrosAssociados = new Cidade("Rio de Janeiro", estadoLivrosAssociados);
            Bairro bairroLivrosAssociados = new Bairro("Copacabana");
            Endereco enderecoLivrosAssociados = new Endereco(45, "Edifício Gaveta",bairroLivrosAssociados,cidadeLivrosAssociados);
            PessoaJuridica livrosAssociados = new PessoaJuridica(100, "Livros Associados SA", "99.8888.7777-77",enderecoLivrosAssociados, "faleconosco@associados.com");

            Livro domCasmurro = new Livro(100, "Dom Casmurro", EnumGenero.Ficção,"Machado de Assis", "Universal", livrosAssociados, 19.99f, 31.99f,20);
            Livro Unity = new Livro(170, "Unity: design e desenvolvimento de jogos", EnumGenero.Games, "William Pereira Alves", "Universal", livrosAssociados, 24.35f, 58.99f, 10);

            Caderno caderno100 = new Caderno(170, 100, livrosAssociados, 10.99f, 25.99f, 15);

            List<PessoaFisica> cadastroClientes = new List<PessoaFisica> { bobNelson, testolfoRocha, beloTeste };
            List<PessoaJuridica> cadastroFornecedores = new List<PessoaJuridica> { livrosAssociados };
        }
    }
}
