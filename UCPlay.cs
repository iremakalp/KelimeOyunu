using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class UCPlay : UserControl
    {
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;
        int toplamp;
        string[] sorular = new string[14];
        string[] kelimeler = new string[14];
        int j = 0;
        int sorusayisi,soru;
        string kelime;
        int soruPuani = 0;
        bool basla;
        Random r = new Random();
        int[] rasgeleSayilar;
        char[] harfler;
        int k,sansayac,dksayac;
        byte kalanSure = 20;
        string sure;
        public UCPlay()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl uc)
        {
            ucHomePanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            ucHomePanel.Controls.Add(uc);
        }
        public void baglanti()
        {
            bag = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=1562;SslMode=none");
            bag.Open();

        }
        public void soruSec() //veritabanindan soru secmek icin calisir
        {
            baglanti();
            MySqlCommand komut3 = new MySqlCommand();
            for (int i = 4; i <= 10; i++)
            {
                komut3.CommandText = "SELECT * FROM tbl_sorular WHERE char_length(kelime)='" + i + "' ORDER BY rand() LIMIT 2";
                komut3.Connection = bag;
                komut3.CommandType = CommandType.Text;
                dr = komut3.ExecuteReader();
                while (dr.Read())
                {
                    if (true)
                    {
                        for (int a = 0; a < 2; a++)
                        {
                            sorular[j] = Convert.ToString(dr["soru"]);
                            kelimeler[j] = Convert.ToString(dr["kelime"]);

                        }
                        j++;
                    }
                }
                dr.Close();
            }
        }
        public void yeniSoru() //soruya gore sirayla sorularin gelmesi icin calisir
        {
            try
            {
                if (basla == true)
                {
                    timer1.Enabled = true;
                }
                soruLbl.Text = "Soru:" + sorular[sorusayisi];
                sorusayisi++;
                basla = false;
                if (soru == 1)
                {
                    kelime = kelimeler[0];
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();
                }
                if (soru == 2)
                {
                    kelime = kelimeler[1];
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 3)
                {
                    kelime = kelimeler[2];
                    guna2Panel5.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 4)
                {
                    kelime = kelimeler[3];
                    guna2Panel5.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 5)
                {
                    kelime = kelimeler[4];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 6)
                {
                    kelime = kelimeler[5];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 7)
                {
                    kelime = kelimeler[6];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 8)
                {
                    kelime = kelimeler[7];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 9)
                {
                    kelime = kelimeler[8];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 10)
                {
                    kelime = kelimeler[9];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 11)
                {
                    kelime = kelimeler[10];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 12)
                {
                    kelime = kelimeler[11];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (soru == 13)
                {
                    kelime = kelimeler[12];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true; guna2Panel10.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();
                }
                if (soru == 14)
                {
                    kelime = kelimeler[13];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true; guna2Panel10.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                soru++;
                kalanSure = 20;
                cevapBtn.Enabled = true;
                harfAlBtn.Enabled = true;
                sonrakiBtn.Enabled = false;
                k = 0; // rasgele harflerin dongusu icin degisen degisken
                harfler = new char[kelime.Length]; //kelime uzunlugu kadar harf dizisi olusturulur
                rasgeleSayilar = new int[harfler.Length]; //rastgele sayilar dizisi doldurulur
                for (int i = 0; i < rasgeleSayilar.Length; i++)
                {
                    rasgeleSayilar[i] = -1;
                }
                baslaBtn.Visible = false;
                harf1Lbl.Text = "";
                harf2Lbl.Text = "";
                harf3Lbl.Text = "";
                harf4Lbl.Text = "";
                harf5Lbl.Text = "";
                harf6Lbl.Text = "";
                harf7Lbl.Text = "";
                harf8Lbl.Text = "";
                harf9Lbl.Text = "";
                harf10Lbl.Text = "";
            }
            catch (Exception)
            {
                ;
            }
        }
        public void kisiEkle() //oyunculari veritabanina ekler
        {
            try
            {
                // referans https://www.c-sharpcorner.com/UploadFile/9582c9/insert-update-delete-display-data-in-mysql-using-C-Sharp/

                baglanti();
                DateTime tarih = DateTime.Now.Date;
                string format = "yyyy-MM-dd"; //referans http://furkanalniak.com/c-veri-tabanina-uygun-datetime-formati/
                var zamanim = tarih.ToString(format);
                string eklemekomut = "insert into tbl_oyuncular(İsim,Puan,KalanSure,Tarih) values ('" + UCHome.isim + "','" + toplamp.ToString() + "','" + sure + "','" + zamanim + "')";
                komut = new MySqlCommand(eklemekomut, bag);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                }
                bag.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void txtaydet() //oyunculari text dosyasina kaydeder
        {
            string file = "C:/Users/İrem Akalp/Source/Repos/KelimeOyunu/bin/Debug/Belgeler/oyuncular.txt";
            string writeText = "İsim: " + UCHome.isim + "  Puan: " + toplamp + " Kalan Süre: " + sure + "  Oynandığı Tarih: " + DateTime.Now.ToString();

            FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(file, Environment.NewLine + writeText);
        }
        private void UCPlay_Load(object sender, EventArgs e)
        {
            guna2Panel5.Visible = false;
            guna2Panel6.Visible = false;
            guna2Panel7.Visible = false;
            guna2Panel8.Visible = false;
            guna2Panel9.Visible = false;
            guna2Panel10.Visible = false;
            timePanel1.Visible = false;
            toplamp = 0;
            toplamPuan.Text = "Toplam Puan:" + toplamp;      
            timer2Lbl.Text = "04:00";
            timer1Lbl.Text = "0:20";
            sorusayisi = 0;
            soru = 1;
            timer1.Enabled = false;
            timer1.Interval = 1000;
            sonrakiBtn.Visible = false;
            cevapTxt.Enabled = false;
            harfAlBtn.Enabled = false;
            cevapBtn.Enabled = false;
            timer2.Enabled = false;
            timer2.Interval = 1000;
        }
        public void rasgeleHarf(int rasgeleHarf, char alinanHarf)
        {
            soruPuani -= 100; //harf alindiginda sorudan puan duser
            soruPuanLbl.Text = soruPuani.ToString();
            // gelen rasgeleHarf indexine gore labellarin gorunmesi icin calisir
            if (rasgeleHarf == 0)
            {
                harf1Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 1)
            {
                harf2Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 2)
            {
                harf3Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 3)
            {
                harf4Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 4)
            {
                harf5Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 5)
            {
                harf6Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 6)
            {
                harf7Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 7)
            {
                harf8Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 8)
            {
                harf9Lbl.Text = alinanHarf.ToString();
            }
            if (rasgeleHarf == 9)
            {
                harf10Lbl.Text = alinanHarf.ToString();
            }
        }
        private void sonrakiBtn_Click_1(object sender, EventArgs e)
        {
            string tahmin = cevapTxt.Text;
            if (tahmin.ToLower() == kelime.ToLower())
            {
                if (soru >= 15) //tum sorular cevaplandiysa calisan kisim
                {
                    toplamp += soruPuani;
                    toplamPuanLbl.Text = "Toplam Puan " + " " + toplamp.ToString();
                    MessageBox.Show("Oyun bitti." + "\n" + "İsim: " + UCHome.isim + "\n" + "Toplam Puanınız: " + toplamp + "\n" + "Kalan Süre: " + sure + "\n" + "Tarih:" + DateTime.Now.ToString());
                    kisiEkle();
                    txtaydet();
                    UCHome uCHome = new UCHome(); //oyun bittiginde baslangic sayfasina geri doner
                    addUserControl(uCHome);
                    baslaBtn.Visible = true;
                    return;
                }
                toplamp += soruPuani;
                toplamPuanLbl.Text = "Toplam Puan " + " " + toplamp.ToString();
                yeniSoru();
                cevapTxt.Text = "";
                cevapTxt.Enabled = false;
                timer2.Enabled = false;
                timePanel1.Visible = false;
                harfAlBtn.Enabled = true;
                sonrakiBtn.Enabled = false;
                cevapBtn.Enabled = true;
                kalanSure = 20;
            }
            else
            {
                //yanlis bilirse calisacak kisim
                MessageBox.Show(" Yanlış bildiniz! Cevap: " + kelime + " " + " Kazanılan Puan : 0");
                cevapTxt.Text = "";
                basla = true;
                if (soru >= 15) // soruyu yanlis bilerek oyun biterse
                {
                    MessageBox.Show("Oyun bitti." + UCHome.isim + "\n" + "Toplam Puanınız : " + toplamp.ToString() + "\n" + " Kalan Süre:" + sure + "\n" + "Tarih:" + DateTime.Now.ToString());
                    kisiEkle();
                    txtaydet();
                    UCHome uCHome = new UCHome(); //oyun bittiginde baslangic sayfasina geri doner
                    addUserControl(uCHome);
                    baslaBtn.Visible = true;
                    return;
                }
                toplamPuanLbl.Text = "Toplam Puan " + " " + toplamp.ToString();
                yeniSoru();
                cevapTxt.Text = "";
                cevapTxt.Enabled = false;
                timer2.Enabled = false;
                timePanel1.Visible = false;
                harfAlBtn.Enabled = true;
                sonrakiBtn.Enabled = false;
                cevapBtn.Enabled = true;
                kalanSure = 20;
                timer1.Enabled = true;
            }
        }
        private void baslaBtn_Click_1(object sender, EventArgs e)
        {
            soruSec();
            sansayac = 0; dksayac = 0;
            basla = true;
            timer1.Enabled = true;
            yeniSoru();
            timer2.Enabled = false;
            Home.guna2Panel1.Enabled = false;

        }
        private void harfAlBtn_Click_1(object sender, EventArgs e)
        {
            switch (soru) //gelen soruya gore kelimeler belirlenir ve harf ona gore secilir
            {
                case 1:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length); //kelime uzunlugu kadar rastgele sayi uretilir ve bir dizide tutulur
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf); // labellarin gelecegi metot cagirilir

                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 2:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 3:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 4:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 5:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 6:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 7:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 8:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 9:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 10:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 11:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 12:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 13:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 14:
                    {
                        harfler = kelime.ToCharArray();
                        int rastegele = r.Next(0, harfler.Length);
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1)
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele];
                        rasgeleHarf(rastegele, alinanHarf);
                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya geçir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        timer1.Enabled = false;
                        break;
                    }
            }
        }
        private void cevapBtn_Click_1(object sender, EventArgs e)
        {
            timePanel1.Visible = true;
            timer1.Enabled = false;
            basla = true;
            sonrakiBtn.Visible = true;
            timer2.Enabled = true;
            cevapTxt.Enabled = true;
            harfAlBtn.Enabled = false;
            sonrakiBtn.Enabled = true;
            cevapBtn.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sansayac++;
            if (sansayac > 50)
            {
                timer2Lbl.Text = "0" + (3 - dksayac).ToString() + " : 0" + (60 - sansayac).ToString();

            }
            else
            {
                timer2Lbl.Text = "0" + (3 - dksayac).ToString() + " : " + (60 - sansayac).ToString();
            }
            sure = timer2Lbl.Text;

            if (sansayac == 60)
            {
                dksayac++;
                sansayac = 0;
            }
            if (dksayac == 4)
            {
                baslaBtn.Enabled = false;
                cevapBtn.Enabled = false;
                harfAlBtn.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Süreniz bitmiştir." + "\n" + "İsim: " + UCHome.isim + "\n" + "Toplam Puanınız: " + toplamp + "\n" + "Tarih:" + DateTime.Now.ToString() + "\n" + "Giriş sayfasına yönlendiriliyorsunuz.");
                kisiEkle();
                txtaydet();
                UCHome ucHome = new UCHome();
                addUserControl(ucHome);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (kalanSure == 0)
            {
                timer2.Enabled = false;
                MessageBox.Show("Süreniz dolmuştur. Kazanılan puan : 0");
                timePanel1.Visible = false;
                cevapTxt.Enabled = false;
                sonrakiBtn.Enabled = false;
                timer1.Enabled = false;
                yeniSoru();
            }
            else
            {
                kalanSure -= 1;
                timer1Lbl.Text = kalanSure.ToString();
            }
        }
    }
}
