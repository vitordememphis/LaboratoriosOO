using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario1 = new Usuario();
            usuario1.Nome = "Bob Nelson";
            usuario1.Idade = 37;
            usuario1.Altura = 1.70;
            usuario1.Peso = 78;

            usuario1.CalcularImc();
            usuario1.CalcularPesoIdeal();

            var usuario2 = new Usuario();
            usuario2.Nome = "Testolfo Rocha";
            usuario2.Idade = 43;
            usuario2.Altura = 1.65;
            usuario2.Peso = 60;

            usuario2.CalcularImc();
            usuario2.CalcularPesoIdeal();

            var usuario3 = new Usuario();
            usuario3.Nome = "Lisa Leite";
            usuario3.Idade = 22;
            usuario3.Altura = 1.72;
            usuario3.Peso = 92;

            usuario3.CalcularImc();
            usuario3.CalcularPesoIdeal();
        }
    }
}
