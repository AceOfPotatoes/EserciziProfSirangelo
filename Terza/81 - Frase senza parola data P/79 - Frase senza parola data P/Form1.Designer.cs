namespace _79___Frase_senza_parola_data_P
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
            this.txtF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plsNuovaF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data una frase ed una parola (presente una sola volta in F), il software visualiz" +
    "zerà la stessa frase, privata della parola data.";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(15, 68);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(583, 20);
            this.txtF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frase";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(254, 143);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola";
            // 
            // plsNuovaF
            // 
            this.plsNuovaF.Location = new System.Drawing.Point(15, 192);
            this.plsNuovaF.Name = "plsNuovaF";
            this.plsNuovaF.Size = new System.Drawing.Size(583, 23);
            this.plsNuovaF.TabIndex = 5;
            this.plsNuovaF.Text = "DAMMI LA FRASE SENZA LA PAROLA";
            this.plsNuovaF.UseVisualStyleBackColor = true;
            this.plsNuovaF.Click += new System.EventHandler(this.plsNuovaF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 227);
            this.Controls.Add(this.plsNuovaF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Frase senza parola data P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsNuovaF;
    }
}

