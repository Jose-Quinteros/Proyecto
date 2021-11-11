using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Balistica
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                this.lblError.Text = "Por favor ingrese Usuario y Contraseña";
            }
            else
            {
                this.lblError.Text = "";

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.InitialCatalog = "Balistica";
                builder.DataSource = "DESKTOP-OMBV52N";
                builder.UserID = "sa";
                builder.Password = "123";
                builder.ApplicationName = "Prueba";


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = builder.ConnectionString;
                conn.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "verificacionUsuario";
                comando.Connection = conn;
                comando.Parameters.AddWithValue("@nomUsuario", tbUsuario.Text);               

                DataSet contenedorInfo = new DataSet();

                SqlDataAdapter cargador = new SqlDataAdapter();
                cargador.SelectCommand = comando;
                cargador.Fill(contenedorInfo);

                if (contenedorInfo.Tables[0].Rows.Count > 0)
                {
                    if (contenedorInfo.Tables[0].Rows[0]["Contraseña"].ToString() == tbPassword.Text)
                    {
                        Response.Redirect("inicio.aspx");
                    }
                    else
                    {
                        lblError.Text = "Contraseña incorrecta";
                    }
                }
                else
                {
                    lblError.Text = "Usuario incorrecto";
                }
                conn.Close();


            }
        }
    }
}