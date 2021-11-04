using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _97___Primo_utilizzo_di_ListBox_e_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperazioni.Items.Add("Aggiungere");
            cmbOperazioni.Items.Add("Eliminare");
            cmbOperazioni.Items.Add("Posizione selezionata");
            cmbOperazioni.Items.Add("Azzerare");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbOperazioni.SelectedIndex == 0)
                lstElenco.Items.Add(Interaction.InputBox("Dammi il numero che vuoi aggiungere"));


            if (cmbOperazioni.SelectedIndex == 1)
            {
                if(lstElenco.SelectedIndex == -1)
                    MessageBox.Show("Nessun elemento della lista selezionato");
                else
                    lstElenco.Items.RemoveAt(lstElenco.SelectedIndex);

            }

            if(cmbOperazioni.SelectedIndex == 2)
            {
                int Elemento = Convert.ToInt16(Interaction.InputBox("Dammi la posizione che vuoi evidenziare"));

                if (Elemento > lstElenco.Items.Count - 1)
                    MessageBox.Show("Posizione non valida");
                else
                    lstElenco.SelectedIndex = Elemento;
            }

            if (cmbOperazioni.SelectedIndex == 3)
                lstElenco.Items.Clear();
        }
    }
}
