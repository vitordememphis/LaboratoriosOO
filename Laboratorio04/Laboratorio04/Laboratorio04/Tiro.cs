using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class Tiro
    {
        public Posicao Posicao { get; protected set; }
        public int Velocidade { get; protected set; }
        public int Potencia { get; protected set; }
        public Tiro(Posicao posicao,int velocidade,int potencia)
        {
            Posicao = posicao;
            Velocidade = velocidade;
            Potencia = potencia;
        }
    }
}
