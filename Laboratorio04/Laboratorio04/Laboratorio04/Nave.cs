using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class Nave : IObjetoMovel, IObjetoDestrutivel
    {
        public string Nome { get; protected set; }
        public int Combustivel { get; protected set; }
        public int Energia { get; protected set; }
        public int Velocidade { get; protected set; }
        public Posicao Posicao { get; protected set; }

        public Nave(string nome,int combustivel,int energia,int velocidade,Posicao posicao)
        {
            Nome = nome;
            Combustivel = combustivel;
            Energia = energia;
            Velocidade = velocidade;
            Posicao = posicao;
        }

        public virtual void Mover()
        {
            Posicao posicaoNova = new Posicao(Posicao.Posicaox + Velocidade, Posicao.Posicaoy + Velocidade);
            Posicao = posicaoNova;
            Console.WriteLine("{0} se moveu para a posição ({1},{2}).", Nome, Posicao.Posicaox, Posicao.Posicaoy);
            Console.ReadLine();
        }
        public void DanoPequeno()
        {
            Energia -= 10;
            if (Energia <= 0)
                Console.WriteLine("{0} foi destruida.", Nome);
            else
                Console.WriteLine("A energia da {0} é {1}", Nome, Energia);
            Console.ReadLine();
        }
        public void DanoMedio()
        {
            Energia -= 20;
            if (Energia <= 0)
                Console.WriteLine("{0} foi destruida.", Nome);
            else
                Console.WriteLine("A energia da {0} é {1}", Nome, Energia);
            Console.ReadLine();
        }
        public void DanoGrave()
        {
            Energia -= 40;
            if (Energia <= 0)
                Console.WriteLine("{0} foi destruida.", Nome);
            else
                Console.WriteLine("A energia da {0} é {1}", Nome, Energia);

            Console.ReadLine();
        }
    }
}
