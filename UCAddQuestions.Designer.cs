
namespace KelimeOyunu
{
    partial class UCAddQuestions
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddQuestions));
            this.ucHomePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.soruEkleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.kelimeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.soruTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ucHomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucHomePanel
            // 
            this.ucHomePanel.BackColor = System.Drawing.Color.Transparent;
            this.ucHomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucHomePanel.BackgroundImage")));
            this.ucHomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHomePanel.Controls.Add(this.soruEkleBtn);
            this.ucHomePanel.Controls.Add(this.guna2HtmlLabel3);
            this.ucHomePanel.Controls.Add(this.guna2HtmlLabel2);
            this.ucHomePanel.Controls.Add(this.kelimeTxt);
            this.ucHomePanel.Controls.Add(this.soruTxt);
            this.ucHomePanel.Controls.Add(this.guna2HtmlLabel1);
            this.ucHomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomePanel.Location = new System.Drawing.Point(0, 0);
            this.ucHomePanel.Name = "ucHomePanel";
            this.ucHomePanel.ShadowDecoration.Parent = this.ucHomePanel;
            this.ucHomePanel.Size = new System.Drawing.Size(766, 484);
            this.ucHomePanel.TabIndex = 0;
            // 
            // soruEkleBtn
            // 
            this.soruEkleBtn.Animated = true;
            this.soruEkleBtn.BorderRadius = 20;
            this.soruEkleBtn.CheckedState.Parent = this.soruEkleBtn;
            this.soruEkleBtn.CustomImages.Parent = this.soruEkleBtn;
            this.soruEkleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.soruEkleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soruEkleBtn.ForeColor = System.Drawing.Color.White;
            this.soruEkleBtn.HoverState.Parent = this.soruEkleBtn;
            this.soruEkleBtn.Location = new System.Drawing.Point(394, 259);
            this.soruEkleBtn.Name = "soruEkleBtn";
            this.soruEkleBtn.ShadowDecoration.Parent = this.soruEkleBtn;
            this.soruEkleBtn.Size = new System.Drawing.Size(105, 45);
            this.soruEkleBtn.TabIndex = 8;
            this.soruEkleBtn.Text = "Soru Ekle";
            this.soruEkleBtn.Click += new System.EventHandler(this.soruEkleBtn_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(101)))), ((int)(((byte)(27)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(64, 278);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(64, 27);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Kelime";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(101)))), ((int)(((byte)(27)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(64, 209);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(43, 27);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Soru ";
            // 
            // kelimeTxt
            // 
            this.kelimeTxt.BorderRadius = 20;
            this.kelimeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kelimeTxt.DefaultText = "";
            this.kelimeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kelimeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kelimeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kelimeTxt.DisabledState.Parent = this.kelimeTxt;
            this.kelimeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kelimeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelimeTxt.FocusedState.Parent = this.kelimeTxt;
            this.kelimeTxt.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelimeTxt.HoverState.Parent = this.kelimeTxt;
            this.kelimeTxt.Location = new System.Drawing.Point(156, 268);
            this.kelimeTxt.Name = "kelimeTxt";
            this.kelimeTxt.PasswordChar = '\0';
            this.kelimeTxt.PlaceholderText = "";
            this.kelimeTxt.SelectedText = "";
            this.kelimeTxt.ShadowDecoration.Parent = this.kelimeTxt;
            this.kelimeTxt.Size = new System.Drawing.Size(200, 36);
            this.kelimeTxt.TabIndex = 2;
            // 
            // soruTxt
            // 
            this.soruTxt.BorderRadius = 20;
            this.soruTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soruTxt.DefaultText = "";
            this.soruTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.soruTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.soruTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soruTxt.DisabledState.Parent = this.soruTxt;
            this.soruTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soruTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soruTxt.FocusedState.Parent = this.soruTxt;
            this.soruTxt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soruTxt.HoverState.Parent = this.soruTxt;
            this.soruTxt.Location = new System.Drawing.Point(156, 200);
            this.soruTxt.Name = "soruTxt";
            this.soruTxt.PasswordChar = '\0';
            this.soruTxt.PlaceholderText = "";
            this.soruTxt.SelectedText = "";
            this.soruTxt.ShadowDecoration.Parent = this.soruTxt;
            this.soruTxt.Size = new System.Drawing.Size(451, 36);
            this.soruTxt.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(64, 105);
            this.guna2HtmlLabel1.MaximumSize = new System.Drawing.Size(600, 80);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(600, 62);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Bu bölümde dilerseniz oyunda kullanılmak üzere soru ekleyebilirsiniz.";
            // 
            // UCAddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucHomePanel);
            this.Name = "UCAddQuestions";
            this.Size = new System.Drawing.Size(766, 484);
            this.ucHomePanel.ResumeLayout(false);
            this.ucHomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ucHomePanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox kelimeTxt;
        private Guna.UI2.WinForms.Guna2TextBox soruTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button soruEkleBtn;
    }
}
