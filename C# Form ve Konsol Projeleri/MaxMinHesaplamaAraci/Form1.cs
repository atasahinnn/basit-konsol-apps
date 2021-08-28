using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxMinHesaplamaAraci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int[] rndSayilar = new int[10];

            for (int i = 0; i < rndSayilar.Length; i++)
            {
                rndSayilar[i] = rnd.Next(1, 99);
                listBox1.Items.Add(rndSayilar[i]);
            }

            int max = Max(rndSayilar);
            int min = Min(rndSayilar);

            MessageBox.Show("Max Sayı: " + max);
            MessageBox.Show("Min Sayı: " + min);

        }



        private int Max(int[] x)
        {
            int buyuk = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (buyuk < x[i])
                {
                    buyuk = x[i];
                }
            }

            return buyuk;
        }

        private int Min(int[] x)
        {
            int kucuk = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (kucuk > x[i])
                {
                    kucuk = x[i];
                }
            }

            return kucuk;
        }
    }
}
