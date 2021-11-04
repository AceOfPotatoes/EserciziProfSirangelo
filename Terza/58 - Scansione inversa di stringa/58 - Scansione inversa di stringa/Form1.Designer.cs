namespace _58___Scansione_inversa_di_stringa
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
            this.plsStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Una volta premuto il pulsante viene richiesta la parola da scansionare. \r\nDopodic" +
    "hè verrà visualizzata la sua scansione inversa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsStart
            // 
            this.plsStart.Location = new System.Drawing.Point(12, 69);
            this.plsStart.Name = "plsStart";
            this.plsStart.Size = new System.Drawing.Size(336, 29);
            this.plsStart.TabIndex = 1;
            this.plsStart.Text = "INIZIA";
            this.plsStart.UseVisualStyleBackColor = true;
            this.plsStart.Click += new System.EventHandler(this.plsStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 110);
            this.Controls.Add(this.plsStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Scansione inversa di stringa";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsStart;
    }
}

