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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones principales";
            // 
            // btnVentadirecta
            // 
            this.btnVentadirecta.Location = new System.Drawing.Point(121, 106);
            this.btnVentadirecta.Name = "btnVentadirecta";
            this.btnVentadirecta.Size = new System.Drawing.Size(176, 26);
            this.btnVentadirecta.TabIndex = 4;
            this.btnVentadirecta.Text = "Realizar venta directa";
            this.btnVentadirecta.UseVisualStyleBackColor = true;
            this.btnVentadirecta.Click += new System.EventHandler(this.btnVentadirecta_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(212, 74);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(176, 26);
            this.btnSalida.TabIndex = 3;
            this.btnSalida.Text = "Realizar salida de producto";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnOrdencompra
            // 
            this.btnOrdencompra.Location = new System.Drawing.Point(17, 74);
            this.btnOrdencompra.Name = "btnOrdencompra";
            this.btnOrdencompra.Size = new System.Drawing.Size(176, 26);
            this.btnOrdencompra.TabIndex = 2;
            this.btnOrdencompra.Text = "Realizar orden de compra";
            this.btnOrdencompra.UseVisualStyleBackColor = true;
            this.btnOrdencompra.Click += new System.EventHandler(this.btnOrdencompra_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(212, 33);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(176, 25);
            this.btnDevolucion.TabIndex = 1;
            this.btnDevolucion.Text = "Realizar devolucion de insumos";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(17, 32);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(176, 26);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenedores";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(121, 102);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(176, 24);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnTipoproducto
            // 
            this.btnTipoproducto.Location = new System.Drawing.Point(212, 64);
            this.btnTipoproducto.Name = "btnTipoproducto";
            this.btnTipoproducto.Size = new System.Drawing.Size(176, 24);
            this.btnTipoproducto.TabIndex = 3;
            this.btnTipoproducto.Text = "Tipos de producto";
            this.btnTipoproducto.UseVisualStyleBackColor = true;
            this.btnTipoproducto.Click += new System.EventHandler(this.btnTipoproducto_Click);
            // 
            // btnTipoinsumo
            // 
            this.btnTipoinsumo.Location = new System.Drawing.Point(14, 64);
            this.btnTipoinsumo.Name = "btnTipoinsumo";
            this.btnTipoinsumo.Size = new System.Drawing.Size(176, 24);
            this.btnTipoinsumo.TabIndex = 2;
            this.btnTipoinsumo.Text = "Tipos de insumos";
            this.btnTipoinsumo.UseVisualStyleBackColor = true;
            this.btnTipoinsumo.Click += new System.EventHandler(this.btnTipoinsumo_Click);
            // 
            // btnMetodopago
            // 
            this.btnMetodopago.Location = new System.Drawing.Point(212, 24);
            this.btnMetodopago.Name = "btnMetodopago";
            this.btnMetodopago.Size = new System.Drawing.Size(176, 24);
            this.btnMetodopago.TabIndex = 1;
            this.btnMetodopago.Text = "Metodo de pago";
            this.btnMetodopago.UseVisualStyleBackColor = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(14, 24);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(176, 24);
            this.btnProveedor.TabIndex = 0;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaAlmacen.Properties.Resources.foto_empresa;
            this.pictureBox1.Location = new System.Drawing.Point(80, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(434, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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

