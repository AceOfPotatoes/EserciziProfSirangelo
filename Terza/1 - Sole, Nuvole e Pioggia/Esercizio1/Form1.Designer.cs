namespace Esercizio1
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
            this.plsSole = new System.Windows.Forms.Button();
            this.plsNuvoloso = new System.Windows.Forms.Button();
            this.plsPioggia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plsSole
            // 
            this.plsSole.Location = new System.Drawing.Point(69, 12);
            this.plsSole.Name = "plsSole";
            this.plsSole.Size = new System.Drawing.Size(144, 28);
            this.plsSole.TabIndex = 0;
            this.plsSole.Text = "SOLE";
            this.plsSole.UseVisualStyleBackColor = true;
            this.plsSole.Click += new System.EventHandler(this.plsSole_Click);
            // 
            // plsNuvoloso
            // 
            this.plsNuvoloso.Location = new System.Drawing.Point(69, 117);
            this.plsNuvoloso.Name = "plsNuvoloso";
            this.plsNuvoloso.Size = new System.Drawing.Size(144, 28);
            this.plsNuvoloso.TabIndex = 1;
            this.plsNuvoloso.Text = "NUVOLE";
            this.plsNuvoloso.UseVisualStyleBackColor = true;
            this.plsNuvoloso.Click += new System.EventHandler(this.plsNuvoloso_Click);
            // 
            // plsPioggia
            // 
            this.plsPioggia.Location = new System.Drawing.Point(69, 222);
            this.plsPioggia.Name = "plsPioggia";
            this.plsPioggia.Size = new System.Drawing.Size(144, 28);
            this.plsPioggia.TabIndex = 2;
            this.plsPioggia.Text = "PIOGGIA";
            this.plsPioggia.UseVisualStyleBackColor = true;
            this.plsPioggia.Click += new System.EventHandler(this.plsPioggia_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.plsPioggia);
            this.Controls.Add(this.plsNuvoloso);
            this.Controls.Add(this.plsSole);
            this.Name = "Form1";
            this.Text = "Meteo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plsSole;
        private System.Windows.Forms.Button plsNuvoloso;
        private System.Windows.Forms.Button plsPioggia;
    }
}

