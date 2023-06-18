using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinci_el_esya_al___sat
{
 public class urun_sahibi
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }

        public string Soyad {get; set; }

        public string cinsiyet { get; set; }
        
        public string adres {get ; set; }

        public string e_posta { get; set; }

        public Int32 tel_no { get; set; } 
    }
 public class urun_pazarlayici
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string cinsiyet { get; set; }

        public string adres { get; set; }

        public string e_posta { get; set; }

        public Int32 tel_no { get; set; }
    }
  public class urun_alici
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string cinsiyet { get; set; }

        public string adres { get; set; }

        public string e_posta { get; set; }

        public Int32 tel_no { get; set; }
    } 
public class urun
    {
      public Guid ID { get; set; }
      
      public string cins {get ; set; }

      public String marka { get; set; }
     
      public string model { get; set; }

      public string renk { get; set; }

      public double fiyat { get; set; }
    }
public class fatura
    {
        public Guid ID { get; set; }

        public string odeme_turu { get; set; }

        public string taksit_pesin { get; set; }


    }
}
