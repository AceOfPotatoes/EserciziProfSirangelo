namespace _60___Numero_di_0_ed_1_in_stringa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStringa = new System.Windows.Forms.TextBox();
            this.plsControlla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data una sequenza di 0 ed 1, il software visualizzerà il numero di 0 e di 1 all\'i" +
    "nterno della stringa stessa";
            // 
            // txtStringa
            // 
            this.txtStringa.Location = new System.Drawing.Point(15, 35);
            this.txtStringa.Name = "txtStringa";
            this.txtStringa.Size = new System.Drawing.Size(484, 20);
            this.txtStringa.TabIndex = 1;
            // 
            // plsControlla
            // 
            this.plsControlla.Location = new System.Drawing.Point(15, 70);
            this.plsControlla.Name = "plsControlla";
            this.plsControlla.Size = new System.Drawing.Size(484, 23);
            this.plsControlla.TabIndex = 2;
            this.plsControlla.Text = "CONTROLLA";
            this.plsControlla.UseVisualStyleBackColor = true;
            this.plsControlla.Click += new System.EventHandler(this.plsControlla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 102);
            this.Controls.Add(this.plsControlla);
            this.Controls.Add(this.txtStringa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numero di 0 ed 1 nella stringa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStringa;
        private System.Windows.Forms.Button plsControlla;
    }
}

