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
    public partial class Uye_Listele : Form
    {
        public SqlConnection bag = new SqlConnection("Data Source =DESKTOP-UP9PN1H; initial catalog=Otomasyon; integrated security=true ");


        void GridDoldur()
        {
            if(bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            SqlCommand komut = new SqlCommand("select Uye_Tc as [Üye TC No], Uye_Adi as [AD], Uye_Soyadi as [Soyad], Uye_DogumTarihi as [Doğum Tarihi], Uye_Cinsiyet as [Cinsiyet], Ucret as [Ücret], Uye_Telno as [Üye Telefon Numarası], Uye_eMail as [E-Mail] from Kul_Bilgi ", bag);

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DataGridView1.DataSource = dt;


        }

        public Uye_Listele()
        {
            InitializeComponent();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Ana_Sayfa Git_Ana_Sayfa = new Ana_Sayfa();
            Git_Ana_Sayfa.Show();
            this.Close();
        }
    }
}
