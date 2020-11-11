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
        private DetallePedido detalle;

        public Pedido()
        {

        }

        public Pedido(int cantComensales, DateTime fechaHoraPedido, int nroPedido, DetallePedido detalle)
        {
            this.cantComensales = cantComensales;
            this.fechaHoraPedido = fechaHoraPedido;
            this.nroPedido = nroPedido;
            this.detalle = detalle;
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

        public DetallePedido DetallePedido
        {
            get => detalle;
            set => detalle = value;
        }
    }
}
