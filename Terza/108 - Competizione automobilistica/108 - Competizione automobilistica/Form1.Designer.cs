namespace _108___Competizione_automobilistica
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.lstPiloti = new System.Windows.Forms.ListBox();
            this.cmbPiloti = new System.Windows.Forms.ComboBox();
            this.plsQualifica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.plsSoloQualificati = new System.Windows.Forms.Button();
            this.plsSqualifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME PILOTA";
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(12, 85);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(436, 23);
            this.plsAggiungi.TabIndex = 2;
            this.plsAggiungi.Text = "AGGIUNGI";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // lstPiloti
            // 
            this.lstPiloti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPiloti.FormattingEnabled = true;
            this.lstPiloti.ItemHeight = 16;
            this.lstPiloti.Location = new System.Drawing.Point(12, 310);
            this.lstPiloti.Name = "lstPiloti";
            this.lstPiloti.Size = new System.Drawing.Size(436, 116);
            this.lstPiloti.TabIndex = 3;
            // 
            // cmbPiloti
            // 
            this.cmbPiloti.FormattingEnabled = true;
            this.cmbPiloti.Location = new System.Drawing.Point(160, 114);
            this.cmbPiloti.Name = "cmbPiloti";
            this.cmbPiloti.Size = new System.Drawing.Size(137, 21);
            this.cmbPiloti.TabIndex = 4;
            this.cmbPiloti.SelectedIndexChanged += new System.EventHandler(this.cmbPiloti_SelectedIndexChanged);
            // 
            // plsQualifica
            // 
            this.plsQualifica.Location = new System.Drawing.Point(12, 237);
            this.plsQualifica.Name = "plsQualifica";
            this.plsQualifica.Size = new System.Drawing.Size(164, 23);
            this.plsQualifica.TabIndex = 7;
            this.plsQualifica.Text = "CONTROLLA QUALIFICA";
            this.plsQualifica.UseVisualStyleBackColor = true;
            this.plsQualifica.Click += new System.EventHandler(this.plsQualifica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEMPO LIMITE";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(12, 211);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(164, 20);
            this.txtTempo.TabIndex = 5;
            // 
            // plsSoloQualificati
            // 
            this.plsSoloQualificati.Location = new System.Drawing.Point(284, 211);
            this.plsSoloQualificati.Name = "plsSoloQualificati";
            this.plsSoloQualificati.Size = new System.Drawing.Size(164, 23);
            this.plsSoloQualificati.TabIndex = 8;
            this.plsSoloQualificati.Text = "MOSTRA SOLO QUALIFICATI";
            this.plsSoloQualificati.UseVisualStyleBackColor = true;
            this.plsSoloQualificati.Click += new System.EventHandler(this.plsSoloQualificati_Click);
            // 
            // plsSqualifica
            // 
            this.plsSqualifica.Location = new System.Drawing.Point(284, 240);
            this.plsSqualifica.Name = "plsSqualifica";
            this.plsSqualifica.Size = new System.Drawing.Size(164, 35);
            this.plsSqualifica.TabIndex = 9;
            this.plsSqualifica.Text = "SQUALIFICA GIOCATORE (SELEZIONATO DA LISTBOX)";
            this.plsSqualifica.UseVisualStyleBackColor = true;
            this.plsSqualifica.Click += new System.EventHandler(this.plsSqualifica_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.plsSqualifica);
            this.Controls.Add(this.plsSoloQualificati);
            this.Controls.Add(this.plsQualifica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.cmbPiloti);
            this.Controls.Add(this.lstPiloti);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmAvvio";
            this.Text = "Corsa automobilistica";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.ListBox lstPiloti;
        private System.Windows.Forms.ComboBox cmbPiloti;
        private System.Windows.Forms.Button plsQualifica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button plsSoloQualificati;
        private System.Windows.Forms.Button plsSqualifica;
    }
}

