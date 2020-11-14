using CU121.FabricacionPura;
using System;
using System.Collections.Generic;
using System.Data;
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
            return (fechaHoraPedido <= fin);
        }

        public void buscarProdSubCatSeleccionados(List<IEstructuraCarta> prodDeCarta, DataTable tablaReporte)
        {
            DataRow row;
            List<string> productos = new List<string>();

            foreach (EstructuraCarta productoDeCarta in prodDeCarta)
            {
                if (this.detalle.contieneProdCarta(prodDeCarta))
                {
                    //productos.Add(this.detalle.obtenerProducto());
                    row = tablaReporte.NewRow();
                    row["Producto"] = this.detalle.obtenerProducto();
                    row["Cantidad"] = this.detalle.getCantidad();
                    row["TotalxCantidad"] = this.detalle.totalProducto();
                    tablaReporte.Rows.Add(row);
                }
            }
            //return row;
        }
    }
}
