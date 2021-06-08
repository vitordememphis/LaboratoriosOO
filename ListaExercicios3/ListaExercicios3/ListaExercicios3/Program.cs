using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string texto = "Uma atividade livre, conscientemente tomada como “não-séria” e exterior à vida habitual, " +
                "mas ao mesmo tempo capaz de absorver o jogador de maneira intensa e total. " +
                "É uma atividade desligada de todo e qualquer interesse material, com a qual não se pode obter qualquer lucro, " +
                "praticada dentro de limites espaciais e temporais próprios, segundo uma certa ordem e certas regras. " +
                "Promove a formação de grupos sociais com tendência a rodearem-se de segredo e a sublinharem sua diferença " +
                "em relação ao resto do mundo por meio de disfarces ou outros meios semelhantes.";

            //Questão 1
            int contador = VerificarPalavrasDiferentes(texto);
            Console.WriteLine($"O texto apresenta {contador} palavras diferentes.");


            //Questão 2
            Dictionary<string, int> resultado = VerificarQuantidadePalavras(texto);
            foreach(var item in resultado)
            {
                Console.WriteLine($"A palavra [{item.Key}] se repete [{item.Value}] vez(es).");
            }

            //Questão 3
            string teste = "1+(5+3-(8-5)*4-((3+7)*(3-1)))";

            bool veracidade = ChecarParenteses(teste);
            if (veracidade)
            {
                Console.WriteLine("Os parênteses estão corretos.");
            }
            else
            {
                Console.WriteLine("Os parênteses estão errados.");
            }

            //Questão 4
            Console.WriteLine("Digite um texto:");
            string exemploTexto;
            exemploTexto = Console.ReadLine();
            int contadorPalavras = VerificarPalavrasDiferentes(exemploTexto);
            Console.WriteLine($"O texto apresenta {contadorPalavras} palavras diferentes.");
            


            Console.ReadLine();
            
        }

        //Questão 1
        static int VerificarPalavrasDiferentes(string texto)
        {
            Dictionary<string, int> palavrasDiferentes = new Dictionary<string, int>();
            string[] palavras = texto.Split(' ', '.', ',', '-', '”', '“');
            int contador = 0;
            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    int count;
                    if(!palavrasDiferentes.TryGetValue(item.ToLower(),out count))
                    {
                        contador ++;
                    }
                    palavrasDiferentes[item.ToLower()] = count + 1;
                }
            }
            return contador;
        }

        //Questão 2
        static Dictionary<string, int> VerificarQuantidadePalavras(string texto)
        {
            Dictionary<string, int> palavrasContadas = new Dictionary<string, int>();
            string[] palavras = texto.Split(' ', '.', ',', '-', '”', '“');
            foreach(var item in palavras)
            {
                if (item.Length != 0)
                {
                    int count;
                    if(!palavrasContadas.TryGetValue(item.ToLower(), out count))
                    {
                        count = 0;
                    }
                    palavrasContadas[item.ToLower()] = count + 1;
                }
            }
            return palavrasContadas;
        }

        //Questão 3
        static bool ChecarParenteses(string input)
        {
            Stack<char> parenteses = new Stack<char>();
            foreach(var caractere in input)
            {
                if (caractere == '(')
                {
                    parenteses.Push(caractere);
                }
                else if (caractere == ')')
                {
                    if (parenteses.Count <= 0)
                    {
                        return false;
                    }

                    char aberto = parenteses.Pop();

                }
            }

            if (parenteses.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
