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
    public partial class frmMatriculas : MaterialSkin.Controls.MaterialForm
    {
        public frmMatriculas()
        {
            InitializeComponent();
        }

        ServiceMatriculaClient smc = new ServiceMatriculaClient();

        private void frmMatriculas_Load(object sender, EventArgs e)
        {
            dgvMatriculas.DataSource = smc.ListarMatriculas().Tables[0];
            dgvMatriculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
