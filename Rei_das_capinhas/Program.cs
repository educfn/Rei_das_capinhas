using System;

namespace Rei_das_capinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            teste_preenchimentoDaLista();

        }

        public static void teste_preenchimentoDaLista()
        {
            Loja loja = new Loja();
            Random rand = new Random();

            loja.comprar_CapaDeCelular(rand.Next(1,100),rand.Next(1, 1000));
            loja.vender_CapaDeCelular(rand.Next(1, 100), rand.Next(1, 1000));

        }
    }

}
