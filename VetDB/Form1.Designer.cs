namespace VetDB
{
    partial class VetDBmain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.magazynButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxModules = new System.Windows.Forms.GroupBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label_VETDB = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxModules.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // magazynButton
            // 
            this.magazynButton.BackColor = System.Drawing.Color.Yellow;
            this.magazynButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.magazynButton.Location = new System.Drawing.Point(6, 19);
            this.magazynButton.Name = "magazynButton";
            this.magazynButton.Size = new System.Drawing.Size(200, 100);
            this.magazynButton.TabIndex = 0;
            this.magazynButton.Text = "Magazyn Lekow";
            this.magazynButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(212, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dane Klientów";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(6, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pacjenci";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(212, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "Raporty";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBoxModules
            // 
            this.groupBoxModules.Controls.Add(this.magazynButton);
            this.groupBoxModules.Controls.Add(this.button3);
            this.groupBoxModules.Controls.Add(this.button1);
            this.groupBoxModules.Controls.Add(this.button2);
            this.groupBoxModules.Location = new System.Drawing.Point(12, 106);
            this.groupBoxModules.Name = "groupBoxModules";
            this.groupBoxModules.Size = new System.Drawing.Size(469, 239);
            this.groupBoxModules.TabIndex = 4;
            this.groupBoxModules.TabStop = false;
            this.groupBoxModules.Text = "Dostępne moduły";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.label_VETDB);
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 100);
            this.panelTop.TabIndex = 5;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // label_VETDB
            // 
            this.label_VETDB.AutoSize = true;
            this.label_VETDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_VETDB.Location = new System.Drawing.Point(14, 29);
            this.label_VETDB.Name = "label_VETDB";
            this.label_VETDB.Size = new System.Drawing.Size(140, 24);
            this.label_VETDB.TabIndex = 1;
            this.label_VETDB.Text = "VetDB - Witamy";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::VetDB.Properties.Resources.close;
            this.pictureBoxClose.Location = new System.Drawing.Point(747, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(453, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 100);
            this.button4.TabIndex = 4;
            this.button4.Text = "Raporty";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // VetDBmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.groupBoxModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VetDBmain";
            this.Text = "VetDB";
            this.groupBoxModules.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button magazynButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxModules;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label_VETDB;
        private System.Windows.Forms.Button button4;
    }
}

