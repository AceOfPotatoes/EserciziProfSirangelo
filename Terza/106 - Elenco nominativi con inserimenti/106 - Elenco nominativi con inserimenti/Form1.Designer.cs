namespace _106___Elenco_nominativi_con_inserimenti
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
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.plsInserisci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNomi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plsX = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plsLettera = new System.Windows.Forms.Button();
            this.txtLettera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.plsElimina = new System.Windows.Forms.Button();
            this.txtElimina = new System.Windows.Forms.TextBox();
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.plsPulisci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNominativo
            // 
            this.txtNominativo.Location = new System.Drawing.Point(19, 25);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(100, 20);
            this.txtNominativo.TabIndex = 0;
            // 
            // plsInserisci
            // 
            this.plsInserisci.Location = new System.Drawing.Point(19, 51);
            this.plsInserisci.Name = "plsInserisci";
            this.plsInserisci.Size = new System.Drawing.Size(100, 23);
            this.plsInserisci.TabIndex = 1;
            this.plsInserisci.Text = "AGGIUNGI";
            this.plsInserisci.UseVisualStyleBackColor = true;
            this.plsInserisci.Click += new System.EventHandler(this.plsInserisci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMINATIVO";
            // 
            // lstNomi
            // 
            this.lstNomi.FormattingEnabled = true;
            this.lstNomi.Location = new System.Drawing.Point(19, 109);
            this.lstNomi.Name = "lstNomi";
            this.lstNomi.Size = new System.Drawing.Size(100, 134);
            this.lstNomi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // plsX
            // 
            this.plsX.Location = new System.Drawing.Point(161, 220);
            this.plsX.Name = "plsX";
            this.plsX.Size = new System.Drawing.Size(100, 23);
            this.plsX.TabIndex = 8;
            this.plsX.Text = "TUTTI > X?";
            this.plsX.UseVisualStyleBackColor = true;
            this.plsX.Click += new System.EventHandler(this.plsX_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(161, 194);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "LETTERA (A-Z)";
            // 
            // plsLettera
            // 
            this.plsLettera.Location = new System.Drawing.Point(161, 134);
            this.plsLettera.Name = "plsLettera";
            this.plsLettera.Size = new System.Drawing.Size(100, 23);
            this.plsLettera.TabIndex = 11;
            this.plsLettera.Text = "VISUALIZZA";
            this.plsLettera.UseVisualStyleBackColor = true;
            this.plsLettera.Click += new System.EventHandler(this.plsLettera_Click);
            // 
            // txtLettera
            // 
            this.txtLettera.Location = new System.Drawing.Point(161, 108);
            this.txtLettera.Name = "txtLettera";
            this.txtLettera.Size = new System.Drawing.Size(100, 20);
            this.txtLettera.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ELIMINA IN POSIZIONE";
            // 
            // plsElimina
            // 
            this.plsElimina.Location = new System.Drawing.Point(161, 51);
            this.plsElimina.Name = "plsElimina";
            this.plsElimina.Size = new System.Drawing.Size(100, 23);
            this.plsElimina.TabIndex = 14;
            this.plsElimina.Text = "ELIMINA";
            this.plsElimina.UseVisualStyleBackColor = true;
            this.plsElimina.Click += new System.EventHandler(this.plsElimina_Click);
            // 
            // txtElimina
            // 
            this.txtElimina.Location = new System.Drawing.Point(161, 25);
            this.txtElimina.Name = "txtElimina";
            this.txtElimina.Size = new System.Drawing.Size(100, 20);
            this.txtElimina.TabIndex = 13;
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.Location = new System.Drawing.Point(19, 262);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(242, 23);
            this.plsVisualizza.TabIndex = 16;
            this.plsVisualizza.Text = "VISUALIZZA VETTORE IN LISTBOX";
            this.plsVisualizza.UseVisualStyleBackColor = true;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // plsPulisci
            // 
            this.plsPulisci.Location = new System.Drawing.Point(19, 291);
            this.plsPulisci.Name = "plsPulisci";
            this.plsPulisci.Size = new System.Drawing.Size(242, 23);
            this.plsPulisci.TabIndex = 17;
            this.plsPulisci.Text = "PULISCI VETTORE E LISTBOX";
            this.plsPulisci.UseVisualStyleBackColor = true;
            this.plsPulisci.Click += new System.EventHandler(this.plsPulisci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.plsPulisci);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plsElimina);
            this.Controls.Add(this.txtElimina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plsLettera);
            this.Controls.Add(this.txtLettera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plsX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lstNomi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plsInserisci);
            this.Controls.Add(this.txtNominativo);
            this.Name = "Form1";
            this.Text = "Voti con inserimenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNominativo;
        private System.Windows.Forms.Button plsInserisci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNomi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button plsLettera;
        private System.Windows.Forms.TextBox txtLettera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button plsElimina;
        private System.Windows.Forms.TextBox txtElimina;
        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.Button plsPulisci;
    }
}

