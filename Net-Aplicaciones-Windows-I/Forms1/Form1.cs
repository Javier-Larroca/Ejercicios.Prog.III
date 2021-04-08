using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau...");
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atencion");
            //this.BackColor = Color.Blue;

            if (CajaTexto.Text == "")
                CajaTexto.BackColor = Color.Red;
            else
                CajaTexto.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Formulario_Click(object sender, EventArgs e)
        {

            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label.BackColor = Color.Cyan;
            Label.Cursor = Cursors.Hand;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label.BackColor = System.Drawing.SystemColors.Control;
            Label.Cursor = Cursors.Arrow;
        }

        private void CajaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void cajaTexto2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + cajaTexto2.Text.Length + " Caracteres");
        }
    }
}
