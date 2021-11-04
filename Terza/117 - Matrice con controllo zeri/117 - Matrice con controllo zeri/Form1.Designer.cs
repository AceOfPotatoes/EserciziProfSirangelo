namespace _117___Matrice_con_controllo_zeri
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
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.lstMat = new System.Windows.Forms.ListBox();
            this.plsInput = new System.Windows.Forms.Button();
            this.numColonne = new System.Windows.Forms.NumericUpDown();
            this.numRighe = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numColonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRighe)).BeginInit();
            this.SuspendLayout();
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.BackColor = System.Drawing.Color.Maroon;
            this.plsVisualizza.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.plsVisualizza.Location = new System.Drawing.Point(46, 284);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(300, 38);
            this.plsVisualizza.TabIndex = 13;
            this.plsVisualizza.Text = "VISUALIZZA DATI MATRICE E SOMMA ELEMENTI";
            this.plsVisualizza.UseVisualStyleBackColor = false;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // lstMat
            // 
            this.lstMat.FormattingEnabled = true;
            this.lstMat.Location = new System.Drawing.Point(47, 131);
            this.lstMat.Name = "lstMat";
            this.lstMat.Size = new System.Drawing.Size(299, 147);
            this.lstMat.TabIndex = 12;
            // 
            // plsInput
            // 
            this.plsInput.BackColor = System.Drawing.Color.Maroon;
            this.plsInput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.plsInput.Location = new System.Drawing.Point(46, 87);
            this.plsInput.Name = "plsInput";
            this.plsInput.Size = new System.Drawing.Size(302, 38);
            this.plsInput.TabIndex = 11;
            this.plsInput.Text = "INIZIA INPUT";
            this.plsInput.UseVisualStyleBackColor = false;
            this.plsInput.Click += new System.EventHandler(this.plsInput_Click);
            // 
            // numColonne
            // 
            this.numColonne.Location = new System.Drawing.Point(229, 61);
            this.numColonne.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numColonne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColonne.Name = "numColonne";
            this.numColonne.Size = new System.Drawing.Size(120, 20);
            this.numColonne.TabIndex = 10;
            this.numColonne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRighe
            // 
            this.numRighe.Location = new System.Drawing.Point(229, 28);
            this.numRighe.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRighe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRighe.Name = "numRighe";
            this.numRighe.Size = new System.Drawing.Size(120, 20);
            this.numRighe.TabIndex = 9;
            this.numRighe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "NUMERO COLONNE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "NUMERO RIGHE:";
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 352);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.lstMat);
            this.Controls.Add(this.plsInput);
            this.Controls.Add(this.numColonne);
            this.Controls.Add(this.numRighe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAvvio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numColonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRighe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plsVisualizza;
        private System.Windows.Forms.ListBox lstMat;
        private System.Windows.Forms.Button plsInput;
        private System.Windows.Forms.NumericUpDown numColonne;
        private System.Windows.Forms.NumericUpDown numRighe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

