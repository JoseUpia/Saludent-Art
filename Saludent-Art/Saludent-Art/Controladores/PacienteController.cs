using Saludent_Art.Modelos;
using System;
using System.Data;

namespace Saludent_Art.Controladores
{
    public class PacienteController
    {
        PacienteModelo PacienteModelo = new PacienteModelo();
        DataTable pacienteSelecionado = new DataTable();
        public DataTable MostrarPacientes()
        {
            DataTable tabla = new DataTable();
            tabla = PacienteModelo.MostrarPacientes();

            return tabla;
        }

        public DataTable Filtrar(string buscar)
        {
            pacienteSelecionado = PacienteModelo.Filtrar(buscar);

            return pacienteSelecionado;
        }

        public void AgregarPaciente(string nombre, string apellido, string edad, string genero, string correo, string telefono, string direccion, DateTime fechaEntrada)
        {
            PacienteModelo.AgregarPaciente(nombre, apellido, Convert.ToInt16(edad), genero, correo, telefono, direccion, Convert.ToString(fechaEntrada));
        }

        public void ActualizarPaciente(string IdPaciente, string nombre, string apellido, string edad, string genero, string correo, string telefono, string direccion, DateTime fechaEntrada)
        {
            PacienteModelo.ActualizarPaciente(Convert.ToInt16(IdPaciente), nombre, apellido, Convert.ToInt16(edad), genero, correo, telefono, direccion, Convert.ToString(fechaEntrada));
        }

        public void EliminarPaciente(string IdPaciente)
        {
            PacienteModelo.EliminarPaciente(Convert.ToInt16(IdPaciente));
        }
    }
}
