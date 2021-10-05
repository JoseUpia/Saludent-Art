using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Saludent_Art.Modelos
{
    class ProcedimientoModelo
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable PrecioTotal = new DataTable();
        DataTable PrecioProcedimiento = new DataTable();
        DataTable facturaSelecionada = new DataTable();


        public DataTable CargarProcedimientos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT nom_Procedimiento FROM Procedimientos";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            //return tabla.Rows[0][0].ToString();
        }

        public DataTable CalcularTotal(string procedimientos)
        {
            PrecioTotal.Rows.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Precio FROM Procedimientos WHERE nom_Procedimiento = '" + procedimientos + "'";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            PrecioTotal.Load(leer);
            conexion.CerrarConexion();

            return PrecioTotal;
        }

        public DataTable ObtenerPrecio(string procedimientos)
        {
            PrecioProcedimiento.Rows.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Precio FROM Procedimientos WHERE nom_Procedimiento = '" + procedimientos + "'";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            PrecioProcedimiento.Load(leer);
            conexion.CerrarConexion();

            return PrecioProcedimiento;
        }

        internal DataTable ProcedimientosFacturados(string idFactura)
        {
            tabla.Rows.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT P.nom_Procedimiento AS Procedimientos, P.Precio FROM DetallesFactura DF " +
                                  "JOIN Procedimientos P ON P.IdProcedimiento = DF.IdProcedimiento " +
                                  "WHERE IdFactura = " + idFactura;
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
