using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginBakebooker
{
    internal class Consulta
    {
        //CONSULTAS TODO
        public SqlDataReader DevolverClientes(SqlConnection strConexion)
        {
            SqlCommand comando = new SqlCommand("select * from Clientes",strConexion);

            return comando.ExecuteReader();
        }
        public SqlDataReader DevolverEmpleados(SqlConnection strConexion)
        {
            SqlCommand comando = new SqlCommand("select * from Empleados", strConexion);

            return comando.ExecuteReader();
        }
        public SqlDataReader DevolverProductos(SqlConnection strConexion)
        {
            SqlCommand comando = new SqlCommand("select * from Productos", strConexion);

            return comando.ExecuteReader();
        }
        public SqlDataReader DevolverProveedores(SqlConnection strConexion)
        {
            SqlCommand comando = new SqlCommand("select * from Proveedores", strConexion);

            return comando.ExecuteReader();
        }
        public SqlDataReader DevolverPedidos(SqlConnection strConexion)
        {
            SqlCommand comando = new SqlCommand("select * from Pedidos", strConexion);

            return comando.ExecuteReader();
        }
        public SqlDataReader DevolverDetallePedidos(SqlConnection strConexion)
        {
            SqlCommand comando = new SqlCommand("select * from Detalle_Pedidos", strConexion);

            return comando.ExecuteReader();
        }
        public SqlDataReader DevolverInventario(SqlConnection strConexion)
        {
            SqlCommand comando = new SqlCommand("select * from Inventario", strConexion);

            return comando.ExecuteReader();
        }


        //////////////////////////////////CLIENTE

        //INSERTAR
        public string InsertarCliente(string strClienteID, string strA_Paterno, string strA_Materno, string strNombre, string strTelefono, string strRfc, string strCorreoElectronico, string strDireccion, string strColonia, string strCodigoPostal, string strFecha_Alta)
        {
            return $"insert into Clientes(Cliente_ID,A_Paterno,A_Materno,Nombre,Teléfono,Rfc,Correo_Electrónico,Dirección,Colonia,Codigo_Postal,Fecha_Alta) values ('{strClienteID}','{strA_Paterno}','{strA_Materno}','{strNombre}','{strTelefono}','{strRfc}','{strCorreoElectronico}','{strDireccion}','{strColonia}','{strCodigoPostal}','{strFecha_Alta}')";
        }
        //ELIMINAR
        public string EliminarCliente(string strClienteID)
        {
            return $"delete from Clientes where Cliente_ID={strClienteID}";
        }
    }
}
