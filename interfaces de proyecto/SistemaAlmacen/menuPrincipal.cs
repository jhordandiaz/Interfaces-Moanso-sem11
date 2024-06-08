using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            EntradaInsumos ei = new EntradaInsumos();
            this.Hide();
            ei.ShowDialog();
            this.Show();
        }
        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            DevolucionInsumos di = new DevolucionInsumos();
            this.Hide();
            di.ShowDialog();
            this.Show();
        }

        private void btnTipoinsumo_Click(object sender, EventArgs e)
        {
            TipoInsumos ti = new TipoInsumos();
            this.Hide();
            ti.ShowDialog();
            this.Show();
        }

        private void btnVentadirecta_Click(object sender, EventArgs e)
        {
            VentaDirecta vd = new VentaDirecta();
            this.Hide();
            vd.ShowDialog();
            this.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Proveedor pr = new Proveedor();
            this.Hide();
            pr.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            this.Hide();
            cl.ShowDialog();
            this.Show();
        }

        private void btnOrdencompra_Click(object sender, EventArgs e)
        {
            OrdenCompra oc = new OrdenCompra();
            this.Hide();
            oc.ShowDialog();
            this.Show();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            SalidaProducto sp = new SalidaProducto();
            this.Hide();
            sp.ShowDialog();
            this.Show();
        }

        private void btnTipoproducto_Click(object sender, EventArgs e)
        {
            TipoProducto tp = new TipoProducto();
            this.Hide();
            tp.ShowDialog();
            this.Show();
        }
    }
}
