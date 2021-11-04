namespace _98___Totocalcio
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
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.cmbSq1 = new System.Windows.Forms.ComboBox();
            this.cmbSq2 = new System.Windows.Forms.ComboBox();
            this.numSq1 = new System.Windows.Forms.NumericUpDown();
            this.numSq2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.plsTotocalcio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSq2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstElenco
            // 
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 15;
            this.lstElenco.Location = new System.Drawing.Point(18, 83);
            this.lstElenco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(140, 304);
            this.lstElenco.TabIndex = 1;
            // 
            // cmbSq1
            // 
            this.cmbSq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSq1.FormattingEnabled = true;
            this.cmbSq1.Location = new System.Drawing.Point(218, 169);
            this.cmbSq1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSq1.Name = "cmbSq1";
            this.cmbSq1.Size = new System.Drawing.Size(140, 23);
            this.cmbSq1.TabIndex = 2;
            // 
            // cmbSq2
            // 
            this.cmbSq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSq2.FormattingEnabled = true;
            this.cmbSq2.Location = new System.Drawing.Point(423, 169);
            this.cmbSq2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSq2.Name = "cmbSq2";
            this.cmbSq2.Size = new System.Drawing.Size(140, 23);
            this.cmbSq2.TabIndex = 3;
            this.cmbSq2.SelectedIndexChanged += new System.EventHandler(this.cmbSq2_SelectedIndexChanged);
            // 
            // numSq1
            // 
            this.numSq1.Location = new System.Drawing.Point(218, 262);
            this.numSq1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSq1.Name = "numSq1";
            this.numSq1.Size = new System.Drawing.Size(141, 21);
            this.numSq1.TabIndex = 4;
            // 
            // numSq2
            // 
            this.numSq2.Location = new System.Drawing.Point(423, 262);
            this.numSq2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSq2.Name = "numSq2";
            this.numSq2.Size = new System.Drawing.Size(141, 21);
            this.numSq2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Squadra 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Squadra 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "GOL Squadra 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "GOL Squadra 2";
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(218, 83);
            this.plsAggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(346, 26);
            this.plsAggiungi.TabIndex = 10;
            this.plsAggiungi.Text = "AGGIUNGI SQUADRA";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Simbolo Totocalcio:";
            // 
            // lblRisultato
            // 
            this.lblRisultato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.ForeColor = System.Drawing.Color.White;
            this.lblRisultato.Location = new System.Drawing.Point(397, 364);
            this.lblRisultato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(95, 23);
            this.lblRisultato.TabIndex = 12;
            this.lblRisultato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsTotocalcio
            // 
            this.plsTotocalcio.Location = new System.Drawing.Point(218, 315);
            this.plsTotocalcio.Name = "plsTotocalcio";
            this.plsTotocalcio.Size = new System.Drawing.Size(346, 23);
            this.plsTotocalcio.TabIndex = 13;
            this.plsTotocalcio.Text = "MOSTRAMI IL SIMBOLO DEL TOTOCALCIO";
            this.plsTotocalcio.UseVisualStyleBackColor = true;
            this.plsTotocalcio.Click += new System.EventHandler(this.plsTotocalcio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 426);
            this.Controls.Add(this.plsTotocalcio);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSq2);
            this.Controls.Add(this.numSq1);
            this.Controls.Add(this.cmbSq2);
            this.Controls.Add(this.cmbSq1);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Totocalcio";
            ((System.ComponentModel.ISupportInitialize)(this.numSq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSq2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstElenco;
        private System.Windows.Forms.ComboBox cmbSq1;
        private System.Windows.Forms.ComboBox cmbSq2;
        private System.Windows.Forms.NumericUpDown numSq1;
        private System.Windows.Forms.NumericUpDown numSq2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Button plsTotocalcio;
    }
}

