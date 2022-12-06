using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg5VKIHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int agirlik = (int)numericUpDown1.Value;
            double boy = Convert.ToDouble(textBox1.Text) / 100;

            int vki = (int)(agirlik / (boy * boy));
            label4.Text = "VKI: " + vki.ToString();

            int altsinir;
            int ustsinir;

            if(radioButton1.Checked)
            {
                altsinir = 20;
                ustsinir = 25;
            }
            else
            {
                altsinir = 19;
                ustsinir = 24;
            }
            if (vki < altsinir)
            {
                label5.Text = "VKI dusuk, kilo almalisiniz";
            }
            else if (vki > ustsinir)
            {
                label5.Text = "VKI yuksek, kilo vermelisiniz";
            }
            else
                label5.Text = "Ideal VKI";

        }
    }
}
