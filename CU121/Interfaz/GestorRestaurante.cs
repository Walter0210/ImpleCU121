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
                gestor.buscarCartasVigentes(fechaInicio, fechaFin);
            }
            else
            {
                MessageBox.Show("Periodo invalido!");
            }
        }

        private void GestorRestaurante_Load(object sender, EventArgs e)
        {
            //desabilitar todo e ir habilitando de a poco



        }
    }
}
