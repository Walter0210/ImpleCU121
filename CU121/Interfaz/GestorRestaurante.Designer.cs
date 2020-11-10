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
            this.cboOrdenarSubCategorias = new System.Windows.Forms.ComboBox();
            this.cboOrdenarProductos = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarSubCategorias = new System.Windows.Forms.Button();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos Mas Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha hasta";
            // 
            // cboOrdenarCategorias
            // 
            this.cboOrdenarCategorias.FormattingEnabled = true;
            this.cboOrdenarCategorias.Location = new System.Drawing.Point(147, 336);
            this.cboOrdenarCategorias.Name = "cboOrdenarCategorias";
            this.cboOrdenarCategorias.Size = new System.Drawing.Size(121, 23);
            this.cboOrdenarCategorias.TabIndex = 2;
            this.cboOrdenarCategorias.Text = "Ordenar de Manera...";
            // 
            // cboOrdenarSubCategorias
            // 
            this.cboOrdenarSubCategorias.FormattingEnabled = true;
            this.cboOrdenarSubCategorias.Location = new System.Drawing.Point(147, 307);
            this.cboOrdenarSubCategorias.Name = "cboOrdenarSubCategorias";
            this.cboOrdenarSubCategorias.Size = new System.Drawing.Size(164, 23);
            this.cboOrdenarSubCategorias.TabIndex = 2;
            this.cboOrdenarSubCategorias.Text = "Ordenar de Manera...";
            // 
            // cboOrdenarProductos
            // 
            this.cboOrdenarProductos.FormattingEnabled = true;
            this.cboOrdenarProductos.Location = new System.Drawing.Point(147, 269);
            this.cboOrdenarProductos.Name = "cboOrdenarProductos";
            this.cboOrdenarProductos.Size = new System.Drawing.Size(164, 23);
            this.cboOrdenarProductos.TabIndex = 2;
            this.cboOrdenarProductos.Text = "Ordenar de Manera...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(134, 113);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // btnBuscarSubCategorias
            // 
            this.btnBuscarSubCategorias.Location = new System.Drawing.Point(147, 375);
            this.btnBuscarSubCategorias.Name = "btnBuscarSubCategorias";
            this.btnBuscarSubCategorias.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarSubCategorias.TabIndex = 5;
            this.btnBuscarSubCategorias.Text = "Mostrar SubCategorias";
            this.btnBuscarSubCategorias.UseVisualStyleBackColor = true;
            this.btnBuscarSubCategorias.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Location = new System.Drawing.Point(147, 404);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarProductos.TabIndex = 6;
            this.btnBuscarProductos.Text = "Mostrar Productos";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            // 
            // GestorRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.btnBuscarSubCategorias);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboOrdenarProductos);
            this.Controls.Add(this.cboOrdenarSubCategorias);
            this.Controls.Add(this.cboOrdenarCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestorRestaurante";
            this.Text = "GestorRestaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOrdenarCategorias;
        private System.Windows.Forms.ComboBox cboOrdenarSubCategorias;
        private System.Windows.Forms.ComboBox cboOrdenarProductos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnBuscarSubCategorias;
        private System.Windows.Forms.Button btnBuscarProductos;
    }
}