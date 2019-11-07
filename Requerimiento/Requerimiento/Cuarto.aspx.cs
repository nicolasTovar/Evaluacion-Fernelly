using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace Requerimiento
{
    public partial class Cuartoo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCategoria.Visible = false;
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
           combo();
            tabla();
            ddlCategoria.Visible = true;
        }
        public void combo()
        {
            string archivo = File.ReadAllText(Server.MapPath("Categoria.json"));
            DataTable data = (DataTable)JsonConvert.DeserializeObject(archivo, typeof(DataTable));
            ddlCategoria.DataSource = data;
            ddlCategoria.DataTextField="NomCat";
            ddlCategoria.DataBind();


        }
        public void tabla()
        {
            string archivo = File.ReadAllText(Server.MapPath("Producto.json"));
            DataTable tabla = (DataTable)JsonConvert.DeserializeObject(archivo, typeof(DataTable));
            gvProducto.DataSource = tabla;
            gvProducto.DataBind();
        }
    }
}