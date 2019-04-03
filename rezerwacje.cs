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
    class rezerwacje:baza
    {
        public void pokaz(DataGridView d)
        {
            try
            {
                con = new MySqlConnection(connStr);
                con.Open();
                adap = new MySqlDataAdapter("SELECT pro.id AS ID, pro.data_wyp AS Data_Wypozyczenia, pro.data_rez AS Zarezerwowano_dnia, cli.imie AS Imie_Klienta, cli.nazwisko AS Nazwisko_klienta,sam.marka as Marka, sam.model as Model FROM rezerwacje pro INNER JOIN klienci cli ON cli.Id = pro.klient_id INNER JOIN samochody sam ON sam.Id = pro.auto_id order by pro.data_wyp asc ", con);
                ds = new DataSet();
                adap.Fill(ds, "rezerwacje");
                d.DataSource = ds.Tables[0];
                d.Columns[0].Visible = true;
                d.ReadOnly = true;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void combousun(ComboBox usun)
        {
            try
            {
                
                con = new MySqlConnection(connStr);
                con.Open();
                string selectQuery = "SELECT pro.id AS ID, pro.data_wyp AS Data_Wypozyczenia, pro.data_rez AS Data_rezerwacji, cli.imie AS Imie_Klienta, cli.nazwisko AS Nazwisko,sam.marka as Marka, sam.model as Model FROM rezerwacje pro INNER JOIN klienci cli ON cli.Id = pro.klient_id INNER JOIN samochody sam ON sam.Id = pro.auto_id order by pro.data_wyp asc";
                MySqlCommand command = new MySqlCommand(selectQuery, con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usun.Items.Add(reader.GetInt32("id") + " - " + reader.GetString("Marka") + " " + reader.GetString("Model") + " " + reader.GetString("Imie_Klienta") + " " + reader.GetString("Nazwisko") + " - " + reader.GetString("Data_Wypozyczenia"));
                }
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
                    auto.Items.Add(reader.GetInt32("id") + " - " + reader.GetString("marka") + " " + reader.GetString("model"));
                }
                con.Close();
                con.Open();
                selectQuery = "SELECT * FROM klienci";
                command = new MySqlCommand(selectQuery, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    klient.Items.Add(reader.GetInt32("id") + " - " + reader.GetString("imie") + " " + reader.GetString("nazwisko"));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void wypozycz(string data_wyp, string data_rez, int auto_id, int klient_id)
        {
            try
            {
                con = new MySqlConnection(connStr);

                MySqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = @"INSERT INTO rezerwacje (data_wyp,data_rez,auto_id,klient_id) VALUES (@data_wyp,@data_rez,@auto_id,@klient_id)";
                command.Parameters.AddWithValue("@data_wyp", data_wyp);
                command.Parameters.AddWithValue("@data_rez", data_rez);
                command.Parameters.AddWithValue("@auto_id", auto_id);
                command.Parameters.AddWithValue("@klient_id", klient_id);
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

        public void oddaj(int id)
        {
            try
            {

                con = new MySqlConnection(connStr);
                con.Open();
                string selectQuery = "delete from rezerwacje where id=@id";
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

        public void edytuj(int rid, int aid, int kid, string data_rez, string data_wyp)
        {
            try
            {
                con = new MySqlConnection(connStr);

                MySqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = @"UPDATE rezerwacje SET klient_id=@kid,auto_id=@aid,data_rez=@data_rez,data_wyp=@data_wyp WHERE id=@rid";
                command.Parameters.AddWithValue("@data_wyp", data_wyp);
                command.Parameters.AddWithValue("@data_rez", data_rez);
                command.Parameters.AddWithValue("@rid", rid);
                command.Parameters.AddWithValue("@aid", aid);
                command.Parameters.AddWithValue("@kid", kid);
                command.Prepare();

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
