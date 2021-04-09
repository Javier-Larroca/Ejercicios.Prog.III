using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidarOk()
        {
            //Habilita el Botón, siempre y cuando txtNombre tenga datos.
            btnOk.Enabled = (textNombre.BackColor != Color.Red);
        }

        private void groupBox_ControlAdded(object sender, ControlEventArgs e)
        {
            groupBox.Controls.Add(radioButtonHombre);
            groupBox.Controls.Add(radioButtonMujer);
        }

        private void textNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;
            ValidarOk();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deshabilito el Botón Ok.
            btnOk.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //No valido datos ya que si el Botón esta Habilitado
            //Es porque paso el Evento Validating del Nombre.
            String salida; //Declaro una variable para armar la salida.
            salida = "Nombe: " + textNombre.Text + "\r\n";
            salida += "Ocupacion: " + (string)(checkProg.Checked ?
            "Programador" : "No es Programador") + "\r\n";
            salida += "Sexo: " + (string)(radioButtonHombre.Checked ? "Hombre" :
            "Mujer") + "\r\n";
            //Vuelco la salida al TextBox Salida.
            textSalida.Text = salida;
        }
    }
}
