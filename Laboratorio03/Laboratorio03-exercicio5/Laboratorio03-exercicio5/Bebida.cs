using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_exercicio5
{
    class Bebida : ItemMenu
    {
        public double PrecoPequena { get; protected set; }
        public double PrecoMedia { get; protected set; }
        public double PrecoGrande { get; protected set; }
        public Bebida(string nome, double precoPequena, double precoMedia, double precoGrande): base(nome)
        {
            PrecoPequena = precoPequena;
            PrecoMedia = precoMedia;
            PrecoGrande = precoGrande;
        }

        public override void ImprimirPreco()
        {
            Console.WriteLine($" Pequena: {PrecoPequena.ToString("C")}");
            Console.WriteLine($" Média: {PrecoMedia.ToString("C")}");
            Console.WriteLine($" Grande: {PrecoGrande.ToString("C")}");
        }
    }
}
