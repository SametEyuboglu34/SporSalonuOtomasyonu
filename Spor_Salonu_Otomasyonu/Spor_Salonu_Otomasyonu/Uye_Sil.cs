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
    public partial class Uye_Sil : Form
    {


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
            guna2DataGridView1.DataSource = dt;
            
            
        }

        public Uye_Sil()
        {
            InitializeComponent();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if(bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {

                bag.Open();

            }
            SqlCommand komut = new SqlCommand("delete from Kul_Bilgi where Uye_Tc = '" + txt_Sil.Text + "'",bag);
            DialogResult sonuc;
            sonuc = MessageBox.Show(txt_Sil.Text + "Numaralı Üyeyi Silmek İstiyormusunuz ? ", "Silme İşlemi uyar", MessageBoxButtons.YesNo);
            
            if(sonuc == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşleminiz Başarılı","Uyarı");
                GridDoldur();
                txt_Sil.Clear();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı");
            }



        }



        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa gidis_AnaSayfa = new Ana_Sayfa();
            gidis_AnaSayfa.Show();
            this.Close();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void Uye_Sil_Load(object sender, EventArgs e)
        {
            txt_Sil.Focus();
        }
    }
}
