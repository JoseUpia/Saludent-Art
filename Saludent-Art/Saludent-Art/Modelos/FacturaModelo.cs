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
    }
}
