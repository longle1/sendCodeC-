using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_21520186
{
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }
        private void Read_Click(object sender, EventArgs e)
        {

            // Đọc nội dung từ file input1.txt
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                Content.Text = content;
            }

            catch (FormatException)
            {
                MessageBox.Show("Bạn chưa chọn tệp. Vui lòng chọn tệp!");
                return;
            }
        
        } 
        

        private void Write_Click(object sender, EventArgs e)
        {
          
            try
            {
                // Đọc nội dung từ tệp input1.txt
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Content.Text.ToUpper());
                sw.Close();
                
                MessageBox.Show("Đã ghi nội dung vào tệp output1" );

            }
            catch (FormatException)
            {
                MessageBox.Show("Ghi nội dung không thành công.");
            }

        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

