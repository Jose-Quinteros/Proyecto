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


                SqlConnection conn = new SqlConnection(builder.ConnectionString);
                SqlCommand command = new SqlCommand("verificacionUsuario", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Connection.Open();
                command.Parameters.AddWithValue("@nomUsuario", tbUsuario.Text);
                command.Parameters.AddWithValue("@contraseña", tbPassword.Text);

                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    lblError.Text = "Error de Usuario o Contraseña";
                }
                command.Connection.Close();


            }
        }
    }
}