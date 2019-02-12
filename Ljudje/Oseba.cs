using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Ljudje
{
    public class Oseba
    {
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Naslov { get; set; }
        public string TelefonskaStevilka { get; set; }
        public string Email { get; set; }
    }
}
