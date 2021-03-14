using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Usuario
    {
        public string Nome;
        public int Idade;
        public double Altura;
        public double Peso;

        double imc;
        double pesoIdeal;
        double imcIdeal;

        public void CalcularImc()
        {
            imc = Peso / (Altura * Altura);
            if (imc < 18.5)
            {
                Console.WriteLine("{0} está abaixo do peso ideal.",Nome);
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Parabéns! {0} está em seu peso normal!",Nome);
            }
            else if (imc > 24.9 && imc <= 29.9)
            {
                Console.Write("{0} está acima de seu peso (sobrepeso).",Nome);
            }
            else if (imc > 29.9 && imc <= 34.9)
            {
                Console.Write("{0} tem obesidade grau I.", Nome);
            }
            else if (imc > 34.9 && imc <= 39.9)
            {
                Console.Write("{0} tem obesidade grau II.", Nome);
            }
            else if (imc > 39.9)
            {
                Console.Write("{0} tem obesidade graus III e IV.", Nome);
            }
            Console.ReadLine();
        }
        public void CalcularPesoIdeal()
        {
            if (imc < 18.5)
            {
                imcIdeal = 18.5;
            }
            else if(imc>=18.5 && imc <= 24.9)
            {
                imcIdeal = imc;
            }
            else if (imc > 24.9)
            {
                imcIdeal = 24.9;
            }
            pesoIdeal = imcIdeal * (Altura * Altura);
            Console.WriteLine("Seu peso ideal de {0} é {1} Kg.", Nome, pesoIdeal);
            Console.ReadLine();
        }
    }
}
