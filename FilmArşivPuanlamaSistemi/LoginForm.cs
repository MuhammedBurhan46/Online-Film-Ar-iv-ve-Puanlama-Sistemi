using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FilmArşivPuanlamaSistemi
{
    public partial class LoginForm : MetroForm
    {
        public Kullanici GirisYapanKullanici { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                GirisYapanKullanici = new Admin(kullaniciAdi, sifre);
            }
            else if (kullaniciAdi == "uye1" && sifre == "1234")
            {
                GirisYapanKullanici = new Uye(kullaniciAdi, sifre);
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        
    
}
    }
}
