namespace _100___Primo_utilizzo_di_un_vettore
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
            this.lstVet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.plsSomma = new System.Windows.Forms.Button();
            this.plsRimuovi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstVet
            // 
            this.lstVet.FormattingEnabled = true;
            this.lstVet.Location = new System.Drawing.Point(12, 62);
            this.lstVet.Name = "lstVet";
            this.lstVet.Size = new System.Drawing.Size(120, 199);
            this.lstVet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Il software gestisce una lista di numeri (max 10), memorizzati in un vettore.\r\nPo" +
    "ssono essere effettuate le azioni rappresentate dai pulsanti qui sotto.";
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(152, 86);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(212, 23);
            this.plsAggiungi.TabIndex = 2;
            this.plsAggiungi.Text = "AGGIUNGI UN ELEMENTO";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.Location = new System.Drawing.Point(152, 128);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(212, 23);
            this.plsVisualizza.TabIndex = 3;
            this.plsVisualizza.Text = "VISUALIZZA NELLA LISTBOX";
            this.plsVisualizza.UseVisualStyleBackColor = true;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // plsSomma
            // 
            this.plsSomma.Location = new System.Drawing.Point(152, 169);
            this.plsSomma.Name = "plsSomma";
            this.plsSomma.Size = new System.Drawing.Size(212, 23);
            this.plsSomma.TabIndex = 4;
            this.plsSomma.Text = "CALCOLA SOMMA ELEMENTI";
            this.plsSomma.UseVisualStyleBackColor = true;
            this.plsSomma.Click += new System.EventHandler(this.plsSomma_Click);
            // 
            // plsRimuovi
            // 
            this.plsRimuovi.Location = new System.Drawing.Point(152, 210);
            this.plsRimuovi.Name = "plsRimuovi";
            this.plsRimuovi.Size = new System.Drawing.Size(212, 23);
            this.plsRimuovi.TabIndex = 5;
            this.plsRimuovi.Text = "RIMUOVI TUTTO ANCHE DA LISTBOX";
            this.plsRimuovi.UseVisualStyleBackColor = true;
            this.plsRimuovi.Click += new System.EventHandler(this.plsRimuovi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero di elementi inseriti:";
            // 
            // lblNum
            // 
            this.lblNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Transparent;
            this.lblNum.Location = new System.Drawing.Point(232, 279);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(45, 18);
            this.lblNum.TabIndex = 7;
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 315);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plsRimuovi);
            this.Controls.Add(this.plsSomma);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVet);
            this.Name = "Form1";
            this.Text = "Primo utilizzo di un vettore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.Button plsSomma;
        private System.Windows.Forms.Button plsRimuovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum;
    }
}

