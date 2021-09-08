using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saludent_Art.Modelos;

namespace Saludent_Art.Controladores
{
    class FacturaController
    {
        FacturaModelo facturaModelo = new FacturaModelo();
        DataTable facturaSelecionada = new DataTable();

        public DataTable MostrarFacturas()
        {
            DataTable tabla = new DataTable();
            tabla = facturaModelo.MostrarFacturas();

            return tabla;
        }

    }
}
