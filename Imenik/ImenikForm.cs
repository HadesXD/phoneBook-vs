using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Ljudje;

namespace Imenik
{
    public partial class ImenikForm : Form
    {
        Imenik_info Imenik = new Imenik_info();

        public ImenikForm()
        {
            InitializeComponent();
        }

        private void ImenikForm_Load(object sender, EventArgs e)
        {
            imenikRichTextBox.Clear();

            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);

            Command.CommandText = "SELECT ime FROM Imeniki";
            SQLiteDataReader result = Command.ExecuteReader();
            string ime;

            while (result.Read())
           {
                ime = result.GetString(0);
                izberiImenikComboBox.Items.Add(ime);
           }

            result.Close();
            Command.Dispose();
            Conn.Close();
        }

        private void izberiImenikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imenikRichTextBox.Text = "";
            string imeImenika = izberiImenikComboBox.SelectedItem.ToString();
            Imenik.OdpriImenik(imeImenika);
            imenikRichTextBox.Text = Imenik.Stiki;
        }

        private void imenikButton_Click(object sender, EventArgs e)
        {
            if (novImenikTextBox.Text != "")
            {

                string imeImenika = novImenikTextBox.Text;

                SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

                Conn.Open();

                SQLiteCommand Command = new SQLiteCommand(Conn);
                Command.CommandText = "SELECT ime FROM Imeniki WHERE ime = '" + imeImenika + "'";
                SQLiteDataReader result = Command.ExecuteReader();

                if (result.HasRows)
                {
                    MessageBox.Show("Imenik že obstaja!");
                    novImenikTextBox.Text = "";
                }
                else
                {
                    Imenik.DodajImenik(imeImenika);
                    MessageBox.Show("Uspešno ste dodali!");
                    izberiImenikComboBox.Items.Add(imeImenika);
                }
            }
            else
            {
                MessageBox.Show("Vnesi ime Imenika!");
            }
        }

        private void dodajOseboButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(izberiImenikComboBox.Text))
            {
                MessageBox.Show("Izberi imenik!");
            }

            else
            {
                string imenik = izberiImenikComboBox.SelectedItem.ToString();
                DodajOsebo log = new DodajOsebo(imenik);
                log.ShowDialog();
            }
        }

        private void urdiOseboButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(izberiImenikComboBox.Text))
            {
                MessageBox.Show("Izberi imenik!");
            }

            else
            {
                SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

                Conn.Open();

                SQLiteCommand Command = new SQLiteCommand(Conn);
                Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + izberiImenikComboBox.Text + "'";
                SQLiteDataReader result = Command.ExecuteReader();
                result.Read();
                int id = result.GetInt32(0);
                result.Close();

                Command.CommandText = "SELECT * FROM Osebe WHERE imenik_id = " + id + "";
                SQLiteDataReader result2 = Command.ExecuteReader();

                if (result2.HasRows)
                {
                    result2.Close();
                    Conn.Close();
                    string imenik = izberiImenikComboBox.SelectedItem.ToString();
                    UrediOsebo log = new UrediOsebo(imenik);
                    log.ShowDialog();
                }
                else
                {
                    result2.Close();
                    Conn.Close();
                    MessageBox.Show("Izbrani imenik nima nobenih oseb!");
                }
            }
        }

        private void izbrisiOseboButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(izberiImenikComboBox.Text))
            {
                MessageBox.Show("Izberi imenik!");
            }

            else
            {
                SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

                Conn.Open();

                SQLiteCommand Command = new SQLiteCommand(Conn);
                Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + izberiImenikComboBox.Text + "'";
                SQLiteDataReader result = Command.ExecuteReader();
                result.Read();
                int id = result.GetInt32(0);
                result.Close();

                Command.CommandText = "SELECT * FROM Osebe WHERE imenik_id = " + id + "";
                SQLiteDataReader result2 = Command.ExecuteReader();

                if (result2.HasRows)
                {
                    result2.Close();
                    Conn.Close();
                    string imenik = izberiImenikComboBox.SelectedItem.ToString();
                    IzbrisiOsebo log = new IzbrisiOsebo(imenik);
                    log.ShowDialog();
                }
                else
                {
                    result2.Close();
                    Conn.Close();
                    MessageBox.Show("Izbrani imenik nima nobenih oseb!");
                }
            }
        }

        private void imeSortButton_Click(object sender, EventArgs e)
        {
            imenikRichTextBox.Text = "";
            string imeImenika = izberiImenikComboBox.SelectedItem.ToString();
            Imenik.SortirajIme(imeImenika);
            imenikRichTextBox.Text = Imenik.Stiki;
        }

        private void priimenkSortButton_Click(object sender, EventArgs e)
        {
            imenikRichTextBox.Text = "";
            string imeImenika = izberiImenikComboBox.SelectedItem.ToString();
            Imenik.SortirajPriimek(imeImenika);
            imenikRichTextBox.Text = Imenik.Stiki;
        }
    }
}
