namespace SistemaAlmacen
{
    partial class menuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVentadirecta = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnOrdencompra = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnTipoproducto = new System.Windows.Forms.Button();
            this.btnTipoinsumo = new System.Windows.Forms.Button();
            this.btnMetodopago = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVentadirecta);
            this.groupBox1.Controls.Add(this.btnSalida);
            this.groupBox1.Controls.Add(this.btnOrdencompra);
            this.groupBox1.Controls.Add(this.btnDevolucion);
            this.groupBox1.Controls.Add(this.btnEntrada);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(553, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones principales";
            // 
            // btnVentadirecta
            // 
            this.btnVentadirecta.Location = new System.Drawing.Point(161, 130);
            this.btnVentadirecta.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentadirecta.Name = "btnVentadirecta";
            this.btnVentadirecta.Size = new System.Drawing.Size(235, 32);
            this.btnVentadirecta.TabIndex = 4;
            this.btnVentadirecta.Text = "Realizar venta directa";
            this.btnVentadirecta.UseVisualStyleBackColor = true;
            this.btnVentadirecta.Click += new System.EventHandler(this.btnVentadirecta_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(283, 91);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(235, 32);
            this.btnSalida.TabIndex = 3;
            this.btnSalida.Text = "Realizar salida de producto";
            this.btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnOrdencompra
            // 
            this.btnOrdencompra.Location = new System.Drawing.Point(23, 91);
            this.btnOrdencompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdencompra.Name = "btnOrdencompra";
            this.btnOrdencompra.Size = new System.Drawing.Size(235, 32);
            this.btnOrdencompra.TabIndex = 2;
            this.btnOrdencompra.Text = "Realizar orden de compra";
            this.btnOrdencompra.UseVisualStyleBackColor = true;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(283, 41);
            this.btnDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(235, 31);
            this.btnDevolucion.TabIndex = 1;
            this.btnDevolucion.Text = "Realizar devolucion de insumos";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(23, 39);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(235, 32);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Realizar entrada de insumos";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCliente);
            this.groupBox2.Controls.Add(this.btnTipoproducto);
            this.groupBox2.Controls.Add(this.btnTipoinsumo);
            this.groupBox2.Controls.Add(this.btnMetodopago);
            this.groupBox2.Controls.Add(this.btnProveedor);
            this.groupBox2.Location = new System.Drawing.Point(16, 554);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(553, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenedores";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(161, 126);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(235, 30);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnTipoproducto
            // 
            this.btnTipoproducto.Location = new System.Drawing.Point(283, 79);
            this.btnTipoproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoproducto.Name = "btnTipoproducto";
            this.btnTipoproducto.Size = new System.Drawing.Size(235, 30);
            this.btnTipoproducto.TabIndex = 3;
            this.btnTipoproducto.Text = "Tipos de producto";
            this.btnTipoproducto.UseVisualStyleBackColor = true;
            // 
            // btnTipoinsumo
            // 
            this.btnTipoinsumo.Location = new System.Drawing.Point(19, 79);
            this.btnTipoinsumo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoinsumo.Name = "btnTipoinsumo";
            this.btnTipoinsumo.Size = new System.Drawing.Size(235, 30);
            this.btnTipoinsumo.TabIndex = 2;
            this.btnTipoinsumo.Text = "Tipos de insumos";
            this.btnTipoinsumo.UseVisualStyleBackColor = true;
            this.btnTipoinsumo.Click += new System.EventHandler(this.btnTipoinsumo_Click);
            // 
            // btnMetodopago
            // 
            this.btnMetodopago.Location = new System.Drawing.Point(283, 30);
            this.btnMetodopago.Margin = new System.Windows.Forms.Padding(4);
            this.btnMetodopago.Name = "btnMetodopago";
            this.btnMetodopago.Size = new System.Drawing.Size(235, 30);
            this.btnMetodopago.TabIndex = 1;
            this.btnMetodopago.Text = "Metodo de pago";
            this.btnMetodopago.UseVisualStyleBackColor = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(19, 30);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(235, 30);
            this.btnProveedor.TabIndex = 0;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaAlmacen.Properties.Resources.foto_empresa;
            this.pictureBox1.Location = new System.Drawing.Point(107, 185);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(578, 728);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVentadirecta;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnOrdencompra;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTipoproducto;
        private System.Windows.Forms.Button btnTipoinsumo;
        private System.Windows.Forms.Button btnMetodopago;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnCliente;
    }
}

