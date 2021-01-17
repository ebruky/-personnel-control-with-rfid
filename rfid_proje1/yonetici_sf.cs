using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rfid_proje1
{
    public partial class yonetici_sf : Form
    {
        string f;
        public yonetici_sf(string k)
        {
            InitializeComponent();
            f = k;

        }
        public string ad_soyad { get; set; }

        private void Yonetici_sf_Load(object sender, EventArgs e)
        {
            label2.Text = "Hoşgeldiniz " + f;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            y_sorgulama s = new y_sorgulama();
            s.Show();
            this.Hide();

        }

        private void Kayit_Click(object sender, EventArgs e)
        {
            y_kayit k = new y_kayit();
            k.Show();
            this.Hide();
        }

        private void Guncelleme_Click(object sender, EventArgs e)
        {
            y_güncelleme g = new y_güncelleme();
            g.Show();
            this.Hide();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            giris_sf g = new giris_sf();
            g.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            y_mesaj ym = new y_mesaj();
            ym.Show();
            this.Hide();

        }

        private void Sorgula_Click(object sender, EventArgs e)
        {
            asil_sorgulama a = new asil_sorgulama();
            a.Show();
            this.Hide();
        }
    }
}
