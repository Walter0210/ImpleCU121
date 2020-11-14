using CU121.Dominio;
using CU121.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace CU121.FabricacionPura
{
    class GestorInformeProducto
    {
        private BindingList<IEstructuraCarta> cartasVigentes;
        private BindingList<IEstructuraCarta> categoriasSeleccionadas;
        private BindingList<IEstructuraCarta> subCategoriasSeleccionadas;
        private List<IEstructuraCarta> productosDeCartaSeleccionados;

        DateTime fechaInicio;
        DateTime fechaFin;

        private DataTable tablaReporte;

        private double totalCategoria;
        private double totalSubCategoria;
        

        public void buscarCartasVigentes(DateTime desde, DateTime hasta, List<EstructuraCarta> cartasTodas)
        {
            fechaInicio = desde;
            fechaFin = hasta;
            cartasVigentes = new BindingList<IEstructuraCarta>();

            foreach (EstructuraCarta carta in cartasTodas)
            {
                if (carta.FechaFinVigencia != null)//cambio para probar desde <= carta.FechaFinVigencia && carta.FechaFinVigencia <= hasta
                {
                    cartasVigentes.Add(carta);
                }
            }
        }

        public List<EstructuraCarta> buscarCategorias()
        {
            List<EstructuraCarta> categoriasCarta = new List<EstructuraCarta>();
            foreach (EstructuraCarta carta in cartasVigentes)
            {
                List<IEstructuraCarta> cates = carta.obtenerHijo();
                foreach (EstructuraCarta categoria in cates)
                {
                    if (!categoriasCarta.Contains(categoria))
                    {
                        categoriasCarta.Add(categoria);
                    }
                    
                }
            }
            return categoriasCarta; 
        }

        public List<EstructuraCarta> buscarSubCategorias(BindingList<IEstructuraCarta> categoriasSeleccionadas)
        {
            this.categoriasSeleccionadas = categoriasSeleccionadas;
            List<EstructuraCarta> subCategoriasCarta = new List<EstructuraCarta>();

            foreach (EstructuraCarta categoria in categoriasSeleccionadas)
            {
                List<IEstructuraCarta> subCates = categoria.obtenerHijo();
                foreach (EstructuraCarta subcategoria in subCates)
                {
                    subCategoriasCarta.Add(subcategoria);
                }
            }
            return subCategoriasCarta;
        }

        public List<EstructuraCarta> buscarProductosCarta(BindingList<IEstructuraCarta> subCateSeleccionadas)
        {
            this.subCategoriasSeleccionadas = subCateSeleccionadas;
            List<EstructuraCarta> productosDeCarta = new List<EstructuraCarta>();

            foreach (EstructuraCarta subCatego in subCateSeleccionadas)
            {
                List<IEstructuraCarta> prodCarta = subCatego.obtenerHijo();

                foreach (EstructuraCarta porductoDeCarta in prodCarta)
                {
                    productosDeCarta.Add(porductoDeCarta);
                }
            }
            return productosDeCarta;
        }

        public DataTable buscarPedidosCumplenFiltros(DateTime inicio, DateTime fin, List<Pedido> todosPedidos, List<IEstructuraCarta> prodCartaSeleccionados)
        {
            tablaReporte = new DataTable();
            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Producto";
            tablaReporte.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Cantidad";
            tablaReporte.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Total productoz";
            tablaReporte.Columns.Add(column);

            foreach (Pedido pedido in todosPedidos)
            {
                if (pedido.esValido(fechaInicio, fechaFin))
                {
                    pedido.buscarProdSubCatSeleccionados(prodCartaSeleccionados, tablaReporte);
                }
            }
            return tablaReporte;
        }

        public void contadores()
        {
            foreach (EstructuraCarta categoria in categoriasSeleccionadas)
            {
                foreach (EstructuraCarta subcategoria in subCategoriasSeleccionadas)
                {

                }
            }
        }



    }
}
