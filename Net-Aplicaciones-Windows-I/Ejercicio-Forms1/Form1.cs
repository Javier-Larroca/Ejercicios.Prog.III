using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se reestablece el color de los textBox en caso de que ya esten en rojo.
            textApellido.BackColor = System.Drawing.SystemColors.Control;
            textNombre.BackColor = System.Drawing.SystemColors.Control;
            textEdad.BackColor = System.Drawing.SystemColors.Control;
            textDireccion.BackColor = System.Drawing.SystemColors.Control;

            //Se pintan los textBox que no contengan contenido alguno.
            if (textApellido.Text == "")
                textApellido.BackColor = Color.Red;
            if (textNombre.Text == "")
                textNombre.BackColor = Color.Red;
            if (textEdad.Text == "")
                textEdad.BackColor = Color.Red;
            if (textDireccion.Text == "")
                textDireccion.BackColor = Color.Red;

            //Se imprimen los datos en el cuadro de texto inferior.
            if(!(textApellido.Text == "" || textNombre.Text == "" || textEdad.Text == "" || textDireccion.Text == ""))
            {
                textResultado.Text = "Apellido y nombre: " + textApellido + " " + textNombre;
                textResultado.Text += "\r\n" + "Edad: " + textEdad;
                textResultado.Text += "\r\n" + "Dirección: " + textDireccion;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se cierra la aplicacion.
            this.Close();
        }
    }
}
