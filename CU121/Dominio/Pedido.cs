using System;
using System.Collections.Generic;
using System.Text;

namespace CU121.Dominio
{
    class Pedido
    {
        private int cantComensales;
        private DateTime fechaHoraPedido;
        private int nroPedido;

        public Pedido()
        {

        }

        public Pedido(int cantComensales, DateTime fechaHoraPedido, int nroPedido)
        {
            this.cantComensales = cantComensales;
            this.fechaHoraPedido = fechaHoraPedido;
            this.nroPedido = nroPedido;
        }

        public int CantComensales
        {
            get => cantComensales;
            set => cantComensales = value;
        }
        public DateTime FechaHoraPedido
        {
            get => fechaHoraPedido;
            set => fechaHoraPedido = value;
        }
        public int NroPedido
        {
            get => nroPedido;
            set => nroPedido = value;
        }


    }
}
