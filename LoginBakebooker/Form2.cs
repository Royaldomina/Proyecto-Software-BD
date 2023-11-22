using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginBakebooker
{
    public partial class Form2 : Form
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=IDEAPAD;Initial Catalog=BakeBooker;Integrated Security=True";


        public Form2(string strUsuario, string strContraseña)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedido_detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void tabControlBakeBooker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreTabla = ObtenerNombreTabla();
            if (!string.IsNullOrEmpty(nombreTabla))
            {
                try
                {
                    sqlConnection.Open();
                    MostrarDatos(nombreTabla);
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private DataGridView ObtenerDataGridViewSeleccionado()
        {
            // Determina el TabPage seleccionado actualmente y devuelve el DataGridView correspondiente
            switch (tabControlBakeBooker.SelectedIndex)
            {
                case 0:
                    return dgvClientes; // Reemplaza con el nombre de tu DataGridView en el TabPage 1
                case 1:
                    return dgvEmpleados; // Reemplaza con el nombre de tu DataGridView en el TabPage 2
                case 2:
                    return dgvProductos; // Reemplaza con el nombre de tu DataGridView en el TabPage 3
                case 3:
                    return dgvPedidos; // Reemplaza con el nombre de tu DataGridView en el TabPage 4
                case 4:
                    return dgvPedido_detalles; // Reemplaza con el nombre de tu DataGridView en el TabPage 5
                case 5:
                    return dgvInventario;
                default:
                    return null;
            }
        }

        private string ObtenerNombreTabla()
        {
            // Devuelve el nombre de la tabla correspondiente al TabPage seleccionado
            switch (tabControlBakeBooker.SelectedIndex)
            {
                case 0:
                    return "Cliente"; // Reemplaza con el nombre de tu tabla en el TabPage 1
                case 1:
                    return "Empleado"; // Reemplaza con el nombre de tu tabla en el TabPage 2
                case 2:
                    return "Producto"; // Reemplaza con el nombre de tu tabla en el TabPage 3
                case 3:
                    return "Pedido"; // Reemplaza con el nombre de tu tabla en el TabPage 4
                case 4:
                    return "Pedido_detalles"; // Reemplaza con el nombre de tu tabla en el TabPage 5
                case 5:
                    return "Inventario";
                default:
                    return null;
            }
        }

        private void MostrarDatos(string nombreTabla)
        {
            try
            {
                string query = $"SELECT * FROM {nombreTabla}"; // Utiliza el nombre de la tabla proporcionado
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Determina qué DataGridView está en el TabPage seleccionado actualmente
                DataGridView dataGridView = ObtenerDataGridViewSeleccionado();
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_Fecha_Alta_C_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_C_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_C_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
