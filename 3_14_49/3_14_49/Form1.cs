using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _3_14_49
{
    public partial class Form1 : Form
    {
        int from = 0, to = 0;
        String fromFormSE = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("S(a).txt");
            String var = sr.ReadLine();
            sr.Close();
            char[] sep = new char[]{',',' '};
            String fromSA = var.Trim(sep);
            textBox1.Text = fromSA;
            sr = new StreamReader("S(b).txt");
            var = sr.ReadLine();
            sr.Close();
            String fromSB = var.Trim(sep);
            textBox2.Text = fromSB;
            sr = new StreamReader("S(c).txt");
            var = sr.ReadLine();
            sr.Close();
            String fromSC = var.Trim(sep);
            textBox3.Text = fromSC;
            sr = new StreamReader("S(d).txt");
            var = sr.ReadLine();
            sr.Close();
            String fromSD = var.Trim(sep);
            textBox4.Text = fromSD;
            Random r = new Random();
            int l = r.Next(0, 10);
            for (int i = 0; i < l; i++)
                fromFormSE += r.Next(0, 10) + " ";
            textBox5.Text = fromFormSE;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fromFormSA = textBox1.Text.ToString();
            StreamWriter sw = new StreamWriter("S(a).txt");
            sw.WriteLine(fromFormSA);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fromFormSB = textBox2.Text.ToString();
            StreamWriter sw = new StreamWriter("S(b).txt");
            sw.WriteLine(fromFormSB);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String fromFormSC = textBox3.Text.ToString();
            StreamWriter sw = new StreamWriter("S(c).txt");
            sw.WriteLine(fromFormSC);
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String fromFormSD = textBox4.Text.ToString();
            StreamWriter sw = new StreamWriter("S(d).txt");
            sw.WriteLine(fromFormSD);
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                Random r = new Random();
                int len = r.Next(0, 10);
                String fromSA = "";
                for (int i = 0; i < len; i++)
                    fromSA += r.Next(from, to) + " ";
                textBox1.Text = fromSA;
                StreamWriter sw = new StreamWriter("S(a).txt");
                sw.WriteLine(fromSA);
                sw.Close();
                len = r.Next(1, 10);
                String fromSB = "";
                for (int i = 0; i < len; i++)
                    fromSB += r.Next(from, to) + " ";
                textBox2.Text = fromSB;
                sw = new StreamWriter("S(b).txt");
                sw.WriteLine(fromSB);
                sw.Close();
                len = r.Next(1, 10);
                String fromSC = "";
                for (int i = 0; i < len; i++)
                    fromSC += r.Next(from, to) + " ";
                textBox3.Text = fromSC;
                sw = new StreamWriter("S(c).txt");
                sw.WriteLine(fromSC);
                sw.Close();
                len = r.Next(1, 10);
                String fromSD = "";
                for (int i = 0; i < len; i++)
                    fromSD += r.Next(from, to) + " ";
                textBox4.Text = fromSD;
                sw = new StreamWriter("S(d).txt");
                sw.WriteLine(fromSD);
                sw.Close();
                len = r.Next(1,10);
                String fromSE = "";
                for (int i = 0; i < len; i++)
                    fromSE += r.Next(from, to) + " ";
                textBox5.Text = fromSE;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            from = int.Parse(textBox7.Text);
            to = int.Parse(textBox8.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fromFormSE = textBox5.Text.ToString();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamReader srr = new StreamReader("S(a).txt");
            String var = srr.ReadLine();
            srr.Close();
            char[] sep = new char[] { ',', ' ' };
            String fromSA = var.Trim(sep);
            string[] SA = new string[fromSA.Split(' ').Length];
            SA = fromSA.Split(' ');
            srr = new StreamReader("S(b).txt");
            var = srr.ReadLine();
            srr.Close();
            String fromSB = var.Trim(sep);
            string[] SB = new string[fromSB.Split(' ').Length];
            SB = fromSB.Split(' ');
            srr = new StreamReader("S(c).txt");
            var = srr.ReadLine();
            srr.Close();
            String fromSC = var.Trim(sep);
            string[] SC = new string[fromSC.Split(' ').Length];
            SC = fromSC.Split(' ');
            srr = new StreamReader("S(d).txt");
            var = srr.ReadLine();
            srr.Close();
            String fromSD = var.Trim(sep);
            string[] SD = new string[fromSD.Split(' ').Length];
            SD = fromSD.Split(' ');
            string[] SE = new string[fromFormSE.Split(' ').Length];
            SE = fromFormSE.Split(' ');
            int a = SA.Length;
            int b = SB.Length;
            int c = SC.Length;
            int d = SD.Length;
            int eq = SE.Length;
            int theGreat =0;
            if (a <= b && a <= c){
                if (a <= d && a <= eq)
                { theGreat = a;}}
            if(b<=a&&b<=c){
                if (b<=d&&b<=eq)
                { theGreat = b;}}
            if (c<=a&&c<=b){
                if (c<=d&&c<=eq)
                {theGreat = c;}}
            if (d<=a&&d<=b){
                if (d<=c&&d<=eq)
                { theGreat = d;}}
            if (eq <= a && eq <= b)
            {
                if (eq <= d && eq <= c)
                { theGreat = eq; }
            }
            ArrayList someList = new ArrayList();
            for (int i = 0; i < theGreat; i++)
            {
                someList.Add(SA[i]);
                someList.Add(SB[i]);
                someList.Add(SC[i]);
                someList.Add(SD[i]);
                someList.Add(SE[i]);
            }
            String End = "";
            for (int i = 0; i < someList.Count; i++)
                End += someList[i]+" ";
            textBox6.Text = End.ToString();
            StreamWriter sww = new StreamWriter("S(e).txt");
            sww.WriteLine(End);
            sww.Close();
        }
    }
}
