using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }

        // Değişkenler
        Random r = new Random();
        string[,] kelimelerDizisi = new string[14, 2];
        int yeniKelimeLevel = 2;
        int eskiKelimeLevel = 0;
        byte olusanKelimeDizisi = 0;
        string olusanKelime = "";
        int kazanilacakPuan = 0;
        int toplamPuan = 0;
        int k = 0;
        char[] harfler;
        int[] rasgeleSayilar;
        byte kalanSure = 15;

        public void kelimeleriYukle()
        {
            kelimelerDizisi[0, 0] = "Mars";
           
            kelimelerDizisi[0, 1] = "Güneş sisteminde 4. gezegen.";

            kelimelerDizisi[1, 0] = "Boks";
            kelimelerDizisi[1, 1] = "2 kişinin yumruklaşarak yaptığı spor.";

            kelimelerDizisi[2, 0] = "Banka";
            kelimelerDizisi[2, 1] = "Parayı yatırıp belli bir faiz aldığımız yer.";
            kelimelerDizisi[3, 0] = "Çakal";
            kelimelerDizisi[3, 1] = "Köpekgiller cinsinden yabani bir hayvan.";

            kelimelerDizisi[4, 0] = "Ketçap";
            kelimelerDizisi[4, 1] = "Genellikle patatese sıkılan domatesten yapılan yiyecek.";
            kelimelerDizisi[5, 0] = "Şinasi";
            kelimelerDizisi[5, 1] = "İlk noktalama işaretlerinin kullanan kişi.";

            kelimelerDizisi[6, 0] = "Monitör";
            kelimelerDizisi[6, 1] = "Bilgisayar'da görüntüyü sağlanan katot ışınlı tüp.";
            kelimelerDizisi[7, 0] = "Paraşüt";
            kelimelerDizisi[7, 1] = "Uçaktan atladıktan sonra açılıp yerçekimini yavaşlatan şey.";

            kelimelerDizisi[8, 0] = "Sardalya";
            kelimelerDizisi[8, 1] = "Konservede bulunan bir çeşit balık türü";
            kelimelerDizisi[9, 0] = "Şarapnel";
            kelimelerDizisi[9, 1] = "Patladığında etrafa küçük parçalar saçan bir tür top mermisi";

            kelimelerDizisi[10, 0] = "Jeneratör";
            kelimelerDizisi[10, 1] = "Elektrikler kesilince devreye girer ve enerji sağlar.";
            kelimelerDizisi[11, 0] = "Kalorifer";
            kelimelerDizisi[11, 1] = "Evlerimizde sıcak su kaynatarak ısındığımız , yapıları bütünüyle ısıtmasıdır.";

            kelimelerDizisi[12, 0] = "Helikopter";
            kelimelerDizisi[12, 1] = "Pervanesi ile havalanıp uçan araç.";
            kelimelerDizisi[13, 0] = "Bilgisayar";
            kelimelerDizisi[13, 1] = "Bilişim Teknolojilerinde kullanılan hızlı işlemler yapan cihaz.";
        }

        public void yeniSoru()
        {
            eskiKelimeLevel += 2;
            yeniKelimeLevel += 2;

            //  if (yeniKelimeLevel >= 14) return; // dizi sınırı aşmasın

            olusanKelimeDizisi = Convert.ToByte(r.Next(eskiKelimeLevel, yeniKelimeLevel));

            lblSoru.Text = "Soru : " + kelimelerDizisi[olusanKelimeDizisi, 1]; // 1 soru 0 kelimedir.
            olusanKelime = kelimelerDizisi[olusanKelimeDizisi, 0];

            lblHarfLength.Text = "Kelime Harf Uzunluğu : " + olusanKelime.Length;

            kazanilacakPuan = olusanKelime.Length * 100;
            lblKazanPuan.Text = "Kazanılacak Puan : " + kazanilacakPuan;

            lblKelime.Text = "";
            for (int i = 0; i < olusanKelime.Length; i++)
            {
                lblKelime.Text += "?";
            }

            k = 0; // rasgele harflerin döngüsü için değişen değişken
            harfler = new char[olusanKelime.Length];
            rasgeleSayilar = new int[harfler.Length];
            for (int i = 0; i < rasgeleSayilar.Length; i++) // içine -1 atıyorum 0 olunca döngü sonsuz döngüye giriyor.
            {
                rasgeleSayilar[i] = -1;
            }

            kalanSure = 15;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeleriYukle();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            // oynanabirliği aç
            btnHarfAl.Enabled = true;
            btnTahmin.Enabled = true;
            txtTahmin.Enabled = true;

            tmrKalanSure.Enabled = true; // süreyi aç

            eskiKelimeLevel = -2; // 2 artınca 0
            yeniKelimeLevel = 0; // 2 artınca 2 olsun.

            yeniSoru();

            toplamPuan = 0;
            lblTopPuan.Text = "Toplam Puan : 0 ";
        }

        private void btnHarfAl_Click(object sender, EventArgs e)
        {

            harfler = olusanKelime.ToCharArray();
            byte rasgeleHarf = Convert.ToByte(r.Next(0, harfler.Length));
            while (Array.IndexOf(rasgeleSayilar, rasgeleHarf) != -1) // rasgele sayılardan aynısı oluşmasın
            {
                rasgeleHarf = Convert.ToByte(r.Next(0, harfler.Length));
            }
            rasgeleSayilar[k] = rasgeleHarf;
            char verilecekHarf = harfler[rasgeleHarf];

            lblKelime.Text = lblKelime.Text.Remove(rasgeleHarf, 1);
            lblKelime.Text = lblKelime.Text.Insert(Convert.ToInt32(rasgeleHarf), verilecekHarf.ToString());

            kazanilacakPuan = kazanilacakPuan - 100;
            lblKazanPuan.Text = "Kazanılacak Puan : " + kazanilacakPuan.ToString();

            if (k < harfler.Length - 1) k++;
            else
            {
                //Bütün harfler alındı yeni soruya geçir
                MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                yeniSoru();
                return;
            }
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahmin.Text;

            if (tahmin.ToLower() == olusanKelime.ToLower())
            {
                // kelime doğru bilindi.
                if (yeniKelimeLevel >= 14)
                {
                    tmrKalanSure.Enabled = false;
                    toplamPuan += kazanilacakPuan;
                    lblTopPuan.Text = "Toplam Puan : " + toplamPuan.ToString();
                    MessageBox.Show("Oyun bitmiştir. Toplam Puanınız : " + toplamPuan.ToString());

                    txtTahmin.Text = "";
                    btnHarfAl.Enabled = false;
                    btnTahmin.Enabled = false;
                    txtTahmin.Enabled = false;

                    eskiKelimeLevel = -2;
                    yeniKelimeLevel = 0;
                    return;
                }

                yeniSoru();

                toplamPuan += kazanilacakPuan;
                lblTopPuan.Text = "Toplam Puan : " + toplamPuan.ToString();

                txtTahmin.Text = "";
                txtTahmin.Focus();

            }
            else
            {
                //kelime yanlış bilindi.
                MessageBox.Show("Kelimeyi yanlış bildiniz. Doğrusu : " + olusanKelime + " olucaktı. Kazanılan Puan : 0");
                txtTahmin.Text = "";
                if (yeniKelimeLevel >= 14) // yanlış bilerek biter ise
                {
                    tmrKalanSure.Enabled = false;
                    MessageBox.Show("Oyun bitmiştir. Toplam Puanınız : " + toplamPuan.ToString());

                    txtTahmin.Text = "";
                    btnHarfAl.Enabled = false;
                    btnTahmin.Enabled = false;
                    txtTahmin.Enabled = false;

                    eskiKelimeLevel = -2;
                    yeniKelimeLevel = 0;
                    return;
                }
                yeniSoru();
            }
        }

        private void tmrKalanSure_Tick(object sender, EventArgs e)
        {
            if (kalanSure == 0)
            {
                tmrKalanSure.Enabled = false;
                MessageBox.Show("Süreniz dolmuştur. Diğer soruya yönlendiriliyorsunuz. Kazanılan puan : 0");
                yeniSoru();
                tmrKalanSure.Enabled = true;
            }
            else
            {
                kalanSure -= 1;
                lblKalanSure.Text = "Kalan Süre : " + kalanSure.ToString();
            }
        }


    }
}
