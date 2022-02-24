using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAKutuphaneotomasyonu.DATA;

namespace WFAKutuphaneOtomasyonu.UI
{
    public partial class KayitOlForm : Form
    {
        private readonly KullaniciYöneticisi kullaniciYoneticisi;

        public KayitOlForm()
        {
            InitializeComponent();
            
            this.kullaniciYoneticisi = kullaniciYoneticisi;
        }

        public KayitOlForm(KullaniciYöneticisi kullaniciYoneticisi)
        {
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();
            string kullaniciAdi = txtKullanıcıAdı.Text.Trim();
            string parola = txtparola.Text;
            
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirilmiştir.");
            Close();
        }
        private bool ParolaDogrula()
        {
            return (txtparola.Text != txtparolatekrar.Text) || string.IsNullOrEmpty(txtparola.Text) || string.IsNullOrEmpty(txtparolatekrar.Text);
        }
    }
}
