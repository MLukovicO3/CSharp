using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Aplikacija
{
    class Racun
    {
        public string IME { get; set; }
        public string PREZIME { get; set; }
        public string SIFRA { get; set; }
        public int DUG { get; set; }
        public DateTime DATUMUPLATE { get; set; }
        public DateTime DATUMPOCETAK { get; set; }
        public Racun()
        {
            IME = string.Empty;
            PREZIME = string.Empty;
            SIFRA = string.Empty;
            DUG = 0;
            DATUMPOCETAK = DateTime.Today;
        }

        public string Show()
        {
            string s=string.Empty;
            s += "STANJE NA RACUNU-cena informacije:0RSD!\n";
            s += "--------------------------------------------\n";
            s += "Ime: " + IME+"\n";
            s += "Prezime: " + PREZIME+"\n";
            s += "SIFRA racuna:" + SIFRA + "\n";
            s += "--------------------------------------------\n";
            s += "Datum postanka: " + DATUMPOCETAK + "\n";
            s += "--------------------------------------------\n";
            if (DATUMUPLATE.ToString() != "1/1/0001 12:00:00 AM")
            {
                s += "Datum poslednje uplate: " + DATUMUPLATE+"\n";
                if (DUG == 0)
                    s += "Dug izmiren!\n";
                else s += "Dug: " + DUG + "\n";
            }
            s += "HVALA STO POSLUJETE SA NAMA<3\n\n";
            return s;
        }

        public void Uplata(int paychek)
        {
            DUG -= paychek;
            List<string> list = new List<string>();
            list.Add(IME);
            list.Add(PREZIME);
            list.Add(SIFRA);
            list.Add(DUG.ToString());
            list.Add(DATUMPOCETAK.ToString());
            DATUMUPLATE = DateTime.Today;
            list.Add(DATUMUPLATE.ToString());
            File.WriteAllText(SIFRA + ".txt", string.Empty);
            File.WriteAllLines(SIFRA + ".txt", list);
        }
    }
}
