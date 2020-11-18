using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaEstagio
{
    class Copa
    {

        public void bebidas()
        {
            int quant = 0, i = 0, aux = 0, bebida, resp;

            int[] pedidos;
            pedidos = new int[30];

            while (i != 2)
            {
                Console.WriteLine("Selecione a bebida que deseja");
                Console.WriteLine("Chopp - 1");
                Console.WriteLine("Refrigerante - 2");
                Console.WriteLine("Cerveja - 3");
                Console.WriteLine("Suco - 4");
                Console.WriteLine("Vinho - 5");
                bebida = int.Parse(Console.ReadLine());
                switch (bebida)
                {
                    case 1:
                        Console.WriteLine("Chopp");
                        pedidos[aux] = bebida;
                        break;

                    case 2:
                        Console.WriteLine("Refrigerante");
                        pedidos[aux] = bebida;
                        break;

                    case 3:
                        Console.WriteLine("Cerveja");
                        pedidos[aux] = bebida;
                        break;

                    case 4:
                        Console.WriteLine("Suco");
                        pedidos[aux] = bebida;
                        break;

                    case 5:
                        Console.WriteLine("Vinho");
                        pedidos[aux] = bebida;
                        break;
                }
                Console.WriteLine("Deseja pedir mais alguma bebida? Se sim digite '1', se não digite '2'");
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
