namespace _96___Lista_di_interi_con_accorgimenti
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
            this.lblElementi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRimuovi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSostituto = new System.Windows.Forms.TextBox();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.plsSostituisci = new System.Windows.Forms.Button();
            this.plsRimuovi = new System.Windows.Forms.Button();
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.plsSvuota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElementi
            // 
            this.lblElementi.BackColor = System.Drawing.Color.Blue;
            this.lblElementi.ForeColor = System.Drawing.Color.White;
            this.lblElementi.Location = new System.Drawing.Point(12, 254);
            this.lblElementi.Name = "lblElementi";
            this.lblElementi.Size = new System.Drawing.Size(519, 23);
            this.lblElementi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DEI NUMERI AGGIUNTI";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(25, 68);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(112, 20);
            this.txtN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero da aggiungere\r\n(se non già presente)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero da rimuovere\r\n(se già presente)\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRimuovi
            // 
            this.txtRimuovi.Location = new System.Drawing.Point(401, 68);
            this.txtRimuovi.Name = "txtRimuovi";
            this.txtRimuovi.Size = new System.Drawing.Size(112, 20);
            this.txtRimuovi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero che vuoi sostituire \r\nal posto di quello in posizione P\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSostituto
            // 
            this.txtSostituto.Location = new System.Drawing.Point(210, 68);
            this.txtSostituto.Name = "txtSostituto";
            this.txtSostituto.Size = new System.Drawing.Size(112, 20);
            this.txtSostituto.TabIndex = 6;
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(25, 94);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(112, 23);
            this.plsAggiungi.TabIndex = 8;
            this.plsAggiungi.Text = "AGGIUNGI";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // plsSostituisci
            // 
            this.plsSostituisci.Location = new System.Drawing.Point(210, 94);
            this.plsSostituisci.Name = "plsSostituisci";
            this.plsSostituisci.Size = new System.Drawing.Size(112, 23);
            this.plsSostituisci.TabIndex = 9;
            this.plsSostituisci.Text = "SOSTITUISCI";
            this.plsSostituisci.UseVisualStyleBackColor = true;
            this.plsSostituisci.Click += new System.EventHandler(this.plsSostituisci_Click);
            // 
            // plsRimuovi
            // 
            this.plsRimuovi.Location = new System.Drawing.Point(401, 94);
            this.plsRimuovi.Name = "plsRimuovi";
            this.plsRimuovi.Size = new System.Drawing.Size(112, 23);
            this.plsRimuovi.TabIndex = 10;
            this.plsRimuovi.Text = "RIMUOVI";
            this.plsRimuovi.UseVisualStyleBackColor = true;
            this.plsRimuovi.Click += new System.EventHandler(this.plsRimuovi_Click);
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.Location = new System.Drawing.Point(25, 170);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(488, 23);
            this.plsVisualizza.TabIndex = 11;
            this.plsVisualizza.Text = "VISUALIZZA ELEMENTI DELLA LISTA INVERTITI";
            this.plsVisualizza.UseVisualStyleBackColor = true;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // plsSvuota
            // 
            this.plsSvuota.Location = new System.Drawing.Point(25, 314);
            this.plsSvuota.Name = "plsSvuota";
            this.plsSvuota.Size = new System.Drawing.Size(488, 23);
            this.plsSvuota.TabIndex = 12;
            this.plsSvuota.Text = "SVUOTA LISTA";
            this.plsSvuota.UseVisualStyleBackColor = true;
            this.plsSvuota.Click += new System.EventHandler(this.plsSvuota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 352);
            this.Controls.Add(this.plsSvuota);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.plsRimuovi);
            this.Controls.Add(this.plsSostituisci);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSostituto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRimuovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblElementi);
            this.Name = "Form1";
            this.Text = "Lista di interi con accorgimenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElementi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRimuovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSostituto;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Button plsSostituisci;
        private System.Windows.Forms.Button plsRimuovi;
        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.Button plsSvuota;
    }
}

