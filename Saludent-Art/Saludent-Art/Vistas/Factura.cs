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
        ProcedimientoController procedimientoController = new ProcedimientoController();
        string IdPaciente;

        public Factura()
        {
            InitializeComponent();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Georgia", 12);
            int ancho = 350;
            int y = 166;

            e.Graphics.DrawImage(Properties.Resources.FacturaSaludent_Art ,new Rectangle(10, 10, 450, 700));



            //if (Procedimiento1.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento1.Text, font, Brushes.Black, new RectangleF(70, y+= 35, ancho, 30));
            //}

            //if (Procedimiento2.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento2.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento3.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento3.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento4.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento4.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento5.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento5.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento6.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento6.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento7.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento7.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento8.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento8.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento9.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento9.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento10.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento10.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}

            //if (Procedimiento11.Checked)
            //{
            //    e.Graphics.DrawString(Procedimiento11.Text, font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
            //}


            e.Graphics.DrawString(CantidadTotal.Text, font, Brushes.Black, new RectangleF(405, 575, ancho, 30));

            e.Graphics.DrawString(nombreTextBox.Text + " " + apellidoTextBox.Text, font, Brushes.Black, new RectangleF(165, 620, ancho, 30));

            e.Graphics.DrawString(edadTextBox.Text, font, Brushes.Black, new RectangleF(70, 660, ancho, 30));

            e.Graphics.DrawString(fechaEntradaDateTimePicker.Value.Day.ToString(), font, Brushes.Black, new RectangleF(170, 660, ancho, 30));
            e.Graphics.DrawString(fechaEntradaDateTimePicker.Value.Month.ToString("MMM"), font, Brushes.Black, new RectangleF(240, 660, ancho, 30));
            e.Graphics.DrawString(fechaEntradaDateTimePicker.Value.Year.ToString(), font, Brushes.Black, new RectangleF(395, 660, ancho, 30));
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
            for (int i = 0; i < 9; i++)
            {
                if (i != 7)
                {
                    pacientesDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            MessageBox.Show(procedimientoController.CargarProcedimientos(4));
            //for (int i = 1; i < 10; i++)
            //{
            //    MessageBox.Show(procedimientoController.CargarProcedimientos(i));
            //}
            //MessageBox.Show(pacientesDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void pacientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPaciente = pacientesDataGridView.CurrentRow.Cells[0].Value.ToString();
            nombreTextBox.Text = pacientesDataGridView.CurrentRow.Cells[1].Value.ToString();
            apellidoTextBox.Text = pacientesDataGridView.CurrentRow.Cells[2].Value.ToString();
            edadTextBox.Text = pacientesDataGridView.CurrentRow.Cells[3].Value.ToString();
            fechaEntradaDateTimePicker.Text = pacientesDataGridView.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
