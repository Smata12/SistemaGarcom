using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaEstagio
{
    class Cozinha
    {
        public void pedido()
        {
            int quant = 0, i = 0, aux = 0, prato, resp;

            int[] pedidos;
            pedidos = new int[30];

            while (i != 2)
            {
                Console.WriteLine("Selecione o prato que deseja");
                Console.WriteLine("Macarrão com molho bolonhesa - 1");
                Console.WriteLine("Tábua de Frios - 2");
                Console.WriteLine("Tábua Filé de Peixe Frito - 3");
                Console.WriteLine("Porção de Fritas - 4");
                Console.WriteLine("Porção de Mandioca - 5");
                prato = int.Parse(Console.ReadLine());
                switch (prato)
                {
                    case 1:
                        Console.WriteLine("Macarrão com molho bolonhesa");
                        pedidos[aux] = prato;
                        break;

                    case 2:
                        Console.WriteLine("Tábua de Frios");
                        pedidos[aux] = prato;
                        break;

                    case 3:
                        Console.WriteLine("Tábua Filé de Peixe Frito");
                        pedidos[aux] = prato;
                        break;

                    case 4:
                        Console.WriteLine("Porção de Fritas");
                        pedidos[aux] = prato;
                        break;

                    case 5:
                        Console.WriteLine("Porção de mandioca");
                        pedidos[aux] = prato;
                        break;
                }
                Console.WriteLine("Deseja pedir mais algum prato? Se sim digite '1', se não digite '2'");
                resp = int.Parse(Console.ReadLine());
                if (resp == 1)
                {
                    i = 1;
                    quant++;
                    aux++;
                }
                else
                {
                    i = 2;
                }
            }
        }
    }
}
