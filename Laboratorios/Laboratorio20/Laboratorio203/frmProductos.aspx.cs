using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Laboratorio203
{
    public partial class frmProductos : System.Web.UI.Page
    {
        string connectionString = @"Server=ADMINIS-E1FE361;Database=Productos;TrustServerCertificate=true;Integrated Security=SSPI;";
        bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                txtId.Enabled = false;
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
                txtStock.Enabled = false;
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;

            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            txtNombre.Focus();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                string sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@NOMBRE, @PRECIO, @STOCK)";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                cmd.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@STOCK", txtStock.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                lblMensaje.Text = "Registro ingresado correctamente.";
            }
            else
            {
                string sql = "UPDATE LAPTOPS SET NOMBRE=@NOMBRE, PRECIO=@PRECIO, STOCK=@STOCK WHERE ID=@ID";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                cmd.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@STOCK", txtStock.Text);
                cmd.Parameters.AddWithValue("@ID", txtId.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                lblMensaje.Text = "Registro actualizado correctamente.";
            }

            Reset();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE ID=@ID";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", txtBuscarId.Text);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtId.Text = reader["ID"].ToString();
                txtNombre.Text = reader["NOMBRE"].ToString();
                txtPrecio.Text = reader["PRECIO"].ToString();
                txtStock.Text = reader["STOCK"].ToString();

                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;

                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
                txtStock.Enabled = true;

                nuevo = false;
            }
            else
            {
                lblMensaje.Text = "No se encontró ningún registro.";
            }

            con.Close();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM LAPTOPS WHERE ID=@ID";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", txtId.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            lblMensaje.Text = "Registro eliminado correctamente.";

            Reset();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtBuscarId.Text = "";
        }
    }
}
