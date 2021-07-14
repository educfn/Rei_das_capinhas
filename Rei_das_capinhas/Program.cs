using System;

namespace Rei_das_capinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Testes.teste_preenchimentoDaLista();
            Testes.teste_calcularValorLista();
            Testes.teste_aferir_lucro();
            Testes.teste__handlers();
            //entradas_usuario();
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
    }

}
