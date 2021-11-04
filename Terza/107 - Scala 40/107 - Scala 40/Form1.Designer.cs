namespace _107___Scala_40
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
            this.lstCarte = new System.Windows.Forms.ListBox();
            this.txtCarta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.plsScarta = new System.Windows.Forms.Button();
            this.plsPalo = new System.Windows.Forms.Button();
            this.plsChiuso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCarte
            // 
            this.lstCarte.BackColor = System.Drawing.Color.Maroon;
            this.lstCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarte.ForeColor = System.Drawing.Color.Transparent;
            this.lstCarte.FormattingEnabled = true;
            this.lstCarte.ItemHeight = 20;
            this.lstCarte.Location = new System.Drawing.Point(12, 164);
            this.lstCarte.Name = "lstCarte";
            this.lstCarte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstCarte.Size = new System.Drawing.Size(214, 104);
            this.lstCarte.TabIndex = 0;
            // 
            // txtCarta
            // 
            this.txtCarta.Location = new System.Drawing.Point(12, 33);
            this.txtCarta.Name = "txtCarta";
            this.txtCarta.Size = new System.Drawing.Size(214, 20);
            this.txtCarta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCRIVI QUI LA CARTA DA AGGIUNGERE";
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(12, 59);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(214, 23);
            this.plsAggiungi.TabIndex = 3;
            this.plsAggiungi.Text = "AGGIUNGI CARTA";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // plsScarta
            // 
            this.plsScarta.Location = new System.Drawing.Point(12, 283);
            this.plsScarta.Name = "plsScarta";
            this.plsScarta.Size = new System.Drawing.Size(214, 23);
            this.plsScarta.TabIndex = 4;
            this.plsScarta.Text = "SCARTA UNA CARTA";
            this.plsScarta.UseVisualStyleBackColor = true;
            this.plsScarta.Visible = false;
            this.plsScarta.Click += new System.EventHandler(this.plsScarta_Click);
            // 
            // plsPalo
            // 
            this.plsPalo.Location = new System.Drawing.Point(12, 104);
            this.plsPalo.Name = "plsPalo";
            this.plsPalo.Size = new System.Drawing.Size(94, 36);
            this.plsPalo.TabIndex = 6;
            this.plsPalo.Text = "STESSO PALO?";
            this.plsPalo.UseVisualStyleBackColor = true;
            this.plsPalo.Click += new System.EventHandler(this.plsPalo_Click);
            // 
            // plsChiuso
            // 
            this.plsChiuso.Location = new System.Drawing.Point(132, 104);
            this.plsChiuso.Name = "plsChiuso";
            this.plsChiuso.Size = new System.Drawing.Size(94, 36);
            this.plsChiuso.TabIndex = 7;
            this.plsChiuso.Text = "HAI CHIUSO?";
            this.plsChiuso.UseVisualStyleBackColor = true;
            this.plsChiuso.Click += new System.EventHandler(this.plsChiuso_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 320);
            this.Controls.Add(this.plsChiuso);
            this.Controls.Add(this.plsPalo);
            this.Controls.Add(this.plsScarta);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarta);
            this.Controls.Add(this.lstCarte);
            this.Name = "frmAvvio";
            this.Text = "Scala 40";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarte;
        private System.Windows.Forms.TextBox txtCarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Button plsScarta;
        private System.Windows.Forms.Button plsPalo;
        private System.Windows.Forms.Button plsChiuso;
    }
}

