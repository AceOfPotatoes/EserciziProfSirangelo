namespace WindowsFormsApplication1
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
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plsOrdinale = new System.Windows.Forms.Button();
            this.plsNonOrdinale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date due parole P1 e P2, il software potrà controllare, tramite metodo non ordina" +
    "le o ordinale, quale delle due è più lunga";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(15, 62);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 1;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(483, 62);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "P1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P2";
            // 
            // plsOrdinale
            // 
            this.plsOrdinale.Location = new System.Drawing.Point(12, 97);
            this.plsOrdinale.Name = "plsOrdinale";
            this.plsOrdinale.Size = new System.Drawing.Size(571, 23);
            this.plsOrdinale.TabIndex = 5;
            this.plsOrdinale.Text = "VERIFICA CON METODO ORDINALE";
            this.plsOrdinale.UseVisualStyleBackColor = true;
            this.plsOrdinale.Click += new System.EventHandler(this.plsOrdinale_Click);
            // 
            // plsNonOrdinale
            // 
            this.plsNonOrdinale.Location = new System.Drawing.Point(12, 144);
            this.plsNonOrdinale.Name = "plsNonOrdinale";
            this.plsNonOrdinale.Size = new System.Drawing.Size(571, 23);
            this.plsNonOrdinale.TabIndex = 6;
            this.plsNonOrdinale.Text = "VERIFICA CON METODO NON ORDINALE";
            this.plsNonOrdinale.UseVisualStyleBackColor = true;
            this.plsNonOrdinale.Click += new System.EventHandler(this.plsNonOrdinale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 185);
            this.Controls.Add(this.plsNonOrdinale);
            this.Controls.Add(this.plsOrdinale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Confronto P1 e P2 con entrambi i metodi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsOrdinale;
        private System.Windows.Forms.Button plsNonOrdinale;
    }
}

