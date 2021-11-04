using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23___Tastiera_note_musicali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);

                if (N > 70)
                {
                    MessageBox.Show("ERRORE!!!");
                }
                else
                {

                if (N > 7)
                {
                    N = N % 7;
                }
                 
                    switch (N)
                    {
                        case 1:
                            MessageBox.Show("DO");
                            break;

                        case 2:
                            MessageBox.Show("RE");
                            break;

                        case 3:
                            MessageBox.Show("MI");
                            break;

                        case 4:
                            MessageBox.Show("FA");
                            break;

                        case 5:
                            MessageBox.Show("SOL");
                            break;

                        case 6:
                            MessageBox.Show("LA");
                            break;

                        default:
                            MessageBox.Show("SI");
                            break;
                    }
                }                          
            }
        }
    }

