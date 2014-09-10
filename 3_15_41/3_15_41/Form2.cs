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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1.Field3 = "";
            Form1.Field2 = "";
            Form1.Field1 = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String var1 = Form1.Field1;
            String var2 = Form1.Field2;
            String var3 = Form1.Field3;
            string[] va3 = new string[var3.Split(' ').Length];
            va3 = var3.Split(' ');
            string[] va2 = new string[va3.Length];
            va2 = var2.Split(' ');
            string[] va1 = new string[va2.Length];
            va1 = var1.Split(' ');
            string text = "";
            int len = (va1.Length/20);
            int def = va1.Length - (va1.Length / 20) * 20;
            int raz = 20 / def;
            label2.Text = len.ToString() ;
            int qwe = 0;
            for (int i = 0; i < len+1; i++)
            {
                text += "|";
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (i == len)
                    {
                        for (int k = (va1.Length / 20) * 20; k < (va1.Length / 20) * 20 + def; k++)
                        {
                            if (j == 0)
                            {
                                string per = va1[k] + " ";
                                while (per.Length < raz*7)
                                    per += " ";
                                text += per;
                            }
                            if (j == 1)
                            {
                                string per = va2[k] + " ";
                                while (per.Length < raz*7)
                                    per += " ";
                                text += per;
                            }
                            if (j == 2)
                            {
                                string per = va3[k] + " ";
                                while (per.Length < raz*7)
                                    per += " ";
                                text += per;
                            }
                        }
                    }
                    else
                    {
                        for (int k = qwe; k < qwe + 20; k++)
                        {
                            if (j == 0)
                            {
                                string per = va1[k] + " ";
                                while (per.Length < 4)
                                    per += " ";
                                text += per;
                            }
                            if (j == 1)
                            {
                                string per = va2[k] + " ";
                                while (per.Length < 4)
                                    per += " ";
                                text += per;
                            }
                            if (j == 2)
                            {
                                string per = va3[k] + " ";
                                while (per.Length < 4)
                                    per += " ";
                                text += per;
                            }
                        }
                    }
                    if (j != 2)
                    {
                        text += "\t \t";
                        count++;
                    }
                }
                text += "|";
                if (count == 2)
                { text += "\t \t"; }
                
                text += Environment.NewLine;
                qwe += 20;
            }
            textBox1.Text = text;
            StreamWriter sw = new StreamWriter("answer.txt");
            sw.Write(text);
            sw.Close();
        }
    }
}
