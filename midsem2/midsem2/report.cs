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
    public partial class report : Form
    {
         int count { get; set; }
         int score { get; set; }
        int problem = 0;
        public static string t1;
        public static string t2;
        public static string t3;
        public void getcount(int c,string k)
        {
            count = c;
           string co = k;
             t1 = "You Have Covered " + co + " topics till now";
            Console.WriteLine(t1);
           
  
        }
        public void getscore(int sc)
        {
            score = sc;
            string sco = score.ToString();
             t2 = "your assessment Score is " + sco + " out of 5";
            Console.WriteLine(t2);
        }
        public void getquestionscore(string q)
        {
            t3 = "your Score in problem Solving is " + q + " till now,practice more";
        }
        public report()
        {
            InitializeComponent();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = t1;
            label2.Text = t2;
            label3.Text = t3;
            Console.WriteLine( t3);
        }
    }
}
