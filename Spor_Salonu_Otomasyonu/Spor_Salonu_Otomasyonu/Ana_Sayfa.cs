using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spor_Salonu_Otomasyonu
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }

        private void btn_UyeEkle_Click(object sender, EventArgs e)
        {
            Uye_Ekle Git_Uye_Ekle = new Uye_Ekle();
            Git_Uye_Ekle.Show();
            this.Hide();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_UyeListele_Click(object sender, EventArgs e)
        {
            Uye_Listele Git_Uye_Listele = new Uye_Listele();
            Git_Uye_Listele.Show();
            this.Hide();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            Uye_Sil Git_Uye_Sil = new Uye_Sil();
            Git_Uye_Sil.Show();
            this.Hide();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            Uye_Guncelle Git_Uye_Guncelle = new Uye_Guncelle();
            Git_Uye_Guncelle.Show();
            this.Hide();

        }

        private void Btn_UyeAra_Click(object sender, EventArgs e)
        {
            Uye_Ara Git_Uye_Ara = new Uye_Ara();
            Git_Uye_Ara.Show();
            this.Hide();
        }
    }
}
