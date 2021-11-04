namespace _85___Controlli_su_frase_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plsControlla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpazio = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblPunt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(15, 129);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(517, 20);
            this.txtF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "F";
            // 
            // plsControlla
            // 
            this.plsControlla.Location = new System.Drawing.Point(15, 170);
            this.plsControlla.Name = "plsControlla";
            this.plsControlla.Size = new System.Drawing.Size(517, 23);
            this.plsControlla.TabIndex = 3;
            this.plsControlla.Text = "EFFETTUA I CONTROLLI";
            this.plsControlla.UseVisualStyleBackColor = true;
            this.plsControlla.Click += new System.EventHandler(this.plsControlla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° di \' \':";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "N° di \'A\':";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "N° di <segno di punteggiatura>:";
            // 
            // lblSpazio
            // 
            this.lblSpazio.AutoSize = true;
            this.lblSpazio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpazio.ForeColor = System.Drawing.Color.Red;
            this.lblSpazio.Location = new System.Drawing.Point(278, 208);
            this.lblSpazio.Name = "lblSpazio";
            this.lblSpazio.Size = new System.Drawing.Size(0, 20);
            this.lblSpazio.TabIndex = 7;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Red;
            this.lblA.Location = new System.Drawing.Point(278, 239);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 20);
            this.lblA.TabIndex = 9;
            // 
            // lblPunt
            // 
            this.lblPunt.AutoSize = true;
            this.lblPunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunt.ForeColor = System.Drawing.Color.Red;
            this.lblPunt.Location = new System.Drawing.Point(278, 269);
            this.lblPunt.Name = "lblPunt";
            this.lblPunt.Size = new System.Drawing.Size(0, 20);
            this.lblPunt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 319);
            this.Controls.Add(this.lblPunt);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblSpazio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plsControlla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Controlli su frase \"F\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plsControlla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSpazio;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblPunt;
    }
}

