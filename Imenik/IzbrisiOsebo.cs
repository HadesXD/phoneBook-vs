using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Ljudje;

namespace Imenik
{
    public partial class IzbrisiOsebo : Form
    {
        Imenik_info Imenik = new Imenik_info();
        string imeImenika;

        public IzbrisiOsebo(string imenik)
        {
            this.imeImenika = imenik;
            InitializeComponent();
        }

        private void IzbrisiOsebo_Load(object sender, EventArgs e)
        {
            imenikLabel.Text = imeImenika;

            string email;

            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + imeImenika + "'";
            SQLiteDataReader result = Command.ExecuteReader();
            result.Read();
            int id = result.GetInt32(0);
            result.Close();

            Command.CommandText = "SELECT email FROM Osebe WHERE imenik_id = " + id + "";
            SQLiteDataReader result2 = Command.ExecuteReader();

            while (result2.Read())
            {
                email = result2.GetString(0);
                selectComboBox.Items.Add(email);
            }

            result2.Close();
            Conn.Close();
        }

        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "SELECT id FROM Osebe WHERE email = '" + selectComboBox.Text + "'";
            SQLiteDataReader result = Command.ExecuteReader();
            result.Read();
            int id = result.GetInt32(0);
            result.Close();

            Conn.Close();

            Imenik.VrniOsebo(id);

            imeTextBox.Text = Imenik.Ime;
            priimekTextBox.Text = Imenik.Priimek;
            naslovTextBox.Text = Imenik.Naslov;
            telTextBox.Text = Imenik.TelefonskaStevilka;
            emailTextBox.Text = Imenik.Email;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectComboBox.Text))
            {
                MessageBox.Show("Izberi osebo!");
            }

            else
            {
                int id;

                SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

                Conn.Open();
                SQLiteCommand Command = new SQLiteCommand(Conn);

                Command.CommandText = "SELECT id FROM Osebe WHERE email = '" + selectComboBox.Text + "'";
                SQLiteDataReader result = Command.ExecuteReader();
                result.Read();
                id = result.GetInt32(0);
                result.Close();

                Imenik.IzbrisiOsebo(id);
                MessageBox.Show("Uspešno ste izbrisali osebo!");

                selectComboBox.Items.Clear();
                selectComboBox.Text = "";
                imeTextBox.Text = "";
                priimekTextBox.Text = "";
                naslovTextBox.Text = "";
                telTextBox.Text = "";
                emailTextBox.Text = "";

                Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + imeImenika + "'";
                SQLiteDataReader result2 = Command.ExecuteReader();
                result2.Read();
                id = result2.GetInt32(0);
                result2.Close();

                Command.CommandText = "SELECT email FROM Osebe WHERE imenik_id = " + id + "";
                SQLiteDataReader result3 = Command.ExecuteReader();

                while (result3.Read())
                {
                    string email = result3.GetString(0);
                    selectComboBox.Items.Add(email);
                }

                result3.Close();
                Conn.Close();
            }
        }

        private void SotrirajPoPriimku()
        {

        }

        private void SortirajPoImenu()
        {

        }
    }
}
