using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Saludent_Art.Modelos
{
    public class PacienteModelo
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable pacienteSelecionado = new DataTable();

        public DataTable MostrarPacientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT IdPaciente AS 'ID', Nombre, Apellido, Edad, Genero, Correo, Telefono, Direccion, FechaEntrada AS 'Fecha de llegada' FROM Pacientes";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public int ObtenerIdPaciente(string Nombre, string Apellido)
        {
            tabla.Rows.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT IdPaciente FROM Pacientes WHERE Nombre = '"+Nombre+"' AND Apellido = '"+Apellido+"'";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return Convert.ToInt32(tabla.Rows[0][0]);
        }
        public DataTable Filtrar(string buscar)
        {
            comando.Connection = conexion.AbrirConexion(); 
            comando.CommandText = "SELECT IdPaciente AS 'ID', Nombre, Apellido, Edad, Genero, Correo, Telefono, Direccion, FechaEntrada AS 'Fecha de llegada' " +
                "FROM Pacientes WHERE IdPaciente LIKE '" + buscar + "%'OR Nombre LIKE '" + buscar + "%' OR Apellido LIKE '" + buscar + "%' OR Edad LIKE '" + buscar + "%' OR Telefono LIKE '" + buscar + "%' OR Correo LIKE '" + buscar + "%'";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            pacienteSelecionado.Load(leer);
            conexion.CerrarConexion();

            return pacienteSelecionado;
        }
        
        
        public void AgregarPaciente(string nombre, string apellido, int edad, string genero, string correo ,string telefono, string direccion, string fechaEntrada)
        {
            //CONVERT(DATETIME, '"+fechaEntrada+"',21)
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Pacientes VALUES('"+nombre+"', '"+apellido+"', "+edad+", '"+genero+"', '"+correo+"', '"+telefono+"', '"+direccion+ "', '"+fechaEntrada+"')";
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void ActualizarPaciente(int IdPaciente, string nombre, string apellido, int edad, string genero, string correo, string telefono, string direccion, string fechaEntrada)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Pacientes SET Nombre = '"+nombre+"', Apellido = '"+apellido+"', Edad = "+edad+", Genero = '"+genero+"', Correo = '"+correo+"', Telefono = '"+telefono+"', Direccion = '"+direccion+"', FechaEntrada = '"+fechaEntrada+"' WHERE IdPaciente = "+IdPaciente;
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarPaciente(int IdPaciente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM Pacientes WHERE IdPaciente = " +IdPaciente;
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    
    }
}
