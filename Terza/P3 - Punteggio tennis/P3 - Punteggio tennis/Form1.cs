using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3___Punteggio_tennis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int PuntMc = 0;
        int PuntProf = 0;
        bool VantaggioMc;
        bool VantaggioProf;


        private void plsMc_Click(object sender, EventArgs e)
        {
            bool Pari = (PuntProf == 40 && PuntMc == 40);
            VantaggioMc = (Pari);


            if (VantaggioProf)
            {
                PuntProf = PuntProf - 15;
                lblProf.Text = PuntProf.ToString();
                PuntMc = PuntMc - 10;
                VantaggioProf = false;
            }

            if (Pari)
            {
                lblMc.Text = "Vantaggio";
                PuntMc = PuntMc + 15;
                VantaggioMc = true;
            }


            else
            {
                if (PuntMc == 30)
                {
                    PuntMc = PuntMc + 10;
                    lblMc.Text = PuntMc.ToString();
                }


                else
                {

                    PuntMc = PuntMc + 15;

                    if (PuntMc > 55)
                    {
                        lblMc.Text = "Vittoria!!!";
                        MessageBox.Show("John McEnroe vince contro Daniele Sirangelo");
                        PuntProf = 0;
                        PuntMc = 0;
                        lblMc.Text = PuntMc.ToString();
                        lblProf.Text = PuntProf.ToString();
                    }
                    else
                        lblMc.Text = PuntMc.ToString();
                }

            }


            if (PuntMc > 40 && PuntProf != 40)
            {
                lblMc.Text = "Vittoria!!!";
                MessageBox.Show("John McEnroe vince contro Daniele Sirangelo");
                PuntMc = 0;
                PuntProf = 0;
                lblMc.Text = PuntMc.ToString();
                lblProf.Text = PuntProf.ToString();
            }
        }
        private void plsProf_Click(object sender, EventArgs e)
        {
            bool Pari = (PuntProf == 40 && PuntMc == 40);
            VantaggioProf = (Pari);

            if (VantaggioMc)
            {
                PuntMc = PuntMc - 15;
                lblMc.Text = PuntMc.ToString();
                PuntProf = PuntProf - 10;
                VantaggioMc = false;
            }

            if (Pari)
                {

                    lblProf.Text = "Vantaggio";
                    PuntProf = PuntProf + 15;
                    VantaggioProf = true;
            }


                else
                {
                    if (PuntProf == 30)
                    {
                        PuntProf = PuntProf + 10;
                        lblProf.Text = PuntProf.ToString();
                    }


                    else
                    {
                        
                        PuntProf = PuntProf + 15;

                        if (PuntProf > 55)
                        {
                        lblProf.Text = "Vittoria!!!";
                        MessageBox.Show("Daniele Sirangelo vince contro John McEnroe");
                        PuntProf = 0;
                        PuntMc = 0;
                        lblMc.Text = PuntMc.ToString();
                        lblProf.Text = PuntProf.ToString();
                    }
                            else
                            lblProf.Text = PuntProf.ToString();
                    }

                }
          

            if (PuntProf > 40 && PuntMc != 40)
            {
                lblProf.Text = "Vittoria!!!";
                MessageBox.Show("Daniele Sirangelo vince contro John McEnroe");               
                PuntMc = 0;
                PuntProf = 0;
                lblMc.Text = PuntMc.ToString();
                lblProf.Text = PuntProf.ToString();
            }
        }
    }
}

