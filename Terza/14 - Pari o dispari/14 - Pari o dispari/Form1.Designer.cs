namespace _14___Pari_o_dispari
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.plsVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserito un numero, determina se esso è pari o dispari";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(104, 35);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(71, 20);
            this.txtN.TabIndex = 1;
            // 
            // plsVerifica
            // 
            this.plsVerifica.Location = new System.Drawing.Point(104, 77);
            this.plsVerifica.Name = "plsVerifica";
            this.plsVerifica.Size = new System.Drawing.Size(71, 29);
            this.plsVerifica.TabIndex = 2;
            this.plsVerifica.Text = "VERIFICA";
            this.plsVerifica.UseVisualStyleBackColor = true;
            this.plsVerifica.Click += new System.EventHandler(this.plsVerifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.plsVerifica);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pari o dispari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button plsVerifica;
    }
}

