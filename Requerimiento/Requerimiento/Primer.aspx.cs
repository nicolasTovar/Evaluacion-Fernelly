using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Script.Serialization;
namespace Requerimiento
{
    public partial class Primer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            combo();
            tabla();
        }
        public void combo()
        {
            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("Categoria.xml"));
            ddlCategoria.DataSource = data;
            ddlCategoria.DataTextField = "NomCat";
            ddlCategoria.DataBind();
        }
        public void tabla()
        {
            //  string archivo = File.ReadAllText(Server.MapPath("Producto.xml"));
            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("Producto.xml"));
            gvProducto.DataSource = data.Tables[0];
           
            gvProducto.DataBind();

        

        }
    }
}