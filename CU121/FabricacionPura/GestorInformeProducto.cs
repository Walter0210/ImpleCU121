using CU121.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CU121.FabricacionPura
{
    class GestorInformeProducto
    {
        private BindingList<IEstructuraCarta> cartasVigentes;
        private BindingList<IEstructuraCarta> categoriasVigentes;
        //private BindingList<IEstructuraCarta> subcategoriasVigentes;


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

        public String buscarPedidosConProductos(DateTime inicio, DateTime fin, List<EstructuraCarta> productosSelec, List<Pedido> todosLosPedidos, List<DetallePedido> todosLosDetalles)
        {
            List<Pedido> pedidosVigentes = new List<Pedido>();
            string respuesta = "";
            foreach (Pedido pedidoVigente in todosLosPedidos)
            {
                if (pedidoVigente.FechaHoraPedido < fin)
                {
                    pedidosVigentes.Add(pedidoVigente);
                }
            }

            List<DetallePedido> detallesBuscar = new List<DetallePedido>();
            foreach (Pedido pedido in pedidosVigentes)
            {
                detallesBuscar.Add(pedido.DetallePedido);
            }

            foreach (DetallePedido detalle in detallesBuscar)
            {
                if (productosSelec.Contains(detalle.Producto))
                {
                    respuesta += detalle.Producto.Nombre + "  " + detalle.Cantidad;
                    respuesta += '\t';
                }
            }
            return respuesta;
        }
    }
}
