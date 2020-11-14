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
        private EstructuraCarta productoDeCarta;


        public DetallePedido()
        {

        }
        public DetallePedido(int cantidad, DateTime hora, int precio, EstructuraCarta producto)
        {
            this.cantidad = cantidad;
            this.hora = hora;
            this.precio = precio;
            this.productoDeCarta = producto;
        }

        public int getCantidad() {
            return this.cantidad;
        
        }

        public bool contieneProdCarta(List<IEstructuraCarta> prodDeCarta)
        {
            return prodDeCarta.Contains(this.productoDeCarta);
        }

        public string obtenerProducto()
        {
            return this.productoDeCarta.getNombreProducto();
        }
    }
}
