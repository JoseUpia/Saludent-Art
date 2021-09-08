
namespace Saludent_Art
{
    partial class EditarP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label fechaEntradaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDatosPersonales = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.fechaEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.buscarPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelFiltrar = new System.Windows.Forms.Panel();
            this.pacientesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            fechaEntradaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            this.panelDatosPersonales.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(36, 22);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(87, 25);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            apellidoLabel.ForeColor = System.Drawing.Color.Black;
            apellidoLabel.Location = new System.Drawing.Point(586, 22);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(88, 25);
            apellidoLabel.TabIndex = 18;
            apellidoLabel.Text = "Apellido:";
            // 
            // edadLabel
            // 
            edadLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            edadLabel.AutoSize = true;
            edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            edadLabel.ForeColor = System.Drawing.Color.Black;
            edadLabel.Location = new System.Drawing.Point(59, 64);
            edadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(64, 25);
            edadLabel.TabIndex = 20;
            edadLabel.Text = "Edad:";
            // 
            // generoLabel
            // 
            generoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            generoLabel.AutoSize = true;
            generoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            generoLabel.ForeColor = System.Drawing.Color.Black;
            generoLabel.Location = new System.Drawing.Point(591, 64);
            generoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(83, 25);
            generoLabel.TabIndex = 22;
            generoLabel.Text = "Genero:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            telefonoLabel.ForeColor = System.Drawing.Color.Black;
            telefonoLabel.Location = new System.Drawing.Point(28, 113);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(95, 25);
            telefonoLabel.TabIndex = 24;
            telefonoLabel.Text = "Telefono:";
            // 
            // fechaEntradaLabel
            // 
            fechaEntradaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            fechaEntradaLabel.AutoSize = true;
            fechaEntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            fechaEntradaLabel.ForeColor = System.Drawing.Color.Black;
            fechaEntradaLabel.Location = new System.Drawing.Point(528, 113);
            fechaEntradaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaEntradaLabel.Name = "fechaEntradaLabel";
            fechaEntradaLabel.Size = new System.Drawing.Size(146, 25);
            fechaEntradaLabel.TabIndex = 28;
            fechaEntradaLabel.Text = "Fecha Entrada:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(45, 155);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 25);
            label1.TabIndex = 31;
            label1.Text = "Correo:";
            // 
            // direccionLabel
            // 
            direccionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            direccionLabel.ForeColor = System.Drawing.Color.Black;
            direccionLabel.Location = new System.Drawing.Point(575, 160);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(99, 25);
            direccionLabel.TabIndex = 37;
            direccionLabel.Text = "Direccion:";
            // 
            // panelDatosPersonales
            // 
            this.panelDatosPersonales.Controls.Add(this.panel5);
            this.panelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatosPersonales.Location = new System.Drawing.Point(0, 0);
            this.panelDatosPersonales.Name = "panelDatosPersonales";
            this.panelDatosPersonales.Size = new System.Drawing.Size(1125, 373);
            this.panelDatosPersonales.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnActualizar);
            this.panel5.Controls.Add(this.direccionTextBox);
            this.panel5.Controls.Add(direccionLabel);
            this.panel5.Controls.Add(label1);
            this.panel5.Controls.Add(this.correoTextBox);
            this.panel5.Controls.Add(nombreLabel);
            this.panel5.Controls.Add(this.fechaEntradaDateTimePicker);
            this.panel5.Controls.Add(fechaEntradaLabel);
            this.panel5.Controls.Add(this.nombreTextBox);
            this.panel5.Controls.Add(apellidoLabel);
            this.panel5.Controls.Add(this.telefonoTextBox);
            this.panel5.Controls.Add(this.apellidoTextBox);
            this.panel5.Controls.Add(telefonoLabel);
            this.panel5.Controls.Add(edadLabel);
            this.panel5.Controls.Add(this.generoComboBox);
            this.panel5.Controls.Add(this.edadTextBox);
            this.panel5.Controls.Add(generoLabel);
            this.panel5.Location = new System.Drawing.Point(42, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 340);
            this.panel5.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnEliminar.Location = new System.Drawing.Point(559, 268);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 44);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnActualizar.Location = new System.Drawing.Point(345, 268);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 44);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnActualizar.MouseLeave += new System.EventHandler(this.btnActualizar_MouseLeave);
            this.btnActualizar.MouseHover += new System.EventHandler(this.btnActualizar_MouseHover);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.direccionTextBox.Location = new System.Drawing.Point(695, 155);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.direccionTextBox.Size = new System.Drawing.Size(298, 59);
            this.direccionTextBox.TabIndex = 38;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.correoTextBox.Location = new System.Drawing.Point(173, 152);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(298, 30);
            this.correoTextBox.TabIndex = 32;
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaEntradaDateTimePicker.CustomFormat = "dd/MMMM/yyyy";
            this.fechaEntradaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fechaEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(695, 110);
            this.fechaEntradaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.fechaEntradaDateTimePicker.TabIndex = 29;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombreTextBox.Location = new System.Drawing.Point(173, 17);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(298, 30);
            this.nombreTextBox.TabIndex = 17;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.telefonoTextBox.Location = new System.Drawing.Point(173, 110);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(298, 30);
            this.telefonoTextBox.TabIndex = 25;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.apellidoTextBox.Location = new System.Drawing.Point(695, 15);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(298, 30);
            this.apellidoTextBox.TabIndex = 19;
            // 
            // generoComboBox
            // 
            this.generoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.generoComboBox.Location = new System.Drawing.Point(695, 64);
            this.generoComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(298, 33);
            this.generoComboBox.TabIndex = 23;
            this.generoComboBox.Text = "Masculino";
            // 
            // edadTextBox
            // 
            this.edadTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edadTextBox.Location = new System.Drawing.Point(173, 64);
            this.edadTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(298, 30);
            this.edadTextBox.TabIndex = 21;
            // 
            // buscarPaciente
            // 
            this.buscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarPaciente.AutoSize = true;
            this.buscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buscarPaciente.ForeColor = System.Drawing.Color.Black;
            this.buscarPaciente.Location = new System.Drawing.Point(706, 14);
            this.buscarPaciente.Margin = new System.Windows.Forms.Padding(3, 0, 200, 0);
            this.buscarPaciente.Name = "buscarPaciente";
            this.buscarPaciente.Size = new System.Drawing.Size(154, 25);
            this.buscarPaciente.TabIndex = 2;
            this.buscarPaciente.Text = "Buscar Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPaciente.Location = new System.Drawing.Point(867, 11);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(143, 30);
            this.txtPaciente.TabIndex = 3;
            this.txtPaciente.TextChanged += new System.EventHandler(this.txtPaciente_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.btnBuscar.Location = new System.Drawing.Point(1016, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // panelFiltrar
            // 
            this.panelFiltrar.Controls.Add(this.buscarPaciente);
            this.panelFiltrar.Controls.Add(this.txtPaciente);
            this.panelFiltrar.Controls.Add(this.btnBuscar);
            this.panelFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltrar.Location = new System.Drawing.Point(0, 373);
            this.panelFiltrar.Name = "panelFiltrar";
            this.panelFiltrar.Size = new System.Drawing.Size(1125, 53);
            this.panelFiltrar.TabIndex = 2;
            // 
            // pacientesDataGridView
            // 
            this.pacientesDataGridView.AllowUserToAddRows = false;
            this.pacientesDataGridView.AllowUserToDeleteRows = false;
            this.pacientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pacientesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(134)))), ((int)(((byte)(142)))));
            this.pacientesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pacientesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pacientesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacientesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pacientesDataGridView.ColumnHeadersHeight = 35;
            this.pacientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pacientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pacientesDataGridView.EnableHeadersVisualStyles = false;
            this.pacientesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.pacientesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pacientesDataGridView.Name = "pacientesDataGridView";
            this.pacientesDataGridView.ReadOnly = true;
            this.pacientesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.pacientesDataGridView.RowHeadersVisible = false;
            this.pacientesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(106)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(111)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.pacientesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.pacientesDataGridView.RowTemplate.Height = 24;
            this.pacientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pacientesDataGridView.Size = new System.Drawing.Size(1095, 302);
            this.pacientesDataGridView.TabIndex = 3;
            this.pacientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientesDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 317);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1110, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 317);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(15, 728);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 15);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pacientesDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(15, 426);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1095, 302);
            this.panel4.TabIndex = 7;
            // 
            // EditarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1125, 743);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFiltrar);
            this.Controls.Add(this.panelDatosPersonales);
            this.Name = "EditarP";
            this.Text = "EditarP";
            this.Load += new System.EventHandler(this.EditarP_Load);
            this.panelDatosPersonales.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelFiltrar.ResumeLayout(false);
            this.panelFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatosPersonales;
        private System.Windows.Forms.Label buscarPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
        private System.Windows.Forms.Panel panelFiltrar;
        private System.Windows.Forms.DataGridView pacientesDataGridView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox direccionTextBox;
    }
}