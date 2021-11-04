namespace Esercizio2
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
            this.plsRosso = new System.Windows.Forms.Button();
            this.plsVerde = new System.Windows.Forms.Button();
            this.plsBlu = new System.Windows.Forms.Button();
            this.plsGiallo = new System.Windows.Forms.Button();
            this.plsNero = new System.Windows.Forms.Button();
            this.lblColore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plsRosso
            // 
            this.plsRosso.BackColor = System.Drawing.Color.Red;
            this.plsRosso.Location = new System.Drawing.Point(25, 29);
            this.plsRosso.Name = "plsRosso";
            this.plsRosso.Size = new System.Drawing.Size(78, 23);
            this.plsRosso.TabIndex = 0;
            this.plsRosso.UseVisualStyleBackColor = false;
            this.plsRosso.Click += new System.EventHandler(this.plsRosso_Click);
            // 
            // plsVerde
            // 
            this.plsVerde.BackColor = System.Drawing.Color.Green;
            this.plsVerde.Location = new System.Drawing.Point(25, 72);
            this.plsVerde.Name = "plsVerde";
            this.plsVerde.Size = new System.Drawing.Size(78, 23);
            this.plsVerde.TabIndex = 1;
            this.plsVerde.UseVisualStyleBackColor = false;
            this.plsVerde.Click += new System.EventHandler(this.plsVerde_Click);
            // 
            // plsBlu
            // 
            this.plsBlu.BackColor = System.Drawing.Color.Blue;
            this.plsBlu.Location = new System.Drawing.Point(25, 115);
            this.plsBlu.Name = "plsBlu";
            this.plsBlu.Size = new System.Drawing.Size(78, 23);
            this.plsBlu.TabIndex = 2;
            this.plsBlu.UseVisualStyleBackColor = false;
            this.plsBlu.Click += new System.EventHandler(this.plsBlu_Click);
            // 
            // plsGiallo
            // 
            this.plsGiallo.BackColor = System.Drawing.Color.Yellow;
            this.plsGiallo.Location = new System.Drawing.Point(25, 158);
            this.plsGiallo.Name = "plsGiallo";
            this.plsGiallo.Size = new System.Drawing.Size(78, 23);
            this.plsGiallo.TabIndex = 3;
            this.plsGiallo.UseVisualStyleBackColor = false;
            this.plsGiallo.Click += new System.EventHandler(this.plsGiallo_Click);
            // 
            // plsNero
            // 
            this.plsNero.BackColor = System.Drawing.Color.Black;
            this.plsNero.Location = new System.Drawing.Point(25, 204);
            this.plsNero.Name = "plsNero";
            this.plsNero.Size = new System.Drawing.Size(78, 23);
            this.plsNero.TabIndex = 4;
            this.plsNero.UseVisualStyleBackColor = false;
            this.plsNero.Click += new System.EventHandler(this.plsNero_Click);
            // 
            // lblColore
            // 
            this.lblColore.Location = new System.Drawing.Point(160, 32);
            this.lblColore.Name = "lblColore";
            this.lblColore.Size = new System.Drawing.Size(105, 194);
            this.lblColore.TabIndex = 5;
            this.lblColore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblColore);
            this.Controls.Add(this.plsNero);
            this.Controls.Add(this.plsGiallo);
            this.Controls.Add(this.plsBlu);
            this.Controls.Add(this.plsVerde);
            this.Controls.Add(this.plsRosso);
            this.Name = "Form1";
            this.Text = "Colore Label";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plsRosso;
        private System.Windows.Forms.Button plsVerde;
        private System.Windows.Forms.Button plsBlu;
        private System.Windows.Forms.Button plsGiallo;
        private System.Windows.Forms.Button plsNero;
        private System.Windows.Forms.Label lblColore;
    }
}

