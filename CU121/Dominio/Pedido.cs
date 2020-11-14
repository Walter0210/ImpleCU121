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
            return (inicio <= fechaHoraPedido && fechaHoraPedido <= fin);
        }

        public DataTable buscarProdSubCatSeleccionados(List<IEstructuraCarta> prodDeCarta)
        {
            // Create new DataTable and DataSource objects.
            DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            List<string> productos = new List<string>();

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.string");
            column.ColumnName = "Producto";
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Cantidad";
            table.Columns.Add(column);

            foreach (EstructuraCarta productoDeCarta in prodDeCarta)
            {
                if (this.detalle.contieneProdCarta(prodDeCarta))
                {
                    productos.Add(this.detalle.obtenerProducto());
                    row = table.NewRow();
                    row["Producto"] = this.detalle.obtenerProducto();
                    row["Cantidad"] = this.detalle.getCantidad();
                    table.Rows.Add(row);
                }
            }
            return table;
        }
    }
}
