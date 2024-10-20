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
    public partial class Uye_Guncelle : Form
    {
        public Uye_Guncelle()
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

            SqlCommand komut = new SqlCommand("select Uye_Tc as [Üye TC No], Uye_Adi as [AD], Uye_Soyadi as [Soyad], Uye_DogumTarihi as [Doğum Tarihi], Uye_Cinsiyet as [Cinsiyet], Ucret as [Ücret], Uye_Telno as [Telefon Numarası], Uye_eMail as [E-Mail] from Kul_Bilgi ", bag);

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DataGridListele.DataSource = dt;



        }

        void temizle()
        {

            txtEmail.Clear();
            txt_Telno.Clear();
            txt_Ucret.Clear();
            txt_uyeAd.Clear();
            txt_UyeSoyad.Clear();
            Combo_Cinsiyet.Text = "Seçiniz";
            maskedTc.Clear();
            maskedTc.Focus();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();

            }
            SqlCommand kmt = new SqlCommand("update Kul_Bilgi set Uye_Adi='" + txt_uyeAd.Text + "',Uye_Soyadi='"+txt_UyeSoyad.Text+"',Uye_Cinsiyet='"+Combo_Cinsiyet.SelectedItem+"',Ucret='"+txt_Ucret.Text+"',Uye_Telno='"+txt_Telno.Text+"',Uye_Email='"+txtEmail.Text+"' where Uye_Tc='"+maskedTc.Text+"'  ", bag);
            kmt.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kayıt Başarıyla Düzenlendi");
            GridDoldur();
            temizle();
        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa git = new Ana_Sayfa();
            git.Show();
            this.Hide();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Broken)
            {
                bag.Open();
            }
            SqlCommand kmut = new SqlCommand("select Uye_Tc as [Üye TC No], Uye_Adi as [AD], Uye_Soyadi as [Soyad], Uye_DogumTarihi as [Doğum Tarihi], Uye_Cinsiyet as [Cinsiyet], Ucret as [Ücret], Uye_Telno as [Telefon Numarası], Uye_eMail as [E-Mail]  from Kul_Bilgi where Uye_Tc='" + maskedTc.Text + "' ", bag);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = kmut; 
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DataGridListele.DataSource = dt;


        }

        private void DataGridListele_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            maskedTc.Text = DataGridListele.CurrentRow.Cells["Üye Tc No"].Value.ToString();
            txt_uyeAd.Text = DataGridListele.CurrentRow.Cells["AD"].Value.ToString();
            txt_UyeSoyad.Text = DataGridListele.CurrentRow.Cells["Soyad"].Value.ToString();
            Combo_Cinsiyet.Text = DataGridListele.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            txt_Telno.Text = DataGridListele.CurrentRow.Cells["Telefon Numarası"].Value.ToString();
            txtEmail.Text = DataGridListele.CurrentRow.Cells["E-Mail"].Value.ToString();
            txt_Ucret.Text = DataGridListele.CurrentRow.Cells["Ücret"].Value.ToString();
        }
    }
}
