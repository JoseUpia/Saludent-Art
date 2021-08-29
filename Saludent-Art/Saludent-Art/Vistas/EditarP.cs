using Saludent_Art.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saludent_Art
{
    public partial class EditarP : Form
    {
        PacienteController PacienteController = new PacienteController();
        DataTable table = new DataTable();
        private string IdPaciente;
        public EditarP()
        {
            InitializeComponent();
        }

        private void EditarP_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void MostrarPacientes()
        {
            pacientesDataGridView.DataSource = PacienteController.MostrarPacientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPaciente.Text != "")
                {
                    PacienteController Filtro = new PacienteController();
                    pacientesDataGridView.DataSource = Filtro.Filtrar(txtPaciente.Text);
                    pacientesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    RefrescarPacientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pacientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPaciente = pacientesDataGridView.CurrentRow.Cells["IdPaciente"].Value.ToString();
            nombreTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
            apellidoTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Apellido"].Value.ToString();
            edadTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Edad"].Value.ToString();
            generoComboBox.Text = pacientesDataGridView.CurrentRow.Cells["Genero"].Value.ToString();
            correoTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
            telefonoTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
            direccionTextBox.Text = pacientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
            fechaEntradaDateTimePicker.Text = pacientesDataGridView.CurrentRow.Cells["FechaEntrada"].Value.ToString();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(nombreTextBox.Text == "" || apellidoTextBox.Text == "" || edadTextBox.Text == "" || generoComboBox.Text == "" || correoTextBox.Text == "" || telefonoTextBox.Text == "" || direccionTextBox.Text == "")
                {
                    MessageBox.Show("¡Existe algun campos vacío!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarPacientes();
                }
                else
                {

                    PacienteController.ActualizarPaciente(IdPaciente, nombreTextBox.Text, apellidoTextBox.Text, edadTextBox.Text, generoComboBox.Text, correoTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, fechaEntradaDateTimePicker.Value);
                    MessageBox.Show("¡Actualizado Correctamente!");
                    RefrescarPacientes();
                    Limpiar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            IdPaciente = "";
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            edadTextBox.Clear();
            generoComboBox.SelectedIndex = 0;
            correoTextBox.Clear();
            telefonoTextBox.Clear();
            direccionTextBox.Clear();
            fechaEntradaDateTimePicker.Value = DateTime.Today;
        }
        private void RefrescarPacientes()
        {
            PacienteController Refrescar = new PacienteController();
            pacientesDataGridView.DataSource = Refrescar.MostrarPacientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons btnEliminar = MessageBoxButtons.YesNo;
                if (pacientesDataGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione un paciente", "Advertencia");
                }
                else
                {
                    string pacienteEliminar = pacientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString() + " " + pacientesDataGridView.CurrentRow.Cells["Apellido"].Value.ToString();
                    DialogResult ConfirmarEliminar = MessageBox.Show("¿Desea Eliminar a " + pacienteEliminar + "?", "Confirmación", btnEliminar,
                        MessageBoxIcon.Question);

                    if (ConfirmarEliminar == DialogResult.Yes)
                    {
                        PacienteController.EliminarPaciente(IdPaciente);
                        MessageBox.Show("¡Eliminado Satisfactoriamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        RefrescarPacientes();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {
            if(txtPaciente.Text == "")
            {
                RefrescarPacientes();
            }
        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            btnActualizar.ForeColor = Color.FromArgb(216, 227, 231);
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            btnActualizar.ForeColor = Color.FromArgb(12, 74, 86);
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.FromArgb(216, 227, 231);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.FromArgb(12, 74, 86);
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.ForeColor = Color.FromArgb(216, 227, 231);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.ForeColor = Color.FromArgb(12, 74, 86);
        }
    }
}
