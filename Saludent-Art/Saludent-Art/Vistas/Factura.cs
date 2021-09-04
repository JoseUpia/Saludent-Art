using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Saludent_Art.Controladores;


namespace Saludent_Art.Vistas
{
    public partial class Factura : Form
    {
        PacienteController PacienteController = new PacienteController();

        string IdPaciente;
        public Factura()
        {
            InitializeComponent();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Georgia", 12);
            int ancho = 350;
            int y = 20;

            e.Graphics.DrawImage(Properties.Resources.FacturaSaludent_Art2 ,new Rectangle(10, 10, 450, 700));

            e.Graphics.DrawString("    --- Procedimientos ---", font, Brushes.Black, new RectangleF(10, y += 150, ancho, 30));

            if (Procedimiento1.Checked)
            {
                e.Graphics.DrawString("      " + Procedimiento1.Text, font, Brushes.Black, new RectangleF(10, y += 20, ancho, 30));
            }

            if (Procedimiento2.Checked)
            {
                e.Graphics.DrawString("      " + Procedimiento2.Text, font, Brushes.Black, new RectangleF(10, y += 20, ancho, 30));
            }

            if (Procedimiento3.Checked)
            {
                e.Graphics.DrawString("      " + Procedimiento3.Text, font, Brushes.Black, new RectangleF(10, y += 20, ancho, 30));
            }

            if (Procedimiento4.Checked)
            {
                e.Graphics.DrawString("      " + Procedimiento4.Text, font, Brushes.Black, new RectangleF(10, y += 20, ancho, 30));
            }
            
            e.Graphics.DrawString("Total: " + CantidadTotal.Text, font, Brushes.Black, new RectangleF(10, y += 30, ancho, 30));

            e.Graphics.DrawString(nombreTextBox.Text + " " + apellidoTextBox.Text, font, Brushes.Black, new RectangleF(125, 635, ancho, 30));
            e.Graphics.DrawString(edadTextBox.Text, font, Brushes.Black, new RectangleF(60, 665, ancho, 30));
            e.Graphics.DrawString(fechaEntradaDateTimePicker.Text, font, Brushes.Black, new RectangleF(215, 665, ancho, 30));
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            ImprimirDocumento = new PrintDocument();
            PrinterSettings PS = new PrinterSettings();
            ImprimirDocumento.PrinterSettings = PS;
            ImprimirDocumento.PrintPage += Imprimir;
            ImprimirDocumento.Print();

            
        }

        private void MostrarPacientes()
        {
            pacientesDataGridView.DataSource = PacienteController.MostrarPacientes();
        }
        public void Filtrar()
        {
            PacienteController Filtro = new PacienteController();
            pacientesDataGridView.DataSource = Filtro.Filtrar(txtBuscar.Text);
            pacientesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void pacientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPaciente = pacientesDataGridView.CurrentRow.Cells["IdPaciente"].Value.ToString();
            nombreTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
            apellidoTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Apellido"].Value.ToString();
            edadTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Edad"].Value.ToString();
        }
    }
}
