using System;
using System.Collections.Generic;
using System.Text;

namespace CU121.Dominio
{
    class DetallePedido
    {
        private int cantidad;
        private DateTime hora;
        private int precio;
        private Pedido pedido;

        public DetallePedido()
        {
            
        }
        public DetallePedido(int cantidad, DateTime hora, int precio, Pedido pedido)
        {
            this.cantidad = cantidad;
            this.hora = hora;
            this.precio = precio;
            this.pedido = pedido;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public DateTime Hora
        {
            get => hora;
            set => hora = value;
        }

        public int Precio
        {
            get => precio;
            set => precio = value;
        }

        public conocerPedido(Pedido pedido)
        {
            
            retur
        }

    }
}
