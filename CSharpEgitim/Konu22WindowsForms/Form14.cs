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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lutfen bir resim dosyasi seciniz";
            //openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp;*.gif";//Resim dosyalarını filtrelemek için kullanılır.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;//Resmin boyutunu pictureboxa göre ayarlamak için kullanılır.
                pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);//Resmi pictureboxa atmak için kullanılır.
                label1.Text = openFileDialog1.FileName;//Resmin yolunu labela yazdırmak için kullanılır.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Lutfen bir klasor seciniz";//Klasör seçme dialogunun başlığını belirler.
            folderBrowserDialog1.RootFolder= Environment.SpecialFolder.MyComputer;//Klasör seçme dialogunun başlangıç klasörünü belirler.
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK) {
            
                label2.Text +=" "+ folderBrowserDialog1.SelectedPath;//Seçilen klasörün yolunu labela yazdırmak için kullanılır.
            }
        }
    }
}
