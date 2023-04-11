using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_21520186
{
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }
        string path = "";
        List<Student> students = new List<Student>();
        [Serializable()]
        private class Student
        {
            public string name;
            public string MSSV;
            public string sdt;
            public float course1;
            public float course2;
            public float course3;
            public float dtb;
            public Student(string name, string MSSV, string sdt, float course1, float course2, float course3)
            {
                this.name = name;
                this.MSSV = MSSV;
                this.sdt = sdt;
                this.course1 = course1;
                this.course2 = course2;
                this.course3 = course3;
            }
        }
        private void Write_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                path = ofd.FileName;
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, students);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void show(int index)
        {
            try
            {
                nameR.Text = students[index].name;
                MSSVR.Text = students[index].MSSV;
                sdtR.Text = students[index].sdt;
                c1R.Text = students[index].course1.ToString();
                c2R.Text = students[index].course2.ToString();
                c3R.Text = students[index].course3.ToString();
                dtbR.Text = students[index].dtb.ToString();
            }
            catch(Exception ex)
            {
                if (numpage < 0) numpage = 0;
                if(numpage >= students.Count) numpage = students.Count - 1;
                MessageBox.Show("Không thể thực hiện tác vụ này");
                return;
            }
        }
        int numpage = 0;
        private void Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                students = formatter.Deserialize(fs) as List<Student>;

                StreamWriter sw = new StreamWriter(new FileStream(ofd.FileName.Replace("input4.txt", "output4.txt"), FileMode.Create));
                if (richTextBox1.Text != "") richTextBox1.Clear();
                foreach (Student x in students)
                {
                    x.dtb = (x.course1 + x.course2 + x.course3) / 3;
                    string text = x.name + "\n" + x.MSSV + "\n" + x.sdt + "\n" + x.course1 + "\n" + x.course2 + "\n" + x.course3 + "\n" + x.dtb + "\n\n";
                    richTextBox1.Text += text;
                    sw.Write(text);
                }
                sw.Close();
                show(numpage);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if((float.Parse(c1W.Text) < 0 || (float.Parse(c1W.Text) > 10)) || (float.Parse(c2W.Text) < 0 || (float.Parse(c2W.Text) > 10)) || float.Parse(c3W.Text) < 0 || (float.Parse(c3W.Text) > 10))
                {
                    MessageBox.Show("Điểm thuộc [0,10]");
                    return;
                }
                Student st = new Student(nameW.Text, MSSVW.Text, sdtW.Text, float.Parse(c1W.Text), float.Parse(c2W.Text), float.Parse(c3W.Text));
                students.Add(st);

                //nameW.Text = ""; MSSVW.Text = ""; sdtW.Text = ""; c1W.Text = ""; c2R.Text = ""; c3W.Text = "";


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numpage -= 1;
            show(numpage);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numpage += 1;
            show(numpage);

        }
    }
}
