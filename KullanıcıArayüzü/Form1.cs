using System;
using System.IO;

namespace KullanıcıArayüzü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kSirasi = 0;
        string[,] bilgilerim;
        private void btn_giriş_Click(object sender, EventArgs e)
        {
            string fullpath = @"C:\Users\REŞAT\Desktop\BİLĞİSAYAR\Csharp projelerim\KullanıcıArayüzü\KullanıcıArayüzü\users.txt";

            string[] satirlar = File.ReadAllLines(fullpath);
            bilgilerim = new string[satirlar.Length, 4];

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] gecici = new string[4];
                gecici = satirlar[i].Split('+');
                bilgilerim[i, 0] = gecici[0];
                bilgilerim[i, 1] = gecici[1];
                bilgilerim[i, 2] = gecici[2];
                bilgilerim[i, 3] = gecici[3];
            }
            //Kullanıcından aldığımız kullanıcı adını aricaz
            for (int i = 0;i < bilgilerim.GetLength(0) ; i++)
            {
                if (txt_kadi.Text.Trim() == bilgilerim[i, 0])
                {
                    //Kullanıcı adı eşleşti
                    if (txt_şifre.Text.Trim() == bilgilerim[i, 1])
                    {
                        //Şifre eşleşti
                        //Oyun arayüzüne giriş yapacak ****************************
                        kSirasi = i;
                        MessageBox.Show("Giriş başarılı");
                        break;
                    }
                    else
                    {
                        //Kullanıcı adı doğru şifre yanlış
                        MessageBox.Show("Hatalı Şifre");
                        break;
                    }
                }
                else
                {
                    if(i == bilgilerim.GetLength(0) - 1)
                    {
                        //böyle bir kullanıcı yok
                        MessageBox.Show("Kullanıcı Adi Yanlis");
                        break;
                    }
                    continue;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SifreYenileme s1 = new SifreYenileme();
            s1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            KayıtOl k1 = new KayıtOl();
            k1.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fullpath = @"C:\Users\REŞAT\Desktop\BİLĞİSAYAR\Csharp projelerim\KullanıcıArayüzü\KullanıcıArayüzü\users.txt";

            string[] satirlar = File.ReadAllLines(fullpath);
            bilgilerim = new string[satirlar.Length,4];

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] gecici = new string[4];
                gecici = satirlar[i].Split('+');
                bilgilerim[i,0] = gecici[0];
                bilgilerim[i,1] = gecici[1];
                bilgilerim[i,2] = gecici[2];
                bilgilerim[i,3] = gecici[3];
            }
            //i kullanıcı sayısını ifade eder. 0 kullanıcı adı, 1 şifre, 2 anahtar kelime, 3 bakiye
        }
    }
}
