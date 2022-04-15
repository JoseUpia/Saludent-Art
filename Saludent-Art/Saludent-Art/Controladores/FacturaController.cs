using Saludent_Art.Modelos;
using System;
using System.Data;

namespace Saludent_Art.Controladores
{
    class FacturaController
    {
        FacturaModelo facturaModelo = new FacturaModelo();
        PacienteModelo pacienteModelo = new PacienteModelo();
        DataTable facturaSelecionada = new DataTable();

        public DataTable MostrarFacturas()
        {
            DataTable tabla = new DataTable();
            tabla = facturaModelo.MostrarFacturas();

            return tabla;
        }

        public void Facturar(string Nombre, string Apellido, string Fecha)
        {
            facturaModelo.Facturar(pacienteModelo.ObtenerIdPaciente(Nombre, Apellido), Fecha);
        }

        internal string ObtenerIdFactura(string IdPaciente, string Fecha)
        {
            return facturaModelo.ObtenerIdFactura(Convert.ToInt32(IdPaciente), Fecha).ToString();
        }

        internal string[] DatosFactura(string v)
        {
            throw new NotImplementedException();
        }
    }
}
