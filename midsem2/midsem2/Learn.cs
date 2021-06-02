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
    public partial class Learn : Form
    {
        int count = 0;
        string s1, s2;
        public Learn()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            s1 = "python";
            s2 = "Python is an interpreted, high-level and general-purpose programming language. Python's design philosophy emphasizes code readabili with its notable use of significant whitespace.";
            material m = new material();
            m.gettext(s1, s2);
            m.Show();
            string k = count.ToString();
            report r = new report();
            r.getcount(count,k);
           }

        private void button7_Click(object sender, EventArgs e)
        {
            s1 = "Strings";
            s2 = "Strings are amongst the most popular types in Python. We can create them simply by enclosing characters in quotes. Python treats single quotes the same as double quotes. Creating strings is as simple as assigning a value to a variable. For example − var1 = 'Hello World!  var2 = \"Python Programming\"";

            count++;
            material m = new material();
            m.gettext(s1, s2);
            m.Show();
            string k = count.ToString();
            report r = new report();
            r.getcount(count,k);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count++;
        }
    }
}
