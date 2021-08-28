using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ChampionsLeague
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "champions.wav";
            ses.Play();
            

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, torba1LstB.Items.Count);

            if (listBox1.Items.Count<1)
            {
                listBox1.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }
            else if (listBox2.Items.Count < 1)
            {
                listBox2.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }

            else if (listBox3.Items.Count < 1)
            {
                listBox3.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }

            else if (listBox4.Items.Count < 1)
            {
                listBox4.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }
            else if (listBox5.Items.Count < 1)
            {
                listBox5.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }
            else if (listBox6.Items.Count < 1)
            {
                listBox6.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }
            else if (listBox7.Items.Count < 1)
            {
                listBox7.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }
            else if (listBox8.Items.Count < 1)
            {
                listBox8.Items.Add(torba1LstB.Items[x]);
                torba1LstB.Items.RemoveAt(x);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, torba2LstB.Items.Count);

            if (listBox1.Items.Count < 2)
            {
                listBox1.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }
            else if (listBox2.Items.Count < 2)
            {
                listBox2.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }

            else if (listBox3.Items.Count < 2)
            {
                listBox3.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }

            else if (listBox4.Items.Count < 2)
            {
                listBox4.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }
            else if (listBox5.Items.Count < 2)
            {
                listBox5.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }
            else if (listBox6.Items.Count < 2)
            {
                listBox6.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }
            else if (listBox7.Items.Count < 2)
            {
                listBox7.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }
            else if (listBox8.Items.Count < 2)
            {
                listBox8.Items.Add(torba2LstB.Items[x]);
                torba2LstB.Items.RemoveAt(x);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, torba3LstB.Items.Count);

            if (listBox1.Items.Count < 3)
            {
                listBox1.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }
            else if (listBox2.Items.Count < 3)
            {
                listBox2.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }

            else if (listBox3.Items.Count < 3)
            {
                listBox3.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }

            else if (listBox4.Items.Count < 3)
            {
                listBox4.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }
            else if (listBox5.Items.Count < 3)
            {
                listBox5.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }
            else if (listBox6.Items.Count < 3)
            {
                listBox6.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }
            else if (listBox7.Items.Count < 3)
            {
                listBox7.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }
            else if (listBox8.Items.Count < 3)
            {
                listBox8.Items.Add(torba3LstB.Items[x]);
                torba3LstB.Items.RemoveAt(x);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();           
            int x = rnd.Next(0, torba4LstB.Items.Count);
            

            if (listBox1.Items.Count < 4)
            {
                listBox1.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }
            else if (listBox2.Items.Count < 4)
            {

                listBox2.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }

            else if (listBox3.Items.Count < 4)
            {
                listBox3.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }

            else if (listBox4.Items.Count < 4)
            {
                listBox4.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }
            else if (listBox5.Items.Count < 4)
            {
                listBox5.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }
            else if (listBox6.Items.Count < 4)
            {
                listBox6.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }
            else if (listBox7.Items.Count < 4)
            {
                listBox7.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }
            else if (listBox8.Items.Count < 4)
            {
                listBox8.Items.Add(torba4LstB.Items[x]);
                torba4LstB.Items.RemoveAt(x);
            }
        }
    }
}
