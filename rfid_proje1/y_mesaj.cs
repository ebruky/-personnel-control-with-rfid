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
using System.Net;
using System.Net.Mail;


namespace rfid_proje1
{
    public partial class y_mesaj : Form
    {
        public y_mesaj()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public int k = 0;
        public string m = "";
        private void Geri_Click(object sender, EventArgs e)
        {
            string c = "";
            yonetici_sf y = new yonetici_sf(c);
            y.Show();
            this.Hide();
        }
        public void mesaj_gonder1()
        {
            con.Close();
            DateTime zaman = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            var zamanim = zaman.ToString(format);

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            string sorgu = "insert into mesajlar(kart_id,mesaj,tarih_saat) values ('" + k + "','" + mesaj.Text + "','" + zamanim + "')";
            
            cmd = new SqlCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Mesaj Başarıyla Gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mesaj.Text = "";
        }
        private void Ad_ara_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            da = new SqlDataAdapter("select p.adi_soyadi,g.kart_id,p.mail,g.giris_saat,g.cikis_saat From personel as p inner join giris_cikis as g on p.kart_id=g.kart_id where p.adi_soyadi like '%" + ad_ara.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "giris_cikis");
            dataGridView1.DataSource = ds.Tables["giris_cikis"];
            con.Close();


        }

        private void Tc_ara_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            da = new SqlDataAdapter("select p.tc,g.kart_id,p.mail,g.giris_saat,g.cikis_saat From personel as p inner join giris_cikis as g on p.kart_id=g.kart_id where p.tc like '%" + tc_ara.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "giris_cikis");
            dataGridView1.DataSource = ds.Tables["giris_cikis"];
            con.Close();
        }

        private void Mesaj_gonder_Click(object sender, EventArgs e)
        {
            mesaj_gonder1();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            k = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            m = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            con.Close();
            da = new SqlDataAdapter("select mesaj From mesajlar where kart_id = '" + k + "'", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();



        }

        private void Y_mesaj_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("proje.rfid.22@gmail.com", "raspberry.12");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("proje.rfid.22@gmail.com", "Admin");
            mail.To.Add(m);
            mail.Subject = "DUYURU!"; mail.IsBodyHtml = true; mail.Body = mesaj.Text;

            sc.Send(mail);
            MessageBox.Show("Mail Başarıyla Gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mesaj.Text = ""; }

        private void Duyuru_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Close();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("proje.rfid.22@gmail.com", "raspberry.12");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("proje.rfid.22@gmail.com", "Admin");
            con.Open();
            cmd.CommandText ="SELECT mail FROM personel";
            cmd.Connection = con;
            SqlDataReader  dr = cmd.ExecuteReader();
           
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string posta = dr["mail"].ToString();
                    mail.To.Add(posta);
                }
            }
            mail.Subject = "DUYURU!"; mail.IsBodyHtml = true; mail.Body = mesaj.Text;
            sc.Send(mail);
            MessageBox.Show("Mail Başarıyla Gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mesaj.Text = "";
            con.Close();
        }
    }

}
