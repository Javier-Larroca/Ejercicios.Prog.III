
namespace Forms1
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.Boton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.CajaTexto = new System.Windows.Forms.TextBox();
            this.cajaTexto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Boton
            // 
            this.Boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Boton.Image = ((System.Drawing.Image)(resources.GetObject("Boton.Image")));
            this.Boton.Location = new System.Drawing.Point(247, 235);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(75, 23);
            this.Boton.TabIndex = 0;
            this.Boton.Text = "Boton";
            this.Boton.UseVisualStyleBackColor = false;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label.Location = new System.Drawing.Point(220, 53);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(122, 38);
            this.Label.TabIndex = 1;
            this.Label.Text = "Etiqueta";
            this.Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // CajaTexto
            // 
            this.CajaTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CajaTexto.Location = new System.Drawing.Point(233, 193);
            this.CajaTexto.MaxLength = 300;
            this.CajaTexto.Name = "CajaTexto";
            this.CajaTexto.Size = new System.Drawing.Size(100, 20);
            this.CajaTexto.TabIndex = 2;
            this.CajaTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
            // 
            // cajaTexto2
            // 
            this.cajaTexto2.Location = new System.Drawing.Point(233, 106);
            this.cajaTexto2.Multiline = true;
            this.cajaTexto2.Name = "cajaTexto2";
            this.cajaTexto2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cajaTexto2.Size = new System.Drawing.Size(100, 66);
            this.cajaTexto2.TabIndex = 3;
            this.cajaTexto2.Leave += new System.EventHandler(this.cajaTexto2_Leave);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(579, 309);
            this.Controls.Add(this.cajaTexto2);
            this.Controls.Add(this.CajaTexto);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Boton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primero Formulario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario_FormClosed);
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.Click += new System.EventHandler(this.Formulario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox CajaTexto;
        private System.Windows.Forms.TextBox cajaTexto2;
    }
}

