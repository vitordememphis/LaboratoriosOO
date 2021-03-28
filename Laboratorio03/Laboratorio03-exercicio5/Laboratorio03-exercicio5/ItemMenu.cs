﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03_exercicio5
{
    class ItemMenu
    {
        public string Nome { get; protected set; }
        public double Preco { get; protected set; }

        public ItemMenu(string nome)
        {
            Nome = nome;
        }

        public void ImprimirNome()
        {
            Console.WriteLine($"{Nome}");
        }
        public virtual void ImprimirPreco()
        {
            Console.WriteLine($"{Preco.ToString("C")}");
        }
    }
}
