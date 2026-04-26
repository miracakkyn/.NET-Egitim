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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;//tabControl1'deki tabPage2'ye geçiş yapar.
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;//Form13 yüklendiğinde tabControl1'deki üçüncü sekmeye geçiş yapar. selected tab ile de aynı işlemi yapabiliriz. tabControl1.SelectedTab = tabPage3; şeklinde de yazabiliriz.
        }
    }
}
