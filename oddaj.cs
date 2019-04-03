using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt1
{
    public partial class oddaj : Form
    {
        public oddaj()
        {
            InitializeComponent();
            wypozyczenia wypozyczenia = new wypozyczenia();
            wypozyczenia.combolista(comboBox_oddaj);
        }

        private void comboBox_oddaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            wypozyczenia ww = new wypozyczenia();
            int aid = 0,i=0;
            string a = "", au = comboBox_oddaj.Text;
            while (Char.IsDigit(au[i]))
            {
                a = a + au[i];
                i++;
            }
            
            aid = Int32.Parse(a);
            
            ww.policz(textBox_dozaplaty,aid);
        }

        private void button_oddaj_Click(object sender, EventArgs e)
        {
            int aid = 0, i = 0;
            string a = "", au = comboBox_oddaj.Text;
            while (Char.IsDigit(au[i]))
            {
                a = a + au[i];
                i++;
            }

            aid = Int32.Parse(a);
            wypozyczenia w = new wypozyczenia();
            DialogResult dial =
                MessageBox.Show(
                    "Czy jesteś pewien że chcesz zakończyć wypożyczenie?\nUpewnij się czy rozliczyłeś się z klientem oraz sprawdziłeś oddawany pojazd",
                    "Czy jesteś pewien?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dial == DialogResult.Yes)
            {
                w.oddaj(aid);
                MessageBox.Show("Oddano samochód!", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_oddaj.Text = "";
                textBox_dozaplaty.Clear();
                comboBox_oddaj.Items.Clear();
                w.combolista(comboBox_oddaj);
            }
            
        }
    }
}
