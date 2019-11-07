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
            if (!IsPostBack)
            {
                combo();
                tabla();
            }
           
        }
        public void combo()
        {
            SqlConnection conex = conexion.obtener();
            SqlCommand comando = new SqlCommand("pa_ConsultarC", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            ddlCategoria.DataSource = data;
            ddlCategoria.DataTextField = "NomCat";
            ddlCategoria.DataValueField = "CodCat";
            ddlCategoria.DataBind();

        }
        public void tabla()
        {
            SqlConnection conex = conexion.obtener();
            SqlCommand comando = new SqlCommand("pa_ConsultarP", conex);
            comando.CommandType = CommandType.StoredProcedure;
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

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int campo = Convert.ToInt32(ddlCategoria.SelectedValue);
            SqlConnection conex = conexion.obtener();
            SqlCommand command = new SqlCommand("pa_ConsultarN", conex);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@codigo", SqlDbType.Int).Value = campo;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            adapter.Fill(set);
            gvProducto.DataSource = set;
            gvProducto.DataBind();
        }
    }
}