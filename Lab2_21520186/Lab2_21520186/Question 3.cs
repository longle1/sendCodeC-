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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            // Đọc nội dung file input3
             OpenFileDialog ofd = new OpenFileDialog();
             ofd.ShowDialog();
             FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
             StreamReader sr = new StreamReader(fs);
           

            // Duyệt từng dòng và tính toán kết quả
            List<string> results = new List<string>();
            foreach (string line in content)
            {
            double result = Calculate(line);
            string resultString = $"{line} = {result}";
            results.Add(resultString);
            }

        }
        private double Calculate(string expression)
        {
            // Sử dụng cấu trúc ngăn xếp để tính toán biểu thức
            Stack<double> stack = new Stack<double>();

            string[] tokens = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double value))
                {
                    stack.Push(value);
                }
                else
                {
                    double operand2 = stack.Pop();
                    double operand1 = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(operand1 + operand2);
                            break;
                        case "-":
                            stack.Push(operand1 - operand2);
                            break;
                        case "*":
                            stack.Push(operand1 * operand2);
                            break;
                        case "/":
                            stack.Push(operand1 / operand2);
                            break;
                        default:
                            throw new ArgumentException($"Không hỗ trợ phép tính '{token}'");
                    }
                }
            }

            // Kết quả cuối cùng là giá trị trên đỉnh ngăn xếp
            return stack.Pop();
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
                sw.WriteLine(Content.Text);
                sw.Close();

                MessageBox.Show("Đã ghi nội dung vào tệp output1");

            }
            catch (FormatException)
            {
                MessageBox.Show("Ghi nội dung không thành công.");
            }

        }
    }
}
