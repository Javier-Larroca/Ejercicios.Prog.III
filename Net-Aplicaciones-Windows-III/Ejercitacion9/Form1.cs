﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitacion9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_ControlAdded(object sender, ControlEventArgs e)
        {
            groupBox1.Controls.Add(radioD);
            groupBox1.Controls.Add(radioL);
            groupBox1.Controls.Add(radioLI);
            groupBox1.Controls.Add(radioSI);
            groupBox1.Controls.Add(radioT);
        }
    }
}
