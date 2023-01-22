using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekaDavid
{
    internal class podatci
    {
        string imeKorisnika, prezimeKorisnika;
        int iDkorisnika;

        public podatci(string imeKorisnika, string prezimeKorisnika, int iDkorisnika)
        {
            this.imeKorisnika = imeKorisnika;
            this.prezimeKorisnika = prezimeKorisnika;
            this.iDkorisnika = iDkorisnika;
        }

        public string ImeKorisnika { get => imeKorisnika; set => imeKorisnika = value; }
        public string PrezimeKorisnika { get => prezimeKorisnika; set => prezimeKorisnika = value; }
        public int IDkorisnika { get => iDkorisnika; set => iDkorisnika = value; }

        public override string ToString()
        {
            return "Ime korisnika : " + ImeKorisnika + "\r\nPrezime korisnika : " + PrezimeKorisnika + 
                   "\r\nID korisnika : " + IDkorisnika;
        }
    }

    
}
