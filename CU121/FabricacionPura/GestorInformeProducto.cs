using CU121.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
