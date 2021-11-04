namespace _103___Fascia_di_credito_voti
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
            this.plsVettore = new System.Windows.Forms.Button();
            this.plsList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFascia = new System.Windows.Forms.Label();
            this.lblTre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plsVettore
            // 
            this.plsVettore.Location = new System.Drawing.Point(141, 88);
            this.plsVettore.Name = "plsVettore";
            this.plsVettore.Size = new System.Drawing.Size(75, 23);
            this.plsVettore.TabIndex = 0;
            this.plsVettore.Text = "VETTORE";
            this.plsVettore.UseVisualStyleBackColor = true;
            this.plsVettore.Click += new System.EventHandler(this.plsVettore_Click);
            // 
            // plsList
            // 
            this.plsList.Location = new System.Drawing.Point(268, 88);
            this.plsList.Name = "plsList";
            this.plsList.Size = new System.Drawing.Size(75, 23);
            this.plsList.TabIndex = 1;
            this.plsList.Text = "LIST<T>";
            this.plsList.UseVisualStyleBackColor = true;
            this.plsList.Click += new System.EventHandler(this.plsList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dato il numero di voti (MAX 10), il software richiederà mano a mano le valutazion" +
    "e singolarmente\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FASCIA:";
            // 
            // lblFascia
            // 
            this.lblFascia.AutoSize = true;
            this.lblFascia.BackColor = System.Drawing.Color.Maroon;
            this.lblFascia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFascia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFascia.Location = new System.Drawing.Point(276, 165);
            this.lblFascia.Name = "lblFascia";
            this.lblFascia.Size = new System.Drawing.Size(0, 20);
            this.lblFascia.TabIndex = 4;
            // 
            // lblTre
            // 
            this.lblTre.AutoSize = true;
            this.lblTre.BackColor = System.Drawing.Color.Maroon;
            this.lblTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTre.Location = new System.Drawing.Point(276, 194);
            this.lblTre.Name = "lblTre";
            this.lblTre.Size = new System.Drawing.Size(0, 20);
            this.lblTre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "C\'E\' UN 3:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.Maroon;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMedia.Location = new System.Drawing.Point(276, 223);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 20);
            this.lblMedia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "MEDIA:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Maroon;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMax.Location = new System.Drawing.Point(276, 136);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 20);
            this.lblMax.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "VOTO MASSIMO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "SCEGLI IL METODO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFascia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plsList);
            this.Controls.Add(this.plsVettore);
            this.Name = "Form1";
            this.Text = "Fascia di credito voti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plsVettore;
        private System.Windows.Forms.Button plsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFascia;
        private System.Windows.Forms.Label lblTre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

