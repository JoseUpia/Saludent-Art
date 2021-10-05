
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label Total;
            System.Windows.Forms.Label fechaEntradaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.PrecioTotal = new System.Windows.Forms.Label();
            this.ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.Facturar = new System.Windows.Forms.Button();
            this.pacientesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.VistaPrevia = new System.Windows.Forms.PrintPreviewDialog();
            this.listBoxProcedimientos = new System.Windows.Forms.ListBox();
            this.listBoxProcedimientosSelecionados = new System.Windows.Forms.ListBox();
            this.SelecionarProcedimiento = new FontAwesome.Sharp.IconButton();
            this.DevolverProcedimiento = new FontAwesome.Sharp.IconButton();
            this.fechaEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            Total = new System.Windows.Forms.Label();
            fechaEntradaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(22, 371);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(87, 25);
            nombreLabel.TabIndex = 41;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            apellidoLabel.ForeColor = System.Drawing.Color.Black;
            apellidoLabel.Location = new System.Drawing.Point(302, 371);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(88, 25);
            apellidoLabel.TabIndex = 43;
            apellidoLabel.Text = "Apellido:";
            // 
            // edadLabel
            // 
            edadLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            edadLabel.AutoSize = true;
            edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            edadLabel.ForeColor = System.Drawing.Color.Black;
            edadLabel.Location = new System.Drawing.Point(573, 374);
            edadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(64, 25);
            edadLabel.TabIndex = 45;
            edadLabel.Text = "Edad:";
            // 
            // Total
            // 
            Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            Total.AutoSize = true;
            Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Total.ForeColor = System.Drawing.Color.Black;
            Total.Location = new System.Drawing.Point(876, 676);
            Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Total.Name = "Total";
            Total.Size = new System.Drawing.Size(78, 25);
            Total.TabIndex = 51;
            Total.Text = "Total: $";
            // 
            // fechaEntradaLabel
            // 
            fechaEntradaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            fechaEntradaLabel.AutoSize = true;
            fechaEntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            fechaEntradaLabel.ForeColor = System.Drawing.Color.Black;
            fechaEntradaLabel.Location = new System.Drawing.Point(714, 374);
            fechaEntradaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaEntradaLabel.Name = "fechaEntradaLabel";
            fechaEntradaLabel.Size = new System.Drawing.Size(73, 25);
            fechaEntradaLabel.TabIndex = 53;
            fechaEntradaLabel.Text = "Fecha:";
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrecioTotal.AutoSize = true;
            this.PrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrecioTotal.ForeColor = System.Drawing.Color.Black;
            this.PrecioTotal.Location = new System.Drawing.Point(946, 676);
            this.PrecioTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.Size = new System.Drawing.Size(23, 25);
            this.PrecioTotal.TabIndex = 52;
            this.PrecioTotal.Text = "0";
            // 
            // ImprimirDocumento
            // 
            this.ImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // Facturar
            // 
            this.Facturar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Facturar.FlatAppearance.BorderSize = 2;
            this.Facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Facturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.Facturar.Location = new System.Drawing.Point(503, 664);
            this.Facturar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(121, 48);
            this.Facturar.TabIndex = 39;
            this.Facturar.Text = "&Facturar";
            this.Facturar.UseVisualStyleBackColor = true;
            this.Facturar.Click += new System.EventHandler(this.guardar_Click);
            this.Facturar.MouseLeave += new System.EventHandler(this.Facturar_MouseLeave);
            this.Facturar.MouseHover += new System.EventHandler(this.Facturar_MouseHover);
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
            this.pacientesDataGridView.Margin = new System.Windows.Forms.Padding(10);
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
            this.pacientesDataGridView.Size = new System.Drawing.Size(1095, 304);
            this.pacientesDataGridView.TabIndex = 40;
            this.pacientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientesDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 52);
            this.panel1.TabIndex = 41;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(172, 11);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 30);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Paciente";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(15, 728);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1095, 15);
            this.panel4.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1110, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 691);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 691);
            this.panel2.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pacientesDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(15, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1095, 304);
            this.panel5.TabIndex = 45;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nombreTextBox.Location = new System.Drawing.Point(117, 368);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(177, 34);
            this.nombreTextBox.TabIndex = 42;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apellidoTextBox.Enabled = false;
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.apellidoTextBox.Location = new System.Drawing.Point(388, 368);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(177, 34);
            this.apellidoTextBox.TabIndex = 44;
            // 
            // edadTextBox
            // 
            this.edadTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edadTextBox.Enabled = false;
            this.edadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.edadTextBox.Location = new System.Drawing.Point(645, 368);
            this.edadTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(61, 34);
            this.edadTextBox.TabIndex = 46;
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
            // listBoxProcedimientos
            // 
            this.listBoxProcedimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProcedimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxProcedimientos.FormattingEnabled = true;
            this.listBoxProcedimientos.ItemHeight = 25;
            this.listBoxProcedimientos.Location = new System.Drawing.Point(120, 465);
            this.listBoxProcedimientos.Name = "listBoxProcedimientos";
            this.listBoxProcedimientos.Size = new System.Drawing.Size(343, 200);
            this.listBoxProcedimientos.TabIndex = 55;
            // 
            // listBoxProcedimientosSelecionados
            // 
            this.listBoxProcedimientosSelecionados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProcedimientosSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxProcedimientosSelecionados.FormattingEnabled = true;
            this.listBoxProcedimientosSelecionados.ItemHeight = 25;
            this.listBoxProcedimientosSelecionados.Location = new System.Drawing.Point(669, 465);
            this.listBoxProcedimientosSelecionados.Name = "listBoxProcedimientosSelecionados";
            this.listBoxProcedimientosSelecionados.Size = new System.Drawing.Size(343, 200);
            this.listBoxProcedimientosSelecionados.TabIndex = 56;
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
            this.SelecionarProcedimiento.Location = new System.Drawing.Point(529, 481);
            this.SelecionarProcedimiento.Name = "SelecionarProcedimiento";
            this.SelecionarProcedimiento.Size = new System.Drawing.Size(68, 68);
            this.SelecionarProcedimiento.TabIndex = 59;
            this.SelecionarProcedimiento.UseVisualStyleBackColor = true;
            this.SelecionarProcedimiento.Click += new System.EventHandler(this.SelecionarProcedimiento_Click);
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
            this.DevolverProcedimiento.Location = new System.Drawing.Point(529, 575);
            this.DevolverProcedimiento.Name = "DevolverProcedimiento";
            this.DevolverProcedimiento.Size = new System.Drawing.Size(68, 68);
            this.DevolverProcedimiento.TabIndex = 59;
            this.DevolverProcedimiento.UseVisualStyleBackColor = true;
            this.DevolverProcedimiento.Click += new System.EventHandler(this.DevolverProcedimiento_Click);
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaEntradaDateTimePicker.CustomFormat = "dd/MMMM/yyyy h:mm tt";
            this.fechaEntradaDateTimePicker.Enabled = false;
            this.fechaEntradaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fechaEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(785, 368);
            this.fechaEntradaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(327, 34);
            this.fechaEntradaDateTimePicker.TabIndex = 54;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1125, 743);
            this.Controls.Add(this.DevolverProcedimiento);
            this.Controls.Add(this.SelecionarProcedimiento);
            this.Controls.Add(this.listBoxProcedimientosSelecionados);
            this.Controls.Add(this.listBoxProcedimientos);
            this.Controls.Add(this.fechaEntradaDateTimePicker);
            this.Controls.Add(fechaEntradaLabel);
            this.Controls.Add(this.PrecioTotal);
            this.Controls.Add(Total);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Facturar);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private System.Windows.Forms.Button Facturar;
        private System.Windows.Forms.DataGridView pacientesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.Label PrecioTotal;
        private System.Windows.Forms.PrintPreviewDialog VistaPrevia;
        private System.Windows.Forms.ListBox listBoxProcedimientos;
        private System.Windows.Forms.ListBox listBoxProcedimientosSelecionados;
        private FontAwesome.Sharp.IconButton SelecionarProcedimiento;
        private FontAwesome.Sharp.IconButton DevolverProcedimiento;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
    }
}