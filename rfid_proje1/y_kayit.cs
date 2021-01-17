using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;

namespace rfid_proje1
{
    public partial class y_kayit : Form
    {
        public int data;
        public y_kayit()
        {
            InitializeComponent();
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;
        }
        SqlConnection con= new SqlConnection("server=DESKTOP-HMFHOT7\\SQLEXPRESS; Initial Catalog=rfid_proje;Integrated Security=SSPI");
        SqlDataAdapter da;
        SqlCommand cmd,cmd2;
        SqlDataReader dr;

        private void Geri_Click(object sender, EventArgs e)
        {
            string c = "";
            yonetici_sf y = new yonetici_sf(c);
            y.Show();
            this.Hide();
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = int.Parse(serialPort1.ReadExisting());
            kart_id.Text = data.ToString();
        }

        private void Y_kayit_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.Open();
        }

        private void Y_kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd2= new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd2.Connection = con;
           
            string metin = ad.Text;
            string[] parcalar = metin.Split(' ');
            cmd2.CommandText = "select kart_id from personel where kart_id='"+data+"'";
            
            dr = cmd2.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("Kayıt Yapılamadı,bu kart id sistemde mevcut.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kart_id.Text = "";
            }
            else
            {
             con.Close();
                con.Open();
             cmd.CommandText = "insert into personel(tc,adi_soyadi,telefon,mail,kart_id,k_adi,sifre) values ('" + tc.Text + "','" + ad.Text + "','" + tel.Text + "','" + mail.Text + "','" + data + "','" + parcalar[0] + "','" + parcalar[1] + "')";
             cmd.ExecuteNonQuery();
             MessageBox.Show("Kayıt Başarıyla Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tc.Text = "";
                ad.Text = "";
                tel.Text = "";
                mail.Text = "";
                kart_id.Text = "";
            }
             con.Close();
            
            

        }
    }
}
