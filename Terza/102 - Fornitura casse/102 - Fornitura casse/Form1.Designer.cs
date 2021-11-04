namespace _102___Fornitura_casse
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
            this.lstPesi = new System.Windows.Forms.ListBox();
            this.lstCasse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.txtCassa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.plsPeso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPesi
            // 
            this.lstPesi.FormattingEnabled = true;
            this.lstPesi.Location = new System.Drawing.Point(36, 63);
            this.lstPesi.Name = "lstPesi";
            this.lstPesi.Size = new System.Drawing.Size(120, 121);
            this.lstPesi.TabIndex = 0;
            // 
            // lstCasse
            // 
            this.lstCasse.FormattingEnabled = true;
            this.lstCasse.Location = new System.Drawing.Point(237, 63);
            this.lstCasse.Name = "lstCasse";
            this.lstCasse.Size = new System.Drawing.Size(120, 121);
            this.lstCasse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PESI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUMERO CASSE";
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(36, 252);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(321, 23);
            this.plsAggiungi.TabIndex = 4;
            this.plsAggiungi.Text = "AGGIUNGI CASSA";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // txtCassa
            // 
            this.txtCassa.Location = new System.Drawing.Point(36, 226);
            this.txtCassa.Name = "txtCassa";
            this.txtCassa.Size = new System.Drawing.Size(321, 20);
            this.txtCassa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peso cassa";
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.Location = new System.Drawing.Point(36, 281);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(321, 23);
            this.plsVisualizza.TabIndex = 7;
            this.plsVisualizza.Text = "VISUALIZZA LISTBOX";
            this.plsVisualizza.UseVisualStyleBackColor = true;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // plsPeso
            // 
            this.plsPeso.Location = new System.Drawing.Point(36, 310);
            this.plsPeso.Name = "plsPeso";
            this.plsPeso.Size = new System.Drawing.Size(321, 23);
            this.plsPeso.TabIndex = 8;
            this.plsPeso.Text = "VISUALIZZA PESO COMPLESSIVO";
            this.plsPeso.UseVisualStyleBackColor = true;
            this.plsPeso.Click += new System.EventHandler(this.plsPeso_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 338);
            this.Controls.Add(this.plsPeso);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCassa);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCasse);
            this.Controls.Add(this.lstPesi);
            this.Name = "frmAvvio";
            this.Text = "Fornitura casse";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPesi;
        private System.Windows.Forms.ListBox lstCasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.TextBox txtCassa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.Button plsPeso;
    }
}

