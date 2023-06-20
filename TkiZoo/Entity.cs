using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkiZoo
{
    public class Musteri 
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Yas { get; set; }
        public string Cinsiyet { get; set; }

        public string Ziyaret { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }


    }

    public class Hayvan
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }

        public string Tur { get; set; }

        public string Yas { get; set; }

        public string Cinsiyet { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Tur}";
        }


    }

    public class Bakici
    {
        public Guid ID { get; set; }

        public Guid HayvanID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Bakilan { get; set; }


    
    }

    public class Odeme
    {
        public Guid ID { get; set; }

        public Guid MusteriID { get; set; }
        public DateTime Tarih { get; set; }
        public double Tutar { get; set; }
        public string OdemeTur { get; set; }
        public string Aciklama { get; set; }
    
    
    }

}
