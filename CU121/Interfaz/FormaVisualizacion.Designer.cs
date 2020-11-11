namespace CU121.Interfaz
{
    partial class FormaVisualizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboForma = new System.Windows.Forms.ComboBox();
            this.lblFormaVis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboForma
            // 
            this.cboForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForma.FormattingEnabled = true;
            this.cboForma.Location = new System.Drawing.Point(167, 71);
            this.cboForma.Name = "cboForma";
            this.cboForma.Size = new System.Drawing.Size(121, 23);
            this.cboForma.TabIndex = 0;
            // 
            // lblFormaVis
            // 
            this.lblFormaVis.AutoSize = true;
            this.lblFormaVis.Location = new System.Drawing.Point(60, 74);
            this.lblFormaVis.Name = "lblFormaVis";
            this.lblFormaVis.Size = new System.Drawing.Size(78, 15);
            this.lblFormaVis.TabIndex = 1;
            this.lblFormaVis.Text = "Visualizacion:";
            this.lblFormaVis.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la forma de visualizaicon del reporte.";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(121, 112);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar!";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // FormaVisualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 156);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFormaVis);
            this.Controls.Add(this.cboForma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormaVisualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccione Forma Visualizacion";
            this.Load += new System.EventHandler(this.FormaVisualizacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboForma;
        private System.Windows.Forms.Label lblFormaVis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}