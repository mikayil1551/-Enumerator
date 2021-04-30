using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Takim tkm = new Takim();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oyuncu oyn = new Oyuncu();
            oyn.Adi = textBox1.Text;
            oyn.DogumTarihi = DateTime.Now;
            oyn.FormaNo = 9;
            oyn.Soyadi = "Sadigzade";
            oyn.Mevkisi = "Orta saha";
            oyn.Uyrugu = "Azerbaycan";
            tkm.Oyuncular.Add(oyn);
            listBox1.Items.Add(oyn.Adi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkm.Adi = "Besiktas";
            tkm.KurulusYili = Convert.ToDateTime("01.01.1930");
            tkm.StadAdi = "Vodafone";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
