namespace SistemaAlmacen
{
    partial class Proveedor
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
            this.grupBoxInProveedor = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cboxCiudad = new System.Windows.Forms.ComboBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grupBoxLisProveedor = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVproveedor = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cbkEstadoProveedor = new System.Windows.Forms.CheckBox();
            this.grupBoxInProveedor.SuspendLayout();
            this.grupBoxLisProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // grupBoxInProveedor
            // 
            this.grupBoxInProveedor.Controls.Add(this.button2);
            this.grupBoxInProveedor.Controls.Add(this.BTNsalir);
            this.grupBoxInProveedor.Controls.Add(this.cbkEstadoProveedor);
            this.grupBoxInProveedor.Controls.Add(this.btnModificar);
            this.grupBoxInProveedor.Controls.Add(this.button6);
            this.grupBoxInProveedor.Controls.Add(this.btnRegistrar);
            this.grupBoxInProveedor.Controls.Add(this.cboxCiudad);
            this.grupBoxInProveedor.Controls.Add(this.txtRubro);
            this.grupBoxInProveedor.Controls.Add(this.txtRuc);
            this.grupBoxInProveedor.Controls.Add(this.txtNombre);
            this.grupBoxInProveedor.Controls.Add(this.label2);
            this.grupBoxInProveedor.Controls.Add(this.label3);
            this.grupBoxInProveedor.Controls.Add(this.label4);
            this.grupBoxInProveedor.Controls.Add(this.label1);
            this.grupBoxInProveedor.Location = new System.Drawing.Point(16, 12);
            this.grupBoxInProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.grupBoxInProveedor.Name = "grupBoxInProveedor";
            this.grupBoxInProveedor.Padding = new System.Windows.Forms.Padding(4);
            this.grupBoxInProveedor.Size = new System.Drawing.Size(755, 245);
            this.grupBoxInProveedor.TabIndex = 0;
            this.grupBoxInProveedor.TabStop = false;
            this.grupBoxInProveedor.Text = "Informacion de proveedor";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkOrange;
            this.button6.Location = new System.Drawing.Point(293, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 27);
            this.button6.TabIndex = 11;
            this.button6.Text = "Agregar ciudad";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cboxCiudad
            // 
            this.cboxCiudad.FormattingEnabled = true;
            this.cboxCiudad.Location = new System.Drawing.Point(96, 163);
            this.cboxCiudad.Name = "cboxCiudad";
            this.cboxCiudad.Size = new System.Drawing.Size(178, 24);
            this.cboxCiudad.TabIndex = 10;
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(96, 116);
            this.txtRubro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(244, 22);
            this.txtRubro.TabIndex = 8;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(96, 77);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(244, 22);
            this.txtRuc.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruc:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rubro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNsalir.Location = new System.Drawing.Point(596, 122);
            this.BTNsalir.Margin = new System.Windows.Forms.Padding(4);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(131, 80);
            this.BTNsalir.TabIndex = 3;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Location = new System.Drawing.Point(596, 23);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 80);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(449, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Inhabilitar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrar.Location = new System.Drawing.Point(449, 19);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 80);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grupBoxLisProveedor
            // 
            this.grupBoxLisProveedor.Controls.Add(this.label5);
            this.grupBoxLisProveedor.Controls.Add(this.button5);
            this.grupBoxLisProveedor.Controls.Add(this.textBox5);
            this.grupBoxLisProveedor.Location = new System.Drawing.Point(16, 275);
            this.grupBoxLisProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.grupBoxLisProveedor.Name = "grupBoxLisProveedor";
            this.grupBoxLisProveedor.Padding = new System.Windows.Forms.Padding(4);
            this.grupBoxLisProveedor.Size = new System.Drawing.Size(753, 56);
            this.grupBoxLisProveedor.TabIndex = 2;
            this.grupBoxLisProveedor.TabStop = false;
            this.grupBoxLisProveedor.Text = "Lista de proveedores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ruc:";
            // 
            // DGVproveedor
            // 
            this.DGVproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproveedor.Location = new System.Drawing.Point(16, 339);
            this.DGVproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.DGVproveedor.Name = "DGVproveedor";
            this.DGVproveedor.RowHeadersWidth = 51;
            this.DGVproveedor.Size = new System.Drawing.Size(755, 166);
            this.DGVproveedor.TabIndex = 2;
            this.DGVproveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproveedor_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(502, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 32);
            this.button5.TabIndex = 1;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 23);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(268, 22);
            this.textBox5.TabIndex = 0;
            // 
            // cbkEstadoProveedor
            // 
            this.cbkEstadoProveedor.AutoSize = true;
            this.cbkEstadoProveedor.Location = new System.Drawing.Point(96, 208);
            this.cbkEstadoProveedor.Name = "cbkEstadoProveedor";
            this.cbkEstadoProveedor.Size = new System.Drawing.Size(161, 20);
            this.cbkEstadoProveedor.TabIndex = 12;
            this.cbkEstadoProveedor.Text = "Estado del Proveedor";
            this.cbkEstadoProveedor.UseVisualStyleBackColor = true;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(787, 518);
            this.Controls.Add(this.grupBoxLisProveedor);
            this.Controls.Add(this.DGVproveedor);
            this.Controls.Add(this.grupBoxInProveedor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.grupBoxInProveedor.ResumeLayout(false);
            this.grupBoxInProveedor.PerformLayout();
            this.grupBoxLisProveedor.ResumeLayout(false);
            this.grupBoxLisProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupBoxInProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNsalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grupBoxLisProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView DGVproveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cboxCiudad;
        private System.Windows.Forms.CheckBox cbkEstadoProveedor;
    }
}