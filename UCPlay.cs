using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int toplamP = 0;
        string[] sorular = new string[14];
        string[] kelimeler = new string[14];
        int j = 0;
        int sorusayisi,soru, toplamp;
        string kelime;
        int soruPuani = 0;
        bool basla;
        Random r = new Random();
        int harf;
        int[] rasgeleSayilar;
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
        public void soruSec()
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
        public void yeniSoru()
        {
           
        }
        private void UCPlay_Load(object sender, EventArgs e)
        {
            guna2Panel5.Visible = false;
            guna2Panel6.Visible = false;
            guna2Panel7.Visible = false;
            guna2Panel8.Visible = false;
            guna2Panel9.Visible = false;
            guna2Panel10.Visible = false;
            toplamPuan.Text = "Toplam Puan:" + toplamP;
            timer2.Interval = 1000;
            timer1.Interval = 20;
            timer2Lbl.Text = "04:00";
            timer1Lbl.Text = "0:20";
            sorusayisi = 0;
            soru = 1;
            basla = true;
            soruSec();
        }
        private void bitirBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Home.guna2Panel1.Enabled = true;
                UCHome ucHome_ = new UCHome();
                addUserControl(ucHome_);
                ucHome_.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }
        }
        private void baslaBtn_Click(object sender, EventArgs e)
        {
           
            bitirBtn.Visible = true;
            panel1.Visible = true;       
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

                    soruPuani = 400;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 2)
                {
                    kelime = kelimeler[1];
                    soruPuani = 400;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 3)
                {
                    kelime = kelimeler[2];
                    guna2Panel5.Visible = true;
                    soruPuani = 500;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 4)
                {
                    kelime = kelimeler[3];
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        guna2HtmlLabel1.Text += "*";
                    }
                    guna2Panel5.Visible = true;
                    soruPuani = 500;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 5)
                {
                    kelime = kelimeler[4];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true;
                    soruPuani = 600;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 6)
                {
                    kelime = kelimeler[5];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true;
                    soruPuani = 600;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 7)
                {
                    kelime = kelimeler[6];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true;
                    soruPuani = 700;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 8)
                {
                    kelime = kelimeler[7];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true;
                    soruPuani = 700;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 9)
                {
                    kelime = kelimeler[8];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true;
                    soruPuani = 800;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 10)
                {
                    kelime = kelimeler[9];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true;
                    soruPuani = 800;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 11)
                {
                    kelime = kelimeler[10];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true;
                    soruPuani = 900;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 12)
                {
                    kelime = kelimeler[11];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true;
                    soruPuani = 900;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 13)
                {
                    kelime = kelimeler[12];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true; guna2Panel10.Visible = true;
                    soruPuani = 1000;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();
                }
                if (soru == 14)
                {
                    kelime = kelimeler[13];
                    guna2Panel5.Visible = true; guna2Panel6.Visible = true; guna2Panel7.Visible = true; guna2Panel8.Visible = true; guna2Panel9.Visible = true; guna2Panel10.Visible = true;
                    soruPuani = 1000;
                    toplamPuanLbl.Text = toplamp.ToString() + "  /  " + soruPuani.ToString();

                }
                soru++;
                if(soru<15)
                {
                    baslaBtn.Text = "Sonraki Soru";
                }
                else
                {
                    baslaBtn.Text = "Başla";
                    baslaBtn.Enabled = false;
                }
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
                cevapBtn.Enabled = true;
                harfAlBtn.Enabled = true;

            }
            catch (Exception)
            {
                ;
            }

        }
        private void harfAlBtn_Click(object sender, EventArgs e)
        {
            char[] harfler = kelime.ToCharArray(); // referans http://forum.csharpnedir.com/forum_posts.asp?TID=45545&title=c-stringharf-blmek-ve-diziye-aktarmak-yardm
            byte rasgeleHarf = Convert.ToByte(r.Next(0, harfler.Length));
            while (Array.IndexOf(rasgeleSayilar, rasgeleHarf) != -1) // rasgele sayılardan aynısı oluşmasın
            {
                rasgeleHarf = Convert.ToByte(r.Next(0, harfler.Length));
            }
            rasgeleSayilar[harf] = rasgeleHarf;
            char alinanHarf = harfler[rasgeleHarf];
            if (rasgeleHarf == 0)
            {
                harf1Lbl.Text = harf1Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 1)
            {
                harf2Lbl.Text = harf2Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 2)
            {
                harf3Lbl.Text = harf3Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 3)
            {
                harf4Lbl.Text = harf4Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 4)
            {
                harf5Lbl.Text = harf5Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 5)
            {
                harf6Lbl.Text = harf6Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 6)
            {
                harf7Lbl.Text = harf7Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 7)
            {
                harf8Lbl.Text = harf8Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 8)
            {
                harf9Lbl.Text = harf9Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }
            if (rasgeleHarf == 9)
            {
                harf10Lbl.Text = harf10Lbl.Text.Insert(Convert.ToInt32(rasgeleHarf), alinanHarf.ToString());
            }

        }
        private void cevapBtn_Click(object sender, EventArgs e)
        {
            switch (sorusayisi)
            {
                case 1:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[0])
                        {
                            toplamp += soruPuani;
                        }
                            
                        else
                        {
                            toplamp -= soruPuani;
                        }
                           
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        break;
                    }
                case 2:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[1])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        break;
                    }
                case 3:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[2])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString();
                        break;
                    }
                case 4:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[3])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString();
                        break;
                    }
                case 5:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[4])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        break;
                    }
                case 6:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[5])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        break;
                    }
                case 7:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[6])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString();
                        break;
                    }
                case 8:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[7])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString();
                        break;
                    }
                case 9:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[8])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString(); harf8Lbl.Text = kelime[7].ToString();
                        break;
                    }
                case 10:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[9])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString(); harf8Lbl.Text = kelime[7].ToString();
                        break;
                    }
                case 11:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[10])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString(); harf8Lbl.Text = kelime[7].ToString();
                        harf9Lbl.Text = kelime[8].ToString();
                        break;
                    }
                case 12:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[11])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString(); harf8Lbl.Text = kelime[7].ToString();
                        harf9Lbl.Text = kelime[8].ToString();
                        break;
                    }
                case 13:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[12])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString(); harf8Lbl.Text = kelime[7].ToString();
                        harf9Lbl.Text = kelime[8].ToString(); harf10Lbl.Text = kelime[9].ToString();
                        break;
                    }
                case 14:
                    {
                        if (cevapTxt.Text.ToLower() == kelimeler[13])
                        {
                            toplamp += soruPuani;
                        }

                        else
                        {
                            toplamp -= soruPuani;
                        }
                        toplamPuanLbl.Text = toplamp.ToString() + "  /  " + "0";
                        harf1Lbl.Text = kelime[0].ToString(); harf2Lbl.Text = kelime[1].ToString();
                        harf3Lbl.Text = kelime[2].ToString(); harf4Lbl.Text = kelime[3].ToString();
                        harf5Lbl.Text = kelime[4].ToString(); harf6Lbl.Text = kelime[5].ToString();
                        harf7Lbl.Text = kelime[6].ToString(); harf8Lbl.Text = kelime[7].ToString();
                        harf9Lbl.Text = kelime[8].ToString(); harf10Lbl.Text = kelime[9].ToString();
                        timer1.Enabled = false;
                        break;
                    }


            }
        }
       
    }
}
