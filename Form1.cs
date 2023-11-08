using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("Тази програма проверява, дали въведеното число е четно или нечетно.");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number;
            try
            {
                number = Double.Parse(textBox1.Text);
                if (number % 2 == 0)
                {
                    MessageBox.Show("Четно!");

                }
                else
                {
                    MessageBox.Show("Нечетно!");
                }
            }
            catch
            {
                MessageBox.Show("Input string is not in correct format!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
