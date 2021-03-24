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
    public partial class UCAddQuestions : UserControl
    {
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;
        public void baglanti()
        {
            bag = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=1562;SslMode=none");
            bag.Open();

        }
        public UCAddQuestions()
        {
            InitializeComponent();
        }

        private void soruEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti();
                string eklemekomut = "insert into tbl_sorular(soru,kelime) values ('" + soruTxt.Text + "','"  + kelimeTxt.Text  + "')";
                komut = new MySqlCommand(eklemekomut, bag);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                }
                MessageBox.Show("Yeni sorunuz kaydedildi !");
                bag.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
