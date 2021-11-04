namespace _16___Valore_assoluto
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.plsDetermina = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAssoluto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato un numero reale, viene determinato il suo \r\nvalore assoluto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(93, 49);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // plsDetermina
            // 
            this.plsDetermina.Location = new System.Drawing.Point(93, 82);
            this.plsDetermina.Name = "plsDetermina";
            this.plsDetermina.Size = new System.Drawing.Size(100, 34);
            this.plsDetermina.TabIndex = 2;
            this.plsDetermina.Text = "DETERMINA";
            this.plsDetermina.UseVisualStyleBackColor = true;
            this.plsDetermina.Click += new System.EventHandler(this.plsDetermina_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(70, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "|X| = ";
            // 
            // lblAssoluto
            // 
            this.lblAssoluto.AutoSize = true;
            this.lblAssoluto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAssoluto.Location = new System.Drawing.Point(129, 119);
            this.lblAssoluto.Name = "lblAssoluto";
            this.lblAssoluto.Size = new System.Drawing.Size(0, 26);
            this.lblAssoluto.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.lblAssoluto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plsDetermina);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Valore assoluto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button plsDetermina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAssoluto;
    }
}

