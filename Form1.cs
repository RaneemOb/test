using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        Class1 obj;
        public form1()
        {
           
            InitializeComponent();
            obj = new Class1(num1.Text, num2.Text);
        }

      

       
        private void button1_Click(object sender, EventArgs e)
        {

            textBox4.Text = obj.Sum(double.Parse(num1.Text) , double.Parse(num2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = obj.Sub(double.Parse(num1.Text), double.Parse(num2.Text)).ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
