using System.IO;
using System.Windows.Forms;
using System;

namespace KelimeOyunu
{
   class txtAktar
   {
       public static void txtKaydet(DataGridView veriTablosu)
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
                   foreach (DataGridViewColumn sutun in veriTablosu.Columns)
                   {
                       txt.Write(sutun.HeaderText + "    ");
                   }
                   txt.Write("\n");
                   foreach (DataGridViewRow satir in veriTablosu.Rows)
                   {
                       foreach (DataGridViewCell hucre in satir.Cells)
                       {
                           txt.Write(hucre.Value.ToString() + "     ");
                       }
                       txt.Write("\n");
                   }
                   txt.Close();
                   MessageBox.Show("TXT dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
               }
           }
           catch(Exception hata)
           {
               MessageBox.Show(hata.Message);
           }
       }
   }
}
