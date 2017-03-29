using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomalıAskerlerProblemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> askerler = new List<int>();
            int askerSayisi = Convert.ToInt32(textBox1.Text);
            int adim = Convert.ToInt32(textBox2.Text);
            int sonAsker = 0;
            int sil = 0;
            for (int x = 1; x <= askerSayisi; x++)
            {
                askerler.Add(x);
            }
            do
            {
                sil = sonAsker + adim - 1;
                if (sil >= askerler.Count)
                {
                    sil = sil % askerler.Count;
                }

                askerler.RemoveAt(sil);
                sonAsker = sil;

                if (sonAsker >= askerler.Count)
                {
                    sonAsker = 0;
                }
            }
            while (askerler.Count > 2);
            listBox1.Items.Add(askerler[0]);
            listBox1.Items.Add(askerler[1]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
