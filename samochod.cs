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
    class samochod:baza
    {
  
        public void pokaz(DataGridView d)
        {
            try
            {
                con = new MySqlConnection(connStr);
                con.Open();
                adap = new MySqlDataAdapter("select * from samochody;", con);
                ds = new DataSet();
                adap.Fill(ds, "samochody");
                d.DataSource = ds.Tables[0];
                d.Columns[4].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells;
                d.Columns[0].Visible = true;
                d.ReadOnly = true;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void aktualizuj(DataGridView d)
        {
            try
            {
                DataTable changes = ((DataTable)d.DataSource).GetChanges();
                con = new MySqlConnection(connStr);
                adap = new MySqlDataAdapter("select * from samochody;", con);

                ds = new DataSet();
                con.Open();
                cmdbl = new MySqlCommandBuilder(adap);
                adap.UpdateCommand = cmdbl.GetUpdateCommand();
                adap.Update(changes);
                ((DataTable)d.DataSource).AcceptChanges();
                con.Close();

                con.Close();
                MessageBox.Show("zaktualizowano dane", "Aktualizacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public override void instrukcja(string info)
        {
            base.instrukcja(info);
        }
    }
}
