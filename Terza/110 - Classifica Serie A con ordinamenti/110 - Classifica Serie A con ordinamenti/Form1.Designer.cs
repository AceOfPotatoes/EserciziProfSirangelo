namespace _110___Classifica_Serie_A_con_ordinamenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvvio));
            this.label1 = new System.Windows.Forms.Label();
            this.lstSquadre = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPunteggio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.plsNome = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtControlla = new System.Windows.Forms.TextBox();
            this.plsControlla = new System.Windows.Forms.Button();
            this.plsPunteggio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSquadre
            // 
            this.lstSquadre.FormattingEnabled = true;
            this.lstSquadre.Location = new System.Drawing.Point(217, 184);
            this.lstSquadre.Name = "lstSquadre";
            this.lstSquadre.Size = new System.Drawing.Size(258, 238);
            this.lstSquadre.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(217, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome squadra";
            // 
            // txtPunteggio
            // 
            this.txtPunteggio.Location = new System.Drawing.Point(375, 89);
            this.txtPunteggio.Name = "txtPunteggio";
            this.txtPunteggio.Size = new System.Drawing.Size(100, 20);
            this.txtPunteggio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Punteggio squadra";
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(217, 115);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(258, 23);
            this.plsAggiungi.TabIndex = 6;
            this.plsAggiungi.Text = "AGGIUNGI SQUADRA";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.plsAggiungi_Click);
            // 
            // plsNome
            // 
            this.plsNome.Location = new System.Drawing.Point(217, 144);
            this.plsNome.Name = "plsNome";
            this.plsNome.Size = new System.Drawing.Size(121, 23);
            this.plsNome.TabIndex = 7;
            this.plsNome.Text = "PER NOME";
            this.plsNome.UseVisualStyleBackColor = true;
            this.plsNome.Click += new System.EventHandler(this.plsNome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Punteggio da controllare";
            // 
            // txtControlla
            // 
            this.txtControlla.Location = new System.Drawing.Point(49, 200);
            this.txtControlla.Name = "txtControlla";
            this.txtControlla.Size = new System.Drawing.Size(100, 20);
            this.txtControlla.TabIndex = 8;
            // 
            // plsControlla
            // 
            this.plsControlla.Location = new System.Drawing.Point(49, 226);
            this.plsControlla.Name = "plsControlla";
            this.plsControlla.Size = new System.Drawing.Size(100, 23);
            this.plsControlla.TabIndex = 10;
            this.plsControlla.Text = "CONTROLLA";
            this.plsControlla.UseVisualStyleBackColor = true;
            this.plsControlla.Click += new System.EventHandler(this.plsControlla_Click);
            // 
            // plsPunteggio
            // 
            this.plsPunteggio.Location = new System.Drawing.Point(354, 144);
            this.plsPunteggio.Name = "plsPunteggio";
            this.plsPunteggio.Size = new System.Drawing.Size(121, 23);
            this.plsPunteggio.TabIndex = 11;
            this.plsPunteggio.Text = "PER PUNTEGGIO";
            this.plsPunteggio.UseVisualStyleBackColor = true;
            this.plsPunteggio.Click += new System.EventHandler(this.plsPunteggio_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 497);
            this.Controls.Add(this.plsPunteggio);
            this.Controls.Add(this.plsControlla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtControlla);
            this.Controls.Add(this.plsNome);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPunteggio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lstSquadre);
            this.Controls.Add(this.label1);
            this.Name = "frmAvvio";
            this.Text = "Campionato Serie A con ordinamenti";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSquadre;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPunteggio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Button plsNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtControlla;
        private System.Windows.Forms.Button plsControlla;
        private System.Windows.Forms.Button plsPunteggio;
    }
}

