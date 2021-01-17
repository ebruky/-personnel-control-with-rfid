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
    public partial class asil_sorgulama : Form
    {
        int secilen_id = 0;
        
        public asil_sorgulama()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        private void Geri_Click(object sender, EventArgs e)
        {
            string c = "";
            yonetici_sf y = new yonetici_sf(c);
            y.Show();
            this.Hide();
        }
       
        private void Geldi_Click(object sender, EventArgs e)
        {
            
        }

        private void Gelmedi_Click(object sender, EventArgs e)
        {

        }

        private void Asil_sorgulama_Load(object sender, EventArgs e)
        {
            
        }

        private void Tarih_ValueChanged(object sender, EventArgs e)
        {
            DateTime zaman = tarih.Value;
            var yil = zaman.Year;
            var ay = zaman.Month;
            var gun = zaman.Day;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select p.adi_soyadi,g.kart_id,g.giris_saat,g.cikis_saat From personel as p inner join giris_cikis as g on p.kart_id=g.kart_id where YEAR(g.giris_saat)='" + yil + "' AND MONTH(g.giris_saat)='" + ay + "' AND DAY(g.giris_saat)='" + gun + "'", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


            DataTable dt1 = new DataTable();
            da = new SqlDataAdapter("select kart_id,adi_soyadi from personel where kart_id not in(select kart_id from giris_cikis where YEAR(giris_saat)='" + yil + "' AND MONTH(giris_saat)='" + ay + "' AND DAY(giris_saat)='" + gun + "')", con);
            con.Open();
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con.Close();
        }

        private void Secilen_tarih_ValueChanged(object sender, EventArgs e)
        {
            //DateTime zaman = secilen_tarih.Value;
            //DateTime zaman1 = tarih.Value;
            //int b = 0;

            //con.Open();

            //cmd.CommandText = "Select count(distinct giris_saat) from giris_cikis where kart_id='" + secilen_id + "' and  giris_saat between '" + secilen_tarih+"' and '"+tarih+"'";
            //cmd.Connection = con;
            //dr = cmd.ExecuteReader();
            //if (dr.HasRows)
            //{
            //    if (dr.Read())
            //    {
            //        b = Convert.ToInt32(dr["count(distinct giris_saat)"]);
            //     }
            // }con.Close();
            //textBox1.Text = b.ToString();

        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            secilen_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            secilen_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
