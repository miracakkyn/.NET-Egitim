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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //nullorempty ve nullorwhitespace metotları string ifadelerin boş olup olmadığını kontrol ederler. Ancak nullorempty metodu sadece null veya boş string ifadeleri kontrol ederken, nullorwhitespace metodu ise null, boş veya sadece boşluk karakterlerinden oluşan string ifadeleri kontrol eder. Bu nedenle, nullorwhitespace metodu daha kapsamlı bir kontrol sağlar ve genellikle kullanıcı girişi gibi durumlarda tercih edilir.
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanici Adi Bos Birakilamaz");
            }else if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Sifre Bos Birakilamaz");
            }else if (string.IsNullOrWhiteSpace(txtKullaniciKodu.Text))
            {
                MessageBox.Show("Kullanici Kodu Bos Birakilamaz");
            }
            else
            {
                string kullaniciAdi = "admin";
                string sifre = "12345";
                string kullaniciKodu= "abcde";
                if(txtKullaniciAdi.Text==kullaniciAdi && txtSifre.Text==sifre && txtKullaniciKodu.Text == kullaniciKodu) {
                    MessageBox.Show("Hosgeldin "+txtKullaniciAdi.Text);
                    groupBox1.Visible=false;
                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Ile Eslesen Kullanici Bulunamadi !" , "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
