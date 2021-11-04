namespace _105___Lancio_del_disco
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstNomi = new System.Windows.Forms.ListBox();
            this.lstMisure = new System.Windows.Forms.ListBox();
            this.lstMigliori = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtleta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Il software si occupa di gestire una gara di lancio del disco";
            // 
            // lstNomi
            // 
            this.lstNomi.FormattingEnabled = true;
            this.lstNomi.Location = new System.Drawing.Point(32, 63);
            this.lstNomi.Name = "lstNomi";
            this.lstNomi.Size = new System.Drawing.Size(87, 186);
            this.lstNomi.TabIndex = 2;
            this.lstNomi.SelectedIndexChanged += new System.EventHandler(this.lstNomi_SelectedIndexChanged);
            // 
            // lstMisure
            // 
            this.lstMisure.FormattingEnabled = true;
            this.lstMisure.Location = new System.Drawing.Point(125, 63);
            this.lstMisure.Name = "lstMisure";
            this.lstMisure.Size = new System.Drawing.Size(87, 186);
            this.lstMisure.TabIndex = 3;
            // 
            // lstMigliori
            // 
            this.lstMigliori.FormattingEnabled = true;
            this.lstMigliori.Location = new System.Drawing.Point(285, 100);
            this.lstMigliori.Name = "lstMigliori";
            this.lstMigliori.Size = new System.Drawing.Size(180, 95);
            this.lstMigliori.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "ATLETI CON LANCI \r\nMIGLIORI DEL SELEZIONATO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(70, 370);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(109, 23);
            this.plsAggiungi.TabIndex = 6;
            this.plsAggiungi.Text = "AGGIUNGI ATLETA";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "NOME ATLETA";
            // 
            // txtAtleta
            // 
            this.txtAtleta.Location = new System.Drawing.Point(70, 329);
            this.txtAtleta.Name = "txtAtleta";
            this.txtAtleta.Size = new System.Drawing.Size(109, 20);
            this.txtAtleta.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "MEDIA MISURE LANCI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "MEDIA:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.Maroon;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMedia.Location = new System.Drawing.Point(397, 375);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 18);
            this.lblMedia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOMI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "MISURE (M)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "N.B.:L\'evento di visualizzazione degli atleti migliori di quello selezionato \r\npa" +
    "rte a seguito della selezione del nome voluto sulla lista\r\n";
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAtleta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMigliori);
            this.Controls.Add(this.lstMisure);
            this.Controls.Add(this.lstNomi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAvvio";
            this.Text = "Lancio del disco";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNomi;
        private System.Windows.Forms.ListBox lstMisure;
        private System.Windows.Forms.ListBox lstMigliori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtleta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

