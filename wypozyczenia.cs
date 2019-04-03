using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projekt1
{
    class wypozyczenia:baza
    {
        public void pokaz(DataGridView d)
        {
            try
            {
                //int[] tab=new int[10];
                con = new MySqlConnection(connStr);
                con.Open();
                adap = new MySqlDataAdapter("SELECT pro.id AS ID, pro.data_wyp AS Data_Wypozyczenia, pro.data_odd AS Planowane_Oddanie, pro.zaliczka, pro.kwota, cli.imie AS Imie_Klienta, cli.nazwisko AS Nazwisko,sam.marka as Marka, sam.model as Model, pro.info FROM wypozyczenia pro INNER JOIN klienci cli ON cli.Id = pro.klient_id INNER JOIN samochody sam ON sam.Id = pro.auto_id order by pro.data_odd asc ", con);
                ds = new DataSet();
                adap.Fill(ds, "wypozyczenia");
                d.DataSource = ds.Tables[0];
              //  d.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                d.Columns[0].Visible = false;
                d.AllowUserToDeleteRows = false;
                d.AllowUserToAddRows = false;
                
                d.ReadOnly = true;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void wypelnijcombo(ComboBox auto, ComboBox klient)
        {
            try
            {
                con = new MySqlConnection(connStr);
                con.Open();
                string selectQuery = "SELECT * FROM samochody";
                MySqlCommand command = new MySqlCommand(selectQuery, con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    auto.Items.Add(reader.GetInt32("id")+" - "+reader.GetString("marka")+" "+reader.GetString("model"));
                }
                con.Close();
                con.Open();
                selectQuery = "SELECT * FROM klienci";
                command = new MySqlCommand(selectQuery,con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    klient.Items.Add(reader.GetInt32("id") + " - "+reader.GetString("imie") +" "+ reader.GetString("nazwisko"));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void combolista(ComboBox oddaj)
        {
            try
            {
                IList<string> lista = new List<string>();
                con = new MySqlConnection(connStr);
                con.Open();
                string selectQuery = "SELECT pro.id AS ID, pro.data_wyp AS Data_Wypozyczenia, pro.data_odd AS Planowane_Oddanie, pro.zaliczka, pro.kwota, cli.imie AS Imie_Klienta, cli.nazwisko AS Nazwisko,sam.marka as Marka, sam.model as Model, pro.info FROM wypozyczenia pro INNER JOIN klienci cli ON cli.Id = pro.klient_id INNER JOIN samochody sam ON sam.Id = pro.auto_id order by pro.data_odd asc";
                MySqlCommand command = new MySqlCommand(selectQuery, con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(reader.GetInt32("id") + " - " + reader.GetString("Marka") + " " + reader.GetString("Model") + " " + reader.GetString("Imie_Klienta") + " " + reader.GetString("Nazwisko") + " - " + reader.GetString("Data_Wypozyczenia"));
                }
                con.Close();
                for (int i = 0; i < lista.Count; i++)
                {
                    oddaj.Items.Add(lista[i]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void policz(TextBox kwota,int id)
        {
            try
            {
                int[] tab = new int[9999];
               // int i = 0;
                con = new MySqlConnection(connStr);
                con.Open();
                string selectQuery = "select * from wypozyczenia";
                MySqlCommand command = new MySqlCommand(selectQuery, con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tab[reader.GetInt32("id")] = reader.GetInt32("kwota") - reader.GetInt32("zaliczka");
                }
                int y = 0;
                int x = reader.GetInt32("kwota");
               // if(reader.GetString("zaliczka") !=null)
                    y= reader.GetInt32("zaliczka");
                x = x - y;
                kwota.Text = x.ToString();
                   
                con.Close();

                kwota.Text = tab[id].ToString();
                if (tab[id] < 0)
                    MessageBox.Show("Zwróć klientowi nadpłaconą sumę w wysokości:\n" + tab[id] + "\n",
                        "Zapłacono za wysoką zaliczkę", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void oddaj(int id)
        {
            try
            {
                
                con = new MySqlConnection(connStr);
                con.Open();
                string selectQuery = "delete from wypozyczenia where id=@id";
                MySqlCommand command = new MySqlCommand(selectQuery, con);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void wypozycz(string data_wyp, string data_odd,double zaliczka, double kwota,int auto_id, int klient_id, string info)
        {
            try
            {
                con = new MySqlConnection(connStr);
                
                MySqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = @"INSERT INTO wypozyczenia (data_wyp,data_odd,zaliczka,kwota,auto_id,klient_id,info) VALUES (@data_wyp,@data_odd,@zaliczka,@kwota,@auto_id,@klient_id,@info)";
                command.Parameters.AddWithValue("@data_wyp", data_wyp);
                command.Parameters.AddWithValue("@data_odd", data_odd);
                command.Parameters.AddWithValue("@zaliczka", zaliczka);
                command.Parameters.AddWithValue("@kwota", kwota);
                command.Parameters.AddWithValue("@auto_id", auto_id);
                command.Parameters.AddWithValue("@klient_id", klient_id);
                command.Parameters.AddWithValue("@info", info);
                command.Prepare();
                // command.CommandText = "INSERT INTO 'wypozyczenia' ('data_wyp','data_odd','zaliczka','kwota','auto_id','klient_id','info') VALUES ('2016-02-22','2016-02-28','500','1000','2','4','trolololo')";

                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
