namespace _24___Scuola_calcio
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
            this.txtAnni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plsVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnni
            // 
            this.txtAnni.Location = new System.Drawing.Point(75, 27);
            this.txtAnni.Name = "txtAnni";
            this.txtAnni.Size = new System.Drawing.Size(100, 20);
            this.txtAnni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Età ragazzo";
            // 
            // plsVerifica
            // 
            this.plsVerifica.Location = new System.Drawing.Point(75, 53);
            this.plsVerifica.Name = "plsVerifica";
            this.plsVerifica.Size = new System.Drawing.Size(100, 26);
            this.plsVerifica.TabIndex = 2;
            this.plsVerifica.Text = "E\' iscrivibile?";
            this.plsVerifica.UseVisualStyleBackColor = true;
            this.plsVerifica.Click += new System.EventHandler(this.plsVerifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 91);
            this.Controls.Add(this.plsVerifica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnni);
            this.Name = "Form1";
            this.Text = "Scuola calcio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsVerifica;
    }
}

