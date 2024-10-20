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

namespace Spor_Salonu_Otomasyonu
{
    public partial class Uye_Ara : Form
    {
        public Uye_Ara()
        {
            InitializeComponent();
        }

        public SqlConnection bag = new SqlConnection("Data Source =DESKTOP-UP9PN1H; initial catalog=Otomasyon; integrated security = true");

        public void GridDoldur()
        {
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();

            }

            SqlCommand komut = new SqlCommand("select Uye_Tc as [Üye TC No], Uye_Adi as [AD], Uye_Soyadi as [Soyad], Uye_DogumTarihi as [Doğum Tarihi], Uye_Cinsiyet as [Cinsiyet], Ucret as [Ücret], Uye_Telno as [Üye Telefon Numarası], Uye_eMail as [E-Mail] from Kul_Bilgi ", bag);

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DataGridListele.DataSource = dt;


        }

        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa GitAna = new Ana_Sayfa();
            GitAna.Show();
            this.Hide();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Broken)
            {
                bag.Open();
            }
            SqlCommand kmut = new SqlCommand("select * from Kul_Bilgi where Uye_Tc='" + maskedTc.Text + "' ", bag);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = kmut; //  yukarı sadece select komutu varsa komutta yazılır.
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DataGridListele.DataSource = dt;
        }
    }
}
