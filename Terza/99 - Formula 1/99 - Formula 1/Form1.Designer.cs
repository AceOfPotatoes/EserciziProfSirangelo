namespace _99___Formula_1
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
            this.lbl = new System.Windows.Forms.Label();
            this.lstPiloti = new System.Windows.Forms.ListBox();
            this.lstRitirati = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plsAvanza = new System.Windows.Forms.Button();
            this.plsArretra = new System.Windows.Forms.Button();
            this.plsRitira = new System.Windows.Forms.Button();
            this.plsPunteggio = new System.Windows.Forms.Button();
            this.plsTermina = new System.Windows.Forms.Button();
            this.cmbPiloti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(585, 65);
            this.lbl.TabIndex = 0;
            this.lbl.Text = resources.GetString("lbl.Text");
            // 
            // lstPiloti
            // 
            this.lstPiloti.FormattingEnabled = true;
            this.lstPiloti.Location = new System.Drawing.Point(15, 112);
            this.lstPiloti.Name = "lstPiloti";
            this.lstPiloti.Size = new System.Drawing.Size(148, 368);
            this.lstPiloti.TabIndex = 1;
            // 
            // lstRitirati
            // 
            this.lstRitirati.FormattingEnabled = true;
            this.lstRitirati.Location = new System.Drawing.Point(423, 369);
            this.lstRitirati.Name = "lstRitirati";
            this.lstRitirati.Size = new System.Drawing.Size(148, 108);
            this.lstRitirati.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piloti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(470, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ritirati";
            // 
            // plsAvanza
            // 
            this.plsAvanza.Location = new System.Drawing.Point(199, 162);
            this.plsAvanza.Name = "plsAvanza";
            this.plsAvanza.Size = new System.Drawing.Size(174, 41);
            this.plsAvanza.TabIndex = 5;
            this.plsAvanza.Text = "FAI AVANZARE SELEZIONATO";
            this.plsAvanza.UseVisualStyleBackColor = true;
            this.plsAvanza.Click += new System.EventHandler(this.plsAvanza_Click);
            // 
            // plsArretra
            // 
            this.plsArretra.Location = new System.Drawing.Point(199, 209);
            this.plsArretra.Name = "plsArretra";
            this.plsArretra.Size = new System.Drawing.Size(174, 41);
            this.plsArretra.TabIndex = 6;
            this.plsArretra.Text = "FAI ARRETRARE SELEZIONATO";
            this.plsArretra.UseVisualStyleBackColor = true;
            this.plsArretra.Click += new System.EventHandler(this.plsArretra_Click);
            // 
            // plsRitira
            // 
            this.plsRitira.Location = new System.Drawing.Point(199, 256);
            this.plsRitira.Name = "plsRitira";
            this.plsRitira.Size = new System.Drawing.Size(174, 41);
            this.plsRitira.TabIndex = 7;
            this.plsRitira.Text = "RITIRA SELEZIONATO";
            this.plsRitira.UseVisualStyleBackColor = true;
            this.plsRitira.Click += new System.EventHandler(this.plsRitira_Click);
            // 
            // plsPunteggio
            // 
            this.plsPunteggio.Location = new System.Drawing.Point(423, 231);
            this.plsPunteggio.Name = "plsPunteggio";
            this.plsPunteggio.Size = new System.Drawing.Size(174, 41);
            this.plsPunteggio.TabIndex = 8;
            this.plsPunteggio.Text = "PUNTEGGIO PROVVISORIO SELEZIONATO";
            this.plsPunteggio.UseVisualStyleBackColor = true;
            this.plsPunteggio.Click += new System.EventHandler(this.plsPunteggio_Click);
            // 
            // plsTermina
            // 
            this.plsTermina.Location = new System.Drawing.Point(199, 303);
            this.plsTermina.Name = "plsTermina";
            this.plsTermina.Size = new System.Drawing.Size(174, 41);
            this.plsTermina.TabIndex = 9;
            this.plsTermina.Text = "TERMINA GARA";
            this.plsTermina.UseVisualStyleBackColor = true;
            this.plsTermina.Click += new System.EventHandler(this.plsTermina_Click);
            // 
            // cmbPiloti
            // 
            this.cmbPiloti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPiloti.FormattingEnabled = true;
            this.cmbPiloti.Location = new System.Drawing.Point(449, 204);
            this.cmbPiloti.Name = "cmbPiloti";
            this.cmbPiloti.Size = new System.Drawing.Size(121, 21);
            this.cmbPiloti.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(487, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Piloti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPiloti);
            this.Controls.Add(this.plsTermina);
            this.Controls.Add(this.plsPunteggio);
            this.Controls.Add(this.plsRitira);
            this.Controls.Add(this.plsArretra);
            this.Controls.Add(this.plsAvanza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRitirati);
            this.Controls.Add(this.lstPiloti);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Formula 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListBox lstPiloti;
        private System.Windows.Forms.ListBox lstRitirati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsAvanza;
        private System.Windows.Forms.Button plsArretra;
        private System.Windows.Forms.Button plsRitira;
        private System.Windows.Forms.Button plsPunteggio;
        private System.Windows.Forms.Button plsTermina;
        private System.Windows.Forms.ComboBox cmbPiloti;
        private System.Windows.Forms.Label label1;
    }
}

