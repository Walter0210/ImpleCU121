namespace CU121.Interfaz
{
    partial class GestorRestaurante
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOrdenarCategorias = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarSubCategorias = new System.Windows.Forms.Button();
            this.btbBuscarCartas = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.dgvSubCategorias = new System.Windows.Forms.DataGridView();
            this.cboOrdenarSubCategorias = new System.Windows.Forms.ComboBox();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.grpSubCategorias = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cboOrdenarProductos = new System.Windows.Forms.ComboBox();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.grpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategorias)).BeginInit();
            this.grpSubCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos Mas Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha hasta";
            // 
            // cboOrdenarCategorias
            // 
            this.cboOrdenarCategorias.FormattingEnabled = true;
            this.cboOrdenarCategorias.Location = new System.Drawing.Point(6, 191);
            this.cboOrdenarCategorias.Name = "cboOrdenarCategorias";
            this.cboOrdenarCategorias.Size = new System.Drawing.Size(203, 23);
            this.cboOrdenarCategorias.TabIndex = 2;
            this.cboOrdenarCategorias.Text = "Ordenar de Manera...";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(208, 81);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(250, 23);
            this.dtpFechaDesde.TabIndex = 3;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(208, 110);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(250, 23);
            this.dtpFechaHasta.TabIndex = 4;
            // 
            // btnBuscarSubCategorias
            // 
            this.btnBuscarSubCategorias.Location = new System.Drawing.Point(6, 222);
            this.btnBuscarSubCategorias.Name = "btnBuscarSubCategorias";
            this.btnBuscarSubCategorias.Size = new System.Drawing.Size(203, 23);
            this.btnBuscarSubCategorias.TabIndex = 5;
            this.btnBuscarSubCategorias.Text = "Mostrar SubCategorias";
            this.btnBuscarSubCategorias.UseVisualStyleBackColor = true;
            // 
            // btbBuscarCartas
            // 
            this.btbBuscarCartas.Location = new System.Drawing.Point(474, 79);
            this.btbBuscarCartas.Name = "btbBuscarCartas";
            this.btbBuscarCartas.Size = new System.Drawing.Size(121, 52);
            this.btbBuscarCartas.TabIndex = 5;
            this.btbBuscarCartas.Text = "Buscar cartas Vigentes";
            this.btbBuscarCartas.UseVisualStyleBackColor = true;
            this.btbBuscarCartas.Click += new System.EventHandler(this.btbBuscarCartas_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(12, 419);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(679, 65);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(6, 22);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(203, 163);
            this.dgvCategorias.TabIndex = 7;
            this.dgvCategorias.Text = "dataGridView1";
            // 
            // grpCategorias
            // 
            this.grpCategorias.Controls.Add(this.dgvCategorias);
            this.grpCategorias.Controls.Add(this.cboOrdenarCategorias);
            this.grpCategorias.Controls.Add(this.btnBuscarSubCategorias);
            this.grpCategorias.Location = new System.Drawing.Point(12, 159);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Size = new System.Drawing.Size(215, 254);
            this.grpCategorias.TabIndex = 8;
            this.grpCategorias.TabStop = false;
            this.grpCategorias.Text = "Categorías";
            // 
            // dgvSubCategorias
            // 
            this.dgvSubCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategorias.Location = new System.Drawing.Point(6, 22);
            this.dgvSubCategorias.Name = "dgvSubCategorias";
            this.dgvSubCategorias.Size = new System.Drawing.Size(200, 163);
            this.dgvSubCategorias.TabIndex = 7;
            this.dgvSubCategorias.Text = "dataGridView2";
            // 
            // cboOrdenarSubCategorias
            // 
            this.cboOrdenarSubCategorias.FormattingEnabled = true;
            this.cboOrdenarSubCategorias.Location = new System.Drawing.Point(6, 191);
            this.cboOrdenarSubCategorias.Name = "cboOrdenarSubCategorias";
            this.cboOrdenarSubCategorias.Size = new System.Drawing.Size(200, 23);
            this.cboOrdenarSubCategorias.TabIndex = 2;
            this.cboOrdenarSubCategorias.Text = "Ordenar de Manera...";
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(6, 222);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(200, 23);
            this.btnMostrarProductos.TabIndex = 5;
            this.btnMostrarProductos.Text = "Mostrar SubCategorias";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            // 
            // grpSubCategorias
            // 
            this.grpSubCategorias.Controls.Add(this.dgvSubCategorias);
            this.grpSubCategorias.Controls.Add(this.cboOrdenarSubCategorias);
            this.grpSubCategorias.Controls.Add(this.btnMostrarProductos);
            this.grpSubCategorias.Location = new System.Drawing.Point(243, 159);
            this.grpSubCategorias.Name = "grpSubCategorias";
            this.grpSubCategorias.Size = new System.Drawing.Size(215, 254);
            this.grpSubCategorias.TabIndex = 8;
            this.grpSubCategorias.TabStop = false;
            this.grpSubCategorias.Text = "SubCategorias";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 22);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(203, 192);
            this.dgvProductos.TabIndex = 7;
            this.dgvProductos.Text = "dataGridView3";
            // 
            // cboOrdenarProductos
            // 
            this.cboOrdenarProductos.FormattingEnabled = true;
            this.cboOrdenarProductos.Location = new System.Drawing.Point(6, 222);
            this.cboOrdenarProductos.Name = "cboOrdenarProductos";
            this.cboOrdenarProductos.Size = new System.Drawing.Size(203, 23);
            this.cboOrdenarProductos.TabIndex = 2;
            this.cboOrdenarProductos.Text = "Ordenar de Manera...";
            // 
            // grpProductos
            // 
            this.grpProductos.Controls.Add(this.dgvProductos);
            this.grpProductos.Controls.Add(this.cboOrdenarProductos);
            this.grpProductos.Location = new System.Drawing.Point(474, 159);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(215, 254);
            this.grpProductos.TabIndex = 8;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Productos";
            // 
            // GestorRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 496);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.grpSubCategorias);
            this.Controls.Add(this.grpCategorias);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btbBuscarCartas);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestorRestaurante";
            this.Text = "GestorRestaurante";
            this.Load += new System.EventHandler(this.GestorRestaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.grpCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategorias)).EndInit();
            this.grpSubCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpProductos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOrdenarCategorias;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnBuscarSubCategorias;
        private System.Windows.Forms.Button btbBuscarCartas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.DataGridView dgvSubCategorias;
        private System.Windows.Forms.ComboBox cboOrdenarSubCategorias;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.GroupBox grpSubCategorias;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cboOrdenarProductos;
        private System.Windows.Forms.GroupBox grpProductos;
    }
}