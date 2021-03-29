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
    public partial class UCBest : UserControl
    {
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;
        public UCBest()
        {
            InitializeComponent();
        }
        public void baglanti()
        {
            bag = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=1562;SslMode=none");
            bag.Open();
        }
        public void oyuncuListele() // gonderen kişinin tüm faturalarını listeleme
        {
            baglanti();
            string komut = "SELECT İsim,Puan,KalanSure,Tarih FROM tbl_oyuncular ORDER BY Puan DESC limit 5";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            oyuncularData.DataSource = dt;

        }
        private void UCBest_Load(object sender, EventArgs e)
        {
            oyuncuListele();
            oyuncularData.AllowUserToAddRows = false;

        }

        private void dosyayaKaydetBtn_Click(object sender, EventArgs e)
        {
            txtAktar.txtKaydet(oyuncularData);
        }
    }
}
