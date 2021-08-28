using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayiHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool asalMi(int sayi)
        {
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }

            return durum;
        }

        private void bulBtn_Click(object sender, EventArgs e)
        {
            asalSayiLstB.Items.Clear();
            int sayac = 0;
            int sayi = Convert.ToInt32(asalTxtB.Text);
            while (true)
            {
                sayi++;
                if (asalMi(sayi)==true)
                {
                 
                    asalSayiLstB.Items.Add(sayi);
                    sayac++;
                    if (sayac == 2)
                    {
                        int ilkSayi = asalSayiLstB.Items.Count - 2;
                        int sonSayi = asalSayiLstB.Items.Count - 1;
                        if (sonSayi - ilkSayi >= 3000)
                        {
                            MessageBox.Show("3000'den Fazla Fark Olan ilk X Asal Sayı Değeri " + ilkSayi.ToString() + " Değeridir");
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Sayının, İlk 2 Asal Farkı 3000'den Azdır.");
                        }
                        break;

                        // Hocam hangi rakamı girersem gireyim, aralarında 3000 sayıdan fazla fark olan ardışık iki asal sayı bulamadım.
                        // Dakikalarca işlem yapılmasına rağmen hala tamamlanmadı. 
                    }

                }
            }

        }

    }
}
