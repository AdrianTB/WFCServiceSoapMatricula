using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pryMatriculaEscritorio.webserviceMatricula;

namespace pryMatriculaEscritorio
{
    public partial class formBuscarbyMatricula : MaterialSkin.Controls.MaterialForm
    {
        public formBuscarbyMatricula()
        {
            InitializeComponent();
        }

        ServiceMatriculaClient smc = new ServiceMatriculaClient();

        private void formBuscarbyMatricula_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtValorBuscado.Text.Length == 0)
            {
                MessageBox.Show("Ingrese la matricula a buscar porfavor ");
                txtValorBuscado.Focus();
                return;
            }         

            
            int matricula = Convert.ToInt32(txtValorBuscado.Text);

            DataTable dt = new DataTable();
            dt = smc.BuscarporMatricula(matricula).Tables[0];

            if(dt.Rows.Count > 0)
            {
                txtNombreCompleto.Text = dt.Rows[0]["nombre"].ToString() + " " + dt.Rows[0]["apellido"].ToString();
                txtDni.Text = dt.Rows[0]["dni"].ToString();
                txtNivel.Text = dt.Rows[0]["nivel"].ToString();
                txtTurno.Text = dt.Rows[0]["turno"].ToString();
                txtGrado.Text = dt.Rows[0]["grado"].ToString();
                txtSeccion.Text = dt.Rows[0]["seccion"].ToString();
                txtApoderado.Text = dt.Rows[0]["apoderado"].ToString();
                txtTelefono.Text = dt.Rows[0]["telefono"].ToString();
            }
            else
            {
                MessageBox.Show("El DNI ingresado no existe ...");
            }

            
        }
        private void txtValorBuscado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
