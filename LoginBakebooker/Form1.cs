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

        SqlConnection conn = new SqlConnection(@"Data Source=IDEAPAD;Initial Catalog=BakeBooker;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;

            usuario= txtUsuario.Text;
            contraseña=txtContraseña.Text;
            try
            {
                string querry = "select * from Empleado where Usuario= '" + usuario + "'AND Contraseña='" + contraseña + "' ";
                SqlDataAdapter sda= new SqlDataAdapter(querry,conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    usuario=txtUsuario.Text;
                    contraseña = txtContraseña.Text;

                    Form2 entrada = new Form2(usuario,contraseña);
                    entrada.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login fallado","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("error de try catch");
            }

           /*
            try
            {
                frm2 = new Form2(/*sqlconexion.ConnectionStringtxtUsuario.Text, txtContraseña.Text);
                frm2.Visible = true;

                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        x.Text = "";
                    }
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                              
            }*/
    
        }
    }
}
