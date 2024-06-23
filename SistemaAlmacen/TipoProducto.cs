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
    public partial class TipoProducto : Form
    {
        public TipoProducto()
        {
            InitializeComponent();
        }

        private void TipoProducto_Load(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
