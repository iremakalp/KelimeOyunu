
namespace KelimeOyunu
{
    partial class Home
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bestBtn = new System.Windows.Forms.PictureBox();
            this.rulesBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.ucHomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.addBtn = new System.Windows.Forms.PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.Controls.Add(this.addBtn);
            guna2Panel1.Controls.Add(this.bestBtn);
            guna2Panel1.Controls.Add(this.rulesBtn);
            guna2Panel1.Controls.Add(homeBtn);
            guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            guna2Panel1.Location = new System.Drawing.Point(-4, -2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.Parent = guna2Panel1;
            guna2Panel1.Size = new System.Drawing.Size(113, 495);
            guna2Panel1.TabIndex = 0;
            // 
            // bestBtn
            // 
            this.bestBtn.BackColor = System.Drawing.Color.Transparent;
            this.bestBtn.Image = ((System.Drawing.Image)(resources.GetObject("bestBtn.Image")));
            this.bestBtn.Location = new System.Drawing.Point(16, 248);
            this.bestBtn.Name = "bestBtn";
            this.bestBtn.Size = new System.Drawing.Size(59, 41);
            this.bestBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bestBtn.TabIndex = 4;
            this.bestBtn.TabStop = false;
            this.bestBtn.Tag = "Skorlar";
            this.bestBtn.Click += new System.EventHandler(this.bestBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.BackColor = System.Drawing.Color.Transparent;
            this.rulesBtn.Image = ((System.Drawing.Image)(resources.GetObject("rulesBtn.Image")));
            this.rulesBtn.Location = new System.Drawing.Point(16, 175);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(59, 41);
            this.rulesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rulesBtn.TabIndex = 3;
            this.rulesBtn.TabStop = false;
            this.rulesBtn.Tag = "Kurallar";
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(16, 102);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(59, 41);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 2;
            this.homeBtn.TabStop = false;
            this.homeBtn.Tag = "Anasayfa";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // ucHomePanel
            // 
            this.ucHomePanel.Location = new System.Drawing.Point(86, -2);
            this.ucHomePanel.Name = "ucHomePanel";
            this.ucHomePanel.ShadowDecoration.Parent = this.ucHomePanel;
            this.ucHomePanel.Size = new System.Drawing.Size(766, 484);
            this.ucHomePanel.TabIndex = 1;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 80;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DragForm = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = guna2Panel1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.Controls.Add(this.pictureBox5);
            this.guna2Panel2.Controls.Add(this.pictureBox4);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.guna2Panel2.Location = new System.Drawing.Point(850, -21);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(97, 525);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 72);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.ContainerControl = this;
            this.guna2DragControl2.TargetControl = this.guna2Panel2;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(16, 321);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(59, 41);
            this.addBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addBtn.TabIndex = 5;
            this.addBtn.TabStop = false;
            this.addBtn.Tag = "Soru Ekle";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 483);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.ucHomePanel);
            this.Controls.Add(guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bestBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(homeBtn)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox homeBtn;
        public static Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox bestBtn;
        private System.Windows.Forms.PictureBox rulesBtn;
        private Guna.UI2.WinForms.Guna2Panel ucHomePanel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.PictureBox addBtn;
    }
}

