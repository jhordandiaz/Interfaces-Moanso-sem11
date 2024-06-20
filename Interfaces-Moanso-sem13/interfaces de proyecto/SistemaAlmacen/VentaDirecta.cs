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
    public partial class VentaDirecta : Form
    {
        public VentaDirecta()
        {
            InitializeComponent();
        }

        private void lbl_Precio_Click(object sender, EventArgs e)
        {

        }

        private void VentaDirecta_Load(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Today.Date.ToString("d");
            lbl_Precio.Text = (0).ToString("C");
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Anular_Click(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
