﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio5
{
    public partial class AlumnosAgregar : Form
    {
        public AlumnosAgregar()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AlumnoAgregarAdulto f3 = new AlumnoAgregarAdulto();
            f3.Show();
        }
    }
}
