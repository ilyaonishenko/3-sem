using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _3_15_41
{
    public partial class Form1 : Form
    {
        static string field1,field2,field3;
        public static String Field1
        {
            get {return field1;}
            set {field1 = value;}
        }
        public static String Field2
        {
            get { return field2; }
            set { field2 = value; }
        }
        public static String Field3
        {
            get { return field3; }
            set { field3 = value; }
        }
        int from = 0, to = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("1.txt");
            Field1 = sr.ReadToEnd();
            textBox1.Text = Field1;
            sr.Close();
            sr = new StreamReader("2.txt");
            Field2 = sr.ReadToEnd();
            textBox2.Text = Field2;
            sr.Close();
            sr = new StreamReader("3.txt");
            Field3 = sr.ReadToEnd();
            textBox3.Text = Field3;
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Field1 = "";
            Field2 = "";
            Field3 = "";
            from = int.Parse(textBox4.Text);
            to = int.Parse(textBox5.Text);
            int len = r.Next(40, 200);
            for (int i = 0; i < len; i++)
                Field1 += r.Next(from, to) + " ";
            textBox1.Text = Field1;
            for (int i = 0; i < len; i++)
            {
                Field2 += r.Next(from, to) + " ";
                Field3 += r.Next(from, to) + " ";
            }
            textBox2.Text = Field2;
            textBox3.Text = Field3;
            StreamWriter sw = new StreamWriter("1.txt");
            sw.Write(Field1);
            sw.Close();
            sw = new StreamWriter("2.txt");
            sw.Write(Field2);
            sw.Close();
            sw = new StreamWriter("3.txt");
            sw.Write(Field3);
            sw.Close();
            label6.Text = len.ToString();
        }
    }
}
