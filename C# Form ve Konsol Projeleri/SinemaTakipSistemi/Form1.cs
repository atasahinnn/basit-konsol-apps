using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sinema salon;

        private void BiletOlusturBtn_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                BilgiLabel.Text = "SALON OLUŞTURULDU.";
            }
            catch
            {
                BilgiLabel.Text = "SALON OLUŞTURULAMADI.";
            }

        }

        private void BiletSatBtn_Click(object sender, EventArgs e)
        {
            salon.BiletSat(checkBox1.Checked);
            BilgiLabel.Text = "Bilet Satıldı. Kalan Koltuk Sayısı: " + salon.BosKoltukOgren();
        }

        private void BiletIptalBtn_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(checkBox1.Checked);
            BilgiLabel.Text = "Bilet İptal Edildi. Kalan Koltuk Sayısı: " + salon.BosKoltukOgren();
        }

        private void BakiyeBtn_Click(object sender, EventArgs e)
        {
            BilgiLabel.Text = "Bakiyeniz: " + salon.BakiyeOgren() +"TL.";
        }

        private void BosKoltukBtn_Click(object sender, EventArgs e)
        {
            BilgiLabel.Text = "Boş Koltuk Sayısı: " + salon.BosKoltukOgren() + ".";
        }
    }
}
