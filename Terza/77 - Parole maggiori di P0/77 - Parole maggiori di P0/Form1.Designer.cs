namespace _77___Parole_maggiori_di_P0
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
            this.txtP0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.plsVerifica = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaggiori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data una parola di riferimento P0 ed una seconda parola P, il software scriverà n" +
    "ella label sottostante solo le parole maggiori di P0, separate da \":\". ";
            // 
            // txtP0
            // 
            this.txtP0.Location = new System.Drawing.Point(311, 60);
            this.txtP0.Name = "txtP0";
            this.txtP0.Size = new System.Drawing.Size(96, 20);
            this.txtP0.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola di riferimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parola da confrontare";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(311, 125);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(96, 20);
            this.txtP.TabIndex = 4;
            // 
            // plsVerifica
            // 
            this.plsVerifica.Location = new System.Drawing.Point(12, 162);
            this.plsVerifica.Name = "plsVerifica";
            this.plsVerifica.Size = new System.Drawing.Size(694, 23);
            this.plsVerifica.TabIndex = 5;
            this.plsVerifica.Text = "VERIFICA. E SE È MAGGIORE DI P0, AGGIUNGI ALLA LABEL";
            this.plsVerifica.UseVisualStyleBackColor = true;
            this.plsVerifica.Click += new System.EventHandler(this.plsVerifica_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "MAGGIORI DI P0:";
            // 
            // lblMaggiori
            // 
            this.lblMaggiori.AutoSize = true;
            this.lblMaggiori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaggiori.ForeColor = System.Drawing.Color.Red;
            this.lblMaggiori.Location = new System.Drawing.Point(174, 218);
            this.lblMaggiori.Name = "lblMaggiori";
            this.lblMaggiori.Size = new System.Drawing.Size(0, 20);
            this.lblMaggiori.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 262);
            this.Controls.Add(this.lblMaggiori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plsVerifica);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP0);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parole maggiori di P0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button plsVerifica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaggiori;
    }
}

