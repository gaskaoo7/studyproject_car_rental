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
    public partial class dodajrez : Form
    {
        public dodajrez()
        {
            InitializeComponent();
            dateTimePicker2.Enabled = false;
            rezerwacje r = new rezerwacje();
            r.wypelnijcombo(comboBox1,comboBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           rezerwacje r = new rezerwacje();
            int aid = 0, kid = 0, i = 0;
            string a = "", b = "", k = comboBox2.Text, au = comboBox1.Text;
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
            string dt = dateTimePicker1.Value.ToShortDateString();
            string dd = dateTimePicker2.Value.ToShortDateString();

            r.wypozycz(dt, dd, aid, kid);
            DialogResult dialog = MessageBox.Show("Dodano pomyślnie\n\nChcesz dodać następną rezerwacje?", "Sukces!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                this.Close();
            else
            {
                this.Close();
                dodajrez re=new dodajrez();
                re.Show();

            }
        }
    }
}
