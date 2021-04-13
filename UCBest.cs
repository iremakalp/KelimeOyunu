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
            bag = new MySqlConnection("Server=127.0.0.1;Database=kelimeoyunu;user=root;Pwd=1562;SslMode=Required");
            bag.Open();
        }
        public void oyuncuListele() 
        {
            baglanti();
            string komut = "SELECT İsim,Puan,KalanSure,Tarih FROM tbl_oyuncular ORDER BY Puan DESC limit 5";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            oyuncularData.DataSource = dt;

        }
        // referans https://forum.turkishcode.com/konu-c-datagridview-den-txt-dosyasina-veri-aktarma.html
        public void txtKaydet(DataGridView veriTablosu)
        {
            try
            {
                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "En İyi Oyuncular";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "Txt Dosyası|*.txt";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    TextWriter txt = new StreamWriter(dosyakaydet.FileName);
                    foreach (DataGridViewColumn sutun in veriTablosu.Columns) //basliklari ceker
                    {
                        txt.Write(sutun.HeaderText + "    ");
                    }
                    txt.Write("\n");
                    foreach (DataGridViewRow satir in veriTablosu.Rows) //sirayla satir sayisina gore hucre bilgilerini toplar
                    {
                        foreach (DataGridViewCell hucre in satir.Cells)
                        {
                            txt.Write(hucre.Value.ToString() + "     ");
                        }
                        txt.Write("\n");
                    }
                    txt.Close();
                    MessageBox.Show("Dosya kaydedildi!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void UCBest_Load(object sender, EventArgs e)
        {
            oyuncuListele();
            oyuncularData.AllowUserToAddRows = false; //dosyaya kaydederken sorun cikarmamasi icin bos satiri gizledik

        }

        private void dosyayaKaydetBtn_Click(object sender, EventArgs e)
        {
            txtKaydet(oyuncularData);
        }
    }
}
