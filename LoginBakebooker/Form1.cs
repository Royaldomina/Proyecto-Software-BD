using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBakebooker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string usuario, contraseña;

            usuario= txtUsuario.Text;
            contraseña=txtContraseña.Text;
            try
            {
                string connectionString = $"Data Source=IDEAPAD;Initial Catalog=BakeBooker;User ID={usuario};Password={contraseña}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MessageBox.Show("Conexión exitosa a la base de datos.");
                        Form2 entrada = new Form2(usuario,contraseña);
                        entrada.Show();
                        this.Hide();
                        // Puedes realizar operaciones adicionales aquí después de establecer la conexión
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    }
                }

            }
            catch 
            {
                MessageBox.Show("error de try catch");
            }
        }
    }
}
