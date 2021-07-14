using System;

namespace Rei_das_capinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste_preenchimentoDaLista();
            // teste_calcularValorLista();
            //teste_aferir_lucro();
            //teste__handlers();
            entradas_usuario();
        }

        public static void entradas_usuario()
        {
            Loja loja = new Loja();

            while (true)
            {
                int usuario_escolha = 0,
                    quantidade_lote = 0;
                float valor_unitario = 0;


                Console.Write("\n\n\nBem vindo ao Sistema Rei das Capas"
                              + "\nEscolha as seguintes opções:"
                              + "\n1-Comprar"
                              + "\n2-Vender"
                              + "\n0-Sair"
                              + "\nSua escolha: ");

                //TODO: Implementar verificacao para caso de valores: com menos(-), nenhum valor.
                usuario_escolha = int.Parse(Console.ReadLine());
            
                if (usuario_escolha != 1 && usuario_escolha != 2) break;

                Console.Clear();
                Console.Write("\nInsira a quantidade: ");
                //TODO: Implementar verificacao para caso de valores: com menos(-), nenhum valor.
                quantidade_lote = int.Parse(Console.ReadLine());
                Console.Write("\nInsira o valor por unidade: ");
                //TODO: Implementar verificacao para caso de valores: com menos(-), nenhum valor.
                valor_unitario = int.Parse(Console.ReadLine());

                if (usuario_escolha == 1)
                {
                    loja.comprar_CapaDeCelular(quantidade_lote,valor_unitario);
                }
                else
                {
                    loja.vender_CapaDeCelular(quantidade_lote, valor_unitario);
                }

            }
        }

        public static void teste_preenchimentoDaLista()
        {
            Loja loja = new Loja();
            Random rand = new Random();

            for (int i = 0, limit = rand.Next(1, 50); i < limit; i++)
            {
                int valor_aleatorio1 = rand.Next(1, 100);
                int valor_aleatorio2 = rand.Next(1, 1000);
                loja.comprar_CapaDeCelular(valor_aleatorio1,valor_aleatorio2);

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

            loja.comprar_CapaDeCelular(10,2);
            loja.vender_CapaDeCelular(5,5);

        }

        public static void teste_TesteCalculoValoresMundoReal()
        {
            //TODO: Calculo com valores previamente calculados.
        }
    }

}
