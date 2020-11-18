using System;

namespace ProvaEstagio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa noite, sou seu garçom está noite e me chamo Diego, em que posso lhe servir?");

            Cliente cliente01 = new Cliente();
            Cozinha pratos = new Cozinha();
            Copa refresco = new Copa();

            cliente01.cliente();

            pratos.pedido();

            refresco.bebidas();
        }
    }
}
