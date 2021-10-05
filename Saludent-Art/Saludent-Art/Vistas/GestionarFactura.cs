using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saludent_Art.Controladores;

namespace Saludent_Art.Vistas
{
    public partial class GestionarFactura : Form
    {
        FacturaController facturaController = new FacturaController();
        ProcedimientoController procedimientoController = new ProcedimientoController();
        public GestionarFactura()
        {
            InitializeComponent();
        }

        private void MostrarFacturas()
        {
            facturasDataGridView.DataSource = facturaController.MostrarFacturas();
        }

        private void GestionarFactura_Load(object sender, EventArgs e)
        {
            MostrarFacturas();
            for (int i = 0; i < 2; i++)
            {
                facturasDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void facturasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] DatosFactura = new string[3];

            procedimientosDataGridView.DataSource = procedimientoController.ProcedimientosFacturados(facturasDataGridView.CurrentRow.Cells[0].Value.ToString());
            DatosFactura =  facturaController.DatosFactura(facturasDataGridView.CurrentRow.Cells[1].Value.ToString());
            fechaFacturaDateTimePicker.Text = facturasDataGridView.CurrentRow.Cells[2].Value.ToString();

            nombreTextBox.Text = DatosFactura[0];
            apellidoTextBox.Text = DatosFactura[1];
            edadTextBox.Text = DatosFactura[2];
        }
    }
}
