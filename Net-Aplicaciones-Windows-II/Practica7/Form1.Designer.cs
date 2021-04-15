
namespace Practica7
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
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnCu = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnG = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.rtxtEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnN
            // 
            this.btnN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN.Location = new System.Drawing.Point(35, 15);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 23);
            this.btnN.TabIndex = 0;
            this.btnN.Text = "Negrita";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnS
            // 
            this.btnS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnS.Location = new System.Drawing.Point(155, 15);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "Subrayado";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnCu
            // 
            this.btnCu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCu.Location = new System.Drawing.Point(275, 15);
            this.btnCu.Name = "btnCu";
            this.btnCu.Size = new System.Drawing.Size(75, 23);
            this.btnCu.TabIndex = 2;
            this.btnCu.Text = "Cursiva";
            this.btnCu.UseVisualStyleBackColor = true;
            this.btnCu.Click += new System.EventHandler(this.btnCu_Click);
            // 
            // btnCe
            // 
            this.btnCe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCe.Location = new System.Drawing.Point(395, 15);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(75, 23);
            this.btnCe.TabIndex = 3;
            this.btnCe.Text = "Centrado";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(258, 55);
            this.txtTamanio.MaxLength = 3;
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(101, 20);
            this.txtTamanio.TabIndex = 4;
            this.txtTamanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTF_KeyPress);
            this.txtTamanio.Validated += new System.EventHandler(this.txtTamanio_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamaño Fuente";
            // 
            // btnG
            // 
            this.btnG.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnG.Location = new System.Drawing.Point(155, 339);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 23);
            this.btnG.TabIndex = 6;
            this.btnG.Text = "Guardar";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA.Location = new System.Drawing.Point(274, 338);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 7;
            this.btnA.Text = "Abrir";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // rtxtEditor
            // 
            this.rtxtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEditor.Location = new System.Drawing.Point(35, 93);
            this.rtxtEditor.Name = "rtxtEditor";
            this.rtxtEditor.Size = new System.Drawing.Size(435, 222);
            this.rtxtEditor.TabIndex = 8;
            this.rtxtEditor.Text = "";
            this.rtxtEditor.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxtEditor_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 374);
            this.Controls.Add(this.rtxtEditor);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnCu);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.MinimumSize = new System.Drawing.Size(10, 10);
            this.Name = "Form1";
            this.Text = "RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnCu;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.RichTextBox rtxtEditor;
    }
}

