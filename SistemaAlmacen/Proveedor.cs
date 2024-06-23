using CapaEntidad;
using CapaLogica;
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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            listarProveedor();
            grupBoxInProveedor.Enabled = true;
            txtNombre.Enabled = true;

        }

        public void listarProveedor()
        {
            DGVproveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ciudad cd = new Ciudad();
            this.Hide();
            cd.ShowDialog();
            this.Show();
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Registrar
            try
            {
                entProveedor p = new entProveedor();
                p.Nombre = txtNombre.Text.Trim();               
                p.Ruc = int.Parse(txtRuc.Text.Trim());
                p.RubroID = int.Parse(txtRubro.Text.Trim());
                p.estProveedor = cbkEstadoProveedor.Checked;
                logProveedor.Instancia.InsertaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            grupBoxInProveedor.Enabled = true;
            grupBoxLisProveedor.Enabled = true;
            listarProveedor();

        }
        //Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            grupBoxInProveedor.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = true;

        }

        // editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxInProveedor.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = true;
        }


        private void DGVproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = DGVproveedor.Rows[e.RowIndex]; //
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtRuc.Text = filaActual.Cells[1].Value.ToString();
            txtRubro.Text = filaActual.Cells[2].Value.ToString();
            cboxCiudad.Text = filaActual.Cells[4].Value.ToString();
            cbkEstadoProveedor.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }
    }
}
