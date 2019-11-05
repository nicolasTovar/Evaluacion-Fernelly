using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using System.Data;
using System.Web.Script.Serialization;
namespace Requerimiento
{
    public partial class Cuarto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
           //combo();
            tabla();
        }
        public void combo()
        {
            string archivo = File.ReadAllText(Server.MapPath("Categoria.json"));
            
            DataTable data = (DataTable)JsonConvert.DeserializeObject(archivo, typeof(DataTable));
            ddlCategoria.DataSource = data;
            ddlCategoria.DataTextField = "NomCat";
            ddlCategoria.DataBind();
            

        }
        public void tabla()
        {
            string archivo = File.ReadAllText(Server.MapPath("Producto.json"));
            DataTable tabla = (DataTable)JsonConvert.DeserializeObject(archivo,typeof(DataTable));
            gvProducto.DataSource = tabla;
            gvProducto.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}