using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace LoginBakebooker
{
    public partial class Form2 : Form
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=IDEAPAD;Initial Catalog=BakeBooker;Integrated Security=True";
        private string usuario;
        private string contraseña;

        public Form2(string usuario, string contraseña)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.connectionString= $"Data Source=IDEAPAD;Initial Catalog=BakeBooker;User ID={usuario};Password={contraseña}";
            sqlConnection = new SqlConnection(connectionString);
            DgvGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Refrescar();

        }
        private void Refrescar()
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
        private void tabControlBakeBooker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrescar();

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


                DgvGeneral.DataSource = dataTable;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       
        private void btnInsertar_C_Click(object sender, EventArgs e)
        {
            string nombre= txtNombre.Text;
            string apellido=txtApellido.Text;
            string calle=txt_calle_C.Text;
            int numexterior=Convert.ToInt32(txt_NumeroExt_C.Text);
            int? numinterior = null;
            if (!string.IsNullOrEmpty(txtNumINT_C.Text))
            {
                // Intentar convertir el texto del TextBox a un número entero
                if (int.TryParse(txtNumINT_C.Text, out int resultado))
                {
                    numinterior = resultado;
                }
                else
                {
                    MessageBox.Show("El campo de correo electrónico debe ser un número válido.");
                    return;
                }
            }
            string rfc = string.IsNullOrEmpty(txtRfc_C.Text) ? null : txtRfc_C.Text;
            int telefono = Convert.ToInt32(txtTelefono_C.Text);
            string correo=txtCorreo_Electronico_C.Text;


            string query = "INSERT INTO Cliente (Nombre,Apellido,Calle,Numero_exterior,Numero_interior,Telefono,Correo_electronico,RFC) VALUES (@nombre,@apellido,@calle,@numexterior,@numinterior,@telefono,@correo,@rfc)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@calle", calle);
                command.Parameters.AddWithValue("@numexterior", numexterior);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@correo", correo);
                if (numinterior != null)
                {
                    command.Parameters.AddWithValue("@numinterior", numinterior);
                }
                else
                {
                    command.Parameters.AddWithValue("@numinterior", DBNull.Value);
                }
                if (rfc != null)
                {
                    command.Parameters.AddWithValue("@rfc", rfc);
                }
                else
                {
                    command.Parameters.AddWithValue("@rfc", DBNull.Value);
                }

                try
                {
                    // Abrir la conexión y ejecutar la consulta de inserción
                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente.");
                        Refrescar();

                    }
                    else
                    {
                        MessageBox.Show("No se pudieron insertar los datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
            }


        }

        private void btnEliminar_C_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_C_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_C_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }
        private void Form2_Load(object sender, EventArgs e)
        {


        }
      
        private void lbl_A_Paterno_C_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            //este boton es el de insertar empleado
            string nombre = txtnombre_Emp.Text;
            string puesto = txtPuesto_emp.Text;
            string apellido = string.IsNullOrEmpty(txtapellido_emp.Text) ? null : txtapellido_emp.Text;
           

            string query = "INSERT INTO Empleado (Nombre,Apellido,Puesto) VALUES (@nombre,@apellido,@puesto)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@puesto", puesto);
              
                if (apellido != null)
                {
                    command.Parameters.AddWithValue("@apellido", apellido);
                }
                else
                {
                    command.Parameters.AddWithValue("@apellido", DBNull.Value);
                }

                try
                {
                    // Abrir la conexión y ejecutar la consulta de inserción
                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente.");
                        Refrescar();
                        // Limpiar los TextBoxes o realizar otras acciones después de la inserción
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron insertar los datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
            }
        }

        private void DgvGeneral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica si se ha hecho clic en una fila válida
            {
                DataGridViewRow filaSeleccionada = DgvGeneral.Rows[e.RowIndex];

                switch (tabControlBakeBooker.SelectedIndex)
                {
                    case 0: // TabPage 1
                        txtNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                        txtApellido.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                        txtCorreo_Electronico_C.Text=filaSeleccionada.Cells["correo_electronico"].Value.ToString();
                        txt_calle_C.Text = filaSeleccionada.Cells["calle"].Value.ToString();
                        txtNumINT_C.Text = filaSeleccionada.Cells["numero_interior"].Value.ToString();
                        txt_NumeroExt_C.Text = filaSeleccionada.Cells["numero_exterior"].Value.ToString();
                        txtRfc_C.Text = filaSeleccionada.Cells["rfc"].Value.ToString();
                        txtTelefono_C.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                        // Otros TextBox del TabPage 1
                        break;

                    case 1: // TabPage 2
                        txtnombre_Emp.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                        txtapellido_emp.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                        string textoCelda = DgvGeneral.Rows[e.RowIndex].Cells["puesto"].Value.ToString();

                        if (textoCelda == "Administrador")
                        {
                            radiobtnAdmin.Checked = true;
                        }
                        else if (textoCelda == "General")
                        {
                            radiobtnGeneral.Checked = true;
                        }
                       // txtPuesto_emp.Text = filaSeleccionada.Cells["puesto"].Value.ToString();
                        // Otros TextBox del TabPage 2
                        break;

                    // Añade casos para los demás TabPages según sea necesario

                    default:
                        break;
                }
            }
        }

        private void btnGeneralInsertar_Click(object sender, EventArgs e)
        {
            switch (tabControlBakeBooker.SelectedIndex)
            {
                case 0: // TabPage 1
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string calle = txt_calle_C.Text;
                    int numexterior = Convert.ToInt32(txt_NumeroExt_C.Text);
                    int? numinterior = null;
                    if (!string.IsNullOrEmpty(txtNumINT_C.Text))
                    {
                        // Intentar convertir el texto del TextBox a un número entero
                        if (int.TryParse(txtNumINT_C.Text, out int resultado))
                        {
                            numinterior = resultado;
                        }
                        else
                        {
                            MessageBox.Show("El campo de correo electrónico debe ser un número válido.");
                            return;
                        }
                    }
                    string rfc = string.IsNullOrEmpty(txtRfc_C.Text) ? null : txtRfc_C.Text;
                    int telefono = Convert.ToInt32(txtTelefono_C.Text);
                    string correo = txtCorreo_Electronico_C.Text;


                    string query = "INSERT INTO Cliente (Nombre,Apellido,Calle,Numero_exterior,Numero_interior,Telefono,Correo_electronico,RFC) VALUES (@nombre,@apellido,@calle,@numexterior,@numinterior,@telefono,@correo,@rfc)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@calle", calle);
                        command.Parameters.AddWithValue("@numexterior", numexterior);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@correo", correo);
                        if (numinterior != null)
                        {
                            command.Parameters.AddWithValue("@numinterior", numinterior);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@numinterior", DBNull.Value);
                        }
                        if (rfc != null)
                        {
                            command.Parameters.AddWithValue("@rfc", rfc);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@rfc", DBNull.Value);
                        }

                        try
                        {
                            // Abrir la conexión y ejecutar la consulta de inserción
                            connection.Open();
                            int filasAfectadas = command.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Datos insertados correctamente.");
                                Refrescar();

                            }
                            else
                            {
                                MessageBox.Show("No se pudieron insertar los datos.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar datos: " + ex.Message);
                        }
                    }
                    break;

                case 1: // TabPage 2
                        //este boton es el de insertar empleado
                    string nombreEmpleado = txtnombre_Emp.Text;
                    string puesto="";

                    // Verificar qué RadioButton está seleccionado
                    if (radiobtnAdmin.Checked)
                    {
                        puesto = "Administrador";
                    }
                    else if (radiobtnGeneral.Checked)
                    {
                        puesto = "General";
                    }
                    else
                    {
                        MessageBox.Show("Ninguna opción seleccionada"); // Trata el caso en el que ninguna opción esté seleccionada
                    }

                    string apellidoEmpleado = string.IsNullOrEmpty(txtapellido_emp.Text) ? null : txtapellido_emp.Text;


                    string query2 = "INSERT INTO Empleado (Nombre,Apellido,Puesto) VALUES (@nombre,@apellido,@puesto)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombreEmpleado);
                        command.Parameters.AddWithValue("@puesto", puesto);

                        if (apellidoEmpleado != null)
                        {
                            command.Parameters.AddWithValue("@apellido", apellidoEmpleado);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@apellido", DBNull.Value);
                        }

                        try
                        {
                            // Abrir la conexión y ejecutar la consulta de inserción
                            connection.Open();
                            int filasAfectadas = command.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Datos insertados correctamente.");
                                Refrescar();
                                // Limpiar los TextBoxes o realizar otras acciones después de la inserción
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron insertar los datos.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar datos: " + ex.Message);
                        }
                    }
                    break;
                case 2:

                    break; 
                case 3: 

                    break; 
                case 4: 

                    break; 
                case 5: 

                    break; 
                case 6: 

                    break;
                default:

                    break;
            }
        }
    }
}
