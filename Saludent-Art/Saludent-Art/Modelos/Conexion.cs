using System.Data;
using System.Data.SqlClient;


namespace Saludent_Art.Modelos
{
    public class Conexion
    {
        //Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase\\Saludent-Art.mdf;Integrated Security=True
        SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase\\Saludent-Art.mdf;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
