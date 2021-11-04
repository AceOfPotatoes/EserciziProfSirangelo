namespace _97___Primo_utilizzo_di_ListBox_e_ComboBox
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
            this.cmbOperazioni = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plsOperazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOperazioni
            // 
            this.cmbOperazioni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperazioni.FormattingEnabled = true;
            this.cmbOperazioni.Location = new System.Drawing.Point(191, 98);
            this.cmbOperazioni.Name = "cmbOperazioni";
            this.cmbOperazioni.Size = new System.Drawing.Size(121, 21);
            this.cmbOperazioni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azioni effettuabili";
            // 
            // lstElenco
            // 
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.Location = new System.Drawing.Point(25, 82);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(120, 290);
            this.lstElenco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Elementi:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(276, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "_";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date delle operazioni predefinite disponibili, il software\r\neffettuerà l\'operazio" +
    "ne richiesta. Inoltre ad ogni passaggio\r\nverrà visualizzato nella label il numer" +
    "o di elementi presenti nella lista.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsOperazione
            // 
            this.plsOperazione.Location = new System.Drawing.Point(191, 208);
            this.plsOperazione.Name = "plsOperazione";
            this.plsOperazione.Size = new System.Drawing.Size(121, 39);
            this.plsOperazione.TabIndex = 6;
            this.plsOperazione.Text = "EFFETTUA OPERAZIONE";
            this.plsOperazione.UseVisualStyleBackColor = true;
            this.plsOperazione.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 400);
            this.Controls.Add(this.plsOperazione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOperazioni);
            this.Name = "Form1";
            this.Text = "Primo utilizzo di ListBox e ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperazioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstElenco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button plsOperazione;
    }
}

