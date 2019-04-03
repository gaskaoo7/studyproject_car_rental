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
    public partial class wypozycz : Form
    {
        public wypozycz()
        {
            InitializeComponent();
            wypozyczenia w = new wypozyczenia();
            w.wypelnijcombo(comboBox_samochod,comboBox_klient);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_kwota_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_kwota_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_wypo_Click(object sender, EventArgs e)
        {
            wypozyczenia w = new wypozyczenia();
            int aid=0, kid=0,i=0;
            string a = "",b="",k=comboBox_klient.Text,au=comboBox_samochod.Text;
            while (Char.IsDigit(au[i]))
            {
                a = a + au[i];
                i++;
            }
            i = 0;
            while (Char.IsDigit(k[i]))
            {
                b = b + k[i];
                i++;
            }
            aid = Int32.Parse(a);
            kid = Int32.Parse(b);
            string dt = dateTimePicker_wypozycz.Value.ToShortDateString();
            string dd = dateTimePicker_oddaj.Value.ToShortDateString();

            w.wypozycz(dt, dd, double.Parse(textBox1.Text),double.Parse(textBox2_kwota.Text),aid,kid,textBox2_info.Text);
           DialogResult dialog =MessageBox.Show("Dodano pomyślnie\n\nChcesz dodać następne wypożyczenie?", "Sukces!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(dialog==DialogResult.No)
                this.Close();
           else
           {
                this.Close();
                wypozycz ww = new wypozycz();
                ww.Show();
               
           }

        }
    }
}
