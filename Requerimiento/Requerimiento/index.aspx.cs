using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Requerimiento
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUno_Click(object sender, EventArgs e)
        {
            Response.Redirect("Primer.aspx");
        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            Response.Redirect("segundo.aspx");
        }

        protected void btnCuatro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cuarto.aspx");
        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            Response.Redirect("tercer.aspx");
        }
    }
}