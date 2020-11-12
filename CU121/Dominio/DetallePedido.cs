using CU121.FabricacionPura;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CU121.Dominio
{
    class DetallePedido
    {
        private int cantidad;
        private DateTime hora;
        private int precio;
        private EstructuraCarta prodcto;


        public DetallePedido()
        {

        }
        public DetallePedido(int cantidad, DateTime hora, int precio, EstructuraCarta producto)
        {
            this.cantidad = cantidad;
            this.hora = hora;
            this.precio = precio;
            this.prodcto = producto;
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

        public EstructuraCarta Producto
        {
            get => prodcto;
            set => prodcto = value;
        }

    }
}
