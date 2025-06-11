using System;
using System.Windows.Forms;

namespace FilmArşivPuanlamaSistemi
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

            // Giriş formunu göster
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Kullanici girisYapan = loginForm.GirisYapanKullanici;
                Application.Run(new Form1(girisYapan));
            }
        }
    }
}
