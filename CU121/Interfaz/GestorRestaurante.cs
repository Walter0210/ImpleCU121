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
        private List<IEstructuraCarta> todasCartas;
        private List<IEstructuraCarta> cartasVigentes;
        private List<IEstructuraCarta> categorias;

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

                foreach (EstructuraCarta carta in cartasVigentes)
                {
                    categorias.Add(carta.obtenerHijo());
                }
                dgvCategorias.DataSource = categorias;
            }
            else
            {
                MessageBox.Show("Periodo invalido!");
            }
        }

        private void GestorRestaurante_Load(object sender, EventArgs e)
        {
            //desabilitar todo e ir habilitando de a poco
            gestor = new GestorInformeProducto();
            //hay que armar todos los objetos de carta y producto

            carta1 = new EstructuraCarta("carta1", true, null, Convert.ToDateTime("10/10/2020"), Convert.ToDateTime("10/11/2020"), Convert.ToDateTime("10/11/2021"), "primerCarta", 1.43f, null, "waltersito");


        }
    }
}
