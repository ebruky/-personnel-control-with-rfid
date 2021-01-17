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
    public partial class y_güncelleme : Form
    {
        public y_güncelleme()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        private void Geri_Click(object sender, EventArgs e)
        {
            string c = "";
            yonetici_sf y = new yonetici_sf(c);
            y.Show();
            this.Hide();
        }
        void griddoldur()
        {
           
            da = new SqlDataAdapter("Select tc,adi_soyadi,telefon,mail,kart_id From personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables["personel"];
            con.Close();
        }
        private void Y_güncelleme_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kart_id.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From personel Where kart_id=@id";
            cmd= new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(kart_id.Text));
            con.Open();
            cmd.ExecuteNonQuery();
           con.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            griddoldur();
        }

        private void Duzenle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update personel" +
                " Set tc=@tc,adi_soyadi=@ad,telefon=@tel,mail=@mail Where  kart_id=@id";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@tc", tc.Text);
            cmd.Parameters.AddWithValue("@ad", ad.Text);
            cmd.Parameters.AddWithValue("@tel", tel.Text);
            cmd.Parameters.AddWithValue("@mail", mail.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(kart_id.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            griddoldur();
        }
    }
}
