using Saludent_Art.Controladores;
using System;
using System.Drawing;
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
                if (nombreTextBox.Text == "" || apellidoTextBox.Text == "" || edadTextBox.Text == "" || generoComboBox.Text == "" || correoTextBox.Text == "" || telefonoTextBox.Text == "" || direccionTextBox.Text == "")
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
            //guardar.FlatAppearance.BorderColor = Color.White;
        }

        private void guardar_MouseLeave(object sender, EventArgs e)
        {
            guardar.ForeColor = Color.FromArgb(12, 74, 86);
            //guardar.FlatAppearance.BorderColor = Color.FromArgb(12, 74, 86);
        }

        private void edadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) ||
                (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) ||
                (e.KeyChar >= 182 && e.KeyChar <= 213) || (e.KeyChar >= 215 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) ||
                (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void apellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) ||
                (e.KeyChar >= 131 && e.KeyChar <= 143) || (e.KeyChar >= 145 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) ||
                (e.KeyChar >= 182 && e.KeyChar <= 213) || (e.KeyChar >= 215 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) ||
                (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
