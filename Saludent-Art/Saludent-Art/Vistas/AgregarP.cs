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
    public partial class AgregarP : Form
    {
        PacienteController PacienteController = new PacienteController();
        public AgregarP()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            edadTextBox.Clear();
            generoComboBox.SelectedIndex = 0;
            correoTextBox.Clear();
            telefonoTextBox.Clear();
            direccionTextBox.Clear();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(nombreTextBox.Text == "" || apellidoTextBox.Text == "" || edadTextBox.Text == "" || generoComboBox.Text == "" || correoTextBox.Text == "" || telefonoTextBox.Text == "" || direccionTextBox.Text == "")
                {
                    MessageBox.Show("¡Existe algun campos vacío!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    PacienteController.AgregarPaciente(nombreTextBox.Text, apellidoTextBox.Text, edadTextBox.Text, generoComboBox.Text, correoTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, fechaEntradaDateTimePicker.Value);
                    MessageBox.Show("¡Se agregó correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardar_MouseHover(object sender, EventArgs e)
        {
            guardar.ForeColor = Color.FromArgb(216, 227, 231);
        }

        private void guardar_MouseLeave(object sender, EventArgs e)
        {
            guardar.ForeColor = Color.FromArgb(12, 74, 86);
        }
    }
}
