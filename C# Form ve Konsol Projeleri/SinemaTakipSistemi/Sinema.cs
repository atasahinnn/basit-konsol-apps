using System;
using System.Collections.Generic;
using System.Text;

namespace SinemaTakipSistemi
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;

        const double TAM = 15.0;
        const double INDIRIMLI = 10.0;

        public Sinema(string salonNumara, int koltukSayi) // KURUCU METOD
        {
            toplamKoltukSayisi = koltukSayi;
            salonNo = salonNumara;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;
        }

        public void BiletSat(bool indirimli)
        {
            bosKoltukSayisi--;
            if (indirimli)
            {
                bakiye += INDIRIMLI;
            }
            else
            {
                bakiye += TAM;     
            }
        }

        public void BiletIptal(bool indirimli) // BİLET İPTAL
        {
            bosKoltukSayisi--;
            if (indirimli)
            {
                bakiye -= INDIRIMLI;
            }
            else
            {
                bakiye -= TAM;
            }
        }

        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }

        public double BakiyeOgren()
        {
            return bakiye;
        }
    }
}
