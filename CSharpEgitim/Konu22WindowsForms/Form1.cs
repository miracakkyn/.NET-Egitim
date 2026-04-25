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
            //butona tiklandiginda ekrana mesaj kutusu cikarir
            Form2 form2=new Form2(); //Form2 sinifindan bir nesne olusturduk
            //form2.Show(); //olusturdugumuz form2 penceresini ekranda gosterir
            form2.ShowDialog(); //olusturdugumuz form2 penceresini ekranda gosterir ve form2 kapanmadan form1 e geri donulmez yani form2 modal bir pencere olur
            //this.Hide(); //form1 i gizler yani form1 ekranda gozukmez ama arka planda calismaya devam eder closedan farki proje kapanmaz sadece form1 gizlenir

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form 1 penceresi kapatildi"); //form1 kapatildiktan sonra ekrana mesaj kutusu cikarir  , eger this.close dan sonra yazarsak mesaj kutusu gosterilmez cunku form1 kapanir ve mesaj kutusu gosterilemez   

            this.Close();
            //this nesnesi form1 i temsil eder ve close methodu ile form1 kapanir
                //Form1.ActiveForm.Close(); //bu kodda form1 i kapatir
        }
    }
}
