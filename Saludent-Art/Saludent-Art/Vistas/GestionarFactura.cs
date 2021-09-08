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
            for (int i = 0; i < 9; i++)
            {
                if (i != 7)
                {
                    facturasDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }
    }
}
