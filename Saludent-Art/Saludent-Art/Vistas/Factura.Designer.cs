
namespace Saludent_Art.Vistas
{
    partial class Factura
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
            System.Windows.Forms.Label Total;
            System.Windows.Forms.Label fechaEntradaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.pacientesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.VistaPrevia = new System.Windows.Forms.PrintPreviewDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DevolverProcedimiento = new FontAwesome.Sharp.IconButton();
            this.SelecionarProcedimiento = new FontAwesome.Sharp.IconButton();
            this.listBoxProcedimientosSelecionados = new System.Windows.Forms.ListBox();
            this.listBoxProcedimientos = new System.Windows.Forms.ListBox();
            this.PrecioTotal = new System.Windows.Forms.Label();
            this.Facturar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.fechaEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            Total = new System.Windows.Forms.Label();
            fechaEntradaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Total.ForeColor = System.Drawing.Color.Black;
            Total.Location = new System.Drawing.Point(638, 185);
            Total.Name = "Total";
            Total.Size = new System.Drawing.Size(61, 20);
            Total.TabIndex = 61;
            Total.Text = "Total: $";
            // 
            // fechaEntradaLabel
            // 
            fechaEntradaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            fechaEntradaLabel.AutoSize = true;
            fechaEntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            fechaEntradaLabel.ForeColor = System.Drawing.Color.Black;
            fechaEntradaLabel.Location = new System.Drawing.Point(520, 18);
            fechaEntradaLabel.Name = "fechaEntradaLabel";
            fechaEntradaLabel.Size = new System.Drawing.Size(58, 20);
            fechaEntradaLabel.TabIndex = 61;
            fechaEntradaLabel.Text = "Fecha:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(0, 15);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 20);
            nombreLabel.TabIndex = 55;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            apellidoLabel.ForeColor = System.Drawing.Color.Black;
            apellidoLabel.Location = new System.Drawing.Point(210, 15);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(69, 20);
            apellidoLabel.TabIndex = 57;
            apellidoLabel.Text = "Apellido:";
            // 
            // edadLabel
            // 
            edadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            edadLabel.AutoSize = true;
            edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            edadLabel.ForeColor = System.Drawing.Color.Black;
            edadLabel.Location = new System.Drawing.Point(414, 18);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(51, 20);
            edadLabel.TabIndex = 59;
            edadLabel.Text = "Edad:";
            // 
            // ImprimirDocumento
            // 
            this.ImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // pacientesDataGridView
            // 
            this.pacientesDataGridView.AllowUserToAddRows = false;
            this.pacientesDataGridView.AllowUserToDeleteRows = false;
            this.pacientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pacientesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(134)))), ((int)(((byte)(142)))));
            this.pacientesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.pacientesDataGridView.Margin = new System.Windows.Forms.Padding(8);
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
            this.pacientesDataGridView.Size = new System.Drawing.Size(822, 247);
            this.pacientesDataGridView.TabIndex = 40;
            this.pacientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientesDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 42);
            this.panel1.TabIndex = 41;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(138, 8);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(102, 26);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Paciente";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(833, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 562);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 562);
            this.panel2.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pacientesDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(11, 42);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(822, 247);
            this.panel5.TabIndex = 45;
            // 
            // VistaPrevia
            // 
            this.VistaPrevia.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.VistaPrevia.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.VistaPrevia.ClientSize = new System.Drawing.Size(400, 300);
            this.VistaPrevia.Document = this.ImprimirDocumento;
            this.VistaPrevia.Enabled = true;
            this.VistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("VistaPrevia.Icon")));
            this.VistaPrevia.Name = "VistaPrevia";
            this.VistaPrevia.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.Controls.Add(this.DevolverProcedimiento);
            this.panel6.Controls.Add(this.SelecionarProcedimiento);
            this.panel6.Controls.Add(this.listBoxProcedimientosSelecionados);
            this.panel6.Controls.Add(this.listBoxProcedimientos);
            this.panel6.Controls.Add(this.PrecioTotal);
            this.panel6.Controls.Add(Total);
            this.panel6.Controls.Add(this.Facturar);
            this.panel6.Location = new System.Drawing.Point(17, 359);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(811, 228);
            this.panel6.TabIndex = 55;
            // 
            // DevolverProcedimiento
            // 
            this.DevolverProcedimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevolverProcedimiento.FlatAppearance.BorderSize = 0;
            this.DevolverProcedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevolverProcedimiento.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.DevolverProcedimiento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.DevolverProcedimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DevolverProcedimiento.IconSize = 80;
            this.DevolverProcedimiento.Location = new System.Drawing.Point(381, 87);
            this.DevolverProcedimiento.Margin = new System.Windows.Forms.Padding(2);
            this.DevolverProcedimiento.Name = "DevolverProcedimiento";
            this.DevolverProcedimiento.Size = new System.Drawing.Size(60, 71);
            this.DevolverProcedimiento.TabIndex = 65;
            this.DevolverProcedimiento.UseVisualStyleBackColor = true;
            // 
            // SelecionarProcedimiento
            // 
            this.SelecionarProcedimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelecionarProcedimiento.FlatAppearance.BorderSize = 0;
            this.SelecionarProcedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelecionarProcedimiento.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.SelecionarProcedimiento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.SelecionarProcedimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelecionarProcedimiento.IconSize = 80;
            this.SelecionarProcedimiento.Location = new System.Drawing.Point(381, 15);
            this.SelecionarProcedimiento.Margin = new System.Windows.Forms.Padding(2);
            this.SelecionarProcedimiento.Name = "SelecionarProcedimiento";
            this.SelecionarProcedimiento.Size = new System.Drawing.Size(60, 68);
            this.SelecionarProcedimiento.TabIndex = 66;
            this.SelecionarProcedimiento.UseVisualStyleBackColor = true;
            // 
            // listBoxProcedimientosSelecionados
            // 
            this.listBoxProcedimientosSelecionados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProcedimientosSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxProcedimientosSelecionados.FormattingEnabled = true;
            this.listBoxProcedimientosSelecionados.ItemHeight = 20;
            this.listBoxProcedimientosSelecionados.Location = new System.Drawing.Point(486, 2);
            this.listBoxProcedimientosSelecionados.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProcedimientosSelecionados.Name = "listBoxProcedimientosSelecionados";
            this.listBoxProcedimientosSelecionados.Size = new System.Drawing.Size(257, 160);
            this.listBoxProcedimientosSelecionados.TabIndex = 64;
            // 
            // listBoxProcedimientos
            // 
            this.listBoxProcedimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProcedimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxProcedimientos.FormattingEnabled = true;
            this.listBoxProcedimientos.ItemHeight = 20;
            this.listBoxProcedimientos.Location = new System.Drawing.Point(74, 2);
            this.listBoxProcedimientos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProcedimientos.Name = "listBoxProcedimientos";
            this.listBoxProcedimientos.Size = new System.Drawing.Size(257, 160);
            this.listBoxProcedimientos.TabIndex = 63;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.AutoSize = true;
            this.PrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrecioTotal.ForeColor = System.Drawing.Color.Black;
            this.PrecioTotal.Location = new System.Drawing.Point(691, 185);
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.Size = new System.Drawing.Size(18, 20);
            this.PrecioTotal.TabIndex = 62;
            this.PrecioTotal.Text = "0";
            // 
            // Facturar
            // 
            this.Facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Facturar.FlatAppearance.BorderSize = 2;
            this.Facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Facturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Facturar.Location = new System.Drawing.Point(360, 176);
            this.Facturar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(91, 39);
            this.Facturar.TabIndex = 60;
            this.Facturar.Text = "&Facturar";
            this.Facturar.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.fechaEntradaDateTimePicker);
            this.panel7.Controls.Add(fechaEntradaLabel);
            this.panel7.Controls.Add(nombreLabel);
            this.panel7.Controls.Add(this.nombreTextBox);
            this.panel7.Controls.Add(apellidoLabel);
            this.panel7.Controls.Add(this.apellidoTextBox);
            this.panel7.Controls.Add(edadLabel);
            this.panel7.Controls.Add(this.edadTextBox);
            this.panel7.Location = new System.Drawing.Point(13, 294);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(820, 62);
            this.panel7.TabIndex = 56;
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fechaEntradaDateTimePicker.CustomFormat = "dd/MMMM/yyyy h:mm tt";
            this.fechaEntradaDateTimePicker.Enabled = false;
            this.fechaEntradaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fechaEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(573, 13);
            this.fechaEntradaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(246, 29);
            this.fechaEntradaDateTimePicker.TabIndex = 62;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nombreTextBox.Location = new System.Drawing.Point(72, 13);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(134, 29);
            this.nombreTextBox.TabIndex = 56;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.apellidoTextBox.Enabled = false;
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.apellidoTextBox.Location = new System.Drawing.Point(275, 13);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(134, 29);
            this.apellidoTextBox.TabIndex = 58;
            // 
            // edadTextBox
            // 
            this.edadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.edadTextBox.Enabled = false;
            this.edadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.edadTextBox.Location = new System.Drawing.Point(468, 13);
            this.edadTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(47, 29);
            this.edadTextBox.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(11, 593);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(822, 11);
            this.panel4.TabIndex = 57;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(844, 604);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private System.Windows.Forms.DataGridView pacientesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PrintPreviewDialog VistaPrevia;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton DevolverProcedimiento;
        private FontAwesome.Sharp.IconButton SelecionarProcedimiento;
        private System.Windows.Forms.ListBox listBoxProcedimientosSelecionados;
        private System.Windows.Forms.ListBox listBoxProcedimientos;
        private System.Windows.Forms.Label PrecioTotal;
        private System.Windows.Forms.Button Facturar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.Panel panel4;
    }
}