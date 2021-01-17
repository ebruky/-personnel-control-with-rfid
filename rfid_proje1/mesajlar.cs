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
    public partial class mesajlar : Form
    {
       int e = 0;
        public mesajlar(int id)
        {
            InitializeComponent();
            e=id;
        }

        SqlConnection con = new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        public string kart_id { get; set; }
        
      
        private void Geri_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            int a= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.CommandText = "SELECT * FROM personel where kart_id = '" + a + "'";
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
        
        private void Mesajlar_Load(object sender, EventArgs e)
        {
            
            griddoldur();
         

        }

        void griddoldur()
        {

            da = new SqlDataAdapter("select kart_id,mesaj From mesajlar where kart_id like '" + e + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "mesajlar");
            dataGridView1.DataSource = ds.Tables["mesajlar"];
            con.Close();
        }
    }
}
