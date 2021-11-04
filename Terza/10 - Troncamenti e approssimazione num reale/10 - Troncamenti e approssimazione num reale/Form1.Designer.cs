namespace _10___Troncamenti_e_approssimazione_num_reale
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrecedente = new System.Windows.Forms.Label();
            this.lblSuccessivo = new System.Windows.Forms.Label();
            this.lblApprossimato = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCOLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(122, 39);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(58, 20);
            this.txtX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intero precedente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intero successivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Intero approssimato:";
            // 
            // lblPrecedente
            // 
            this.lblPrecedente.AutoSize = true;
            this.lblPrecedente.Location = new System.Drawing.Point(155, 137);
            this.lblPrecedente.Name = "lblPrecedente";
            this.lblPrecedente.Size = new System.Drawing.Size(0, 13);
            this.lblPrecedente.TabIndex = 5;
            // 
            // lblSuccessivo
            // 
            this.lblSuccessivo.AutoSize = true;
            this.lblSuccessivo.Location = new System.Drawing.Point(155, 159);
            this.lblSuccessivo.Name = "lblSuccessivo";
            this.lblSuccessivo.Size = new System.Drawing.Size(0, 13);
            this.lblSuccessivo.TabIndex = 6;
            // 
            // lblApprossimato
            // 
            this.lblApprossimato.AutoSize = true;
            this.lblApprossimato.Location = new System.Drawing.Point(155, 181);
            this.lblApprossimato.Name = "lblApprossimato";
            this.lblApprossimato.Size = new System.Drawing.Size(0, 13);
            this.lblApprossimato.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inserire qui il numero reale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApprossimato);
            this.Controls.Add(this.lblSuccessivo);
            this.Controls.Add(this.lblPrecedente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Troncamenti e approssimazioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecedente;
        private System.Windows.Forms.Label lblSuccessivo;
        private System.Windows.Forms.Label lblApprossimato;
        private System.Windows.Forms.Label label4;
    }
}

