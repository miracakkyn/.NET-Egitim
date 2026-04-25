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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random=new Random(); //Random sınıfından bir nesne oluşturduk
            this.BackColor = Color.FromArgb(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100));//formun arkaplan rengini rastgele degistiriyor (siralama r , g , b seklinde)
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; //form3 yuklendikten sonra timer1 i aktif hale getirir ve timer1_Tick methodu her timer1 in interval degeri kadar sure gecince calisir
            timer1.Interval = 500;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close(); //F4 tusuna basildiginda form3 kapanir
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            //escape tusuna basildiktan sonra elinizi cektiginizde message box acilir
             if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("Escape tusuna basildi , Form Kapatilacak!"); //escape tusuna basildiktan sonra ekrana mesaj kutusu cikarir
                this.Close(); //escape tusuna basildiktan sonra elinizi cektiginizde message box acilir ve devaminda pencere kapatir
            }
        }
    }
}
