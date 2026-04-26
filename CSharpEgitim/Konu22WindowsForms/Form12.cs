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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //trackbar kontrolu degfer artis yada azalis islemleri yaptirmamizi saglar
            trackBar1.Minimum = 1;//trackbarin minimum degerini belirliyoruz
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 10;//trackbarin tik araliklarini belirliyoruz
            textBox1.Text = "trackbar kullanimi";

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Tahoma", trackBar1.Value);

        }
    }
}
