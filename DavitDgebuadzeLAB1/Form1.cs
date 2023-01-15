using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Answer to a question: When the text boxes are empty, the value is considered as 0 and it will not be added to the total.
namespace DavitDgebuadzeLAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);


            double total = num1 + num2;


            textBox3.Text = total.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // opend those by accident tried to delete it but then design file would show errors could figure out how to properly delete those
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // opend those by accident tried to delete it but then design file would show errors could figure out how to properly delete those
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);


            double total = num1 - num2;


            textBox3.Text = total.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);


            double total = num1 * num2;


            textBox3.Text = total.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);


            double total = num1 / num2;


            textBox3.Text = total.ToString();
        }
    }
}
