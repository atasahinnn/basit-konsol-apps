using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukemmelSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            if (sayi1TxtB.Text == "")
            {
                MessageBox.Show("LÜTFEN BİR SAYI GİRİNİZ!");
            }
            else
            {
                int sayi;
                sayi = Convert.ToInt32(sayi1TxtB.Text);
                int toplam = 0;
                for (int i = 1; i <= sayi / 2; i++)
                {

                    if (sayi % i == 0)
                    {
                        toplam = toplam + i;
                    }
                }
                if (sayi == toplam)
                {
                    MessageBox.Show("MÜKEMMEL SAYI.");
                }
                else
                {
                    MessageBox.Show("MÜKEMMEL SAYI DEĞİLDİR.");
                }
            }

        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {

            if (sayi1TxtB.Text == "" || sayi2TxtB.Text == "")
            {
                MessageBox.Show("LÜTFEN SAYILARI GİRİNİZ.");
            }
            else
            {
                mukemmelSayiList.Items.Clear();
                int sayi, sonsayi;
                int toplam;
                sayi = Convert.ToInt32(sayi1TxtB.Text);
                sonsayi = Convert.ToInt32(sayi2TxtB.Text);
                for (int i = sayi; i <= sonsayi; i++)
                {
                    toplam = 0;
                    for (int j = 1; j <= (i / 2); j++)
                    {
                        if (i % j == 0)
                        {
                            toplam = toplam + j;
                        }
                    }

                    if (i == toplam)
                    {
                        mukemmelSayiList.Items.Add(i);
                    }
                    label3.Text = mukemmelSayiList.Items.Count.ToString() + " adet mükemmel sayı listelenmiştir.";
                }
            }

        }

        private void bulBtn_Click(object sender, EventArgs e)
        {
            mukemmelSayiList.Items.Clear();;
            int kacsayi;
            int toplam;
            kacsayi = Convert.ToInt32(sayi3TxtB.Text);
            for (int i = 1; i <= 100000; i++)
            {
                toplam = 0;
                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        toplam = toplam + j;
                    }
                }

                if (i == toplam)
                {
                    mukemmelSayiList.Items.Add(i);
                    if (mukemmelSayiList.Items.Count == kacsayi)
                    {
                        string gelenSayi = mukemmelSayiList.Items[mukemmelSayiList.Items.Count - 1].ToString();
                        MessageBox.Show(kacsayi.ToString() + ". sırada gelen mükemmel sayı: " + gelenSayi.ToString() + ".");
                        mukemmelSayiList.Items.Clear();
                        break;
                        
                    }
                    sayi3TxtB.Text = "";
                }
                
            }
        }
    }
}



    

