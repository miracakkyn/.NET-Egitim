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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 10)
            {
                label1.Font = new Font("Tahoma", (float)numericUpDown1.Value);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            for(int i = 10; i < 50; i++) {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name);//domainUpDown1'in items özelliği ile domainUpDown1'e font ailesi isimlerini ekliyoruz.
            }
            domainUpDown1.Wrap = true;//domainUpDown1'in wrap özelliğini true yaparak domainUpDown1'in sonuna gelindiğinde tekrar başa dönmesini sağlıyoruz.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            //domainUpDown1'de seçilen font ailesi ismini alarak label1'in fontunu güncelliyoruz.
            textBox1.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }
    }
}
