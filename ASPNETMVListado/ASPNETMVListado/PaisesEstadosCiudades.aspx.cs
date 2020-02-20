using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETMVListado
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Evitar que el usuario pierda información
            if(!IsPostBack)
            {
                IniciarLlenadoDropDown();
            }
            
        }
        private void IniciarLlenadoDropDown()
        {
            dropPais.DataSource = Consultar("Select*From paises");
            dropPais.DataTextField = "pais";
            dropPais.DataValueField = "idPais";
            dropPais.DataBind();
            dropPais.Items.Insert(0,new ListItem("[Seleccionar]", "0"));
            dropEstado.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            dropCiudad.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }


        public DataSet Consultar(string strSQL) // Conectarse a la base de datos y ejecutar una seencia sql
        {
            string strcon = "Data Source=DESKTOP-61R22GL;Initial Catalog=Aplicacion;integrated security=True";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd); //adaptador y comando que se va a ejecutar
            DataSet ds = new DataSet();
            da.Fill(ds);// Dibujar los registros en el dataset
            con.Close();
            return ds;
        }

        protected void PaisSeleccionado(object sender, EventArgs e)
        {

        }

        protected void EstadoSeleccionado(object sender, EventArgs e)
        {

        }

        protected void CiudadSeleccionado(object sender, EventArgs e)
        {

        }
    }
}