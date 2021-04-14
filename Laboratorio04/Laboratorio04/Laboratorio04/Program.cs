using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste 1

            Posicao posicaoBobNelson = new Posicao(0, 0);
            Posicao posicaoNavePirata = new Posicao(5, 5);
            Posicao posicaoasteroide1 = new Posicao(2, 2);
            Posicao posicaoasteroide2 = new Posicao(1, 1);
            NaveGuerra naveBobNelson = new NaveGuerra("Nave do Bob Nelson", 50, 100, 5, posicaoBobNelson, 30, 5);
            NaveGuerra navePirata1 = new NaveGuerra("Nave Pirata 1", 50, 20, 3, posicaoNavePirata, 30, 1);
            NaveGuerra navePirata2 = new NaveGuerra("Nave Pirata 2", 50, 30, 2, posicaoNavePirata, 30, 1);
            NaveGuerra navePirata3 = new NaveGuerra("Nave Pirata 3", 50, 10, 1, posicaoNavePirata, 30, 1);
            Asteroide asteroide1 = new Asteroide(15, posicaoasteroide1);
            Asteroide asteroide2 = new Asteroide(10, posicaoasteroide2);

            naveBobNelson.AtirarNave(navePirata1);
            naveBobNelson.AtirarNave(navePirata2);
            naveBobNelson.AtirarNave(navePirata3);

            navePirata1.DanoGrave();
            navePirata2.DanoGrave();
            navePirata3.DanoGrave();

            //Teste 2

            Posicao posicaoBobNelson2 = new Posicao(2, 2);
            NaveTransporte naveBobNelson2 = new NaveTransporte("Nave do Bob Nelson", 50, 100, 3, posicaoBobNelson2, 1);
            Posicao destino = new Posicao(4, 4);
            Posicao posicaoNavePirata2 = new Posicao(1, 1);
            NaveGuerra navePirata4 = new NaveGuerra("Nave Pirata 4", 50, 20, 3, posicaoNavePirata2, 30, 1);
            NaveGuerra navePirata5 = new NaveGuerra("Nave Pirata 5", 50, 30, 2, posicaoNavePirata2, 30, 1);
            naveBobNelson2.ConfirmarDestino(destino);
            navePirata4.AtirarNave(naveBobNelson2);
            naveBobNelson2.DanoPequeno();
            navePirata5.AtirarNave(naveBobNelson2);
            naveBobNelson2.DanoPequeno();
            naveBobNelson2.Mover();
            naveBobNelson2.ChecarDestino(naveBobNelson2.Posicao);

            Console.ReadLine();
        }
    }
}
