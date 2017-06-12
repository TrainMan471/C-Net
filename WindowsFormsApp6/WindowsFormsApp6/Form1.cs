using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Names = new string[5];
            Names[0] = "Joe";
            Names[1] = "Mike";
            Names[2] = "Peter";
            Names[3] = "Jacob";
            Names[4] = "Erin";
            MessageBox.Show(Names[4]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> Names = new List<string>();
            Names.Add("Adam");
            Names.Add("Joe");
            Names.Add("Peter");
            Names.Add("Erin");
            Names.Add("Nate");
            MessageBox.Show(Names[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++ )
            {
                MessageBox.Show("Hello" + i.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> names = new List<int>();
            names.Add(12);
            names.Add(15);
            names.Add(17);
            foreach(int i in names)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i < 10 )
            {
                textBox1.Text += i.ToString();
                i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 0;
            do
            {
                textBox2.Text += number.ToString();
                number++;

            }
            while (number < 10);
        }
    }
}
