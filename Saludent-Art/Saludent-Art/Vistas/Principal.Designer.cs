
namespace Saludent_Art
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.BarraIzquierda = new System.Windows.Forms.Panel();
            this.Acumulado = new FontAwesome.Sharp.IconButton();
            this.Facturar = new FontAwesome.Sharp.IconButton();
            this.Configuracion = new FontAwesome.Sharp.IconButton();
            this.Consultas = new FontAwesome.Sharp.IconButton();
            this.VerListado = new FontAwesome.Sharp.IconButton();
            this.EditarPaciente = new FontAwesome.Sharp.IconButton();
            this.RegistrarPaciente = new FontAwesome.Sharp.IconButton();
            this.NuevaConsulta = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.Hora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.BarraIzquierda.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.AutoSize = true;
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.BarraSuperior.Controls.Add(this.Minimizar);
            this.BarraSuperior.Controls.Add(this.Restaurar);
            this.BarraSuperior.Controls.Add(this.Maximizar);
            this.BarraSuperior.Controls.Add(this.Cerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1434, 32);
            this.BarraSuperior.TabIndex = 4;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1335, 4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 3;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1366, 4);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 2;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1366, 4);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 1;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1397, 4);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // BarraIzquierda
            // 
            this.BarraIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(111)))), ((int)(((byte)(130)))));
            this.BarraIzquierda.Controls.Add(this.Acumulado);
            this.BarraIzquierda.Controls.Add(this.Facturar);
            this.BarraIzquierda.Controls.Add(this.Configuracion);
            this.BarraIzquierda.Controls.Add(this.Consultas);
            this.BarraIzquierda.Controls.Add(this.VerListado);
            this.BarraIzquierda.Controls.Add(this.EditarPaciente);
            this.BarraIzquierda.Controls.Add(this.RegistrarPaciente);
            this.BarraIzquierda.Controls.Add(this.NuevaConsulta);
            this.BarraIzquierda.Controls.Add(this.Logo);
            this.BarraIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraIzquierda.Location = new System.Drawing.Point(0, 32);
            this.BarraIzquierda.Name = "BarraIzquierda";
            this.BarraIzquierda.Size = new System.Drawing.Size(291, 790);
            this.BarraIzquierda.TabIndex = 5;
            // 
            // Acumulado
            // 
            this.Acumulado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acumulado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Acumulado.FlatAppearance.BorderSize = 0;
            this.Acumulado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Acumulado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.Acumulado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acumulado.ForeColor = System.Drawing.Color.White;
            this.Acumulado.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.Acumulado.IconColor = System.Drawing.Color.White;
            this.Acumulado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Acumulado.IconSize = 60;
            this.Acumulado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acumulado.Location = new System.Drawing.Point(0, 583);
            this.Acumulado.Name = "Acumulado";
            this.Acumulado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Acumulado.Size = new System.Drawing.Size(291, 60);
            this.Acumulado.TabIndex = 10;
            this.Acumulado.Text = "Acumulado";
            this.Acumulado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Acumulado.UseVisualStyleBackColor = true;
            this.Acumulado.Click += new System.EventHandler(this.Acumulado_Click);
            // 
            // Facturar
            // 
            this.Facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Facturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Facturar.FlatAppearance.BorderSize = 0;
            this.Facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facturar.ForeColor = System.Drawing.Color.White;
            this.Facturar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.Facturar.IconColor = System.Drawing.Color.White;
            this.Facturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Facturar.IconSize = 60;
            this.Facturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Facturar.Location = new System.Drawing.Point(0, 523);
            this.Facturar.Name = "Facturar";
            this.Facturar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Facturar.Size = new System.Drawing.Size(291, 60);
            this.Facturar.TabIndex = 9;
            this.Facturar.Text = "Facturar";
            this.Facturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Facturar.UseVisualStyleBackColor = true;
            this.Facturar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Configuracion
            // 
            this.Configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Configuracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Configuracion.FlatAppearance.BorderSize = 0;
            this.Configuracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Configuracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Configuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuracion.ForeColor = System.Drawing.Color.White;
            this.Configuracion.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.Configuracion.IconColor = System.Drawing.Color.White;
            this.Configuracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Configuracion.IconSize = 60;
            this.Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Configuracion.Location = new System.Drawing.Point(0, 730);
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 10);
            this.Configuracion.Size = new System.Drawing.Size(291, 60);
            this.Configuracion.TabIndex = 8;
            this.Configuracion.Text = "Acerca De";
            this.Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Configuracion.UseVisualStyleBackColor = true;
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // Consultas
            // 
            this.Consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Consultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Consultas.FlatAppearance.BorderSize = 0;
            this.Consultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Consultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultas.ForeColor = System.Drawing.Color.White;
            this.Consultas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.Consultas.IconColor = System.Drawing.Color.White;
            this.Consultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Consultas.IconSize = 60;
            this.Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultas.Location = new System.Drawing.Point(0, 463);
            this.Consultas.Name = "Consultas";
            this.Consultas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Consultas.Size = new System.Drawing.Size(291, 60);
            this.Consultas.TabIndex = 7;
            this.Consultas.Text = "Consultas";
            this.Consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Consultas.UseVisualStyleBackColor = true;
            this.Consultas.Click += new System.EventHandler(this.Consultas_Click);
            this.Consultas.MouseHover += new System.EventHandler(this.iconButton5_MouseHover);
            // 
            // VerListado
            // 
            this.VerListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerListado.FlatAppearance.BorderSize = 0;
            this.VerListado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.VerListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.VerListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerListado.ForeColor = System.Drawing.Color.White;
            this.VerListado.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.VerListado.IconColor = System.Drawing.Color.White;
            this.VerListado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VerListado.IconSize = 60;
            this.VerListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerListado.Location = new System.Drawing.Point(0, 403);
            this.VerListado.Name = "VerListado";
            this.VerListado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.VerListado.Size = new System.Drawing.Size(291, 60);
            this.VerListado.TabIndex = 6;
            this.VerListado.Text = "Ver Listado";
            this.VerListado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VerListado.UseVisualStyleBackColor = true;
            this.VerListado.Click += new System.EventHandler(this.VerListado_Click);
            this.VerListado.MouseHover += new System.EventHandler(this.iconButton5_MouseHover);
            // 
            // EditarPaciente
            // 
            this.EditarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditarPaciente.FlatAppearance.BorderSize = 0;
            this.EditarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.EditarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.EditarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarPaciente.ForeColor = System.Drawing.Color.White;
            this.EditarPaciente.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditarPaciente.IconColor = System.Drawing.Color.White;
            this.EditarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarPaciente.IconSize = 60;
            this.EditarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditarPaciente.Location = new System.Drawing.Point(0, 343);
            this.EditarPaciente.Name = "EditarPaciente";
            this.EditarPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EditarPaciente.Size = new System.Drawing.Size(291, 60);
            this.EditarPaciente.TabIndex = 5;
            this.EditarPaciente.Text = "Editar un Paciente";
            this.EditarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarPaciente.UseVisualStyleBackColor = true;
            this.EditarPaciente.Click += new System.EventHandler(this.EditarPaciente_Click);
            this.EditarPaciente.MouseHover += new System.EventHandler(this.iconButton5_MouseHover);
            // 
            // RegistrarPaciente
            // 
            this.RegistrarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrarPaciente.FlatAppearance.BorderSize = 0;
            this.RegistrarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.RegistrarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.RegistrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarPaciente.ForeColor = System.Drawing.Color.White;
            this.RegistrarPaciente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.RegistrarPaciente.IconColor = System.Drawing.Color.White;
            this.RegistrarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegistrarPaciente.IconSize = 60;
            this.RegistrarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrarPaciente.Location = new System.Drawing.Point(0, 283);
            this.RegistrarPaciente.Name = "RegistrarPaciente";
            this.RegistrarPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RegistrarPaciente.Size = new System.Drawing.Size(291, 60);
            this.RegistrarPaciente.TabIndex = 4;
            this.RegistrarPaciente.Text = "Registrar Paciente";
            this.RegistrarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarPaciente.UseVisualStyleBackColor = true;
            this.RegistrarPaciente.Click += new System.EventHandler(this.RegistrarPaciente_Click);
            this.RegistrarPaciente.MouseHover += new System.EventHandler(this.iconButton5_MouseHover);
            // 
            // NuevaConsulta
            // 
            this.NuevaConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevaConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.NuevaConsulta.FlatAppearance.BorderSize = 0;
            this.NuevaConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.NuevaConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.NuevaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaConsulta.ForeColor = System.Drawing.Color.White;
            this.NuevaConsulta.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.NuevaConsulta.IconColor = System.Drawing.Color.White;
            this.NuevaConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevaConsulta.IconSize = 60;
            this.NuevaConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevaConsulta.Location = new System.Drawing.Point(0, 223);
            this.NuevaConsulta.Name = "NuevaConsulta";
            this.NuevaConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NuevaConsulta.Size = new System.Drawing.Size(291, 60);
            this.NuevaConsulta.TabIndex = 3;
            this.NuevaConsulta.Text = "Nueva Consulta";
            this.NuevaConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevaConsulta.UseVisualStyleBackColor = true;
            this.NuevaConsulta.Click += new System.EventHandler(this.NuevaConsulta_Click);
            this.NuevaConsulta.MouseHover += new System.EventHandler(this.iconButton5_MouseHover);
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.pictureBox2);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(291, 223);
            this.Logo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(291, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.PanelCentral.Controls.Add(this.Hora);
            this.PanelCentral.Controls.Add(this.pictureBox1);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(291, 32);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1143, 790);
            this.PanelCentral.TabIndex = 6;
            // 
            // Hora
            // 
            this.Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hora.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(111)))), ((int)(((byte)(130)))));
            this.Hora.Location = new System.Drawing.Point(923, 0);
            this.Hora.Margin = new System.Windows.Forms.Padding(0);
            this.Hora.Name = "Hora";
            this.Hora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Hora.Size = new System.Drawing.Size(220, 60);
            this.Hora.TabIndex = 1;
            this.Hora.Text = "07:50:00 PM";
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1434, 822);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.BarraIzquierda);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludent-Art";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.BarraIzquierda.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Panel BarraIzquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private FontAwesome.Sharp.IconButton Configuracion;
        private FontAwesome.Sharp.IconButton Consultas;
        private FontAwesome.Sharp.IconButton VerListado;
        private FontAwesome.Sharp.IconButton EditarPaciente;
        private FontAwesome.Sharp.IconButton RegistrarPaciente;
        private FontAwesome.Sharp.IconButton NuevaConsulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton Facturar;
        private FontAwesome.Sharp.IconButton Acumulado;
    }
}

