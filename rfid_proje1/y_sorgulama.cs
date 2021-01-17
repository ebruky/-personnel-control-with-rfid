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
    public partial class y_sorgulama : Form
    {
        public y_sorgulama()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public int k = 0;
        private void Geri_Click(object sender, EventArgs e)
        {
            string c = "";
            yonetici_sf y = new yonetici_sf(c);
            y.Show();
            this.Hide();
        }

     

     
        private void Y_sorgulama_Load(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ad_ara_TextChanged(object sender, EventArgs e)
       {
            con.Close();
            da = new SqlDataAdapter("select tc,adi_soyadi,telefon,mail,kart_id From personel where adi_soyadi like '%" + ad_ara.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables["personel"];
            con.Close();


        }

        private void Tc_ara_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            da = new SqlDataAdapter("select tc,adi_soyadi,telefon,mail,kart_id From personel where tc like '%" + tc_ara.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables["personel"];
            con.Close();
        }

        private void İd_ara_TextChanged(object sender, EventArgs e)

        {   
      
        }

        private void Mesaj_gonder_Click(object sender, EventArgs e)
        {
           

        }

        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
