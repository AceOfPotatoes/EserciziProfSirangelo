namespace _64___Vocali_e_consonanti
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
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVocali = new System.Windows.Forms.Label();
            this.lblConsonanti = new System.Windows.Forms.Label();
            this.plsControlla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data una frase (scritta rigorosamente in maiuscolo),\r\nil software visualizzerà in" +
    " distinte label vocali e consonanti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(15, 96);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(275, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "La tua frase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "VOCALI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONSONANTI:";
            // 
            // lblVocali
            // 
            this.lblVocali.AutoSize = true;
            this.lblVocali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocali.Location = new System.Drawing.Point(146, 193);
            this.lblVocali.Name = "lblVocali";
            this.lblVocali.Size = new System.Drawing.Size(0, 20);
            this.lblVocali.TabIndex = 5;
            // 
            // lblConsonanti
            // 
            this.lblConsonanti.AutoSize = true;
            this.lblConsonanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsonanti.Location = new System.Drawing.Point(146, 223);
            this.lblConsonanti.Name = "lblConsonanti";
            this.lblConsonanti.Size = new System.Drawing.Size(0, 20);
            this.lblConsonanti.TabIndex = 6;
            // 
            // plsControlla
            // 
            this.plsControlla.Location = new System.Drawing.Point(15, 138);
            this.plsControlla.Name = "plsControlla";
            this.plsControlla.Size = new System.Drawing.Size(275, 23);
            this.plsControlla.TabIndex = 7;
            this.plsControlla.Text = "CONTROLLA";
            this.plsControlla.UseVisualStyleBackColor = true;
            this.plsControlla.Click += new System.EventHandler(this.plsControlla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 252);
            this.Controls.Add(this.plsControlla);
            this.Controls.Add(this.lblConsonanti);
            this.Controls.Add(this.lblVocali);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consonanti e vocali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVocali;
        private System.Windows.Forms.Label lblConsonanti;
        private System.Windows.Forms.Button plsControlla;
    }
}

