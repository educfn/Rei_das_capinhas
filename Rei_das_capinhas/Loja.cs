using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei_das_capinhas
{
    class Loja
    {
        ObservableCollection<CapaDeCelular> capas_compradas;
        ObservableCollection<CapaDeCelular> capas_vendidas;

        public Loja() 
        {
            capas_compradas = new ObservableCollection<CapaDeCelular>();
            capas_vendidas = new ObservableCollection<CapaDeCelular>();

            //TODO: Criar 3 handlers(Valor monetario das capas(compradas e vendidas) e do lucro)
            //para a lista observada 'capas_compradas' que deverá ser exibido na tela.
            //TODO: Criar 3 handlers(Valor monetario das capas(compradas e vendidas) e do lucro)
            //para a lista observada 'capas_vendidas' que deverá ser exibido na tela.
        }

        public void comprar_CapaDeCelular(int quantidadeDoLote, float valor_unitario)
        {
            if (quantidadeDoLote > 0 && valor_unitario > 0)
            {
                for (int i = 0; i < quantidadeDoLote; i++)
                {
                    CapaDeCelular capa = new CapaDeCelular(valor_unitario);
                    capas_compradas.Add(capa);
                }
            }
        }

        public void vender_CapaDeCelular(int quantidadeDoLote, float valor_unitario)
        {
            if (quantidadeDoLote > 0 && valor_unitario > 0)
            {
                for (int i = 0; i < quantidadeDoLote; i++)
                {
                    CapaDeCelular capa = new CapaDeCelular(valor_unitario);
                    capas_vendidas.Add(capa);
                }
            }
        }

        public float calcular_valor_listaCompras()
        {
            float valorTotalDaLista = 0;        

            for (int i = 0; i < capas_compradas.Count; i++)
            {
                valorTotalDaLista += capas_compradas[i].Valor_unitario;
            }
           
            return valorTotalDaLista;
        }

        public float calcular_valor_listaVendas()
        {
            float valorTotalDaLista = 0;

            for (int i = 0; i < capas_vendidas.Count; i++)
            {
                valorTotalDaLista += capas_vendidas[i].Valor_unitario;
            }

            return valorTotalDaLista;
        }

        public float aferir_lucro() 
        {
            float valor_lucro = 0, valorTotal_ListaCompras = 0, valorTotal_ListaVendas = 0;

            valorTotal_ListaCompras = calcular_valor_listaCompras();
            valorTotal_ListaVendas = calcular_valor_listaVendas();

            valor_lucro = valorTotal_ListaVendas - valorTotal_ListaCompras;

            return valor_lucro;
        }


    }
}
