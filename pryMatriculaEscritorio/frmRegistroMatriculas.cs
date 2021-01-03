using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pryMatriculaEscritorio.webserviceMatricula; // Importar Servicio

namespace pryMatriculaEscritorio
{
    public partial class frmRegistroMatriculas : MaterialSkin.Controls.MaterialForm
    {


        public frmRegistroMatriculas()
        {
            InitializeComponent();
        }

        ServiceMatriculaClient smc = new ServiceMatriculaClient();


        private void ListarDatos()
        {
            dgvMatriculas.DataSource = smc.ListarMatriculas().Tables[0];
            dgvMatriculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Limpiar()
        {
            foreach (var txt in this.Controls.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>()){
                txt.Clear();
            }

            txtIdMatricula.Text = "";
            txtNombre.Focus();
        }

        private void frmRegistroMatriculas_Load(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {

  
            
            webserviceMatricula.Matricula obj_matricula = new webserviceMatricula.Matricula();

            obj_matricula.nombre = txtNombre.Text;
            obj_matricula.apellido = txtApellido.Text;
            obj_matricula.dni = txtDni.Text;
            obj_matricula.nivel= txtNivel.Text;
            obj_matricula.turno = txtTurno.Text;
            obj_matricula.grado = txtGrado.Text;
            obj_matricula.seccion = txtSeccion.Text;
            obj_matricula.apoderado = txtApoderado.Text;
            obj_matricula.telefono = txtTelefono.Text;

            String estado = smc.RegistrarMatricula(obj_matricula);

            ListarDatos();


            MessageBox.Show(estado);

            Limpiar();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtIdMatricula.Text.Length == 0)
            {
                MessageBox.Show("Elija una matricula para editar.",
                "Mensaje");
                txtNombre.Focus();
                return;
            }

            webserviceMatricula.Matricula obj_matricula = new webserviceMatricula.Matricula();

            obj_matricula.id_matricula = Convert.ToInt32(txtIdMatricula.Text);
            obj_matricula.nombre = txtNombre.Text;
            obj_matricula.apellido = txtApellido.Text;
            obj_matricula.dni = txtDni.Text;
            obj_matricula.nivel = txtNivel.Text;
            obj_matricula.turno = txtTurno.Text;
            obj_matricula.grado = txtGrado.Text;
            obj_matricula.seccion = txtSeccion.Text;
            obj_matricula.apoderado = txtApoderado.Text;
            obj_matricula.telefono = txtTelefono.Text;


            String estado = smc.ActualizarMatricula(obj_matricula);

            ListarDatos();


            MessageBox.Show(estado);           

        }


        private void dgvMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnGuardar.Enabled = false;

            dgvMatriculas.CurrentRow.Selected = true;

            txtIdMatricula.Text = dgvMatriculas.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvMatriculas.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvMatriculas.CurrentRow.Cells[2].Value.ToString();
            txtDni.Text = dgvMatriculas.CurrentRow.Cells[3].Value.ToString();
            txtNivel.Text = dgvMatriculas.CurrentRow.Cells[4].Value.ToString();
            txtTurno.Text = dgvMatriculas.CurrentRow.Cells[5].Value.ToString();
            txtGrado.Text = dgvMatriculas.CurrentRow.Cells[6].Value.ToString();
            txtSeccion.Text = dgvMatriculas.CurrentRow.Cells[7].Value.ToString();
            txtApoderado.Text = dgvMatriculas.CurrentRow.Cells[8].Value.ToString();
            txtTelefono.Text = dgvMatriculas.CurrentRow.Cells[9].Value.ToString();


            txtIdMatricula.Enabled = false;
            


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtIdMatricula.Text.Length == 0)
            {
                MessageBox.Show("Elija un registro para eliminar.",
                "Mensaje");
                txtNombre.Focus();
                return;
            }


            DialogResult rpta = MessageBox.Show("¿Seguro de eliminar el registro N°"+txtIdMatricula.Text,"Senati",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(rpta == DialogResult.Yes)
            {

                webserviceMatricula.Matricula obj_matricula = new webserviceMatricula.Matricula();

                obj_matricula.id_matricula = Convert.ToInt32(txtIdMatricula.Text);

                String estado = smc.EliminarMatricula(obj_matricula);

                ListarDatos();


                MessageBox.Show(estado, "Mensaje");

                Limpiar();
            }


        }


        private void ValidacionNumero(object sender, KeyPressEventArgs e)
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

    

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumero(sender, e);
        }

        private void txtGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumero(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumero(sender, e);
        }

        private void txtApoderado_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
