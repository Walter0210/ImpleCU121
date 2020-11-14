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
        private Double precio;
        private EstructuraCarta productoDeCarta;


        public DetallePedido()
        {

        }
        public DetallePedido(int cantidad, DateTime hora, Double precio, EstructuraCarta producto)
        {
            this.cantidad = cantidad;
            this.hora = hora;
            this.productoDeCarta = producto;
            this.precio = this.cantidad * productoDeCarta.getPrecio();
            
        }

        public int getCantidad() {
            return this.cantidad;
        }

        public bool contieneProdCarta(EstructuraCarta prodDeCarta)
        {
            return prodDeCarta.Equals(this.productoDeCarta);
        }

        public string obtenerProducto()
        {
            return this.productoDeCarta.getNombreProducto();
        }

        internal double totalProducto()
        {
            return precio;
        }
    }
}
