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
            //TODO: comprar_CapaDeCelular
        }

        public void vender_CapaDeCelular(int quantidadeDoLote, float valor_unitario)
        {
            //TODO: vender_CapaDeCelular
        }

        public float calcular_valor_lista(ObservableCollection<CapaDeCelular> lista)
        {
            float valorTotalDaLista = 0;

            //TODO: calcular_valor_lista

            return valorTotalDaLista;
        }

        public float aferir_lucro() 
        {
            float valor_lucro = 0;

            //TODO: aferir_lucro

            return valor_lucro;
        }


    }
}
