using Saludent_Art.Controladores;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace Saludent_Art.Vistas
{
    public partial class Factura : Form
    {
        PacienteController PacienteController = new PacienteController();
        ProcedimientoController procedimientoController = new ProcedimientoController();
        FacturaController facturaController = new FacturaController();
        string[] Procedimientos = new string[0];
        string PrecioProcedimiento = "0";
        string IdPaciente;

        public Factura()
        {
            InitializeComponent();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Palatino Linotype", 12);

            int ancho = 350;
            int y = 166;

            e.Graphics.DrawImage(Properties.Resources.FacturaSaludent_ArtVacia, new Rectangle(10, 10, 450, 700));

            //Datos Superiores de la factura
            e.Graphics.DrawString("C/ Isabel La Católica (Los Alemanes)", new Font("Palatino Linotype", 40, GraphicsUnit.Document), Brushes.SteelBlue, new RectangleF(235, 21, ancho, 30));
            e.Graphics.DrawString("#39, Próximo al juzgado de", new Font("Palatino Linotype", 40, GraphicsUnit.Document), Brushes.SteelBlue, new RectangleF(272, 37, ancho, 30));
            e.Graphics.DrawString("Paz, Villa Altagracia.", new Font("Palatino Linotype", 40, GraphicsUnit.Document), Brushes.SteelBlue, new RectangleF(290, 52, ancho, 30));

            e.Graphics.DrawString("Tels.:", new Font("Palatino Linotype", 18, GraphicsUnit.World), Brushes.SteelBlue, new RectangleF(280, 80, ancho, 30));
            e.Graphics.DrawString("809-288-8700", new Font("Palatino Linotype", 18, GraphicsUnit.World), Brushes.SteelBlue, new RectangleF(326, 83, ancho, 30));
            e.Graphics.DrawString("829-587-9298", new Font("Palatino Linotype", 18, GraphicsUnit.World), Brushes.SteelBlue, new RectangleF(304, 102, ancho, 30));

            //Procedimientos facturados
            for (int i = 0; i < listBoxProcedimientosSelecionados.Items.Count; i++)
            {
                e.Graphics.DrawString(listBoxProcedimientosSelecionados.Items[i].ToString(), font, Brushes.Black, new RectangleF(70, y += 34, ancho, 30));
                e.Graphics.DrawString(ObtenerPrecio(listBoxProcedimientosSelecionados.Items[i].ToString()), font, Brushes.Black, new RectangleF(400, y, ancho, 30));
            }

            //Datos del Paciente en la factura
            e.Graphics.DrawString(PrecioTotal.Text, font, Brushes.Black, new RectangleF(390, 538, ancho, 30));
            e.Graphics.DrawString(facturaController.ObtenerIdFactura(IdPaciente, fechaEntradaDateTimePicker.Text), font, Brushes.Black, new RectangleF(120, 584, ancho, 30));
            e.Graphics.DrawString(nombreTextBox.Text + " " + apellidoTextBox.Text, font, Brushes.Black, new RectangleF(87, 623, ancho, 30));
            e.Graphics.DrawString(edadTextBox.Text, font, Brushes.Black, new RectangleF(76, 661, ancho, 30));
            e.Graphics.DrawString(fechaEntradaDateTimePicker.Value.Day.ToString(), font, Brushes.Black, new RectangleF(176, 661, ancho, 30));
            e.Graphics.DrawString(buscarMes(fechaEntradaDateTimePicker.Value.Month.ToString()), font, Brushes.Black, new RectangleF(240, 661, ancho, 30));
            e.Graphics.DrawString(fechaEntradaDateTimePicker.Value.Year.ToString(), font, Brushes.Black, new RectangleF(395, 661, ancho, 30));
        }

        private void guardar_Click(object sender, EventArgs e)
        {




            try
            {
                if (nombreTextBox.Text != "" && PrecioTotal.Text != "0")
                {
                    facturaController.Facturar(nombreTextBox.Text, apellidoTextBox.Text, fechaEntradaDateTimePicker.Text);
                    HacerImpresion();
                }
                else
                {
                    MessageBox.Show("¡Faltan datos en la factura!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HacerImpresion()
        {
            ImprimirDocumento = new PrintDocument();
            PrinterSettings PS = new PrinterSettings();
            ImprimirDocumento.PrinterSettings = PS;
            ImprimirDocumento.PrintPage += Imprimir;
            ImprimirDocumento.Print();
        }
        private string buscarMes(string mesString)
        {
            int mes = Convert.ToInt16(mesString);
            string mesLetras = "No Encontrado";

            switch (mes)
            {
                case 1:
                    mesLetras = "Enero";
                    return mesLetras;
                case 2:
                    mesLetras = "Febrero";
                    return mesLetras;
                case 3:
                    mesLetras = "Marzo";
                    return mesLetras;
                case 4:
                    mesLetras = "Abril";
                    return mesLetras;
                case 5:
                    mesLetras = "Mayo";
                    return mesLetras;
                case 6:
                    mesLetras = "Junio";
                    return mesLetras;
                case 7:
                    mesLetras = "Julio";
                    return mesLetras;
                case 8:
                    mesLetras = "Agosto";
                    return mesLetras;
                case 9:
                    mesLetras = "Septiembre";
                    return mesLetras;
                case 10:
                    mesLetras = "Octubre";
                    return mesLetras;
                case 11:
                    mesLetras = "Noviembre";
                    return mesLetras;
                case 12:
                    mesLetras = "Diciembre";
                    return mesLetras;
                default:
                    return mesLetras;
            }
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

        private string ObtenerPrecio(string Procedimiento)
        {
            PrecioProcedimiento = "0";
            PrecioProcedimiento = procedimientoController.ObtenerPrecio(Procedimiento);

            return PrecioProcedimiento;
        }
        private void CalcularTotal()
        {
            string[] procedimientosSelecionados = new string[listBoxProcedimientosSelecionados.Items.Count];

            for (int i = 0; i <= listBoxProcedimientosSelecionados.Items.Count - 1; i++)
            {
                procedimientosSelecionados[i] = listBoxProcedimientosSelecionados.Items[i].ToString();
            }
            PrecioTotal.Text = procedimientoController.CalcularTotal(procedimientosSelecionados).ToString();
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
            //MessageBox.Show(procedimientoController.CargarProcedimientos(4));

            Procedimientos = procedimientoController.CargarProcedimientos();

            for (int i = 0; i < Procedimientos.Length; i++)
            {
                listBoxProcedimientos.Items.Add(Procedimientos[i].ToString());
            }
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
            //fechaEntradaDateTimePicker.Text = pacientesDataGridView.CurrentRow.Cells[8].Value.ToString();
        }

        private void Facturar_MouseLeave(object sender, EventArgs e)
        {
            Facturar.ForeColor = Color.FromArgb(12, 74, 86);
        }

        private void Facturar_MouseHover(object sender, EventArgs e)
        {
            Facturar.ForeColor = Color.FromArgb(216, 227, 231);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBoxProcedimientos.SelectedItem != null)
            {
                listBoxProcedimientosSelecionados.Items.Add(listBoxProcedimientos.SelectedItem);
                listBoxProcedimientos.Items.Remove(listBoxProcedimientos.SelectedItem);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBoxProcedimientosSelecionados.SelectedItem != null)
            {
                listBoxProcedimientos.Items.Add(listBoxProcedimientosSelecionados.SelectedItem);
                listBoxProcedimientosSelecionados.Items.Remove(listBoxProcedimientosSelecionados.SelectedItem);
            }
        }

        private void SelecionarProcedimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxProcedimientos.SelectedItem != null)
                {
                    if (listBoxProcedimientosSelecionados.Items.Count < 10)
                    {
                        listBoxProcedimientosSelecionados.Items.Add(listBoxProcedimientos.SelectedItem);
                        listBoxProcedimientos.Items.Remove(listBoxProcedimientos.SelectedItem);
                        CalcularTotal();
                    }
                    else
                    {
                        MessageBox.Show("¡No es posible facturar mas de 10 procedimientos al mismo tiempo!", "No facturable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("¡Selecione un procedimiento!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevolverProcedimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxProcedimientosSelecionados.SelectedItem != null)
                {
                    listBoxProcedimientos.Items.Add(listBoxProcedimientosSelecionados.SelectedItem);
                    listBoxProcedimientosSelecionados.Items.Remove(listBoxProcedimientosSelecionados.SelectedItem);
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("¡Selecione un procedimiento!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
