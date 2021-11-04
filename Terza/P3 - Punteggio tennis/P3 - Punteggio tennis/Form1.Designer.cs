namespace P3___Punteggio_tennis
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
            this.plsMc = new System.Windows.Forms.Button();
            this.plsProf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMc = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plsMc
            // 
            this.plsMc.Location = new System.Drawing.Point(12, 12);
            this.plsMc.Name = "plsMc";
            this.plsMc.Size = new System.Drawing.Size(119, 23);
            this.plsMc.TabIndex = 0;
            this.plsMc.Text = "John McEnroe";
            this.plsMc.UseVisualStyleBackColor = true;
            this.plsMc.Click += new System.EventHandler(this.plsMc_Click);
            // 
            // plsProf
            // 
            this.plsProf.Location = new System.Drawing.Point(153, 12);
            this.plsProf.Name = "plsProf";
            this.plsProf.Size = new System.Drawing.Size(119, 23);
            this.plsProf.TabIndex = 1;
            this.plsProf.Text = "Daniele Sirangelo";
            this.plsProf.UseVisualStyleBackColor = true;
            this.plsProf.Click += new System.EventHandler(this.plsProf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "McEnroe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sirangelo:";
            // 
            // lblMc
            // 
            this.lblMc.AutoSize = true;
            this.lblMc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMc.ForeColor = System.Drawing.Color.Blue;
            this.lblMc.Location = new System.Drawing.Point(137, 56);
            this.lblMc.Name = "lblMc";
            this.lblMc.Size = new System.Drawing.Size(21, 24);
            this.lblMc.TabIndex = 4;
            this.lblMc.Text = "0";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.ForeColor = System.Drawing.Color.Blue;
            this.lblProf.Location = new System.Drawing.Point(137, 80);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(21, 24);
            this.lblProf.TabIndex = 5;
            this.lblProf.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblMc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plsProf);
            this.Controls.Add(this.plsMc);
            this.Name = "Form1";
            this.Text = "Punteggio tennis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plsMc;
        private System.Windows.Forms.Button plsProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMc;
        private System.Windows.Forms.Label lblProf;
    }
}

