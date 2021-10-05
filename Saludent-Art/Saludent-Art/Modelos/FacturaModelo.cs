using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludent_Art.Modelos
{
    class FacturaModelo
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable facturaSelecionada = new DataTable();

        public DataTable MostrarFacturas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT F.IdFactura AS 'ID de Factura', F.IdPaciente AS 'ID de Paciente', Fecha AS 'Fecha de Facturacion' FROM Factura F";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public void Facturar(int IdPaciente, string FechaFactura)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Factura VALUES("+IdPaciente+", '"+FechaFactura+"')";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
        }

        public int ObtenerIdFactura(int IdPaciente, string Fecha)
        {
            tabla.Rows.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT IdFactura FROM Factura WHERE IdPaciente = "+IdPaciente+" AND Fecha = '"+Fecha+"'";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return Convert.ToInt32(tabla.Rows[0][0]);

        }
    }
}
