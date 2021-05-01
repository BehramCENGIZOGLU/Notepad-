using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Only text|*.rtf";
            saveFileDialog1.FileName = "isimsiz.txt";
            saveFileDialog1.Title = "Kaydet";
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.InitialDirectory = "C:";
        }

        private void miYeni_Click(object sender, EventArgs e)
        {
            if (rtbAnaMetin.Text != "")
            {
                var result = MessageBox.Show("Kapatmadan Önce Kaydetmek İstermisiniz?","Onay",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var saveres = saveFileDialog1.ShowDialog();
                }

            }

            rtbAnaMetin.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetStyle(rtbAnaMetin.SelectionFont.Size);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SetStyle(rtbAnaMetin.SelectionFont.Size);
           
        }

        private void SetStyle(float fontSize)
        {
            rtbAnaMetin.SelectionFont = new Font(rtbAnaMetin.Font, rtbAnaMetin.Font.Style);

            if (checkBox2.Checked)
            {
                rtbAnaMetin.SelectionFont = new Font(rtbAnaMetin.Font.Name, fontSize, rtbAnaMetin.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                rtbAnaMetin.SelectionFont = new Font(rtbAnaMetin.Font.Name, fontSize, rtbAnaMetin.SelectionFont.Style | FontStyle.Regular);

            }

            if (checkBox1.Checked)
            {
                rtbAnaMetin.SelectionFont = new Font(rtbAnaMetin.Font.Name, fontSize, rtbAnaMetin.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                rtbAnaMetin.SelectionFont = new Font(rtbAnaMetin.Font.Name, fontSize, rtbAnaMetin.SelectionFont.Style | FontStyle.Regular);

            }

            rtbAnaMetin.Focus();
        }

        private void miKaydet_Click(object sender, EventArgs e)
        {
          
             
                    var saveres = saveFileDialog1.ShowDialog();
             

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(saveFileDialog1.FileName);
                Kayit.WriteLine(rtbAnaMetin.Rtf);
                Kayit.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = colorDialog1.ShowDialog();

            if(res == DialogResult.OK)
            {
                rtbAnaMetin.SelectionColor = colorDialog1.Color;
            }
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetStyle(float.Parse(cbFontSize.SelectedItem.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            string metin = rtbAnaMetin.Text;
            rtbAnaMetin.Text = "";
            rtbAnaMetin.Text = metin;
            while (rtbAnaMetin.Text.IndexOf(tbBul.Text, index)!= -1)
{
                int konum = rtbAnaMetin.Text.IndexOf(tbBul.Text, index);
                rtbAnaMetin.Select( konum, tbBul.Text.Length);
                rtbAnaMetin.SelectionBackColor = Color.Yellow;
                index = konum + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtbAnaMetin.Text =  rtbAnaMetin.Text.Replace(tbBul.Text, tbDegistir.Text);
        }

       
    }
}
