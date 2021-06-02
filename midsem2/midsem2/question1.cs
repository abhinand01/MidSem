using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midsem2
{
    public partial class question1 : Form
    {
        public static int score = 0;
        public question1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer= "2.0";
            Console.WriteLine(answer);
            if (textBox1.Text == answer)
            {
                MessageBox.Show("correct Answer");
                score = 10;
            }
            else
                MessageBox.Show("wrong");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            report r = new report();
            string s = score.ToString();
            r.getquestionscore(s);
            this.Close();
        }
    }
}
