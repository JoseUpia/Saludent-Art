using Saludent_Art.Modelos;
using System;
using System.Data;
//using System.Windows.Forms;

namespace Saludent_Art.Controladores
{
    class ProcedimientoController
    {
        ProcedimientoModelo procedimientoModelo = new ProcedimientoModelo();
        DataTable procedimientosguardados = new DataTable();
        DataTable precioTotal = new DataTable();
        DataTable PrecioProcedimiento = new DataTable();
        DataTable ProcedimientosF = new DataTable();
        string Precio = "0";

        public string[] CargarProcedimientos()
        {
            procedimientosguardados = procedimientoModelo.CargarProcedimientos();
            string[] procedimiento = new string[procedimientosguardados.Rows.Count];
            for (int i = 0; i < procedimientosguardados.Rows.Count; i++)
            {
                procedimiento[i] = procedimientosguardados.Rows[i][0].ToString();
            }
            return procedimiento;
        }
        public int CalcularTotal(string[] procedimientos)
        {
            int SumaTotal = 0;
            for (int i = 0; i <= procedimientos.Length - 1; i++)
            {
                precioTotal.Rows.Clear();
                precioTotal = procedimientoModelo.CalcularTotal(procedimientos[i].ToString());
                SumaTotal += Convert.ToInt32(precioTotal.Rows[0][0]);
            }

            return SumaTotal;
        }

        internal DataTable ProcedimientosFacturados(string IdFactura)
        {
            ProcedimientosF.Rows.Clear();
            ProcedimientosF = procedimientoModelo.ProcedimientosFacturados(IdFactura);

            return ProcedimientosF;
        }

        public string ObtenerPrecio(string procedimientos)
        {
            PrecioProcedimiento.Rows.Clear();

            PrecioProcedimiento = procedimientoModelo.ObtenerPrecio(procedimientos);
            Precio = Convert.ToString(PrecioProcedimiento.Rows[0][0]);

            return Precio;
        }
    }
}
