
namespace Ejercitacion
{
    partial class Form1
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.checkProg = new System.Windows.Forms.CheckBox();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textSalida = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Location = new System.Drawing.Point(457, 36);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre: ";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(94, 36);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(328, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textNombre_Validating);
            // 
            // checkProg
            // 
            this.checkProg.AutoSize = true;
            this.checkProg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkProg.Checked = true;
            this.checkProg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkProg.Location = new System.Drawing.Point(19, 76);
            this.checkProg.Name = "checkProg";
            this.checkProg.Size = new System.Drawing.Size(89, 17);
            this.checkProg.TabIndex = 3;
            this.checkProg.Text = "Programador:";
            this.checkProg.UseVisualStyleBackColor = true;
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.Checked = true;
            this.radioButtonHombre.Location = new System.Drawing.Point(43, 31);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(62, 17);
            this.radioButtonHombre.TabIndex = 4;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonMujer);
            this.groupBox.Controls.Add(this.radioButtonHombre);
            this.groupBox.Location = new System.Drawing.Point(98, 111);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(328, 71);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Sexo";
            this.groupBox.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.groupBox_ControlAdded);
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(222, 31);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMujer.TabIndex = 5;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salida:";
            // 
            // textSalida
            // 
            this.textSalida.Location = new System.Drawing.Point(19, 222);
            this.textSalida.Multiline = true;
            this.textSalida.Name = "textSalida";
            this.textSalida.Size = new System.Drawing.Size(403, 105);
            this.textSalida.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 339);
            this.Controls.Add(this.textSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.checkProg);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.CheckBox checkProg;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSalida;
    }
}

