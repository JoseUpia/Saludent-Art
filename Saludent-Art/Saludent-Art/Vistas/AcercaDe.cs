﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Saludent_Art.Vistas
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.FromArgb(216, 227, 231);
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.FromArgb(12, 74, 86);
        }
    }
}
