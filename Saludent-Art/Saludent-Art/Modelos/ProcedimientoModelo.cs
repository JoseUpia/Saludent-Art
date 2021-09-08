using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludent_Art.Modelos
{
    class ProcedimientoModelo
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable facturaSelecionada = new DataTable();

        public string CargarProcedimientos(int IdProcedimiento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT nom_Procedimiento FROM Procedimientos WHERE IdProcedimiento = "+IdProcedimiento;
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return leer.ToString();
        }
    }
}
