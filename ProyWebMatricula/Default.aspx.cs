using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyWebMatricula.wsMatricula;

namespace ProyWebMatricula
{
    public partial class _Default : Page
    {

        ServiceMatriculaClient smc = new ServiceMatriculaClient(); // Linea de codigo para poder usar las funciones del servicio

        protected void Page_Load(object sender, EventArgs e)
        {
            ListarMatriculas();
        }


        private void ListarMatriculas()
        {
           
        }


    }
}