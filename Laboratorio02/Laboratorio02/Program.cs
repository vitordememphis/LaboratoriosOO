using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Bob = new ContaCorrente("Bob Nelson", "12345-6", "Conta Corrente");
            Poupanca Testolfo = new Poupanca("Testolfo Rocha", "71717-1", "Conta Poupança");
            ContaCorrente Lisa = new ContaCorrente("Lisa Leite", "65432-1", "Conta Corrente");

            Bob.Depositar(5000);
            Lisa.Depositar(2000);
            Testolfo.Depositar(1500);
            Bob.TransferirPoupanca(Testolfo, 600);
            Lisa.Sacar(250);
            Lisa.TransferirPoupanca(Testolfo, 400);
            Testolfo.TransferirCorrente(Bob, 1000);
            Bob.Sacar(900);
            Bob.TransferirCorrente(Lisa, 1500);
            Testolfo.TransferirCorrente(Lisa, 1200);
            Bob.Sacar(2000);
            Lisa.Depositar(100);
            Testolfo.TransferirCorrente(Bob, 700);
            Bob.VerSaldo();
            Testolfo.VerSaldo();
            Lisa.VerSaldo();
        }
    }
}
