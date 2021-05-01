namespace WindowsFormsApp1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.miYukle = new System.Windows.Forms.ToolStripMenuItem();
            this.miKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.miCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rtbAnaMetin = new System.Windows.Forms.RichTextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.tbBul = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbDegistir = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miYeni,
            this.miYukle,
            this.miKaydet,
            this.miCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // miYeni
            // 
            this.miYeni.Name = "miYeni";
            this.miYeni.Size = new System.Drawing.Size(138, 26);
            this.miYeni.Text = "Yeni";
            this.miYeni.Click += new System.EventHandler(this.miYeni_Click);
            // 
            // miYukle
            // 
            this.miYukle.Name = "miYukle";
            this.miYukle.Size = new System.Drawing.Size(138, 26);
            this.miYukle.Text = "Yükle";
            // 
            // miKaydet
            // 
            this.miKaydet.Name = "miKaydet";
            this.miKaydet.Size = new System.Drawing.Size(138, 26);
            this.miKaydet.Text = "Kaydet";
            this.miKaydet.Click += new System.EventHandler(this.miKaydet_Click);
            // 
            // miCikis
            // 
            this.miCikis.Name = "miCikis";
            this.miCikis.Size = new System.Drawing.Size(138, 26);
            this.miCikis.Text = "Çıkış";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Kalın";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rtbAnaMetin
            // 
            this.rtbAnaMetin.Location = new System.Drawing.Point(12, 70);
            this.rtbAnaMetin.Name = "rtbAnaMetin";
            this.rtbAnaMetin.Size = new System.Drawing.Size(851, 394);
            this.rtbAnaMetin.TabIndex = 3;
            this.rtbAnaMetin.Text = "";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(79, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 21);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "İtalik";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Renk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "48",
            "64"});
            this.cbFontSize.Location = new System.Drawing.Point(657, 38);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(121, 24);
            this.cbFontSize.TabIndex = 6;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // tbBul
            // 
            this.tbBul.Location = new System.Drawing.Point(143, 42);
            this.tbBul.Name = "tbBul";
            this.tbBul.Size = new System.Drawing.Size(100, 22);
            this.tbBul.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Değiştir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbDegistir
            // 
            this.tbDegistir.Location = new System.Drawing.Point(330, 40);
            this.tbDegistir.Name = "tbDegistir";
            this.tbDegistir.Size = new System.Drawing.Size(100, 22);
            this.tbDegistir.TabIndex = 7;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 476);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbDegistir);
            this.Controls.Add(this.tbBul);
            this.Controls.Add(this.cbFontSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.rtbAnaMetin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Ana Ekran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miYeni;
        private System.Windows.Forms.ToolStripMenuItem miYukle;
        private System.Windows.Forms.ToolStripMenuItem miKaydet;
        private System.Windows.Forms.ToolStripMenuItem miCikis;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox rtbAnaMetin;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.TextBox tbBul;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbDegistir;
    }
}