using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei_das_capinhas
{
    public class Testes
    {
        public static void teste_preenchimentoDaLista()
        {
            Loja loja = new Loja();
            Random rand = new Random();

            for (int i = 0, limit = rand.Next(1, 50); i < limit; i++)
            {
                int valor_aleatorio1 = rand.Next(1, 100);
                int valor_aleatorio2 = rand.Next(1, 1000);
                loja.comprar_CapaDeCelular(valor_aleatorio1, valor_aleatorio2);

                valor_aleatorio1 = rand.Next(1, 100);
                valor_aleatorio2 = rand.Next(1, 1000);
                loja.vender_CapaDeCelular(valor_aleatorio1, valor_aleatorio1);
            }

            ;
            //Verificar o resultado durante o 'Debug'.

        }

        public static void teste_calcularValorLista()
        {
            Loja loja = new Loja();
            Random rand = new Random();

            for (int i = 0, limit = rand.Next(1, 50); i < limit; i++)
            {
                int valor_aleatorio1 = rand.Next(1, 100);
                int valor_aleatorio2 = rand.Next(1, 1000);
                loja.comprar_CapaDeCelular(valor_aleatorio1, valor_aleatorio2);

                valor_aleatorio1 = rand.Next(1, 100);
                valor_aleatorio2 = rand.Next(1, 1000);
                loja.vender_CapaDeCelular(valor_aleatorio1, valor_aleatorio1);
            }

            float valor_listaVendas = 0, valor_listaCompras = 0;

            valor_listaVendas = loja.calcular_valor_listaVendas();
            valor_listaCompras = loja.calcular_valor_listaCompras();

            ;
            //Verificar o resultado durante o 'Debug'.
        }

        public static void teste_aferir_lucro()
        {
            Loja loja = new Loja();
            Random rand = new Random();

            for (int i = 0, limit = rand.Next(1, 50); i < limit; i++)
            {
                int valor_aleatorio1 = rand.Next(1, 100);
                int valor_aleatorio2 = rand.Next(1, 100);
                loja.comprar_CapaDeCelular(valor_aleatorio1, valor_aleatorio2);

                valor_aleatorio1 = rand.Next(1, 100);
                valor_aleatorio2 = rand.Next(1, 500);
                loja.vender_CapaDeCelular(valor_aleatorio1, valor_aleatorio1);
            }

            float valor_listaVendas = 0, valor_listaCompras = 0;

            valor_listaVendas = loja.calcular_valor_listaVendas();
            valor_listaCompras = loja.calcular_valor_listaCompras();

            float valor_lucro = 0;

            valor_lucro = loja.aferir_lucro();

            ;
            //Verificar o resultado durante o 'Debug'.
        }

        public static void teste__handlers()
        {
            Loja loja = new Loja();

            loja.comprar_CapaDeCelular(10, 2);
            loja.vender_CapaDeCelular(5, 5);

        }
        public static void teste_TesteCalculoValoresMundoReal()
        {
            //TODO: Calculo com valores previamente calculados.
        }

    }
}
