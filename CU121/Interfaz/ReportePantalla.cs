using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CU121.Interfaz
{
    public partial class ReportePantalla : Form
    {
        private DataTable tablaReporte;
        DateTime i;
        DateTime f;

        public ReportePantalla(DataTable tabla, DateTime ini, DateTime fi)
        {
            InitializeComponent();
            tablaReporte = tabla;
            i = ini;
            f = fi;
        }

        public void construirEncabezado(DateTime fechaInicio, DateTime fechaFin)

        {
            lblEncabezado.Text = "Informe de Productos mas pedidos para el periodo " + fechaInicio.ToString("MMMM dd") + " - " + fechaFin.ToString("MMMM dd");
        }

        public void construirCuerpo(DataTable datos)
        {
            grdCuerpo.DataSource = datos;
        }

        public void construirPie()
        {
            DateTime now = DateTime.Now;
            lblPie.Text = "El informe fue generado por Grupo 15 en la fecha" + now.ToString();
        }

        private void ReportePantalla_Load(object sender, EventArgs e)
        {
            construirEncabezado(i, f);
            construirCuerpo(tablaReporte);
            construirPie();
        }
    }
}
