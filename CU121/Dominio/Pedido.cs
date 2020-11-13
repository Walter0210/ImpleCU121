using CU121.FabricacionPura;
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

        public bool esValido(DateTime inicio, DateTime fin)
        {
            return (inicio <= fechaHoraPedido && fechaHoraPedido <= fin);
        }

        public List<string> tieneProductoDeCartaSeleccionado(List<IEstructuraCarta> prodDeCarta)
        {
            List<string> productos = new List<string>();
            foreach (EstructuraCarta productoDeCarta in prodDeCarta)
            {
                if (this.detalle.contieneProdCarta(prodDeCarta))
                {
                    productos.Add(this.detalle.obtenerProducto());
                }
            }
            return productos;
        }
    }
}
