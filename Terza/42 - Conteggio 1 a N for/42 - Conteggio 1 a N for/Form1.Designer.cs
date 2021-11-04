namespace _42___Conteggio_1_a_N_for
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
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato un intero N, il software visualizzerà\r\ni numeri da 1 ad N";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.Location = new System.Drawing.Point(43, 105);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(192, 23);
            this.plsVisualizza.TabIndex = 1;
            this.plsVisualizza.Text = "VISUALIZZA";
            this.plsVisualizza.UseVisualStyleBackColor = true;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(43, 69);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(192, 20);
            this.txtN.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 156);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conteggio da 1 a N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
    }
}

