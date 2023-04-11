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

namespace Lab2_21520186
{
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string name = ofd.SafeFileName;
                string url = ofd.FileName;

                FileInfo fi = new FileInfo(url);
                long fileSize = fi.Length;

                StreamReader sr = new StreamReader(url);
                string content = sr.ReadToEnd();

                int lines = 0;
                int words = 0;
                int chars = 0;

                string[] delimiters = { " ", "\r\n", "\n" };
                string[] contentArray = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                lines = contentArray.Length;
                words = contentArray.Length;

                foreach (string word in contentArray)
                {
                    chars += word.Length;
                }

                sr.Close();

                // Hiển thị thông tin lên giao diện
                FileName.Text = name;
                FileSize.Text = fileSize.ToString();
                URL.Text = url;
                LineCount.Text = lines.ToString();
                WordCount.Text = words.ToString();
                CharacterCount.Text = chars.ToString();
                Content.Text = content;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
