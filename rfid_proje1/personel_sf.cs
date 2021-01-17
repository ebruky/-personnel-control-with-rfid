using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rfid_proje1
{
    public partial class personel_sf : Form
    {
        string f;
        public personel_sf(string k)
        {
            InitializeComponent();
            f = k;
        }
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public string ad_soyad { get; set; }

        private void Personel_sf_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldiniz " + f;
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            giris_sf g = new giris_sf();
            g.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.CommandText = "SELECT kart_id FROM personel where adi_soyadi='" + f + "' ";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    int i = Convert.ToInt32(dr["kart_id"]);

                    kullanici_bilgileri k = new kullanici_bilgileri(i);
                    k.Show();
                    this.Hide();
                }
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.CommandText = "SELECT kart_id FROM personel where adi_soyadi='" + f + "' ";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            // dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    int i = Convert.ToInt32(dr["kart_id"]);

                    mesajlar m = new mesajlar(i);
                    m.Show();
                    this.Hide();
                }
            }
        }
    }
}
