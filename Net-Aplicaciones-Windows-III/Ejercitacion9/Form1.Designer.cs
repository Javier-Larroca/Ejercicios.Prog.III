
namespace Ejercitacion9
{
    partial class formListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formListView));
            this.lblActualdir = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioT = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioL = new System.Windows.Forms.RadioButton();
            this.radioSI = new System.Windows.Forms.RadioButton();
            this.radioLI = new System.Windows.Forms.RadioButton();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.lvCarpetas = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActualdir
            // 
            this.lblActualdir.AutoSize = true;
            this.lblActualdir.Location = new System.Drawing.Point(13, 13);
            this.lblActualdir.Name = "lblActualdir";
            this.lblActualdir.Size = new System.Drawing.Size(85, 13);
            this.lblActualdir.TabIndex = 0;
            this.lblActualdir.Text = "Directorio Actual";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(191, 337);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioT);
            this.groupBox1.Controls.Add(this.radioD);
            this.groupBox1.Controls.Add(this.radioL);
            this.groupBox1.Controls.Add(this.radioSI);
            this.groupBox1.Controls.Add(this.radioLI);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(467, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de Vista";
            this.groupBox1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.groupBox1_ControlAdded);
            // 
            // radioT
            // 
            this.radioT.AutoSize = true;
            this.radioT.Location = new System.Drawing.Point(7, 150);
            this.radioT.Name = "radioT";
            this.radioT.Size = new System.Drawing.Size(51, 17);
            this.radioT.TabIndex = 4;
            this.radioT.Text = "Titulo";
            this.radioT.UseVisualStyleBackColor = true;
            this.radioT.CheckedChanged += new System.EventHandler(this.radioT_CheckedChanged);
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Checked = true;
            this.radioD.Location = new System.Drawing.Point(7, 120);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(58, 17);
            this.radioD.TabIndex = 3;
            this.radioD.TabStop = true;
            this.radioD.Text = "Detalle";
            this.radioD.UseVisualStyleBackColor = true;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioD_CheckedChanged);
            // 
            // radioL
            // 
            this.radioL.AutoSize = true;
            this.radioL.Location = new System.Drawing.Point(7, 90);
            this.radioL.Name = "radioL";
            this.radioL.Size = new System.Drawing.Size(47, 17);
            this.radioL.TabIndex = 2;
            this.radioL.Text = "Lista";
            this.radioL.UseVisualStyleBackColor = true;
            this.radioL.CheckedChanged += new System.EventHandler(this.radioL_CheckedChanged);
            // 
            // radioSI
            // 
            this.radioSI.AutoSize = true;
            this.radioSI.Location = new System.Drawing.Point(7, 60);
            this.radioSI.Name = "radioSI";
            this.radioSI.Size = new System.Drawing.Size(74, 17);
            this.radioSI.TabIndex = 1;
            this.radioSI.Text = "Small Icon";
            this.radioSI.UseVisualStyleBackColor = true;
            this.radioSI.CheckedChanged += new System.EventHandler(this.radioSI_CheckedChanged);
            // 
            // radioLI
            // 
            this.radioLI.AutoSize = true;
            this.radioLI.Location = new System.Drawing.Point(7, 30);
            this.radioLI.Name = "radioLI";
            this.radioLI.Size = new System.Drawing.Size(76, 17);
            this.radioLI.TabIndex = 0;
            this.radioLI.Text = "Large Icon";
            this.radioLI.UseVisualStyleBackColor = true;
            this.radioLI.CheckedChanged += new System.EventHandler(this.radioLI_CheckedChanged);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "noun_Circular Saw_2817211.png");
            this.imageListSmall.Images.SetKeyName(1, "noun_Hammer_2812437.png");
            this.imageListSmall.Images.SetKeyName(2, "noun_hand saw_2812438.png");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "noun_Location_2793721.png");
            this.imageListLarge.Images.SetKeyName(1, "noun_padlock_2793728.png");
            this.imageListLarge.Images.SetKeyName(2, "noun_Camera_2793724.png");
            // 
            // lvCarpetas
            // 
            this.lvCarpetas.HideSelection = false;
            this.lvCarpetas.LargeImageList = this.imageListLarge;
            this.lvCarpetas.Location = new System.Drawing.Point(16, 39);
            this.lvCarpetas.Name = "lvCarpetas";
            this.lvCarpetas.Size = new System.Drawing.Size(429, 273);
            this.lvCarpetas.SmallImageList = this.imageListSmall;
            this.lvCarpetas.TabIndex = 4;
            this.lvCarpetas.UseCompatibleStateImageBehavior = false;
            this.lvCarpetas.View = System.Windows.Forms.View.Details;
            this.lvCarpetas.ItemActivate += new System.EventHandler(this.lvCarpetas_ItemActivate);
            // 
            // formListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 379);
            this.Controls.Add(this.lvCarpetas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblActualdir);
            this.Name = "formListView";
            this.Text = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActualdir;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioT;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioL;
        private System.Windows.Forms.RadioButton radioSI;
        private System.Windows.Forms.RadioButton radioLI;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ListView lvCarpetas;
    }
}

