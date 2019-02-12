using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Ljudje
{
    public class Imenik_info : Oseba
    {
        public string ImeImenika { get; set; }
        List<Oseba> SeznamOsebe = new List<Oseba>();
        public int SteviloOseb { get; }

        public string Stiki;
        public string Oseba = "";

        public string OdpriImenik(string imeImenika)
        {
            Stiki = "";
            ImeImenika = imeImenika;
            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + imeImenika + "'";
            SQLiteDataReader result = Command.ExecuteReader();
            result.Read();
            int id = result.GetInt32(0);
            result.Close();

            Command.CommandText = "SELECT * FROM Osebe WHERE imenik_id = " + id + "";
            SQLiteDataReader result2 = Command.ExecuteReader();

            while (result2.Read())
            {
                Stiki = Stiki +
                    result2["ime"].ToString() + ", " +
                    result2["priimek"].ToString() + ", " +
                    result2["naslov"].ToString() + ", " +
                    result2["tel"].ToString() + ", " +
                    result2["email"].ToString() + "\n";
            }

            return Stiki;
        }

        public void DodajImenik(string imeImenika)
        {
            ImeImenika = imeImenika;
            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "INSERT INTO Imeniki (ime) VALUES ('" + ImeImenika + "')";
            Command.ExecuteNonQuery();

            Conn.Close();
        }

        public void DodajOsebo(string imeImenika, string ime, string priimek, string naslov, string telefonskaStevilka, string email)
        {
            ImeImenika = imeImenika;
            Ime = ime;
            Priimek = priimek;
            Naslov = naslov;
            TelefonskaStevilka = telefonskaStevilka;
            Email = email;

            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);

            Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + imeImenika + "'";
            SQLiteDataReader result = Command.ExecuteReader();
            result.Read();
            int Imenik_id = result.GetInt32(0);
            result.Close();

            Command.CommandText = "INSERT INTO Osebe (imenik_id, ime, priimek, naslov, tel, email) VALUES (" + Imenik_id + ", '" + Ime + "', '" + Priimek + "', '" + Naslov + "', '" + TelefonskaStevilka + "', '" + Email + "')";
            Command.ExecuteNonQuery();
            Conn.Close();
        }

        public Imenik_info VrniOsebo (int id)
        {
            Imenik_info Imenik = new Imenik_info();

            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "SELECT * FROM Osebe WHERE id = " + id + "";
            SQLiteDataReader result = Command.ExecuteReader();
            result.Read();

            Ime = result["ime"].ToString();
            Priimek = result["priimek"].ToString();
            Naslov = result["naslov"].ToString();
            TelefonskaStevilka = result["tel"].ToString();
            Email = result["email"].ToString();

            result.Close();
            Conn.Close();

            return Imenik;
        }

        public void PosodobiOsebo (int id, string ime, string priimek, string naslov, string telefonskaStevilka, string email)
        {
            Ime = ime;
            Priimek = priimek;
            Naslov = naslov;
            TelefonskaStevilka = telefonskaStevilka;
            Email = email;

            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "UPDATE Osebe SET ime ='" + Ime + "', priimek ='" + Priimek + "', naslov ='" + Naslov + "', tel ='" + TelefonskaStevilka + "', email ='" + Email + "' WHERE id = " + id + "";
            Command.ExecuteNonQuery();
            Conn.Close();
        }

        public void IzbrisiOsebo(int id)
        {
            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "DELETE FROM Osebe WHERE id = " + id + "";
            Command.ExecuteNonQuery();
            Conn.Close();
        }

        public string SortirajPriimek(string imeImenika)
        {
            Stiki = "";
            ImeImenika = imeImenika;
            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + imeImenika + "'";
            SQLiteDataReader result = Command.ExecuteReader();
            result.Read();
            int id = result.GetInt32(0);
            result.Close();

            Command.CommandText = "SELECT * FROM Osebe WHERE imenik_id = " + id + " ORDER BY priimek ASC ";
            SQLiteDataReader result2 = Command.ExecuteReader();

            while (result2.Read())
            {
                Stiki = Stiki +
                    result2["ime"].ToString() + ", " +
                    result2["priimek"].ToString() + ", " +
                    result2["naslov"].ToString() + ", " +
                    result2["tel"].ToString() + ", " +
                    result2["email"].ToString() + "\n";
            }

            return Stiki;
        }

        public string SortirajIme(string imeImenika)
        {
            Stiki = "";
            ImeImenika = imeImenika;
            SQLiteConnection Conn = new SQLiteConnection("data source = 'imenik_database.sqlite'");

            Conn.Open();

            SQLiteCommand Command = new SQLiteCommand(Conn);
            Command.CommandText = "SELECT id FROM Imeniki WHERE ime = '" + imeImenika + "'";
            SQLiteDataReader result = Command.ExecuteReader();
            result.Read();
            int id = result.GetInt32(0);
            result.Close();

            Command.CommandText = "SELECT * FROM Osebe WHERE imenik_id = " + id + " ORDER BY ime ASC ";
            SQLiteDataReader result2 = Command.ExecuteReader();

            while (result2.Read())
            {
                Stiki = Stiki +
                    result2["ime"].ToString() + ", " +
                    result2["priimek"].ToString() + ", " +
                    result2["naslov"].ToString() + ", " +
                    result2["tel"].ToString() + ", " +
                    result2["email"].ToString() + "\n";
            }

            return Stiki;
        }
    }
}
