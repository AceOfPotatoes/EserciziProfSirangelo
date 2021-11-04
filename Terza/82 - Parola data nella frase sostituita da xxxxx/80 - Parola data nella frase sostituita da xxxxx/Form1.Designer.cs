namespace _80___Parola_data_nella_frase_sostituita_da_xxxxx
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblFF = new System.Windows.Forms.Label();
            this.plsVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data una parola ed una frase, il software farà uscire nella label una nuova frase" +
    ",\r\ndove al posto della parola verranno visualizzate cinque x, e dirà quante volt" +
    "e la parola è presente nella frase. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(12, 92);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(515, 20);
            this.txtF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frase";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(222, 153);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NUOVA FRASE:";
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.ForeColor = System.Drawing.Color.Red;
            this.lblFF.Location = new System.Drawing.Point(149, 266);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(0, 20);
            this.lblFF.TabIndex = 6;
            // 
            // plsVerifica
            // 
            this.plsVerifica.Location = new System.Drawing.Point(16, 210);
            this.plsVerifica.Name = "plsVerifica";
            this.plsVerifica.Size = new System.Drawing.Size(511, 23);
            this.plsVerifica.TabIndex = 7;
            this.plsVerifica.Text = "VERIFICA E DAMMI LA NUOVA FRASE";
            this.plsVerifica.UseVisualStyleBackColor = true;
            this.plsVerifica.Click += new System.EventHandler(this.plsVerifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 295);
            this.Controls.Add(this.plsVerifica);
            this.Controls.Add(this.lblFF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parola data nella frase sostituita da \"xxxxx\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.Button plsVerifica;
    }
}

