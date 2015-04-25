using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Webparcial
{
    public partial class WebAppRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Conexion con Base De Datos
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc13\documents\visual studio 2012\Projects\Webparcial\Webparcial\App_Data\aspnet-Webparcial-20150424191146.mdf;Initial Catalog=aspnet-Webparcial-20150424191146;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string sqlCommand = "INSERT INTO empleados(cedula, nombre, apellido, correo, domicilio, ciudad, telefono) VALUES (104,'julio', 'paredes', 'simpsons@hotmail.com','ceci', 'cucuta', '5873408')";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
        }
    }
}