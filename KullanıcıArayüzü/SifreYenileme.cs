using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıArayüzü
{
    public partial class SifreYenileme : Form
    {
        string[,] bilgilerim;
        public SifreYenileme()
        {
            InitializeComponent();
        }
        int kullanicisırası = 0;
        private void btn_giriş_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < bilgilerim.GetLength(0); i++)
            {
                if (txt_kadi.Text.Trim() == bilgilerim[i, 0])
                {
                    //Kullanıcı eşleşmesi oldu fakat birden fazla aynı isimde kullanıcı olabilir.
                    if (txt_anahtar.Text.Trim() == bilgilerim[i, 2])
                    {
                        //Kullancı adı ve anahtar kelime eşleşmesi sağlandı label adları değişecek
                        lbl_anahtar.Text = "Şifre Tekrarı:";
                        lbl_kadi.Text = "Şifre Giriniz:";
                        txt_anahtar.Text = "";
                        txt_kadi.Text = "";
                        kullanicisırası = i;
                        break;
                    }
                    else
                    {
                        //kullanıcı adı eşleşti fakat anahtar kelime yanlış
                        MessageBox.Show("Yanlış anahtar kelilmesi olabilir veya aynı addan başka kullanıcı");
                        continue;
                    }
                }
                else
                {
                    if (i == bilgilerim.GetLength(0) - 1)
                    {
                        //Böyle bir kullanıcı yok
                        MessageBox.Show("Böyle bir kullanıcı yok");
                        break;
                    }
                    continue;
                }
            }
            btn_giriş.Visible = false;
            btn_sifredegis.Visible = true;
        }

        private void SifreYenileme_Load(object sender, EventArgs e)
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

            btn_sifredegis.Visible = false;
        }

        private void btn_sifredegis_Click(object sender, EventArgs e)
        {

            //Bu kyllanıcının sırasını bulup onu değiştirmemiz lazım
            if(txt_anahtar.Text.Trim()== txt_kadi.Text.Trim())
            {
                bilgilerim[kullanicisırası, 2] = txt_kadi.Text.Trim();
                MessageBox.Show("Şifre başarıyla değiştirildi");

            }
            else
            {
                MessageBox.Show("Şifreler uyumlu değil şifre değiştirilemedi");
            }
            string fullpath = @"C:\Users\REŞAT\Desktop\BİLĞİSAYAR\Csharp projelerim\KullanıcıArayüzü\KullanıcıArayüzü\users.txt";

            string[] newBilgi = new string[bilgilerim.GetLength(0)];
            for (int i = 0; i < newBilgi.Length; i++)
            {
                newBilgi[i] = bilgilerim[i, 0] + "+" + bilgilerim[i, 1] + "+" + bilgilerim[i, 2] + "+" + bilgilerim[i, 3];
            }

            File.WriteAllLines(fullpath, newBilgi);
            Thread.Sleep(3000);
            this.Close();
        }
    }
}
