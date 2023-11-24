using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            using (SqlConnection conexionrol = new SqlConnection(connectionString))
            {
                conexionrol.Open();              
            }
            sqlConnection = new SqlConnection(connectionString);
            DgvGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Refrescar();

        }
        private void Refrescar()
        {
            string nombreTabla = ObtenerNombreTabla();
            string ID = obtenerIDParaOrdenar();
            if (!string.IsNullOrEmpty(nombreTabla))
            {
                try
                {
                    sqlConnection.Open();
                    MostrarDatos(nombreTabla,ID);
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
        private string obtenerIDParaOrdenar()
        {
            switch (tabControlBakeBooker.SelectedIndex)
            {
                case 0:
                    return "ID_cliente";
                case 1:
                    return "ID_pedido";
                case 2:
                    return "ID_detalle";
                case 3:
                    return "ID_producto";
                case 4:
                    return "ID_PEDIDOPRODUCTO";
                case 5:
                    return "ID_inventario";
                case 6:
                    return "ID_empleado";
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
                    return "Cliente";
                case 1:
                    return "Pedido";
                case 2:
                    return "Pedido_detalles"; 
                case 3:
                    return "Producto"; 
                case 4:
                    return "Pedido_Producto";
                case 5:
                    return "Inventario";
                case 6:
                    return "Empleado";
                default:
                    return null;
            }
        }

        private void MostrarDatos(string nombreTabla, string ID)
        {
            try
            {
                string query = $"SELECT * FROM {nombreTabla} ORDER BY {ID} DESC"; // Utiliza el nombre de la tabla proporcionado
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
       
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }
        private void Form2_Load(object sender, EventArgs e)
        {


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
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            // Abrir la conexión
                            connection.Open();
                            // Crear el comando para el stored procedure
                            using (SqlCommand cmd = new SqlCommand("sp_InsertarCliente", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                                // Asignar parámetros al stored procedure
                                cmd.Parameters.AddWithValue("@Nombre", nombre);
                                cmd.Parameters.AddWithValue("@Apellido", apellido);
                                cmd.Parameters.AddWithValue("@Calle", calle);
                                cmd.Parameters.AddWithValue("@Numero_Exterior", numexterior);
                                cmd.Parameters.AddWithValue("@Telefono", telefono);
                                cmd.Parameters.AddWithValue("@Correo_electronico", correo);
                                if (numinterior != null)
                                {
                                    cmd.Parameters.AddWithValue("@Numero_interior", numinterior);
                                }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@Numero_interior", DBNull.Value);
                                    }
                                if (rfc != null)
                                {
                                    cmd.Parameters.AddWithValue("@RFC", rfc);
                                }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@RFC", DBNull.Value);
                                    }


                                // Ejecutar el comando (stored procedure)
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Datos insertados correctamente en la tabla Cliente.");
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
            Refrescar();

        }

        private void btnEncargo_Click(object sender, EventArgs e)
        {
            tabcontrolPedido.SelectedIndex = 0; 
        }

        private void btnParaLlevar_Click(object sender, EventArgs e)
        {
            tabcontrolPedido.SelectedIndex = 1; 
        }

        private void tabPagePedidos_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneralModificar_Click(object sender, EventArgs e)
        {
            string tabla=ObtenerNombreTabla();
            string id=obtenerIDParaOrdenar();
            string query = $"SELECT * FROM {tabla} ORDER BY {id} DESC"; // Utiliza el nombre de la tabla proporcionado
            switch (tabControlBakeBooker.SelectedIndex)
            {
                case 0:
                    try
                    {                        
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(); // No se inicializa con el origen de datos en este punto
                        DataTable dataTable = (DataTable)DgvGeneral.DataSource; // Obtiene el DataTable del origen de datos del DataGridView

                        using (SqlCommand conexion = new SqlCommand(query, sqlConnection))
                        {
                            dataAdapter.SelectCommand = conexion;
                            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
                            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                            dataAdapter.Update(dataTable);

                            MessageBox.Show("Datos modificados correctamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar los datos: " + ex.Message);
                    }
                    break;
                case 1:
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
