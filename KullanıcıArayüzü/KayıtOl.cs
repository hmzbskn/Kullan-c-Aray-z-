using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KullanıcıArayüzü
{
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {

        }

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\REŞAT\Desktop\BİLĞİSAYAR\Csharp projelerim\KullanıcıArayüzü\KullanıcıArayüzü";
            string fullpath = path + "\\users.txt";

            string[] satirlar = File.ReadAllLines(fullpath);
            string[,] bilgiler = new string[satirlar.Length + 1, 4];
            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] gecici = new string[4];
                gecici = satirlar[i].Split('+');
                bilgiler[i, 0] = gecici[0];
                bilgiler[i, 1] = gecici[1];
                bilgiler[i, 2] = gecici[2];
                bilgiler[i, 3] = gecici[3];
            }
            bilgiler[satirlar.GetLength(0), 0] = txt_kadi.Text.Trim();
            bilgiler[satirlar.GetLength(0), 1] = txt_şifre.Text.Trim();
            bilgiler[satirlar.GetLength(0), 2] = txt_anahtar.Text.Trim();
            bilgiler[satirlar.GetLength(0), 3] = txt_bakiye.Text.Trim();
            string[] newBilgi = new string[bilgiler.GetLength(0)];
            for(int i = 0 ; i < bilgiler.GetLength(0) ; i++)
            {
                newBilgi[i] = bilgiler[i, 0] + "+" + bilgiler[i, 1] + "+" + bilgiler[i, 2] + "+" + bilgiler[i, 3];
            }
            File.WriteAllLines(fullpath, newBilgi);
            MessageBox.Show("Kayıt başarılı");
            this.Close();
            
        }
    }
}
