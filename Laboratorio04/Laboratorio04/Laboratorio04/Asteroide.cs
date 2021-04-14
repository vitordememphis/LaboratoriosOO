using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class Asteroide : IObjetoMovel, IObjetoDestrutivel
    {
        public int Energia { get; protected set; }
        public Posicao Posicao { get; protected set; }
        public Asteroide(int energia,Posicao posicao)
        {
            Energia = energia;
            Posicao = posicao;
        }
        public void Mover()
        {
            Random aleatorio = new Random();
            Posicao posicaoNova = new Posicao(Posicao.Posicaox + aleatorio.Next(0, 10), Posicao.Posicaoy + aleatorio.Next(0, 10));
            Posicao = posicaoNova;
            Console.WriteLine("O asteroide se moveu para a posição ({0},{1}).", Posicao.Posicaox, Posicao.Posicaoy);
            Console.ReadLine();
        }
        public void DanoPequeno()
        {
            Energia -= 10;
            if (Energia <= 0)
                Console.WriteLine("O asteroide foi destruido.");
            else
                Console.WriteLine("A energia do asteroide é {0}", Energia);
            Console.ReadLine();
        }
        public void DanoMedio()
        {
            Energia -= 20;
            if (Energia <= 0)
                Console.WriteLine("O asteroide foi destruido.");
            else
                Console.WriteLine("A energia do asteroide é {0}", Energia);
            Console.ReadLine();
        }
        public void DanoGrave()
        {
            Energia -= 40;
            if (Energia <= 0)
                Console.WriteLine("O asteroide foi destruido.");
            else
                Console.WriteLine("A energia do asteroide é {0}", Energia);

            Console.ReadLine();
        }
    }
}
