using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konu22WindowsForms
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                progressBar1.Maximum= sayi;
                for (int i = 0; i < sayi; i++)
                {
                    progressBar1.Value = i; 
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sayı giriniz.");
            }

        }
    }
}
