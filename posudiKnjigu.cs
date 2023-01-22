using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekaDavid
{
    internal class posudiKnjigu
    {
        string idKorisnika, idKnjige, datumPosudjivanja, datumVracanja;

        public posudiKnjigu(string idKorisnika, string idKnjige, string datumPosudjivanja, string datumVracanja)
        {
            this.idKorisnika = idKorisnika;
            this.idKnjige = idKnjige;
            this.datumPosudjivanja = datumPosudjivanja;
            this.datumVracanja = datumVracanja;
        }

        public string IdKorisnika { get => idKorisnika; set => idKorisnika = value; }
        public string IdKnjige { get => idKnjige; set => idKnjige = value; }
        public string DatumPosudjivanja { get => datumPosudjivanja; set => datumPosudjivanja = value; }
        public string DatumVracanja { get => datumVracanja; set => datumVracanja = value; }

        public override string ToString()
        {
            return "ID korisnika : " + IdKorisnika + "\r\nID knjige : " + IdKnjige + "\r\nDatum posuđivanja : " + DatumPosudjivanja +
                   "\r\nDatum vraćanja : " + DatumVracanja;
        }
    }
}
