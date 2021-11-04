namespace _53___Somma_positivi_e_negativi_in_lista
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
            this.plsInizia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblNeg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dati i numeri interi positivi o negativi nella lista (terminata dal numero ZERO)\r" +
    "\nIl software visualizzerà distintamente la somma degli\r\ninteri positivi e quelli" +
    " negativi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsInizia
            // 
            this.plsInizia.Location = new System.Drawing.Point(87, 62);
            this.plsInizia.Name = "plsInizia";
            this.plsInizia.Size = new System.Drawing.Size(246, 36);
            this.plsInizia.TabIndex = 1;
            this.plsInizia.Text = "INIZIA";
            this.plsInizia.UseVisualStyleBackColor = true;
            this.plsInizia.Click += new System.EventHandler(this.plsInizia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Somma positivi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Somma negativi:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.BackColor = System.Drawing.Color.Red;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPos.Location = new System.Drawing.Point(256, 118);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(17, 18);
            this.lblPos.TabIndex = 4;
            this.lblPos.Text = "_";
            // 
            // lblNeg
            // 
            this.lblNeg.AutoSize = true;
            this.lblNeg.BackColor = System.Drawing.Color.Black;
            this.lblNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNeg.Location = new System.Drawing.Point(256, 147);
            this.lblNeg.Name = "lblNeg";
            this.lblNeg.Size = new System.Drawing.Size(17, 18);
            this.lblNeg.TabIndex = 5;
            this.lblNeg.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 192);
            this.Controls.Add(this.lblNeg);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plsInizia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Somma positivi e negativi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsInizia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblNeg;
    }
}

