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
    public partial class edytuj_rez : Form
    {
        public edytuj_rez()
        {
            InitializeComponent();
            rezerwacje r = new rezerwacje();
            r.wypelnijcombo(comboBox_auto,comboBox_klient);
            r.combousun(comboBox1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_edytuj_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_edytuj.Checked == true)
            {
                comboBox_klient.Enabled = true;
                comboBox_auto.Enabled = true;
                dateTimePicker_wypoz.Enabled = true;
                button1_zapiszedycje.Enabled = true;
            }
            else
            {
                comboBox_klient.Enabled = false;
                comboBox_auto.Enabled = false;
                dateTimePicker_wypoz.Enabled = false;
                button1_zapiszedycje.Enabled = false;
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            rezerwacje usun = new rezerwacje();
            int aid = 0, i = 0;
            string a = "", au = comboBox1.Text;
            while (Char.IsDigit(au[i]))
            {
                a = a + au[i];
                i++;
            }

            aid = Int32.Parse(a);
            
            DialogResult dial =
                MessageBox.Show(
                    "Czy jesteś pewien że chcesz usunąć rezerwację?\nUpewnij się czy wybrałeś dobrą rezerwację!",
                    "Czy jesteś pewien?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dial == DialogResult.Yes)
            {
                usun.oddaj(aid);
                MessageBox.Show("Usunięto rezerwacje!", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Text = "";
                
                comboBox1.Items.Clear();
                usun.combousun(comboBox1);
            }
        }

        private void button1_zapiszedycje_Click(object sender, EventArgs e)
        {
            int aid = 0, kid = 0,rid=0, i = 0;
            string a = "", b = "",c="", k = comboBox_klient.Text, au = comboBox_auto.Text,r=comboBox1.Text;
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
            i = 0;
            while (Char.IsDigit(r[i]))
            {
                c = c + r[i];
                i++;
            }
            aid = Int32.Parse(a);
            kid = Int32.Parse(b);
            rid = Int32.Parse(c);
            string dt = dateTimePicker_wypoz.Value.ToShortDateString();
            string dd = dateTimePicker2.Value.ToShortDateString();//data rezrwacji, edycji
            rezerwacje editRezerwacje = new rezerwacje();
            DialogResult dial =
                MessageBox.Show(
                    "Czy jesteś pewien że chcesz nadpisać rezerwację?\nUpewnij się czy wybrałeś dobrą rezerwację!",
                    "Czy jesteś pewien?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dial == DialogResult.Yes)
            {
                editRezerwacje.edytuj(rid, aid, kid, dd, dt);
                MessageBox.Show("Zapisano zmiany!", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Text = "";

                comboBox1.Items.Clear();
                editRezerwacje.combousun(comboBox1);
            }
            
        }
    }
}
