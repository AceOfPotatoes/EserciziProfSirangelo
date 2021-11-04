namespace _104___Lista_importi
{
    partial class frmAvvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvvio));
            this.label1 = new System.Windows.Forms.Label();
            this.plsInizia = new System.Windows.Forms.Button();
            this.ListaBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plsSomma = new System.Windows.Forms.Button();
            this.plsX = new System.Windows.Forms.Button();
            this.plsMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plsInizia
            // 
            this.plsInizia.Location = new System.Drawing.Point(145, 67);
            this.plsInizia.Name = "plsInizia";
            this.plsInizia.Size = new System.Drawing.Size(75, 23);
            this.plsInizia.TabIndex = 1;
            this.plsInizia.Text = "INIZIA";
            this.plsInizia.UseVisualStyleBackColor = true;
            this.plsInizia.Click += new System.EventHandler(this.plsInizia_Click);
            // 
            // ListaBox
            // 
            this.ListaBox.FormattingEnabled = true;
            this.ListaBox.Location = new System.Drawing.Point(15, 139);
            this.ListaBox.Name = "ListaBox";
            this.ListaBox.Size = new System.Drawing.Size(120, 95);
            this.ListaBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista elementi";
            // 
            // plsSomma
            // 
            this.plsSomma.Location = new System.Drawing.Point(201, 123);
            this.plsSomma.Name = "plsSomma";
            this.plsSomma.Size = new System.Drawing.Size(147, 39);
            this.plsSomma.TabIndex = 4;
            this.plsSomma.Text = "SOMMA IMPORTI";
            this.plsSomma.UseVisualStyleBackColor = true;
            this.plsSomma.Click += new System.EventHandler(this.plsSomma_Click);
            // 
            // plsX
            // 
            this.plsX.Location = new System.Drawing.Point(201, 168);
            this.plsX.Name = "plsX";
            this.plsX.Size = new System.Drawing.Size(147, 40);
            this.plsX.TabIndex = 5;
            this.plsX.Text = "POSIZIONE ELEMENTO + EVIDENZIA\r\n";
            this.plsX.UseVisualStyleBackColor = true;
            this.plsX.Click += new System.EventHandler(this.plsX_Click);
            // 
            // plsMax
            // 
            this.plsMax.Location = new System.Drawing.Point(201, 214);
            this.plsMax.Name = "plsMax";
            this.plsMax.Size = new System.Drawing.Size(147, 39);
            this.plsMax.TabIndex = 6;
            this.plsMax.Text = "POSIZIONE VALORE MASSIMO + EVIDENZIA";
            this.plsMax.UseVisualStyleBackColor = true;
            this.plsMax.Click += new System.EventHandler(this.plsMax_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 294);
            this.Controls.Add(this.plsMax);
            this.Controls.Add(this.plsX);
            this.Controls.Add(this.plsSomma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaBox);
            this.Controls.Add(this.plsInizia);
            this.Controls.Add(this.label1);
            this.Name = "frmAvvio";
            this.Text = "Lista importi";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plsInizia;
        private System.Windows.Forms.ListBox ListaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plsSomma;
        private System.Windows.Forms.Button plsX;
        private System.Windows.Forms.Button plsMax;
    }
}

