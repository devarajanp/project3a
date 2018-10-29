using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priya_project_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string a = box1.Text;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = box1.Text;
            for (int i = 0; i <= a.Length; i++)
            {
                a = a.Replace("@", "");
                a = a.Replace("}", "");
                a = a.Replace("#", "");
                a = a.Replace("(", "");
                a = a.Replace("[", "");
                a = a.Replace("]", "");
                a = a.Replace(")", "");
            }
            box1.Text = a;
            string b = box2.Text;
            if (b.StartsWith("the") || b.StartsWith("they") || b.StartsWith("all") || b.StartsWith("not") || b.StartsWith("no") || b.StartsWith("bye")) ;
            {
                MessageBox.Show("The Character 2 cannot start with the or they or all or not or no or bye");
                box2.Clear();
                box2.Focus();
            }
            string c = box3.Text;
            if (c.EndsWith("1") || c.EndsWith("2") || c.EndsWith("3") || c.EndsWith("4") || c.EndsWith("5"))
            {
                MessageBox.Show("The Character 3 cannot End with a 1 or 2 or 3 or 4 or 5");
                box3.Clear();
                box3.Focus();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
