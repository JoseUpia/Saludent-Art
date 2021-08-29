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
    public partial class Consultas : Form
    {
        ConsultaController consultaController = new ConsultaController();
        private string IdDatos;

        public Consultas()
        {
            InitializeComponent();
        }
        private void MostrarConsultas()
        {
            consultasDataGridView.DataSource = consultaController.MostrarConsultas();
        }
        private void Limpiar()
        {
            IdDatos = "";
            RB1_SI.Checked = false;
            RB1_NO.Checked = false;
            RB2_SI.Checked = false;
            RB2_NO.Checked = false;
            RB3_SI.Checked = false;
            RB3_NO.Checked = false;
            RB4_SI.Checked = false;
            RB4_NO.Checked = false;
            RB5_SI.Checked = false;
            RB5_NO.Checked = false;
            RB6_SI.Checked = false;
            RB6_NO.Checked = false;
            RB7_SI.Checked = false;
            RB7_NO.Checked = false;
            RB8_SI.Checked = false;
            RB8_NO.Checked = false;
            RB9_SI.Checked = false;
            RB9_NO.Checked = false;
            RB10_SI.Checked = false;
            RB10_NO.Checked = false;
            RB11_SI.Checked = false;
            RB11_NO.Checked = false;
            RB12_SI.Checked = false;
            RB12_NO.Checked = false;
            RB13_SI.Checked = false;
            RB13_NO.Checked = false;
            txtConsumeMedicamento.Clear();
            txtEmbarazada.Clear();
            txtIntervencionQuirurgica.Clear();
            txtMedicamentoAlergico.Clear();
            txtMotivoConsulta.Clear();
            txtOtraEnfermedad.Clear();
        }
        private void RefrescarConsulta()
        {
            ConsultaController Refrescar = new ConsultaController();
            consultasDataGridView.DataSource = Refrescar.MostrarConsultas();
        }

        public bool[] SelecionarCampos()
        {
            bool[] Datos = new bool[28];

            Datos[0] = RB1_SI.Checked;
            Datos[1] = RB1_NO.Checked;
            Datos[2] = RB2_SI.Checked;
            Datos[3] = RB2_NO.Checked;
            Datos[4] = RB3_SI.Checked;
            Datos[5] = RB3_NO.Checked;
            Datos[6] = RB4_SI.Checked;
            Datos[7] = RB4_NO.Checked;
            Datos[8] = RB5_SI.Checked;
            Datos[9] = RB5_NO.Checked;
            Datos[10] = RB6_SI.Checked;
            Datos[11] = RB6_NO.Checked;
            Datos[12] = RB7_SI.Checked;
            Datos[13] = RB7_NO.Checked;
            Datos[14] = RB8_SI.Checked;
            Datos[15] = RB8_NO.Checked;
            Datos[16] = RB9_SI.Checked;
            Datos[17] = RB9_NO.Checked;
            Datos[18] = RB10_SI.Checked;
            Datos[19] = RB10_NO.Checked;
            Datos[20] = RB11_SI.Checked;
            Datos[21] = RB11_NO.Checked;
            Datos[22] = RB12_SI.Checked;
            Datos[23] = RB12_NO.Checked;
            Datos[24] = RB13_SI.Checked;
            Datos[25] = RB13_NO.Checked;

            return Datos;
        }
        public string[] RespuestaFinal(string[] Respuestas)
        {
            string[] RespuestaFinal = Respuestas;

            if (RespuestaFinal[0] =="")
            {
                RespuestaFinal[0] = txtMedicamentoAlergico.Text;
            }

            if (RespuestaFinal[1] == "")
            {
                RespuestaFinal[1] = txtIntervencionQuirurgica.Text;
            }

            if (RespuestaFinal[2] == "")
            {
                RespuestaFinal[2] = txtConsumeMedicamento.Text;
            }

            if (RespuestaFinal[7] == "")
            {
                RespuestaFinal[7] = txtOtraEnfermedad.Text;
            }

            if (RespuestaFinal[8] == "")
            {
                RespuestaFinal[8] = txtEmbarazada.Text;
            }

            //MessageBox.Show(camposTxt[0].ToString());
            return RespuestaFinal;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            MostrarConsultas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons btnEliminar = MessageBoxButtons.YesNo;
                if (consultasDataGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione una consulta", "Advertencia");
                }
                else
                {
                    DialogResult ConfirmarEliminar = MessageBox.Show("¿Desea Eliminar esta consulta?", "Confirmación", btnEliminar,
                        MessageBoxIcon.Question);

                    if (ConfirmarEliminar == DialogResult.Yes)
                    {
                        consultaController.EliminarConsulta(IdDatos);
                        MessageBox.Show("¡Consulta eliminada satisfactoriamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        RefrescarConsulta();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(IdDatos == "" || txtMotivoConsulta.Text == "" || (RB1_SI.Checked && RB1_NO.Checked && txtMedicamentoAlergico.Text == "") ||
                    (RB2_SI.Checked && RB2_NO.Checked && txtIntervencionQuirurgica.Text == "") || (RB3_SI.Checked && RB3_NO.Checked && txtConsumeMedicamento.Text == "") ||
                    (RB4_SI.Checked && RB4_NO.Checked) || (RB5_SI.Checked && RB5_NO.Checked) || (RB6_SI.Checked && RB6_NO.Checked) || (RB7_SI.Checked && RB7_NO.Checked) ||
                    (RB8_SI.Checked && RB8_NO.Checked && txtOtraEnfermedad.Text == "") || (RB9_SI.Checked && RB9_NO.Checked && txtEmbarazada.Text == "") || (RB10_SI.Checked && RB10_NO.Checked) ||
                    (RB11_SI.Checked && RB11_NO.Checked) || (RB12_SI.Checked && RB12_NO.Checked) || (RB13_SI.Checked && RB13_NO.Checked))
                {
                    MessageBox.Show("¡Existe algun campos vacío!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string[] Respuestas = new string[13];

                    Respuestas = consultaController.Respuestas(SelecionarCampos());
                    Respuestas = RespuestaFinal(Respuestas);
                    consultaController.ActualizarConsulta(IdDatos, Respuestas[0].ToString(), Respuestas[1].ToString(), Respuestas[2].ToString(), Respuestas[3].ToString(), Respuestas[4].ToString(), Respuestas[5].ToString(), Respuestas[6].ToString(), Respuestas[7].ToString(), Respuestas[8].ToString(), Respuestas[9].ToString(), Respuestas[10].ToString(), Respuestas[11].ToString(), Respuestas[12].ToString(), txtMotivoConsulta.Text);
                    MessageBox.Show("¡Actualizado Correctamente!");
                    RefrescarConsulta();
                    Limpiar();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SelecionarConsulta()
        {
            RadioButton[] RB_SI = { RB1_SI, RB2_SI, RB3_SI, RB4_SI, RB5_SI, RB6_SI, RB7_SI, RB8_SI, RB9_SI, RB10_SI, RB11_SI, RB12_SI, RB13_SI };
            RadioButton[] RB_NO = { RB1_NO, RB2_NO, RB3_NO, RB4_NO, RB5_NO, RB6_NO, RB7_NO, RB8_NO, RB9_NO, RB10_NO, RB11_NO, RB12_NO, RB13_NO };
            TextBox[] Text_Consultas = { txtMedicamentoAlergico, txtIntervencionQuirurgica, txtConsumeMedicamento, txtOtraEnfermedad, txtEmbarazada, txtMotivoConsulta };
            int j=0;

            for (int i = 2; i < 16; i++)
            {
                if (i == 2 || i == 3 || i == 4 || i == 9 || i == 10 || i == 15)
                {
                    j += 1;
                    //MessageBox.Show(consultasDataGridView.CurrentRow.Cells[j].Value.ToString());
                }

                if (consultasDataGridView.CurrentRow.Cells[i].Value.ToString() == "Si")
                {
                    //MessageBox.Show(consultasDataGridView.CurrentRow.Cells[i].Value.ToString());
                    RB_SI[i-2].Checked = true;
                }
                else if (consultasDataGridView.CurrentRow.Cells[i].Value.ToString() == "No")
                {
                    //MessageBox.Show(consultasDataGridView.CurrentRow.Cells[i].Value.ToString());
                    RB_NO[i-2].Checked = true;
                }
                else
                {
                    Text_Consultas[j - 1].Text = consultasDataGridView.CurrentRow.Cells[i].Value.ToString();
                }
            }
        }

        private void consultasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
            IdDatos = consultasDataGridView.CurrentRow.Cells[0].Value.ToString();
            SelecionarConsulta();
        }
        public void Filtrar()
        {
            ConsultaController Filtro = new ConsultaController();
            consultasDataGridView.DataSource = Filtro.Filtrar(txtBuscar.Text);
            consultasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
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

        private void txtMedicamentoAlergico_TextChanged(object sender, EventArgs e)
        {
            if (txtMedicamentoAlergico.Text != "")
            {
                RB1_SI.Checked = false;
                RB1_NO.Checked = false;
            }
        }

        private void RB1_NO_CheckedChanged(object sender, EventArgs e)
        {
            txtMedicamentoAlergico.Text = "";
        }

        private void RB1_SI_CheckedChanged(object sender, EventArgs e)
        {
            txtMedicamentoAlergico.Text = "";
        }

        private void txtIntervencionQuirurgica_TextChanged(object sender, EventArgs e)
        {
            if (txtIntervencionQuirurgica.Text != "")
            {
                RB2_SI.Checked = false;
                RB2_NO.Checked = false;
            }
        }

        private void RB2_NO_CheckedChanged(object sender, EventArgs e)
        {
            txtIntervencionQuirurgica.Text = "";
        }

        private void RB2_SI_CheckedChanged(object sender, EventArgs e)
        {
            txtIntervencionQuirurgica.Text = "";
        }

        private void txtConsumeMedicamento_TextChanged(object sender, EventArgs e)
        {
            if (txtConsumeMedicamento.Text != "")
            {
                RB3_SI.Checked = false;
                RB3_NO.Checked = false;
            }
        }

        private void RB3_NO_CheckedChanged(object sender, EventArgs e)
        {
            txtConsumeMedicamento.Text = "";
        }

        private void RB3_SI_CheckedChanged(object sender, EventArgs e)
        {
            txtConsumeMedicamento.Text = "";
        }

        private void txtOtraEnfermedad_TextChanged(object sender, EventArgs e)
        {
            if (txtOtraEnfermedad.Text != "")
            {
                RB8_SI.Checked = false;
                RB8_NO.Checked = false;
            }
        }

        private void RB8_SI_CheckedChanged(object sender, EventArgs e)
        {
            txtOtraEnfermedad.Text = "";
        }

        private void RB8_NO_CheckedChanged(object sender, EventArgs e)
        {
            txtOtraEnfermedad.Text = "";
        }

        private void txtEmbarazada_TextChanged(object sender, EventArgs e)
        {
            if (txtEmbarazada.Text != "")
            {
                RB9_SI.Checked = false;
                RB9_NO.Checked = false;
            }
        }

        private void RB9_NO_CheckedChanged(object sender, EventArgs e)
        {
            txtEmbarazada.Text = "";
        }

        private void RB9_SI_CheckedChanged(object sender, EventArgs e)
        {
            txtEmbarazada.Text = "";
        }

    }
}