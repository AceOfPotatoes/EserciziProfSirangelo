namespace _101___Numero_maschi_e_femmine_vettori
{
    partial class frmAvvio
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.plsInizia = new System.Windows.Forms.Button();
            this.lstM = new System.Windows.Forms.ListBox();
            this.lstF = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plsVis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaschi = new System.Windows.Forms.Label();
            this.lblFemmine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Il software gestisce e smista in due ListBox distinte con alla base Vettori, mass" +
    "imo 20 nominativi fra maschi e femmine.";
            // 
            // plsInizia
            // 
            this.plsInizia.Location = new System.Drawing.Point(15, 266);
            this.plsInizia.Name = "plsInizia";
            this.plsInizia.Size = new System.Drawing.Size(552, 23);
            this.plsInizia.TabIndex = 1;
            this.plsInizia.Text = "INIZIA";
            this.plsInizia.UseVisualStyleBackColor = true;
            this.plsInizia.Click += new System.EventHandler(this.plsInizia_Click);
            // 
            // lstM
            // 
            this.lstM.FormattingEnabled = true;
            this.lstM.Location = new System.Drawing.Point(15, 63);
            this.lstM.Name = "lstM";
            this.lstM.Size = new System.Drawing.Size(120, 186);
            this.lstM.TabIndex = 2;
            // 
            // lstF
            // 
            this.lstF.FormattingEnabled = true;
            this.lstF.Location = new System.Drawing.Point(447, 63);
            this.lstF.Name = "lstF";
            this.lstF.Size = new System.Drawing.Size(120, 186);
            this.lstF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MASCHI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MASCHI";
            // 
            // plsVis
            // 
            this.plsVis.Location = new System.Drawing.Point(15, 307);
            this.plsVis.Name = "plsVis";
            this.plsVis.Size = new System.Drawing.Size(552, 23);
            this.plsVis.TabIndex = 6;
            this.plsVis.Text = "VISUALIZZA NELLE LISTE (E NUMERO ELEMENTI)";
            this.plsVis.UseVisualStyleBackColor = true;
            this.plsVis.Click += new System.EventHandler(this.plsVis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero MASCHI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero FEMMINE:";
            // 
            // lblMaschi
            // 
            this.lblMaschi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMaschi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaschi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMaschi.Location = new System.Drawing.Point(346, 111);
            this.lblMaschi.Name = "lblMaschi";
            this.lblMaschi.Size = new System.Drawing.Size(54, 20);
            this.lblMaschi.TabIndex = 9;
            this.lblMaschi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFemmine
            // 
            this.lblFemmine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFemmine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemmine.ForeColor = System.Drawing.Color.White;
            this.lblFemmine.Location = new System.Drawing.Point(346, 140);
            this.lblFemmine.Name = "lblFemmine";
            this.lblFemmine.Size = new System.Drawing.Size(54, 20);
            this.lblFemmine.TabIndex = 10;
            this.lblFemmine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 340);
            this.Controls.Add(this.lblFemmine);
            this.Controls.Add(this.lblMaschi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plsVis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstF);
            this.Controls.Add(this.lstM);
            this.Controls.Add(this.plsInizia);
            this.Controls.Add(this.label1);
            this.Name = "frmAvvio";
            this.Text = "Numero maschi e femmine vettori e ListBox";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsInizia;
        private System.Windows.Forms.ListBox lstM;
        private System.Windows.Forms.ListBox lstF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsVis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaschi;
        private System.Windows.Forms.Label lblFemmine;
    }
}

