namespace _15___Reali_in_ordine_crescente
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
            this.lblaaaa = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.lblMaggiore = new System.Windows.Forms.Label();
            this.lblMinore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblaaaa
            // 
            this.lblaaaa.AutoSize = true;
            this.lblaaaa.Location = new System.Drawing.Point(33, 9);
            this.lblaaaa.Name = "lblaaaa";
            this.lblaaaa.Size = new System.Drawing.Size(210, 26);
            this.lblaaaa.TabIndex = 0;
            this.lblaaaa.Text = "Inseriti due numeri reali, \r\nessi verrano visualizzati in ordine crescente";
            this.lblaaaa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(36, 53);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(53, 20);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(190, 53);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(53, 20);
            this.txtN2.TabIndex = 2;
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.Location = new System.Drawing.Point(88, 95);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(106, 35);
            this.plsVisualizza.TabIndex = 3;
            this.plsVisualizza.Text = "VISUALIZZA";
            this.plsVisualizza.UseVisualStyleBackColor = true;
            this.plsVisualizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMaggiore
            // 
            this.lblMaggiore.AutoSize = true;
            this.lblMaggiore.Location = new System.Drawing.Point(71, 161);
            this.lblMaggiore.Name = "lblMaggiore";
            this.lblMaggiore.Size = new System.Drawing.Size(0, 13);
            this.lblMaggiore.TabIndex = 4;
            // 
            // lblMinore
            // 
            this.lblMinore.AutoSize = true;
            this.lblMinore.Location = new System.Drawing.Point(171, 161);
            this.lblMinore.Name = "lblMinore";
            this.lblMinore.Size = new System.Drawing.Size(0, 13);
            this.lblMinore.TabIndex = 5;
            this.lblMinore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = ">";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinore);
            this.Controls.Add(this.lblMaggiore);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblaaaa);
            this.Name = "Form1";
            this.Text = "Reali in ordine crescente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaaaa;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.Label lblMaggiore;
        private System.Windows.Forms.Label lblMinore;
        private System.Windows.Forms.Label label1;
    }
}

