using CU121.Dominio;
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

        private DataTable tablaReporte;


        public void buscarCartasVigentes(DateTime desde, DateTime hasta, List<EstructuraCarta> cartasTodas)
        {
            cartasVigentes = new BindingList<IEstructuraCarta>();

            foreach (EstructuraCarta carta in cartasTodas)
            {
                if (carta.FechaFinVigencia != null)//cambio para probar desde <= carta.FechaFinVigencia && carta.FechaFinVigencia <= hasta
                {
                    cartasVigentes.Add(carta);
                }
            }
        }

        public List<IEstructuraCarta> buscarCategorias()
        {
            List<IEstructuraCarta> categoriasCarta = new List<IEstructuraCarta>();
            foreach (EstructuraCarta carta in cartasVigentes)
            {
                List<IEstructuraCarta> cates = carta.obtenerHijo();
                foreach (EstructuraCarta categoria in cates)
                {
                    categoriasCarta.Add(categoria);
                }
            }
            return categoriasCarta; 
        }

        public List<IEstructuraCarta> buscarSubCategorias(BindingList<IEstructuraCarta> categoriasSeleccionadas)
        {
            this.categoriasSeleccionadas = categoriasSeleccionadas;
            List<IEstructuraCarta> subCategoriasCarta = new List<IEstructuraCarta>();
            foreach (EstructuraCarta categoria in categoriasSeleccionadas)
            {
                List<IEstructuraCarta> subCates = categoria.obtenerHijo();
                
                foreach (EstructuraCarta subcategoria in subCates)
                {
                    subCategoriasCarta.Add(categoria);
                }
            }
            return subCategoriasCarta;
        }

        public List<IEstructuraCarta> buscarProductos(BindingList<IEstructuraCarta> subCateSeleccionadas)
        {
            this.subCategoriasSeleccionadas = subCateSeleccionadas;
            List<IEstructuraCarta> productosDeCarta = new List<IEstructuraCarta>();

            foreach (EstructuraCarta subCat in subCateSeleccionadas)
            {
                List<IEstructuraCarta> prodCarta = subCat.obtenerHijo();
                foreach (EstructuraCarta prod in prodCarta)
                {
                    productosDeCarta.Add(prod);
                }
            }
            this.productosDeCartaSeleccionados = productosDeCarta;
            return productosDeCarta;
        }

        public void buscarPedidosCumplenFiltros(DateTime inicio, DateTime fin, List<Pedido> todosPedidos, List<IEstructuraCarta> prodCartaSeleccionados)
        {
            foreach (Pedido pedido in todosPedidos)
            {
                if (pedido.esValido(inicio, fin))
                {
                    tablaReporte = pedido.buscarProdSubCatSeleccionados(prodCartaSeleccionados);
                }
            }
        }




    }
}
