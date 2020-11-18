using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaEstagio
{
    class Cliente
    {
        public void cliente()
        {
            String nome;
            int mesa;

            Console.WriteLine("Como o(a) senhor(a) se chama?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a numeração de sua mesa?");
            mesa = int.Parse(Console.ReadLine());
        }
    }
}
