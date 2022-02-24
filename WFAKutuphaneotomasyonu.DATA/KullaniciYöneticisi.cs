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





        //  - Kullanıcı yöenticisi olmalı 
        //- KayıtOl methodu
        //- GirisYap methodu
        //- KullanıcıVarmi methodu
    }


}
