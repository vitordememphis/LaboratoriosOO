using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Poupanca : Conta
    {
        public Poupanca(string _nome, string _id, string _tipoConta)
        {
            Nome = _nome;
            Id = _id;
            TipoConta = _tipoConta;
        }

        public void Sacar(double valor)
        {
            if (Saldo < valor * 1.002)
            {
                Console.WriteLine("Saldo insuficiente. Operação cancelada.");
                Console.ReadLine();
            }
            else
            {
                Saldo -= valor * 1.002;
            }
        }
        public void TransferirPoupanca(Poupanca Destino, double valor)
        {
            if (Saldo < valor * 1.0015)
            {
                Console.WriteLine("Saldo insuficiente. Operação cancelada.");
                Console.ReadLine();
            }
            else
            {
                Destino.Saldo += valor;
                Saldo -= valor * 1.0015;
            }
        }
        public void TransferirCorrente(ContaCorrente Destino, double valor)
        {
            if (Saldo < valor * 1.0015)
            {
                Console.WriteLine("Saldo insuficiente. Operação cancelada.");
                Console.ReadLine();
            }
            else
            {
                Destino.Saldo += valor;
                Saldo -= valor * 1.0015;
            }
        }
    }
}
