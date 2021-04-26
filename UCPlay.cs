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
using System.Configuration;
namespace KelimeOyunu
{
    public partial class UCPlay : UserControl
    {     
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;
        int toplamp;
        string[] sorular = new string[14]; //sorular icin dizi
        string[] kelimeler = new string[14]; //kelimeler icin dizi
        int j = 0; //sorulari diziye almak icin
        int sorusayisi;
        string kelime;
        int soruPuani = 0;
        bool basla; //oyuna baslandigini kontrol etmek icin
        Random r = new Random();
        int[] rasgeleSayilar; //rasgele harf almak icin sayi dizisi
        char[] harfler; //rasgele harf almak icin
        int k,sansayac,dksayac; //timer icin
        byte kalanSure = 20; //20saniye icin
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
            bag = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=1562;SslMode=Required"); // https://mysqlconnector.net/troubleshooting/retrieval-public-key/
            bag.Open();

        } //veritabani baglantisi icin
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
                if (basla == true) // soru almaya baslandiysa 4 dakikayı baslat
                {
                    timer1.Enabled = true;
                }
                soruLbl.Text =  sorular[sorusayisi];
                basla = false;
                if (sorusayisi == 0)
                {
                    kelime = kelimeler[sorusayisi];
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();
                }
                if (sorusayisi == 1)
                {
                    kelime = kelimeler[sorusayisi];
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 2)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 3)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 4)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 5)
                {
                    kelime = kelimeler[5];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 6)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 7)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 8)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 9)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 10)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 11)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                if (sorusayisi == 12)
                {
                    kelime = kelimeler[12];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true; guna2Panel10.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();
                }
                if (sorusayisi == 13)
                {
                    kelime = kelimeler[sorusayisi];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true; guna2Panel10.Visible = true;
                    soruPuani = kelime.Length * 100;
                    soruPuanLbl.Text = soruPuani.ToString();

                }
                sorusayisi++;
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
                DateTime tarih = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss"; //referans http://furkanalniak.com/c-veri-tabanina-uygun-datetime-formati/
                var zaman = tarih.ToString(format);
                string eklemekomut = "insert into tbl_oyuncular(İsim,Puan,KalanSure,Tarih) values ('" + UCHome.isim + "','" + toplamp.ToString() + "','" + sure + "','" + zaman + "')";
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
        public void scoreUpdate()// yeni oyun oynandıysa tabloyu guncelleme
        {
            baglanti();
            string komut = "SELECT İsim,Puan,KalanSure,Tarih FROM tbl_oyuncular ORDER BY puan DESC limit 5";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }      
        private void UCPlay_Load(object sender, EventArgs e)
        {
            //baslangicte sadece 4 harf gostermek icin digerleri gizlnedi
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
            timer1Lbl.Text = "20";
            sorusayisi = 0;
            timer1.Enabled = false;
            timer1.Interval = 1000;
            sonrakiBtn.Visible = false;
            cevapTxt.Enabled = false;
            harfAlBtn.Enabled = false;
            cevapBtn.Enabled = false;
            timer2.Enabled = false;
            timer2.Interval = 1000;
            guna2GradientPanel1.Visible = false;
        }
        //alinan rasgele harfi labelda  yazdirma kodu
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

        //harf alma butonu
        private void harfAlBtn_Click_1(object sender, EventArgs e)
        {
            switch (sorusayisi) //gelen soruya gore kelimeler belirlenir ve harf ona gore secilir
            {
                case 0:
                    {
                        harfler = kelime.ToCharArray(); //kelime harflerine ayrılır diziye atilir
                        int rastegele = r.Next(0, harfler.Length); //kelime uzunlugu kadar rastgele sayi uretilir
                        while (Array.IndexOf(rasgeleSayilar, rastegele) != -1) //ayni sayi gelmemesi icin
                        {
                            rastegele = r.Next(0, harfler.Length);

                        }
                        rasgeleSayilar[k] = rastegele;
                        char alinanHarf = harfler[rastegele]; //harfler dizisinden gelen rastgele sayiya ait harf alinir
                        rasgeleHarf(rastegele, alinanHarf); // labellarin gelecegi metot cagirilir

                        if (k < harfler.Length - 1)
                        {
                            k++;
                        }
                        else
                        {
                            //Bütün harfler alındı yeni soruya gecir
                            MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                            yeniSoru();
                            return;
                        }
                        break;
                    }
                case 1:
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
                        timer1.Enabled = false;
                        break;
                    }
            }
        }

        // oyunu baslatmak icin
        private void baslaBtn_Click(object sender, EventArgs e)
        {
            soruSec();
            sansayac = 0; dksayac = 0;
            basla = true; //soru almaya baslandi
            timer1.Enabled = true;
            yeniSoru();
            timer2.Enabled = false;
            Home.guna2Panel1.Enabled = false;
            guna2GradientPanel1.Visible = true;
        }

        //sonraki soruya gecmek icin calisan kod
        private void sonrakiBtn_Click(object sender, EventArgs e)
        {
            string tahmin = cevapTxt.Text;
            if (tahmin.ToLower() == kelime.ToLower()) //buyuk-kucuk harf sorunu olmaması icin
            {
                if (sorusayisi >= 14) //tum sorular cevaplandiysa calisan kisim
                {
                    toplamp += soruPuani;
                    toplamPuanLbl.Text = toplamp.ToString();
                    MessageBox.Show("Oyun bitti." + "\n" + "İsim: " + UCHome.isim + "\n" + "Toplam Puanınız: " + toplamp + "\n" + "Kalan Süre: " + sure + "\n" + "Tarih:" + DateTime.Now.ToString());
                    kisiEkle();
                    txtaydet();
                    scoreUpdate();
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    UCHome uCHome = new UCHome(); //oyun bittiginde baslangic sayfasina geri doner
                    addUserControl(uCHome);
                    Home.guna2Panel1.Enabled = true;
                    return;
                }
                toplamp += soruPuani;
                toplamPuanLbl.Text = toplamp.ToString();
                yeniSoru();
                cevapTxt.Text = "";
                cevapTxt.Enabled = false;
                timer2.Enabled = false;
                timePanel1.Visible = false;
                harfAlBtn.Enabled = true;
                sonrakiBtn.Visible = false;
                cevapBtn.Enabled = true;
                kalanSure = 20;
            }
            else
            {
                //yanlis bilirse calisacak kisim
                MessageBox.Show(" Yanlış bildiniz! Kazanılan Puan : 0");
                cevapTxt.Text = "";
                basla = true;
                sonrakiBtn.Visible = false;
                cevapBtn.Enabled = true;
                if (sorusayisi >= 14) // soruyu yanlis bilerek oyun biterse
                {
                    MessageBox.Show("Oyun bitti." + UCHome.isim + "\n" + "Toplam Puanınız : " + toplamp.ToString() + "\n" + " Kalan Süre:" + sure + "\n" + "Tarih:" + DateTime.Now.ToString());
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    kisiEkle();
                    txtaydet();
                    scoreUpdate();
                    UCHome uCHome = new UCHome(); //oyun bittiginde baslangic sayfasina geri doner
                    addUserControl(uCHome);
                    Home.guna2Panel1.Enabled = true;
                    return;
                }
                toplamPuanLbl.Text = toplamp.ToString();
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
        
        //anasayfa geri donme butonu
        private void guna2GradientPanel1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Giriş Sayfasına Dönülsün mü?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                kisiEkle();
                txtaydet();
                scoreUpdate();
                UCHome uCHome = new UCHome(); //oyun bittiginde baslangic sayfasina geri doner
                addUserControl(uCHome);
                Home.guna2Panel1.Enabled = true;
            }
            else
            {

            }
        }
        private void cevapBtn_Click_1(object sender, EventArgs e) //cevaplama butonu
        {
            timePanel1.Visible = true; 
            timer1.Enabled = false; //4 dakikayi durdur
            basla = true;
            sonrakiBtn.Visible = true;
            timer2.Enabled = true; // 20 saniye baslat
            cevapTxt.Enabled = true; //cevabin yazilacagi text aktif
            harfAlBtn.Enabled = false; //harf alama
            sonrakiBtn.Enabled = true;
            cevapBtn.Enabled = false;
        }

        // 4 dakika icin calisan timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            sansayac++;
            if (sansayac > 50)
            {
                timer2Lbl.Text = "0" + (3 - dksayac).ToString() + " : 0" + (60 - sansayac).ToString(); // 03:09  ve sonrasi icin

            }
            else
            {
                timer2Lbl.Text = "0" + (3 - dksayac).ToString() + " : " + (60 - sansayac).ToString(); // 03:10 icin
            }
            sure = timer2Lbl.Text;

            if (sansayac == 60) //60 saniye dolduysa dakikaya cevir saniyeyi 0la
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
                scoreUpdate();
               
                UCHome uCHome = new UCHome(); //oyun bittiginde baslangic sayfasina geri doner
                addUserControl(uCHome);
                Home.guna2Panel1.Enabled = true;
            }
        }

        //20 saniye icin calisan timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (kalanSure == 0)
            {
                timer2.Enabled = false; //20 saniyeyi durdur
                MessageBox.Show("Süreniz dolmuştur. Kazanılan puan : 0");
                timePanel1.Visible = false;
                cevapTxt.Enabled = false;
                sonrakiBtn.Enabled = false;
                timer1.Enabled = false; // 4 dakikayi baslat
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
