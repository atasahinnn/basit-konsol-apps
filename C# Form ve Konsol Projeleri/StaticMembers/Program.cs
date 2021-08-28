using System;

namespace static_members
{
    class Program
    {

        class Urun
        { 

            public int urunID { get; set; }

            public string urunAd { get; set; }

            public double urunFiyat { get; set; }

            public bool satistaMi { get; set; }

        }

        static class UrunManager
        {

            static Urun[] Urunler;
            static UrunManager()
            {
                Urunler = new Urun[3];

                Urunler[0] = new Urun { urunID = 1, urunAd = "Xiaomi Mi Note 6", urunFiyat = 2500, satistaMi = true };
                Urunler[1] = new Urun { urunID = 2, urunAd = "NVIDIA RTX 3080 Dual Fan GPU", urunFiyat = 7500, satistaMi = true };
                Urunler[2] = new Urun { urunID = 3, urunAd = "MSI GP62 Gaming Laptop", urunFiyat = 5000, satistaMi = false };

            }

            public static Urun[] UrunleriGetir()
            {
                return Urunler;
            }

            public static Urun NumarayaGoreUrunGetir(int id)
            {
                Urun urun = null;

                foreach (var i in Urunler)
                {
                    if (i.urunID == id)
                    {
                        urun = i;
                        break;
                    }
                }

                return urun;
            }

            public static Urun AdaGoreUrunGetir(string name)
            {
                Urun urun = null;

                foreach (var i in Urunler)
                {
                    if (i.urunAd == name)
                    {
                        urun = i;
                        break;
                    }
                    
                }
                return urun;
            }
        }


        static void Main(string[] args)
        {
            var urunler = UrunManager.UrunleriGetir();
            var urunNo = UrunManager.NumarayaGoreUrunGetir(2);
            var urunAd = UrunManager.AdaGoreUrunGetir("NVIDIA RTX 3080 Dual Fan GPU");


            Console.WriteLine($"ÜRÜN ADI: {urunAd.urunAd} ------------------ FİYATI: {urunAd.urunFiyat}"); // ÜRÜN İSMİNE GÖRE ÜRÜN LİSTELEME


            //Console.WriteLine($"ÜRÜN ADI: {urunNo.urunAd} ------------------ FİYATI: {urunNo.urunFiyat}"); // ID GÖRE ÜRÜN LİSTELEME


            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine($"ÜRÜN ADI: {urun.urunAd} ------------------ FİYATI: {urun.urunFiyat}");
            //}

        }
    }
}
