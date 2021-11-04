namespace P1___Area_quadrato_e_restante
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.plsCalcola = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAq = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "L1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "L2";
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(46, 59);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(61, 20);
            this.txtL1.TabIndex = 2;
            // 
            // txtL2
            // 
            this.txtL2.Location = new System.Drawing.Point(174, 59);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(61, 20);
            this.txtL2.TabIndex = 3;
            // 
            // plsCalcola
            // 
            this.plsCalcola.Location = new System.Drawing.Point(106, 105);
            this.plsCalcola.Name = "plsCalcola";
            this.plsCalcola.Size = new System.Drawing.Size(69, 26);
            this.plsCalcola.TabIndex = 4;
            this.plsCalcola.Text = "CALCOLA";
            this.plsCalcola.UseVisualStyleBackColor = true;
            this.plsCalcola.Click += new System.EventHandler(this.plsCalcola_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dati i lati L1 ed L2, calcola l\'area del quadrato costruito su \r\nL1 e l\'area rest" +
    "ante all\'interno del rettangolo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Area quadrato L1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Area restante rettangolo:";
            // 
            // lblAq
            // 
            this.lblAq.AutoSize = true;
            this.lblAq.Location = new System.Drawing.Point(140, 176);
            this.lblAq.Name = "lblAq";
            this.lblAq.Size = new System.Drawing.Size(0, 13);
            this.lblAq.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // lblAr
            // 
            this.lblAr.AutoSize = true;
            this.lblAr.Location = new System.Drawing.Point(140, 201);
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(0, 13);
            this.lblAr.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plsCalcola);
            this.Controls.Add(this.txtL2);
            this.Controls.Add(this.txtL1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.Button plsCalcola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAr;
    }
}

