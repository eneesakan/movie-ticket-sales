using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam, misir, su, cips, bilet;

            misir = Convert.ToInt32(textBox1.Text);
            su = Convert.ToInt32(textBox2.Text);
            cips = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);

            toplam = misir * 10 + su * 5 + cips * 15 + bilet * 20;

            label5.Text = "Toplam: " + toplam + " TL";

            kasa = kasa + toplam;

            label6.Text = "Toplam: " + kasa + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            label5.Text = "Toplam 00 TL";

        }
    }
}
