using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace projekt1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_update_klienci.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            klient k = new klient();
            k.pokaz(dataGridView1);

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klient kl = new klient();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            button_update_klienci.Visible = true;
            kl.pokaz(dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = false;
        }

        private void button_update_klienci_Click(object sender, EventArgs e)
        {
            DataTable changes = ((DataTable) dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                klient kk = new klient();
                kk.aktualizuj(dataGridView1);
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable changes = ((DataTable) dataGridView1.DataSource).GetChanges();

                if (changes != null)
                {
                    klient kkk = new klient();
                    kkk.aktualizuj(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ja ja = new ja();
        }

        private void instrukcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klient klient = new klient();
            string info =
                "1. Aby pokazać listę klientów należy wejść w zakładkę pokaż\n2. Aby dodać, usunąć bądź edytować dane klientów wejdź w zakładkę Edytuj\n" +
                "wybierając już istniejące dane możnaje zmienić wpisując nową wartość i zatwierdzić enterem\n" +
                "chcąc dodać nowe dane należy poprostu uzupełnić wszystie kolumny (email nie jest wymagany)\n" +
                "chcąc usunąć wszystkie danego danego klienta należy kliknąć po lewej strone w interesujący\n" +
                "nas wiersz, gdy będzie już zaznaczony wcisnąć klawisz delete i następnie kliknąć Aktualizuj";
            klient.instrukcja(info);
        }

        private void pokażToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button_update_klienci.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            samochod samochod = new samochod();
            samochod.pokaz(dataGridView2);

        }

        private void edytujToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            samochod s = new samochod();
            s.pokaz(dataGridView2);
            button_update_klienci.Visible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.ReadOnly = false;
        }

        private void dataGridView2_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable) dataGridView2.DataSource).GetChanges();

            if (changes != null)
            {
                samochod samochod = new samochod();
                samochod.aktualizuj(dataGridView2);
            }
        }

        private void instrukcjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            samochod sa = new samochod();
            string info =
                "1. Aby pokazać listę samochodów należy wejść w zakładkę pokaż\n2. Aby dodać, usunąć bądź edytować bazę samochodów wejdź w zakładkę Edytuj\n" +
                "wybierając już istniejące dane możnaje zmienić wpisując nową wartość i zatwierdzić enterem\n" +
                "chcąc dodać nowe dane należy poprostu uzupełnić wszystie kolumny \n" +
                "chcąc usunąć wszystkie dany pojazd należy kliknąć po lewej strone w interesujący\n" +
                "nas wiersz, gdy będzie już zaznaczony wcisnąć klawisz delete i następnie wcisnac enter";
            sa.instrukcja(info);
        }

        private void aktualneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            wypozyczenia wyp = new wypozyczenia();
            wyp.pokaz(dataGridView3);
        }

        private void wypożyczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wypozycz w = new wypozycz();
            w.Show();
        }

        private void oddajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //button_oddaj.Visible = true;
            //dataGridView3.Visible = true;
            //wypozyczenia wyp = new wypozyczenia();
            //wyp.pokaz(dataGridView3);
            oddaj o = new oddaj();
            o.Show();

        }

        private void button_oddaj_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView3.CurrentCell.RowIndex;
            int columnindex = dataGridView3.CurrentCell.ColumnIndex;


            MessageBox.Show(dataGridView3.Rows[rowindex].Cells[columnindex].Value.ToString());
        }

        private void dataGridView4_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dodajToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            rezerwacje rr=new rezerwacje();
            rr.pokaz(dataGridView4);
        }

        private void edytujToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           edytuj_rez ee=new edytuj_rez();
            ee.Show();
           
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dodajrez d = new dodajrez();
            d.Show();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(
                "Upewnij się, czy poprawnie uzupełniłes dane\nsprawdź czy w numerze telefonu nie ma innych znaków niz cyfry\nsprawdź czy podałeś datę w dobrym formacie",
                "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
