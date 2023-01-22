using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace bibliotekaDavid
{
    public partial class Form2 : Form
    {
        List<podatci> korisnik = new List<podatci>();
        List<posudiKnjigu> knjige = new List<posudiKnjigu>();
        string dokument = "Podaci.xml";

        public Form2()
        {
            InitializeComponent();
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string novikorisnik = comboBox1.Text;

            if (novikorisnik == "NOVI KORISNIK")
            {
                label1.Visible = true;
                textBoxImeKorisnika.Visible = true;
                label2.Visible = true;
                textBoxPrezimeKorisnika.Visible = true;
                label6.Visible = false;
                textBoxIDknjige.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }

            if (novikorisnik == "STARI KORISNIK")
            {
                label1.Visible = false;
                textBoxImeKorisnika.Visible = false;
                label2.Visible = false;
                textBoxPrezimeKorisnika.Visible = false;
                label6.Visible = true;
                textBoxIDknjige.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
        }



        private void buttonUnesiPodatke_Click(object sender, EventArgs e)
        {
            podatci Korisnik = new podatci(textBoxImeKorisnika.Text, textBoxPrezimeKorisnika.Text, Convert.ToInt32(textBoxIDkorisnika.Text));
            korisnik.Add(Korisnik);



            
                var PodatakXML = new XDocument();
                PodatakXML.Add(new XElement("Podatci"));
                foreach (podatci korisnik1 in korisnik)
                {
                    var podatak = new XElement("Podatci", new XElement("Ime", Korisnik.ImeKorisnika),
                    new XElement("Prezime", Korisnik.PrezimeKorisnika), new XElement("ID_korisnika", Korisnik.IDkorisnika));

                    PodatakXML.Root.Add(podatak);
                }
               
                
                        SaveFileDialog noviDokument = new SaveFileDialog();
                        noviDokument.InitialDirectory = @"D:\NIOP";
                        noviDokument.Title = "Podatak";
                        noviDokument.DefaultExt = "xml";
                        noviDokument.ShowDialog();

                        dokument = noviDokument.FileName;

                        PodatakXML.Save(dokument);

                    }

        private void buttonPosudiKnjigu_Click(object sender, EventArgs e)
        {
            posudiKnjigu Knjige = new posudiKnjigu(textBoxIDkorisnika.Text, textBoxIDknjige.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            knjige.Add(Knjige);


            var KnjigeXML = new XDocument();
            KnjigeXML.Add(new XElement("Knjige"));
            foreach (posudiKnjigu knjige1 in knjige)
            {
                var knjige = new XElement("Posuđene_Knjige", new XElement("ID_korisnika", Knjige.IdKorisnika), new XElement("ID_knjige", Knjige.IdKnjige), 
                new XElement("Datum_Posuđivanja", Knjige.DatumPosudjivanja), new XElement("Datum_Vraćanja", Knjige.DatumVracanja));

                KnjigeXML.Root.Add(knjige);
            }

            SaveFileDialog noviDokument1 = new SaveFileDialog();
            noviDokument1.InitialDirectory = @"D:\NIOP";
            noviDokument1.Title = "Knjige";
            noviDokument1.DefaultExt = "xml";
            noviDokument1.ShowDialog();

            dokument = noviDokument1.FileName;

            KnjigeXML.Save(dokument);

        }
    }
        }
    

