using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Saludent_Art.Modelos
{
    public class ConsultaModelo
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable consultaSelecionada = new DataTable();

        public DataTable MostrarConsultas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM DatosClinicos";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
        public DataTable Filtrar(string buscar)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM DatosClinicos D Join Pacientes P ON D.IdPaciente = P.IdPaciente WHERE D.IdPaciente LIKE '"+buscar+"%' OR P.Nombre LIKE '"+buscar+"%'";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            consultaSelecionada.Load(leer);
            conexion.CerrarConexion();

            return consultaSelecionada;
        }

        public void AgregarConsulta(int IdPaciente, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13, string p14)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO DatosClinicos VALUES("+IdPaciente+", '"+p1+"', '"+p2+"', '"+p3+"', '"+p4+"', '"+p5+"', '"+p6+"', '"+p7+"', '"+p8+"', '"+p9+"', '"+p10+"', '"+p11+"', '"+p12+"', '"+p13+"', '"+p14+"');";
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void ActualizarConsulta(int IdDatos, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13, string p14)
        {
            MessageBox.Show(p1 + " " + p2 + " " + p3 + "\n " + p4 + " " + p5 + " " + p6 + "\n " + p7 + " " + p8 + " " + p9 + "\n " + p10 + " " + p11 + " " + p12 + "\n " + p13 + " " + p14);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE DatosClinicos SET MedicamentoAlergico = '"+p1+ "',  IntervencionQuirurgica = '" + p2 + "',  ConsumeMedicamento = '" + p3 + "',  ReacionesAnestecia = '" + p4 + "',  ProblemasSangrado = '" + p5 + "',  PadeceDiabetes = '" + p6 + "',  HipertensionArterial = '" + p7 + "',  OtraEnfermedad = '" + p8 + "',  Embarazada = '" + p9 + "', MolestiaBacal = '" + p10 + "', MalOlor_MalSabor_Boca = '" + p11 + "',  DientesMoviles = '" + p12 + "',  HabitosPerniciosos = '" + p13 + "', MotivoConsulta = '" + p14 + "' WHERE IdDatos = " + IdDatos;
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarConsulta(int IdDatos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM DatosClinicos WHERE IdDatos = " + IdDatos;
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}

