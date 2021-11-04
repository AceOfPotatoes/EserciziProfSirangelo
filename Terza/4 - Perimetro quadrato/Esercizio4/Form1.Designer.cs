namespace Esercizio4
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
            this.txtLato = new System.Windows.Forms.TextBox();
            this.plsCalcola = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci qui il lato del quadrato";
            // 
            // txtLato
            // 
            this.txtLato.Location = new System.Drawing.Point(90, 53);
            this.txtLato.Name = "txtLato";
            this.txtLato.Size = new System.Drawing.Size(100, 20);
            this.txtLato.TabIndex = 1;
            // 
            // plsCalcola
            // 
            this.plsCalcola.Location = new System.Drawing.Point(90, 97);
            this.plsCalcola.Name = "plsCalcola";
            this.plsCalcola.Size = new System.Drawing.Size(100, 35);
            this.plsCalcola.TabIndex = 2;
            this.plsCalcola.Text = "CALCOLA";
            this.plsCalcola.UseVisualStyleBackColor = true;
            this.plsCalcola.Click += new System.EventHandler(this.plsCalcola_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Il perimetro del quadrato misura";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(187, 185);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plsCalcola);
            this.Controls.Add(this.txtLato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcolo Perimetro Quadrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLato;
        private System.Windows.Forms.Button plsCalcola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerimetro;
    }
}

