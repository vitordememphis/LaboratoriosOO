using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemMenu batata = new Aperitivo("Batata frita", 15);
            ItemMenu mandioca = new Aperitivo("Mandioca frita", 13.5);

            ItemMenu sucoLaranja = new Bebida("Suco de Laranja", 7, 9.5, 11);
            ItemMenu guarana = new Bebida("Guaraná Antarctica", 4, 6, 8.5);
            ItemMenu sucoUva = new Bebida("Suco de Uva", 7.5, 9.5, 10.5);

            ItemMenu[] itensMenu = { sucoLaranja, sucoUva, guarana, batata, mandioca };

            foreach(ItemMenu item in itensMenu)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("-----------------------");
                Console.ReadLine();
            }
        }
    }
}
