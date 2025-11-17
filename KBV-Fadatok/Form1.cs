using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBV_Fadatok
{
    public partial class Form1 : Form
    {
        Dictionary<string, OrszagData> orszagok = new Dictionary<string, OrszagData>();
        public class OrszagData
        {
            public string Nev { get; set; }
            public string Fovaros { get; set; }
            public string Terulet { get; set; }
            public string Nepesseg { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            btnAu.Click += ZaszloButton_Click;
            btnFr.Click += ZaszloButton_Click;
            btnBri.Click += ZaszloButton_Click;
            btnHu.Click += ZaszloButton_Click;
            btnUsa.Click += ZaszloButton_Click;

            orszagok["btnAu"] = new OrszagData
            {
                Nev = "Ausztria",
                Fovaros = "Bécs",
                Terulet = "83 879 km²",
                Nepesseg = "8 900 000"
            };
            orszagok["btnFr"] = new OrszagData
            {
                Nev = "Franciaország",
                Fovaros = "Párizs",
                Terulet = "643 801 km²",
                Nepesseg = "67 000 000"
            };
            orszagok["btnBri"] = new OrszagData
            {
                Nev = "Nagy-Britannia",
                Fovaros = "London",
                Terulet = "243 610 km²",
                Nepesseg = "68 000 000"
            };
            orszagok["btnHu"] = new OrszagData
            {
                Nev = "Magyarország",
                Fovaros = "Budapest",
                Terulet = "93 000 km²",
                Nepesseg = "9 800 000"
            };
            orszagok["btnUsa"] = new OrszagData
            {
                Nev = "USA",
                Fovaros = "Washington D.C.",
                Terulet = "9 834 000 km²",
                Nepesseg = "331 000 000"
            };
        }

        private void ZaszloButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string key = btn.Tag.ToString();

            var c = orszagok[key];

            lblNev2.Text = c.Nev;
            lblFovaros2.Text = c.Fovaros;
            lblTerulet2.Text = c.Terulet;
            lblNepesseg2.Text = c.Nepesseg;
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
