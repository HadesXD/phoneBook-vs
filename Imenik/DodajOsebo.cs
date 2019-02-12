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
    public partial class DodajOsebo : Form
    {
        Imenik_info Imenik = new Imenik_info();
        string imeImenika;

        public DodajOsebo(string imenik)
        {
            this.imeImenika = imenik;
            InitializeComponent();
        }

        private void DodajOsebo_Load(object sender, EventArgs e)
        {
            imenikLabel.Text = imeImenika;
        }

        private void shraniButton_Click(object sender, EventArgs e)
        {
            if (imeTextBox.Text != "" && priimekTextBox.Text != "" && naslovTextBox.Text != "" && telTextBox.Text != "" && emailTextBox.Text != "")
            {
                string ime = imeTextBox.Text;
                string priimek = priimekTextBox.Text;
                string naslov = naslovTextBox.Text;
                string telefonskaStevilka = telTextBox.Text;
                string email = emailTextBox.Text;

                SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

                Conn.Open();

                SQLiteCommand Command = new SQLiteCommand(Conn);
                Command.CommandText = "SELECT email FROM Osebe WHERE email = '" + emailTextBox.Text + "'";
                SQLiteDataReader result = Command.ExecuteReader();

                if (result.HasRows)
                {
                    result.Close();
                    MessageBox.Show("Email je že uporabljen!");
                }
                else
                {
                    result.Close();
                    Command.CommandText = "SELECT tel FROM Osebe WHERE tel = '" + telTextBox.Text + "'";
                    SQLiteDataReader result2 = Command.ExecuteReader();

                    if (result2.HasRows)
                    {
                        result2.Close();
                        MessageBox.Show("Telefonska je že uporabljna!");
                    }
                    else
                    {
                        result2.Close();
                        Imenik.DodajOsebo(imeImenika, ime, priimek, naslov, telefonskaStevilka, email);
                        MessageBox.Show("Uspešno ste dodali!");

                        imeTextBox.Text = "";
                        priimekTextBox.Text = "";
                        naslovTextBox.Text = "";
                        telTextBox.Text = "";
                        emailTextBox.Text = "";
                    }
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            imeTextBox.Text = "";
            priimekTextBox.Text = "";
            naslovTextBox.Text = "";
            telTextBox.Text = "";
            emailTextBox.Text = "";
        }
    }
}
