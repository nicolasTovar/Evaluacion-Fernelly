using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Requerimiento
{
    public partial class tercer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            combo();
         //   tabla();
        }
        public void combo()
        {
            SqlConnection conex = conexion.obtener();
            SqlCommand comando = new SqlCommand("pa_ConsultarCN", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            ddlCategoria.DataSource = data;
           
            ddlCategoria.DataTextField = "NomCat";
            if (ddlCategoria.SelectedValue=="NomC")
            {
          //      tabla();
            }
       
            ddlCategoria.DataBind();
        }
       public void tabla(string nombre,int codigo)
        {
            SqlConnection conex = conexion.obtener();
            SqlCommand comando = new SqlCommand("pa_ConsultarN", conex);
            comando.CommandType = CommandType.StoredProcedure;
             SqlParameter parametro = new SqlParameter();
             SqlParameter parametro2 = new SqlParameter();
            comando.Parameters.Add(parametro2).Value = nombre;
            comando.Parameters.Add(parametro).Value = codigo;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            gvProducto.DataSource = data;
            gvProducto.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}