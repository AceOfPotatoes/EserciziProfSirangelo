namespace _109___Ordinamento_e_ricerca_nominativi
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
            this.lstDisordinata = new System.Windows.Forms.ListBox();
            this.lstOrdinata = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plsInserisci = new System.Windows.Forms.Button();
            this.plsRicerca = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plsOrdina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDisordinata
            // 
            this.lstDisordinata.FormattingEnabled = true;
            this.lstDisordinata.Location = new System.Drawing.Point(12, 192);
            this.lstDisordinata.Name = "lstDisordinata";
            this.lstDisordinata.Size = new System.Drawing.Size(221, 199);
            this.lstDisordinata.TabIndex = 0;
            // 
            // lstOrdinata
            // 
            this.lstOrdinata.FormattingEnabled = true;
            this.lstOrdinata.Location = new System.Drawing.Point(286, 192);
            this.lstOrdinata.Name = "lstOrdinata";
            this.lstOrdinata.Size = new System.Drawing.Size(221, 199);
            this.lstOrdinata.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsInserisci
            // 
            this.plsInserisci.Location = new System.Drawing.Point(182, 127);
            this.plsInserisci.Name = "plsInserisci";
            this.plsInserisci.Size = new System.Drawing.Size(75, 23);
            this.plsInserisci.TabIndex = 3;
            this.plsInserisci.Text = "INSERISCI";
            this.plsInserisci.UseVisualStyleBackColor = true;
            this.plsInserisci.Click += new System.EventHandler(this.plsInserisci_Click);
            // 
            // plsRicerca
            // 
            this.plsRicerca.Location = new System.Drawing.Point(263, 127);
            this.plsRicerca.Name = "plsRicerca";
            this.plsRicerca.Size = new System.Drawing.Size(75, 23);
            this.plsRicerca.TabIndex = 4;
            this.plsRicerca.Text = "RICERCA";
            this.plsRicerca.UseVisualStyleBackColor = true;
            this.plsRicerca.Click += new System.EventHandler(this.plsRicerca_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(182, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMINATIVO";
            // 
            // plsOrdina
            // 
            this.plsOrdina.Location = new System.Drawing.Point(182, 156);
            this.plsOrdina.Name = "plsOrdina";
            this.plsOrdina.Size = new System.Drawing.Size(156, 23);
            this.plsOrdina.TabIndex = 7;
            this.plsOrdina.Text = "ORDINA";
            this.plsOrdina.UseVisualStyleBackColor = true;
            this.plsOrdina.Click += new System.EventHandler(this.plsOrdina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "LISTA DISORDINATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "LISTA ORDINATA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plsOrdina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.plsRicerca);
            this.Controls.Add(this.plsInserisci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOrdinata);
            this.Controls.Add(this.lstDisordinata);
            this.Name = "Form1";
            this.Text = "Ordinamento e ricerca nominativi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisordinata;
        private System.Windows.Forms.ListBox lstOrdinata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsInserisci;
        private System.Windows.Forms.Button plsRicerca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plsOrdina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

