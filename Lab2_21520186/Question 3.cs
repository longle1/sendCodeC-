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

        private string Convert(string expression)
        {
            string postfix = "";
            Stack<string> operatorStack = new Stack<string>();
            string newexpression = "";
            //loai bo cac khoang trang
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ') continue;
                expression += expression[i];
            }
            //them dấu ',' vao giua cac ki tu
            string c = "-+*/()";
            for (int i = 0; i < expression.Length; i++)
            {
                if (c.Contains(expression[i]))
                {
                    newexpression += $",{expression[i]},";
                }
                else newexpression += expression[i];
            }
            expression = newexpression.Replace(",,", ",");
            newexpression = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if ((i == 0 && expression[0] == ',') || (i == expression.Length - 1 && expression[expression.Length - 1] == ',')) continue;
                newexpression += expression[i];
            }

            return newexpression;

            string[] list = newexpression.Split(',');
            for (int i = 0; i < list.Length; i++)
            {
                string c1 = list[i];

                if (!c1.Contains("+-*/()"))
                {
                    // Nếu là toán hạng, đưa vào kết quả đầu ra
                    postfix += c + " ";
                }
                else if (c1 == "(")
                {
                    // Nếu là dấu ngoặc trái, đưa vào stack
                    operatorStack.Push(c1);
                }
                else if (c1 == ")")
                {
                    // Nếu là dấu ngoặc phải, lấy các toán tử trong stack và đưa vào kết quả đầu ra cho đến khi gặp dấu ngoặc trái
                    while (operatorStack.Count > 0 && operatorStack.Peek() != "(")
                    {
                        postfix += operatorStack.Pop() + " ";
                    }
                    if (operatorStack.Count > 0 && operatorStack.Peek() == "(")
                    {
                        operatorStack.Pop();
                    }
                }
                else if (IsOperator(c1))
                {
                    // Nếu là toán tử, lấy toán tử có độ ưu tiên cao hơn trong stack ra đưa vào kết quả đầu ra
                    while (operatorStack.Count > 0 && Priority(c1) <= Priority(operatorStack.Peek()))
                    {
                        postfix += operatorStack.Pop() + " ";
                    }
                    operatorStack.Push(c1);
                }
            }

            // Đưa các toán tử còn lại trong stack vào kết quả đầu ra
            while (operatorStack.Count > 0)
            {
                postfix += operatorStack.Pop() + " ";
            }

            return postfix;
        }

        // Hàm tính toán biểu thức hậu tố
        //private double EvaluatePostfix(string postfix)
        //{
        //    Stack<double> operandStack = new Stack<double>();
        //    Queue<char> operatorQueue = new Queue<char>(postfix.ToCharArray());

        //    while (operatorQueue.Count > 0)
        //    {
        //        char c = operatorQueue.Dequeue();

        //        if (char.IsDigit(c))
        //        {
        //            // Nếu là toán hạng, đưa vào stack
        //            operandStack.Push(double.Parse(c.ToString()));
        //        }
        //        else if (IsOperator(c))
        //        {
        //            // Nếu là toán tử, lấy hai toán hạng từ stack ra và thực hiện phép tính tương ứng
        //            double operand2 = operandStack.Pop();
        //            double operand1 = operandStack.Pop();

        //            switch (c)
        //            {
        //                case '+':
        //                    operandStack.Push(operand1 + operand2);
        //                    break;
        //                case '-':
        //                    operandStack.Push(operand1 - operand2);
        //                    break;
        //                case '*':
        //                    operandStack.Push(operand1 * operand2);
        //                    break;
        //                case '/':
        //                    operandStack.Push(operand1 / operand2);
        //                    break;
        //            }
        //        }
        //    }

        //    // Kết quả cuối cùng sẽ nằm trong stack
        //    return operandStack.Pop();
        //}

        // Hàm kiểm tra xem một ký tự có phải là toán tử hay không
        private bool IsOperator(string c)
        {
            return (c == "+" || c == "-" || c == "*" || c == "/");
        }

        // Hàm trả về độ ưu tiên của một toán tử
        private int Priority(string c)
        {
            switch (c)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }
        string pathName;
        private void Read_Click(object sender, EventArgs e)
        {
            // Đọc nội dung file input3
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            Content.Text = sr.ReadToEnd();
            pathName = ofd.FileName;
            fs.Close();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            try
            {
                //// Đọc nội dung từ tệp input1.txt
                //OpenFileDialog ofd = new OpenFileDialog();
                //ofd.ShowDialog();
                //if (File.Exists(ofd.FileName))
                //{
                //    File.Delete(ofd.FileName);
                //}
                //FileStream fs = new FileStream(ofd.FileName, FileMode.CreateNew);
                //StreamWriter sw = new StreamWriter(fs);
                //Content.Clear();
                //StreamReader sr = new StreamReader(pathName);
                ////string line;
                ////do
                ////{
                ////    line = sr.ReadLine();
                ////    if (line != null && line != "")
                ////    {
                ////        sw.WriteLine(line + " = " + InfixToPostfix(line));
                ////    }
                ////} while (line != null);
                //sw.Close();
                //sr.Close();
                Content.Text = Convert("200/10*5+(3-6)*2/7-1+10");

                MessageBox.Show("Đã ghi nội dung vào tệp output3");

            }
            catch (FormatException)
            {
                MessageBox.Show("Ghi nội dung không thành công.");
            }

        }
    }
}
