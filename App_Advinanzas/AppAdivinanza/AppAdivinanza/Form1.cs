﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdivinanza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AppAdivinanza.MatPreguntas frmMatPreguntas = new MatPreguntas();
            frmMatPreguntas.MdiParent = this;
            frmMatPreguntas.Show();
        }
    }
}
