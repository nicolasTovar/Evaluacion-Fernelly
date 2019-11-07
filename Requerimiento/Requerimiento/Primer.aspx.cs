using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace Requerimiento
{
    public partial class Primer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCategoria.Visible = false;
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            combo();
            tabla();
            ddlCategoria.Visible = true;
          
        }
        public void combo()
        {
            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("Categoria.xml"));
            ddlCategoria.DataSource = data;
            ddlCategoria.DataTextField = "NomCat";
            ddlCategoria.DataBind();
            dynamic combo = ddlCategoria.DataSource;
           
            Session["Archivo"] = JsonConvert.SerializeObject(combo);
         

        }
      

        
        public void tabla()
        {
            //  string archivo = File.ReadAllText(Server.MapPath("Producto.xml"));
            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("Producto.xml"));
            gvProducto.DataSource = data.Tables[0];
           
            gvProducto.DataBind();
            dynamic tabla = gvProducto.DataSource;
            
            Session["Archivo2"] = JsonConvert.SerializeObject(tabla);
          

        }
       

        

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnCategoria_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Server.MapPath("Categoria.json"), "[" + Session["Archivo"].ToString() + "]");
            Response.Write("<script>alert('Se creo archivo JSON de Categoria')</script>");
        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Server.MapPath("Producto.json"), "[" + Session["Archivo2"].ToString() + "]");
            Response.Write("<script>alert('Creado archivo JSON de producto')</script>");
        }
    }
}