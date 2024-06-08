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
    }
}
