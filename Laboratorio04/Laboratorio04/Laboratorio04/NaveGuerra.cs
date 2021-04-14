using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class NaveGuerra : Nave
    {
        public int PotenciaTiro { get; protected set; }
        public int VelocidadeTiro { get; protected set; }

        public NaveGuerra(string nome, int combustivel,int energia,int velocidade,Posicao posicao,int potenciaTiro,int velocidadeTiro) 
            : base(nome,combustivel,energia,velocidade,posicao)
        {
            PotenciaTiro = potenciaTiro;
            VelocidadeTiro = velocidadeTiro;
        }
        public void AtirarNave(Nave alvo)
        {
            Tiro tiro = new Tiro(this.Posicao, this.VelocidadeTiro, this.PotenciaTiro);
            Posicao posicaoTiro = new Posicao(tiro.Posicao.Posicaox + tiro.Velocidade, tiro.Posicao.Posicaoy + tiro.Velocidade);
            if (alvo.Posicao.Posicaox == posicaoTiro.Posicaox && alvo.Posicao.Posicaoy == posicaoTiro.Posicaoy)
            {
                Console.WriteLine("O tiro da {0} acertou {1}.", Nome, alvo.Nome);
            }
            else
            {
                Console.WriteLine("O tiro da {0} errou o alvo.", Nome);
            }
        }
        public void AtirarAsteroide(Asteroide alvo)
        {
            Tiro tiro = new Tiro(this.Posicao, this.VelocidadeTiro, this.PotenciaTiro);
            Posicao posicaoTiro = new Posicao(tiro.Posicao.Posicaox + tiro.Velocidade, tiro.Posicao.Posicaoy + tiro.Velocidade);
            if (alvo.Posicao == posicaoTiro)
            {
                Console.WriteLine("O tiro da {0} acertou o asteroide.", Nome);
            }
            else
            {
                Console.WriteLine("O tiro da {0} errou o alvo.", Nome);
            }
        }
    }
}
