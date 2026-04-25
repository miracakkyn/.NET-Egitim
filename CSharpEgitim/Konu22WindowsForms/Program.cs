using System;
using System.Windows.Forms;

namespace Konu22WindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form10());//Proje calistiginda ilk olarak acilacak formu belirtiyoruz. Form3'ü açmak istediğimiz için Form3'ü yazıyoruz.
        }
        
    }
}
