namespace SistemaAlmacen
{
    partial class VentaDirecta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.cmb_MtdPago = new System.Windows.Forms.ComboBox();
            this.cmb_Seleccion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dtgv_VentaDirecta = new System.Windows.Forms.DataGridView();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Anular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ACliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_VentaDirecta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione el producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.lbl_Precio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.cmb_MtdPago);
            this.groupBox1.Controls.Add(this.cmb_Seleccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Precio.Location = new System.Drawing.Point(299, 136);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(251, 20);
            this.lbl_Precio.TabIndex = 9;
            this.lbl_Precio.Text = "Visualizador del precio del producto";
            this.lbl_Precio.Click += new System.EventHandler(this.lbl_Precio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(270, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio del producto";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(272, 57);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(133, 22);
            this.txt_Cantidad.TabIndex = 7;
            // 
            // cmb_MtdPago
            // 
            this.cmb_MtdPago.FormattingEnabled = true;
            this.cmb_MtdPago.Location = new System.Drawing.Point(21, 161);
            this.cmb_MtdPago.Name = "cmb_MtdPago";
            this.cmb_MtdPago.Size = new System.Drawing.Size(205, 24);
            this.cmb_MtdPago.TabIndex = 6;
            // 
            // cmb_Seleccion
            // 
            this.cmb_Seleccion.FormattingEnabled = true;
            this.cmb_Seleccion.Location = new System.Drawing.Point(21, 53);
            this.cmb_Seleccion.Name = "cmb_Seleccion";
            this.cmb_Seleccion.Size = new System.Drawing.Size(205, 24);
            this.cmb_Seleccion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(270, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione método de pago";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Buscar.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Buscar.Location = new System.Drawing.Point(166, 73);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(131, 40);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dtgv_VentaDirecta
            // 
            this.dtgv_VentaDirecta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgv_VentaDirecta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_VentaDirecta.GridColor = System.Drawing.Color.Goldenrod;
            this.dtgv_VentaDirecta.Location = new System.Drawing.Point(23, 409);
            this.dtgv_VentaDirecta.Name = "dtgv_VentaDirecta";
            this.dtgv_VentaDirecta.RowHeadersWidth = 51;
            this.dtgv_VentaDirecta.RowTemplate.Height = 24;
            this.dtgv_VentaDirecta.Size = new System.Drawing.Size(722, 288);
            this.dtgv_VentaDirecta.TabIndex = 11;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Volver.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Volver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Volver.Location = new System.Drawing.Point(591, 363);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(131, 40);
            this.btn_Volver.TabIndex = 11;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Registrar.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Registrar.Location = new System.Drawing.Point(591, 201);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(131, 40);
            this.btn_Registrar.TabIndex = 12;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Anular
            // 
            this.btn_Anular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Anular.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Anular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Anular.Location = new System.Drawing.Point(591, 280);
            this.btn_Anular.Name = "btn_Anular";
            this.btn_Anular.Size = new System.Drawing.Size(131, 40);
            this.btn_Anular.TabIndex = 13;
            this.btn_Anular.Text = "Anular";
            this.btn_Anular.UseVisualStyleBackColor = false;
            this.btn_Anular.Click += new System.EventHandler(this.btn_Anular_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nombre Cliente:";
            // 
            // txt_NCliente
            // 
            this.txt_NCliente.Location = new System.Drawing.Point(6, 44);
            this.txt_NCliente.Name = "txt_NCliente";
            this.txt_NCliente.Size = new System.Drawing.Size(133, 22);
            this.txt_NCliente.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_DNI);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_ACliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_NCliente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(23, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 174);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(10, 140);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(133, 22);
            this.txt_DNI.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "DNI:";
            // 
            // txt_ACliente
            // 
            this.txt_ACliente.Location = new System.Drawing.Point(6, 91);
            this.txt_ACliente.Name = "txt_ACliente";
            this.txt_ACliente.Size = new System.Drawing.Size(133, 22);
            this.txt_ACliente.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Apellido:";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Fecha.Location = new System.Drawing.Point(420, 81);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(195, 20);
            this.lbl_Fecha.TabIndex = 16;
            this.lbl_Fecha.Text = "Visualizador de fecha actual";
            // 
            // VentaDirecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(758, 704);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Anular);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dtgv_VentaDirecta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "VentaDirecta";
            this.Text = "VentaDirecta";
            this.Load += new System.EventHandler(this.VentaDirecta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_VentaDirecta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox cmb_MtdPago;
        private System.Windows.Forms.ComboBox cmb_Seleccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgv_VentaDirecta;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Anular;
        private System.Windows.Forms.TextBox txt_NCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ACliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.Label lbl_Fecha;
    }
}