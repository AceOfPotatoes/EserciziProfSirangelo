namespace _95___Lista_numeri_reali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblElementi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plsAggiungi = new System.Windows.Forms.Button();
            this.plsSomma = new System.Windows.Forms.Button();
            this.plsMedia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSomma = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.plsMaggioriX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblMaggioriX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.plsVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblElementi
            // 
            this.lblElementi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblElementi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblElementi.Location = new System.Drawing.Point(12, 262);
            this.lblElementi.Name = "lblElementi";
            this.lblElementi.Size = new System.Drawing.Size(604, 23);
            this.lblElementi.TabIndex = 1;
            this.lblElementi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista degli elementi";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(15, 137);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(257, 20);
            this.txtElemento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero da aggiungere";
            // 
            // plsAggiungi
            // 
            this.plsAggiungi.Location = new System.Drawing.Point(15, 172);
            this.plsAggiungi.Name = "plsAggiungi";
            this.plsAggiungi.Size = new System.Drawing.Size(257, 23);
            this.plsAggiungi.TabIndex = 5;
            this.plsAggiungi.Text = "AGGIUNGI NUMERO ALLA LISTA";
            this.plsAggiungi.UseVisualStyleBackColor = true;
            this.plsAggiungi.Click += new System.EventHandler(this.button1_Click);
            // 
            // plsSomma
            // 
            this.plsSomma.Location = new System.Drawing.Point(187, 308);
            this.plsSomma.Name = "plsSomma";
            this.plsSomma.Size = new System.Drawing.Size(257, 23);
            this.plsSomma.TabIndex = 6;
            this.plsSomma.Text = "EFFETTUA LA SOMMA";
            this.plsSomma.UseVisualStyleBackColor = true;
            this.plsSomma.Click += new System.EventHandler(this.plsSomma_Click);
            // 
            // plsMedia
            // 
            this.plsMedia.Location = new System.Drawing.Point(187, 348);
            this.plsMedia.Name = "plsMedia";
            this.plsMedia.Size = new System.Drawing.Size(257, 23);
            this.plsMedia.TabIndex = 7;
            this.plsMedia.Text = "EFFETTUA LA MEDIA ARITMETICA";
            this.plsMedia.UseVisualStyleBackColor = true;
            this.plsMedia.Click += new System.EventHandler(this.plsMedia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SOMMA =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "MEDIA ARTIMETICA =";
            // 
            // lblSomma
            // 
            this.lblSomma.AutoSize = true;
            this.lblSomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomma.ForeColor = System.Drawing.Color.Red;
            this.lblSomma.Location = new System.Drawing.Point(114, 398);
            this.lblSomma.Name = "lblSomma";
            this.lblSomma.Size = new System.Drawing.Size(0, 20);
            this.lblSomma.TabIndex = 10;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.Red;
            this.lblMedia.Location = new System.Drawing.Point(560, 398);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 20);
            this.lblMedia.TabIndex = 11;
            // 
            // plsMaggioriX
            // 
            this.plsMaggioriX.Location = new System.Drawing.Point(352, 172);
            this.plsMaggioriX.Name = "plsMaggioriX";
            this.plsMaggioriX.Size = new System.Drawing.Size(257, 23);
            this.plsMaggioriX.TabIndex = 14;
            this.plsMaggioriX.Text = "MOSTRAMI I NUMERI MAGGIORI DI QUESTO";
            this.plsMaggioriX.UseVisualStyleBackColor = true;
            this.plsMaggioriX.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numero di riferimento";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(352, 137);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(257, 20);
            this.txtX.TabIndex = 12;
            // 
            // lblMaggioriX
            // 
            this.lblMaggioriX.AutoSize = true;
            this.lblMaggioriX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaggioriX.ForeColor = System.Drawing.Color.Red;
            this.lblMaggioriX.Location = new System.Drawing.Point(379, 442);
            this.lblMaggioriX.Name = "lblMaggioriX";
            this.lblMaggioriX.Size = new System.Drawing.Size(0, 20);
            this.lblMaggioriX.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(216, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "MAGGIORI DI X =";
            // 
            // plsVisualizza
            // 
            this.plsVisualizza.Location = new System.Drawing.Point(15, 212);
            this.plsVisualizza.Name = "plsVisualizza";
            this.plsVisualizza.Size = new System.Drawing.Size(594, 23);
            this.plsVisualizza.TabIndex = 17;
            this.plsVisualizza.Text = "VISUALIZZA GLI ELEMENTI DELLA LISTA";
            this.plsVisualizza.UseVisualStyleBackColor = true;
            this.plsVisualizza.Click += new System.EventHandler(this.plsVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 482);
            this.Controls.Add(this.plsVisualizza);
            this.Controls.Add(this.lblMaggioriX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.plsMaggioriX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblSomma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plsMedia);
            this.Controls.Add(this.plsSomma);
            this.Controls.Add(this.plsAggiungi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblElementi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lista di numeri interi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblElementi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plsAggiungi;
        private System.Windows.Forms.Button plsSomma;
        private System.Windows.Forms.Button plsMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSomma;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button plsMaggioriX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblMaggioriX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button plsVisualizza;
    }
}

