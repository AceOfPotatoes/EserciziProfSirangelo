namespace Esercizio3
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
            this.plsArcobaleno = new System.Windows.Forms.Button();
            this.lblRosso = new System.Windows.Forms.Label();
            this.lblArancione = new System.Windows.Forms.Label();
            this.lblGiallo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblBlu = new System.Windows.Forms.Label();
            this.lblIndaco = new System.Windows.Forms.Label();
            this.lblVioletto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plsArcobaleno
            // 
            this.plsArcobaleno.Location = new System.Drawing.Point(22, 6);
            this.plsArcobaleno.Name = "plsArcobaleno";
            this.plsArcobaleno.Size = new System.Drawing.Size(244, 35);
            this.plsArcobaleno.TabIndex = 0;
            this.plsArcobaleno.Text = "FAI APPARIRE UN\'ARCOBALENO!!!";
            this.plsArcobaleno.UseVisualStyleBackColor = true;
            this.plsArcobaleno.Click += new System.EventHandler(this.plsArcobaleno_Click);
            // 
            // lblRosso
            // 
            this.lblRosso.Location = new System.Drawing.Point(19, 80);
            this.lblRosso.Name = "lblRosso";
            this.lblRosso.Size = new System.Drawing.Size(247, 22);
            this.lblRosso.TabIndex = 1;
            // 
            // lblArancione
            // 
            this.lblArancione.Location = new System.Drawing.Point(19, 102);
            this.lblArancione.Name = "lblArancione";
            this.lblArancione.Size = new System.Drawing.Size(247, 22);
            this.lblArancione.TabIndex = 2;
            // 
            // lblGiallo
            // 
            this.lblGiallo.Location = new System.Drawing.Point(19, 124);
            this.lblGiallo.Name = "lblGiallo";
            this.lblGiallo.Size = new System.Drawing.Size(247, 22);
            this.lblGiallo.TabIndex = 3;
            // 
            // lblVerde
            // 
            this.lblVerde.Location = new System.Drawing.Point(19, 146);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(247, 22);
            this.lblVerde.TabIndex = 4;
            // 
            // lblBlu
            // 
            this.lblBlu.Location = new System.Drawing.Point(19, 168);
            this.lblBlu.Name = "lblBlu";
            this.lblBlu.Size = new System.Drawing.Size(247, 22);
            this.lblBlu.TabIndex = 5;
            // 
            // lblIndaco
            // 
            this.lblIndaco.Location = new System.Drawing.Point(19, 190);
            this.lblIndaco.Name = "lblIndaco";
            this.lblIndaco.Size = new System.Drawing.Size(247, 22);
            this.lblIndaco.TabIndex = 6;
            // 
            // lblVioletto
            // 
            this.lblVioletto.Location = new System.Drawing.Point(19, 212);
            this.lblVioletto.Name = "lblVioletto";
            this.lblVioletto.Size = new System.Drawing.Size(247, 22);
            this.lblVioletto.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblVioletto);
            this.Controls.Add(this.lblIndaco);
            this.Controls.Add(this.lblBlu);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblGiallo);
            this.Controls.Add(this.lblArancione);
            this.Controls.Add(this.lblRosso);
            this.Controls.Add(this.plsArcobaleno);
            this.Name = "Form1";
            this.Text = "Arcobaleno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plsArcobaleno;
        private System.Windows.Forms.Label lblRosso;
        private System.Windows.Forms.Label lblArancione;
        private System.Windows.Forms.Label lblGiallo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblBlu;
        private System.Windows.Forms.Label lblIndaco;
        private System.Windows.Forms.Label lblVioletto;
    }
}

