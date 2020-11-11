using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CU121.Interfaz
{
    public partial class FormaVisualizacion : Form
    {

        private List<string> formasvs;
        public FormaVisualizacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormaVisualizacion_Load(object sender, EventArgs e)
        {

            formasvs = new List<string>();
            formasvs.Add("Pantalla");
            formasvs.Add("Impreso");
            formasvs.Add("PDF");
            formasvs.Add("Excel");

            cboForma.DataSource = formasvs;
        }



        private void cboForma_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            switch (cboForma.SelectedValue)
            {
                case "Pantalla":
                    ReportePantalla reporte = new ReportePantalla();
                    reporte.Show();
                    //this.Dispose();
                    break;
                case "Impreso":
                    MessageBox.Show("Esto es un Reporte Impreso");
                    break;
                case "PDF":
                    MessageBox.Show("Esto es un Reporte PDF");
                    break;
                case "Excel":
                    MessageBox.Show("Esto es un Reporte Excel");
                    break;
                default:
                    break;
            }
        }
    }
}
