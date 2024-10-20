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
    public partial class Giris_Ekrani : Form
    {
        public SqlConnection baglanti = new SqlConnection("Data source =LAB1PC2\\SQLEXPRESS; initial catalog=Otomasyon; integrated security=true");

        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select *from Kul_Giris where Kullanici_Adi ='"+txt_KulAdi.Text+"'and sifre='"+txt_Sifre.Text+"'";
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = komut;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            baglanti.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Giriş Başarılı", "Hoş Geldiniz");
                Ana_Sayfa git_AnaSayfa = new Ana_Sayfa();
                git_AnaSayfa.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Yanlıştır");
                txt_KulAdi.Clear();
                txt_Sifre.Clear();
                txt_KulAdi.Focus();
            }
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
