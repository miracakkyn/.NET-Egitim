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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //proje calistiririldiginda ilk bu ekran gelecek ve bu method calisacak
        {
            //form ekraninda mause ile cift tiklayarak bu methodu olusturduk
             MessageBox.Show("Form1 yuklendi"); //form yuklendikten sonra ekrana mesaj kutusu cikarir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
