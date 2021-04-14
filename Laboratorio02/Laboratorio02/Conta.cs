using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Conta
    {
        string nome;
        string id;
        string tipoConta;
        double saldo;
        public string Nome { get; protected set; }
        public string Id { get; protected set; }
        public string TipoConta { get; protected set; }
        public double Saldo { get; protected set; }

        public void Depositar(double deposito)
        {
            Saldo = Saldo + deposito;
        }
        public void VerSaldo()
        {
            Console.WriteLine("O saldo de {0} é de R$ {1}.", Nome, Saldo);
            Console.ReadLine();
        }
    }
}
