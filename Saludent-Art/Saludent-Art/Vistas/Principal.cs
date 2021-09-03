using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Saludent_Art.Vistas;

namespace Saludent_Art
{
    public partial class Principal : Form
    {
        //Campos
        private IconButton BotonActual;
        private Panel BordeIzquierdo;
        private Form FormularioActual;
        public Principal()
        {
            InitializeComponent();
            //Barra en los botones de la izquierda
            BordeIzquierdo = new Panel();
            BordeIzquierdo.Size = new Size(7, 60);
            BarraIzquierda.Controls.Add(BordeIzquierdo);

            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        private void ActivarBotone(object remitenteBtn)
        {
            if (remitenteBtn != null)
            {
                DisableButton();
                //Button
                BotonActual = (IconButton)remitenteBtn;
                BotonActual.BackColor = Color.FromArgb(12, 74, 86);
                BotonActual.ForeColor = Color.White;
                BotonActual.TextAlign = ContentAlignment.MiddleRight;
                BotonActual.IconColor = Color.White;
                BotonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                BotonActual.ImageAlign = ContentAlignment.MiddleRight;
                //Bordes izquierdos del botón
                BordeIzquierdo.BackColor = Color.FromArgb(255,255,255);
                BordeIzquierdo.Location = new Point(0, BotonActual.Location.Y);
                BordeIzquierdo.Visible = true;
                BordeIzquierdo.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (BotonActual != null)
            { 
                BotonActual.BackColor = Color.FromArgb(19, 111, 130);
                BotonActual.ForeColor = Color.FromArgb(255,255,255);
                BotonActual.TextAlign = ContentAlignment.MiddleLeft;
                BotonActual.IconColor = Color.FromArgb(255,255,255);
                BotonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                BotonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mover Formulario con Mause
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if(WindowState == FormWindowState.Normal)
            {
                Restaurar.Visible = false;
                Maximizar.Visible = true;
            }
        }
        private void AbrirFormulario(Form childForm)
        {
            //Abrir Formulario
            if (FormularioActual != null)
            {
                FormularioActual.Close();
            }
            FormularioActual = childForm;
            //Fin
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelCentral.Controls.Add(childForm);
            PanelCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void NuevaConsulta_Click(object sender, EventArgs e)
        {
            ActivarBotone(sender);
            AbrirFormulario(new NuevaConsulta());
        }

        private void RegistrarPaciente_Click(object sender, EventArgs e)
        {
            ActivarBotone(sender);
            AbrirFormulario(new AgregarP());
        }

        private void EditarPaciente_Click(object sender, EventArgs e)
        {
            ActivarBotone(sender);
            AbrirFormulario(new EditarP());
        }

        private void VerListado_Click(object sender, EventArgs e)
        {
            ActivarBotone(sender);
            AbrirFormulario(new ListaP());
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {
            //ActivarBotone(sender);
            //AbrirFormulario(new AcercaDe());
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

        private void iconButton5_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormularioActual.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            ActivarBotone(sender);
            AbrirFormulario(new Consultas());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBotone(sender);
            AbrirFormulario(new Factura());
        }

        private void Acumulado_Click(object sender, EventArgs e)
        {
            ActivarBotone(sender);
            AbrirFormulario(new Acumulado());
        }
    }
}
