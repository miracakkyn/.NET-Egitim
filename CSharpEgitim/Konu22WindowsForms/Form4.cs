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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;//DialogResult sınıfından sonuc adında bir değişken oluşturduk dialog result sinifi MessageBox.Show methodunun geri dönüş tipidir ve kullanıcının mesaj kutusunda hangi butona bastığını tutar
            sonuc = MessageBox.Show("Cikmak istiyor musunuz ? ", "Uyari", MessageBoxButtons.OKCancel);//MessageBox.Show methodu ile ekrana bir mesaj kutusu açar ve kullanıcının hangi butona bastığını sonuc değişkeninde tutar
            //Cikmak istiyormusunuz kismi mesaj kutusunda gosterilecek metindir , Uyari kismi mesaj kutusunun baslik kisminda gosterilecek metindir , MessageBoxButtons.OKCancel parametresi ise mesaj kutusunda OK ve Cancel butonlarının gosterilmesini saglar
            if (sonuc==DialogResult.OK) //eğer kullanıcı mesaj kutusunda OK butonuna basarsa
            {
                MessageBox.Show("Form4 Kapatiliyor..."); //form4 kapanmadan önce ekrana mesaj kutusu cikarir
                this.Close(); //form4 kapanır
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //degiskenlere gerek duymadan direkt if blogu icerisinde MessageBox.Show methodunu kullanarak mesaj kutusu açabiliriz ve kullanıcının hangi butona bastığını if blogu icerisinde kontrol edebiliriz
            if (MessageBox.Show("Cikmak istiyor musunuz ? ", "Uyari", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                MessageBox.Show("Form4 Kapatiliyor...");
                this.Close(); //form4 kapanır
            }
        }
    }
}
