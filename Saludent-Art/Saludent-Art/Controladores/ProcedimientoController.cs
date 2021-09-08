using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saludent_Art.Modelos;

namespace Saludent_Art.Controladores
{
    class ProcedimientoController
    {
        ProcedimientoModelo procedimientoModelo = new ProcedimientoModelo();

        public string CargarProcedimientos(int IdProcedimiento)
        {
            string procedimiento;
            procedimiento = procedimientoModelo.CargarProcedimientos(IdProcedimiento);
            return procedimiento;
        }
    }
}
