namespace CU121.Interfaz
{
    partial class ReportePantalla
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
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblPie = new System.Windows.Forms.Label();
            this.grdCuerpo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuerpo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblEncabezado.Location = new System.Drawing.Point(60, 43);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(328, 17);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Informe de Productos mas pedidos entre las fechas:";
            // 
            // lblPie
            // 
            this.lblPie.AutoSize = true;
            this.lblPie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPie.Location = new System.Drawing.Point(12, 658);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(152, 15);
            this.lblPie.TabIndex = 1;
            this.lblPie.Text = "El reporte fue generado por:";
            // 
            // grdCuerpo
            // 
            this.grdCuerpo.AllowUserToAddRows = false;
            this.grdCuerpo.AllowUserToDeleteRows = false;
            this.grdCuerpo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCuerpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCuerpo.Location = new System.Drawing.Point(12, 114);
            this.grdCuerpo.Name = "grdCuerpo";
            this.grdCuerpo.ReadOnly = true;
            this.grdCuerpo.Size = new System.Drawing.Size(596, 541);
            this.grdCuerpo.TabIndex = 2;
            // 
            // ReportePantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 682);
            this.Controls.Add(this.grdCuerpo);
            this.Controls.Add(this.lblPie);
            this.Controls.Add(this.lblEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReportePantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePantalla";
            this.Load += new System.EventHandler(this.ReportePantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuerpo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblPie;
        private System.Windows.Forms.DataGridView grdCuerpo;
    }
}