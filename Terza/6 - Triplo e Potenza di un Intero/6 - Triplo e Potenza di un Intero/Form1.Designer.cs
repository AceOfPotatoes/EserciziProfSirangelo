namespace _6___Triplo_e_Potenza_di_un_Intero
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTriplo = new System.Windows.Forms.Label();
            this.lblCubo = new System.Windows.Forms.Label();
            this.plsCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il numero nella casella di testo";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(105, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Triplo =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cubo =";
            // 
            // lblTriplo
            // 
            this.lblTriplo.AutoSize = true;
            this.lblTriplo.Location = new System.Drawing.Point(73, 139);
            this.lblTriplo.Name = "lblTriplo";
            this.lblTriplo.Size = new System.Drawing.Size(0, 13);
            this.lblTriplo.TabIndex = 4;
            // 
            // lblCubo
            // 
            this.lblCubo.AutoSize = true;
            this.lblCubo.Location = new System.Drawing.Point(247, 139);
            this.lblCubo.Name = "lblCubo";
            this.lblCubo.Size = new System.Drawing.Size(0, 13);
            this.lblCubo.TabIndex = 5;
            // 
            // plsCalcola
            // 
            this.plsCalcola.Location = new System.Drawing.Point(105, 84);
            this.plsCalcola.Name = "plsCalcola";
            this.plsCalcola.Size = new System.Drawing.Size(97, 23);
            this.plsCalcola.TabIndex = 6;
            this.plsCalcola.Text = "CALCOLA";
            this.plsCalcola.UseVisualStyleBackColor = true;
            this.plsCalcola.Click += new System.EventHandler(this.plsCalcola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 181);
            this.Controls.Add(this.plsCalcola);
            this.Controls.Add(this.lblCubo);
            this.Controls.Add(this.lblTriplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Triplo e Cubo di un Intero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTriplo;
        private System.Windows.Forms.Label lblCubo;
        private System.Windows.Forms.Button plsCalcola;
    }
}

