namespace _87___Numeri_primi_fino_ad_N
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
            this.label2 = new System.Windows.Forms.Label();
            this.plsMostra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato un intero N, il software visualizzerà tutti i numeri primi a partire da 2 fi" +
    "no ad N.";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(15, 52);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(382, 20);
            this.txtN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N";
            // 
            // plsMostra
            // 
            this.plsMostra.Location = new System.Drawing.Point(15, 86);
            this.plsMostra.Name = "plsMostra";
            this.plsMostra.Size = new System.Drawing.Size(382, 23);
            this.plsMostra.TabIndex = 3;
            this.plsMostra.Text = "MOSTRAMI I NUMERI PRIMI";
            this.plsMostra.UseVisualStyleBackColor = true;
            this.plsMostra.Click += new System.EventHandler(this.plsMostra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 121);
            this.Controls.Add(this.plsMostra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numeri primi fino ad N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plsMostra;
    }
}

