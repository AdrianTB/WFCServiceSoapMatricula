using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyWebMatricula.wsMatricula;


namespace ProyWebMatricula
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {

        ServiceMatriculaClient smc = new ServiceMatriculaClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            gvMatriculas.DataSource = smc.ListarMatriculas().Tables[0];
            gvMatriculas.DataBind();
        }
    }
}