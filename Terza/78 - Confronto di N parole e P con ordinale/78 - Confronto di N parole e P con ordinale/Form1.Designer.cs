namespace _78___Confronto_di_N_parole_e_P_con_ordinale
{
    partial class Form1
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
            this.txtP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.plsInizia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaggiori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data una parola P di riferimento e in N il numero di input che si vogliono effett" +
    "uare.\r\nIl software posizionerà in un\'apposita label solo le parole maggiori di P" +
    ", utilizzando il metodo ordinale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(15, 98);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "P di Riferimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° Input";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(384, 98);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 3;
            // 
            // plsInizia
            // 
            this.plsInizia.Location = new System.Drawing.Point(15, 150);
            this.plsInizia.Name = "plsInizia";
            this.plsInizia.Size = new System.Drawing.Size(470, 23);
            this.plsInizia.TabIndex = 5;
            this.plsInizia.Text = "INIZIA";
            this.plsInizia.UseVisualStyleBackColor = true;
            this.plsInizia.Click += new System.EventHandler(this.plsInizia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "MAGGIORI DI P:";
            // 
            // lblMaggiori
            // 
            this.lblMaggiori.AutoSize = true;
            this.lblMaggiori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaggiori.ForeColor = System.Drawing.Color.Red;
            this.lblMaggiori.Location = new System.Drawing.Point(155, 204);
            this.lblMaggiori.Name = "lblMaggiori";
            this.lblMaggiori.Size = new System.Drawing.Size(0, 20);
            this.lblMaggiori.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.lblMaggiori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plsInizia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Confronto di N parole con P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button plsInizia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaggiori;
    }
}

