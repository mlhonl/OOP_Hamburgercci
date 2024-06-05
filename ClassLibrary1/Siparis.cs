using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;
            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }
            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                ToplamTutar += ekstra.Fiyat;
            }
            ToplamTutar *= Adet;
        }
        public override string ToString()
        {
            if (EkstraMalzemeler.Count < 1) //Ekstra malzeme yoksa
            {
                return string.Format("{0} Menü X {1} Adet , {2} Boy , Toplam {3}", SeciliMenu.Ad, Adet, Boyut, ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = string.Empty;
                foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
                {
                    ekstraMalzemeler += ekstra.Ad + ",";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');
                return string.Format("{0} Menü X {1} Adet , {2} Boy ,{3}, Toplam {4}", SeciliMenu.Ad, Adet, Boyut, ekstraMalzemeler, ToplamTutar.ToString("C2"));

            }
        }

    }
}
