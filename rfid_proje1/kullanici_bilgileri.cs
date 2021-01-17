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
    public partial class kullanici_bilgileri : Form
    {
        int e = 0;
        public kullanici_bilgileri(int id)
        {
            InitializeComponent();
            e = id;
        }

        SqlConnection con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        DataSet ds;
        SqlDataReader dr;

        private void Geri_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand();
           

            cmd.CommandText = "SELECT * FROM personel where kart_id like '" + Convert.ToInt32(id.Text) + "'";
            con.Open();
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string b = dr["adi_soyadi"].ToString();

                personel_sf p = new personel_sf(b);
                p.Show();
                this.Hide();
            }
            con.Close();
        }
        public void textbox_doldur()
        {
           

            cmd.CommandText = "select * from personel where kart_id = '" + e + "'";
            cmd.Connection = con;
            con.Open();
          
          
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tc.Text = dr["tc"].ToString();
                ad.Text = dr["adi_soyadi"].ToString();
                tel.Text = dr["telefon"].ToString();
                mail.Text = dr["mail"].ToString();
                k_adi.Text = dr["k_adi"].ToString();
                sf.Text = dr["sifre"].ToString();
                id.Text = dr["kart_id"].ToString();

            }
            con.Close();
        }
        private void Guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update personel" +
                   " Set tc=@tc,adi_soyadi=@ad,telefon=@tel,mail=@mail,k_adi=@k_adi,sifre=@sf Where kart_id=@id";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@tc", tc.Text);
            cmd.Parameters.AddWithValue("@ad", ad.Text);
            cmd.Parameters.AddWithValue("@tel", tel.Text);
            cmd.Parameters.AddWithValue("@mail", mail.Text);
            cmd.Parameters.AddWithValue("@k_adi", k_adi.Text);
            cmd.Parameters.AddWithValue("@sf", sf.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textbox_doldur();


        }

        private void Kullanici_bilgileri_Load(object sender, EventArgs e)
        {
            textbox_doldur();
        }
    }
}
