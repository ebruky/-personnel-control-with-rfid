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
    public partial class giris_sf : Form
    {
        public giris_sf()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Giris_Click(object sender, EventArgs e)
        {
            string k_a = k_adi.Text;
            string sf = sifre.Text;
            con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.CommandText = "SELECT * FROM personel where k_adi='" + k_adi.Text + "' AND sifre='" + sifre.Text + "'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            // dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    string b = dr["adi_soyadi"].ToString();
                    string m = dr["kart_id"].ToString();

                    if (dr["gorev"].ToString() == "1")
                    {   yonetici_sf y = new yonetici_sf(b);
                        y.Show();
                        this.Hide();
                    }
                    else
                    {personel_sf p = new personel_sf(b);
                     p.Show();
                     this.Hide();
                    }
                }
            }
            else
            {

                dr.Close();
                MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
    