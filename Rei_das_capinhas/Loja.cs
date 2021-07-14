using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei_das_capinhas
{
    class Loja
    {
        ObservableCollection<CapaDeCelular> capas_compradas;
        ObservableCollection<CapaDeCelular> capas_vendidas;
        float valorMonetario_vendas { get; set; }
        float valorMonetario_compras { get; set; }
        float valorMonetarioTotal { get; set; }

        public Loja() 
        {
            capas_compradas = new ObservableCollection<CapaDeCelular>();
            capas_vendidas = new ObservableCollection<CapaDeCelular>();

            capas_compradas.CollectionChanged += handler_calcular_valor_listaCompras;
            capas_compradas.CollectionChanged += handler_aferir_lucro;
            capas_vendidas.CollectionChanged += handler_calcular_valor_listaVendas;
            capas_vendidas.CollectionChanged += handler_aferir_lucro;
        }

        private void handler_calcular_valor_listaVendas(object sender, NotifyCollectionChangedEventArgs e)
        {
            valorMonetario_vendas = calcular_valor_listaVendas();
        }

        private void handler_calcular_valor_listaCompras(object sender, NotifyCollectionChangedEventArgs e)
        {
            valorMonetario_compras = calcular_valor_listaCompras();
        }
        private void handler_aferir_lucro(object sender, NotifyCollectionChangedEventArgs e)
        {
            valorMonetarioTotal = aferir_lucro();
            MostrarTodosOsValores();
        }

        public void comprar_CapaDeCelular(int quantidadeDoLote, float valor_unitario)
        {
            if (quantidadeDoLote > 0 && valor_unitario > 0)
            {
                CapaDeCelular capa = new CapaDeCelular(valor_unitario, quantidadeDoLote);
                capas_compradas.Add(capa);   
            }
        }

        public void vender_CapaDeCelular(int quantidadeDoLote, float valor_unitario)
        {
            if (quantidadeDoLote > 0 && valor_unitario > 0)
            {
                CapaDeCelular capa = new CapaDeCelular(valor_unitario, quantidadeDoLote);
                capas_vendidas.Add(capa);            
            }
        }

        public float calcular_valor_listaCompras()
        {
            float valorTotalDaLista = 0;        

            for (int i = 0; i < capas_compradas.Count; i++)
            {
                valorTotalDaLista += capas_compradas[i].Valor_unitario * capas_compradas[i].Tamanho_lote;
            }
           
            return valorTotalDaLista;
        }

        public float calcular_valor_listaVendas()
        {
            float valorTotalDaLista = 0;

            for (int i = 0; i < capas_vendidas.Count; i++)
            {
                valorTotalDaLista += capas_vendidas[i].Valor_unitario * capas_vendidas[i].Tamanho_lote;
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

        public void MostrarTodosOsValores() 
        {
            Console.Write("\n Valor despesas: " + valorMonetario_compras +
                          "\n Valor ganhos: " + valorMonetario_vendas);
            if (valorMonetarioTotal > 0.0f) Console.Write("\nO lucro é de: " + valorMonetarioTotal);
            else Console.Write("\nO prejuizo é de: " + Math.Abs(valorMonetarioTotal));
        }

    }
}
