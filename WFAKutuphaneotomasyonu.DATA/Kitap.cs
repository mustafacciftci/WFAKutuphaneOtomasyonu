using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKutuphaneotomasyonu.DATA
{
   public class Kitap
    {
        public Kitap()
        {
           Id= Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime BasimTarihi { get; set; }
        public KitapTurEnum KitapTur { get; set; }

        public string YazarAd { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }

        //        

    }
}
