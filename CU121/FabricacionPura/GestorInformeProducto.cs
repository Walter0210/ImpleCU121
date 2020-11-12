using CU121.Dominio;
using System;
using System.Collections.Generic;

namespace CU121.FabricacionPura
{
    class GestorInformeProducto
    {
        public List<EstructuraCarta> buscarCartasVigentes(DateTime desde, DateTime hasta, List<EstructuraCarta> cartasTodas)
        {
            List<EstructuraCarta> cartasVigentes = new List<EstructuraCarta>();

            foreach (EstructuraCarta carta in cartasTodas)
            {
                if (carta.FechaFinVigencia != null)//cambio para probar desde <= carta.FechaFinVigencia && carta.FechaFinVigencia <= hasta
                {
                    cartasVigentes.Add(carta);
                }
            }
            return cartasVigentes;
        }

        public List<EstructuraCarta> obtenerHijos(List<EstructuraCarta> padres)
        {
            List<EstructuraCarta> hijos = new List<EstructuraCarta>();


            foreach (EstructuraCarta listaHijos in padres)
            {
                List<EstructuraCarta> aux = listaHijos.obtenerHijo();
                foreach (EstructuraCarta hijo in aux)
                {
                    if (!hijos.Contains(hijo))
                    {
                        hijos.Add(hijo);
                    }                }
            }
            return hijos;
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
