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
    public partial class Uye_Ekle : Form
    {

        Uye_Sil Uyesil = new Uye_Sil();
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

           void Temizle()
        {

            txt_Telno.Clear();
            txt_Ucret.Clear();
            txt_uyeAd.Clear();
            txt_UyeSoyad.Clear();
            maskedTc.Clear();
            txtEmail.Clear();
            dateTimeDogumTarihi.ResetText();
            Combo_Cinsiyet.Text = "Seçiniz";

        }

        public Uye_Ekle()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if(bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            try
            {
                if (txt_Telno.Text == "" || txt_Ucret.Text == "" || txt_uyeAd.Text == "" || txtEmail.Text == "" ||  dateTimeDogumTarihi.Value == null| Combo_Cinsiyet.SelectedItem == null )
                {

                    MessageBox.Show("Hiçbir değer boş geçilemez ! ");


                }
                else
                {
                    SqlCommand kmt = new SqlCommand();
                    kmt.CommandText = "insert into Kul_Bilgi (Uye_Adi, Uye_Soyadi, Uye_Cinsiyet, Ucret,  Uye_Telno, Uye_Tc, Uye_DogumTarihi, Uye_eMail) values (@Uye_Adi, @Uye_Soyadi, @Uye_Cinsiyet, @Ucret, @Uye_Telno,  @Uye_Tc, @Uye_DogumTarihi, @Uye_eMail)";
                    kmt.Connection = bag;
                    kmt.CommandType = CommandType.Text;
                    kmt.Parameters.Add("@Uye_Adi", SqlDbType.NVarChar).Value = txt_uyeAd.Text;
                    kmt.Parameters.Add("@Uye_Soyadi", SqlDbType.NVarChar).Value = txt_UyeSoyad.Text;
                    kmt.Parameters.Add("@Uye_Cinsiyet", SqlDbType.NVarChar).Value = Combo_Cinsiyet.SelectedItem;
                    kmt.Parameters.Add("@Ucret", SqlDbType.NVarChar).Value = txt_Ucret.Text;
                    kmt.Parameters.Add("@Uye_Telno", SqlDbType.NVarChar).Value = txt_Telno.Text;
                    kmt.Parameters.Add("@Uye_Tc", SqlDbType.BigInt).Value = maskedTc.Text;
                    kmt.Parameters.Add("@Uye_DogumTarihi", SqlDbType.NVarChar).Value = dateTimeDogumTarihi.Text;
                    kmt.Parameters.Add("@Uye_eMail", SqlDbType.NVarChar).Value = txtEmail.Text;



                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı");
                    Temizle();
                    bag.Close();
                }
            }
            catch
            {

                MessageBox.Show("Kayıtlı bir TC kimlik numarası veya Telefon numarası sadece bir kez kaydedilebilir. Lütfen Başka bir Tc kimlik numarası veya telefon numarası ile deneyiniz !","Uyarı");

            }
        
          

        }

        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa Git_Ana_Sayfa = new Ana_Sayfa();
            Git_Ana_Sayfa.Show();
            this.Hide();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Listele_Click_1(object sender, EventArgs e)
        {
            GridDoldur();
        }
    }
}
