using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKutuphaneotomasyonu.DATA
{
    public class KullaniciYöneticisi
    {
        public KullaniciYöneticisi()
        {
            Kullanicilar = new List<Kullanici>();

        }
        public List<Kullanici> Kullanicilar { get; set; }
        public bool KullaniciVarmi(string kullaniciAdi)
        {
            return Kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
        }
        public void KayitOl(string adSoyad, string kullaniciAdi, string parola, string parolatekrar)
        {
            Kullanici kullanici = new Kullanici()
            {
                AdSoyad = adSoyad,
                Parola = parola,
                KullaniciAdi = kullaniciAdi

            };

            Kullanicilar.Add(kullanici);
        }
        public Kullanici GirisYap(string kullaniciadi, string parola)
        {
            return new Kullanici();
        }




        //  - Kullanıcı yöenticisi olmalı 
        //- KayıtOl methodu
        //- GirisYap methodu
        //- KullanıcıVarmi methodu
    }


}
