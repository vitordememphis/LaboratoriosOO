using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class NaveTransporte : Nave
    {
        public int Carga { get; protected set; }
        public Posicao Destino { get; protected set; }

        public NaveTransporte(string nome,int combustivel,int energia,int velocidade,Posicao posicao, int carga) 
            : base(nome, combustivel, energia, velocidade, posicao)
        {
            Carga = carga;
        }
        public override void Mover()
        {
            Posicao posicaoNova = new Posicao(Posicao.Posicaox + Velocidade - Carga, Posicao.Posicaoy + Velocidade - Carga);
            Posicao = posicaoNova;
            Console.WriteLine("{0} se moveu para a posição ({1},{2}).", Nome, Posicao.Posicaox, Posicao.Posicaoy);
            Console.ReadLine();
        }
        public void ConfirmarDestino(Posicao destino)
        {
            Destino = destino;
        }
        public void ChecarDestino(Posicao posicaoAtual)
        {
            if (posicaoAtual.Posicaox == Destino.Posicaox && posicaoAtual.Posicaoy==Destino.Posicaoy)
            {
                Console.WriteLine("A nave chegou ao seu destino");
            }
            else
            {
                Console.WriteLine("A nave não chegou ao seu destino;");
            }
        }
    }
}
