using CU121.Dominio;
using CU121.FabricacionPura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CU121.Interfaz
{
    public partial class GestorRestaurante : Form

    {
        private GestorInformeProducto gestor;
        private List<EstructuraCarta> todasCartas;
        private List<EstructuraCarta> cartasVigentes;
        private BindingList<EstructuraCarta> categorias;

        public GestorRestaurante()
        {
            InitializeComponent();
        }

        private void btbBuscarCartas_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaDesde.Value;
            DateTime fechaFin = dtpFechaHasta.Value;

            if (fechaFin > fechaInicio)
            {
                cartasVigentes = gestor.buscarCartasVigentes(fechaInicio, fechaFin, todasCartas);
                BindingList<EstructuraCarta> categorias = new BindingList<EstructuraCarta>();
                
                foreach (EstructuraCarta carta in cartasVigentes)
                {
                    categorias.Add(carta.obtenerHijo());
                }
                dgvCategorias.DataSource = categorias;
                dgvCategorias.Refresh();
            }
            else
            {
                MessageBox.Show("Periodo invalido!");
            }

        }

        private void GestorRestaurante_Load(object sender, EventArgs e)
        {
            //desabilitar todo e ir habilitando de a poco.
            gestor = new GestorInformeProducto();
            todasCartas = new List<EstructuraCarta>();
            
            //hay que armar todos los objetos de carta y producto.
            EstructuraCarta subcategoriadeprubea = new EstructuraCarta("subcate1", true, null, Convert.ToDateTime("10/10/2020"), Convert.ToDateTime("10/11/2020"), Convert.ToDateTime("10/11/2021"), "primerCarta", 1.43f, null, "waltersito3");
            EstructuraCarta categoriadePrueba = new EstructuraCarta("categoria1", false, subcategoriadeprubea, Convert.ToDateTime("10/10/2020"), Convert.ToDateTime("10/11/2020"), Convert.ToDateTime("10/11/2021"), "primerCarta", 1.43f, null, "waltersito2");
            EstructuraCarta carta1 = new EstructuraCarta("carta1", true, categoriadePrueba, Convert.ToDateTime("10/10/2020"), Convert.ToDateTime("10/11/2020"), Convert.ToDateTime("10/11/2021"), "primerCarta", 1.43f, null, "waltersito");
            todasCartas.Add(carta1);

        }
    }
}
