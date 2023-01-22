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

namespace bibliotekaDavid
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonUcitajKorisnik_Click(object sender, EventArgs e)
        {

        }

        private void buttonUcitajKnjiga_Click(object sender, EventArgs e)
        {
            XElement PrviXML = XElement.Load(@"D:\NIOP\Knjiga.xml");
            richTextBoxIspisKnjiga.Text = PrviXML.ToString();
        }
    }
}
