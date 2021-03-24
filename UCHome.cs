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
    public partial class UCHome : UserControl
    {
        public UCHome()
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.WindowState =FormWindowState.Minimized;
        }
        private void baslaBtn_Click(object sender, EventArgs e)
        {
            UCPlay ucPlay_ = new UCPlay();
            addUserControl(ucPlay_);
            if(Home.guna2Panel1.Enabled== true)
            {
                Home.guna2Panel1.Enabled = false;
            }
            
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            baslaBtn.Enabled = false;
        }

        private void adTxt_TextChanged(object sender, EventArgs e)
        {
            if (adTxt.Text == " ")
            {
                baslaBtn.Enabled = false;

            }
            else
            {
                baslaBtn.Enabled = true;
            }
        }
    }
}
