using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priya_project_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class startwithtwo : Exception
        {


            public startwithtwo()
            {
                MessageBox.Show("An exception has occured the number cannot start with 1 for the second number");
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = text2.Text;
                decimal Divident = Convert.ToDecimal(text1.Text);
                decimal Divisor = Convert.ToDecimal(text2.Text);
                decimal Remainder = Divident / Divisor;
                if (Divisor > 1000)
                {
                    throw new OverflowException();
                };
                if (a.StartsWith("1"))
                {
                    throw new startwithtwo();
                }
                text3.Text = Remainder.ToString();
                text1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception has occured enter values in numbers only");
                text1.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow exception has occured enter Number less than 1000");
                text1.Focus();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide by zero exception has occured enter a number greater than zero for Second Number");
                text2.Focus();
            }
            catch (startwithtwo)
            {
                text1.Focus();
            }
        }
    }
}
