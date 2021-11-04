namespace _94___Lista_di_nomi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomi = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.plsSvuota = new System.Windows.Forms.Button();
            this.plsRimuovi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metti qui il tuo nome da aggiungere.";
            // 
            // lblNomi
            // 
            this.lblNomi.BackColor = System.Drawing.Color.Red;
            this.lblNomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomi.Location = new System.Drawing.Point(63, 209);
            this.lblNomi.Name = "lblNomi";
            this.lblNomi.Size = new System.Drawing.Size(433, 23);
            this.lblNomi.TabIndex = 3;
            this.lblNomi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(66, 155);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(212, 23);
            this.plsAggiungi.TabIndex = 4;
            this.plsAggiungi.Text = "AGGIUNGI ALLA LISTA";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // plsSvuota
            // 
            this.plsSvuota.Location = new System.Drawing.Point(66, 257);
            this.plsSvuota.Name = "plsSvuota";
            this.plsSvuota.Size = new System.Drawing.Size(430, 23);
            this.plsSvuota.TabIndex = 5;
            this.plsSvuota.Text = "SVUOTA LISTA";
            this.plsSvuota.UseVisualStyleBackColor = true;
            this.plsSvuota.Click += new System.EventHandler(this.plsSvuota_Click);
            // 
            // plsRimuovi
            // 
            this.plsRimuovi.Location = new System.Drawing.Point(290, 155);
            this.plsRimuovi.Name = "plsRimuovi";
            this.plsRimuovi.Size = new System.Drawing.Size(212, 23);
            this.plsRimuovi.TabIndex = 8;
            this.plsRimuovi.Text = "RIMUOVI DALLA LISTA";
            this.plsRimuovi.UseVisualStyleBackColor = true;
            this.plsRimuovi.Click += new System.EventHandler(this.plsRimuovi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posizione elemento da rimuovere";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(357, 115);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(67, 20);
            this.txtPos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 292);
            this.Controls.Add(this.plsRimuovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.plsSvuota);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.lblNomi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lista di nomi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomi;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Button plsSvuota;
        private System.Windows.Forms.Button plsRimuovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPos;
    }
}

