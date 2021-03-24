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
    public partial class Home : Form
    {
        MySqlConnection bag;
        MySqlCommand komut;
        MySqlDataReader dr;
        public static bool durum;
        public Home()
        {
            InitializeComponent();
            UCHome uC_ = new UCHome();
            addUserControl(uC_);
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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // referans https://kodzilla.wordpress.com/2012/04/23/c-fare-uzerine-aciklama-yazma-tooltip-kullanimi/ 
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(homeBtn, "Anasayfa");
            Aciklama.SetToolTip(rulesBtn, "Oyun Kuralları");
            Aciklama.SetToolTip(bestBtn, "Oyun Skorları");
            Aciklama.SetToolTip(addBtn, "Soru Ekle");
        }
        private void rulesBtn_Click(object sender, EventArgs e)
        {
            UCRules ucRules_ = new UCRules();
            addUserControl(ucRules_);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UCHome uC_ = new UCHome();
            addUserControl(uC_);
            durum = true;
          
        }

        private void bestBtn_Click(object sender, EventArgs e)
        {
            UCBest ucBest_ = new UCBest();
            addUserControl(ucBest_);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UCAddQuestions uCAddQuestions_ = new UCAddQuestions();
            addUserControl(uCAddQuestions_);
        }
    }
}
