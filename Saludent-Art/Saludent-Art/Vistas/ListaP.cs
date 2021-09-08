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

namespace Saludent_Art
{
    public partial class ListaP : Form
    {
        PacienteController PacienteController = new PacienteController();

        public ListaP()
        {
            InitializeComponent();
        }
        private void MostrarPacientes()
        {
            pacientesDataGridView.DataSource = PacienteController.MostrarPacientes();
        }

        private void ListaP_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
            for(int i = 0; i<9; i++)
            {
                if(i != 7)
                {
                    pacientesDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        public void Filtrar()
        {
            PacienteController Filtro = new PacienteController();
            pacientesDataGridView.DataSource = Filtro.Filtrar(txtBuscar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        //public void Ajustar()
        //{
        //    int AlturaFormulario = this.Height;
        //    int AnchuraFormulario = this.Width;
        //    int AlturaTabla = pacientesDataGridView.Height;
        //    int AnchuraTabla = pacientesDataGridView.Width;

        //    int NuevaAlturaTabla = (AlturaFormulario - AlturaTabla) / 2;
        //    int NuevaAnchuraTabla = (AnchuraFormulario - AnchuraTabla) / 2;

        //    pacientesDataGridView.Location = new Point(NuevaAnchuraTabla, NuevaAlturaTabla);

        //}

    }
}
