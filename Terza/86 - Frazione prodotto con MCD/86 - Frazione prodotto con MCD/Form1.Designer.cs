namespace _86___MCD_con_metodo_di_Euclide
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.plsCalcola = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date due frazioni del tipo N1/D1 e N2/D2.\r\nIl software calcolerà la propria frazi" +
    "one prodotto ridotta ai minimi termini.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(47, 77);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(50, 20);
            this.txtN1.TabIndex = 1;
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(47, 129);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(50, 20);
            this.txtD1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "____________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "D1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "D2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "N2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "____________";
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(256, 129);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(50, 20);
            this.txtD2.TabIndex = 7;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(256, 77);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(50, 20);
            this.txtN2.TabIndex = 6;
            // 
            // plsCalcola
            // 
            this.plsCalcola.Location = new System.Drawing.Point(15, 201);
            this.plsCalcola.Name = "plsCalcola";
            this.plsCalcola.Size = new System.Drawing.Size(335, 23);
            this.plsCalcola.TabIndex = 11;
            this.plsCalcola.Text = "CALCOLA";
            this.plsCalcola.UseVisualStyleBackColor = true;
            this.plsCalcola.Click += new System.EventHandler(this.plsCalcola_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(143, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "____________";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.Red;
            this.lblN.Location = new System.Drawing.Point(162, 242);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 20);
            this.lblN.TabIndex = 13;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.Red;
            this.lblD.Location = new System.Drawing.Point(162, 287);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(0, 20);
            this.lblD.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 328);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.plsCalcola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Frazione prodotto con M.C.D.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button plsCalcola;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblD;
    }
}

