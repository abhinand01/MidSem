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
    public partial class Learning : Form
    {
        public Learning()
        {
            InitializeComponent();
        }
        public void gettext(string str)
        {
            label1.Text = "hi ," + str;
        }

        private void Learning_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Learn f = new Learn() { TopLevel = false, TopMost = false };
        practice fr = new practice() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        report re = new report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 2)
                this.panel2.Controls.Remove(fr);
            if (flag == 3)
                this.panel2.Controls.Remove(re);
            this.panel2.Controls.Add(f);
            flag = 1;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                this.panel2.Controls.Remove(f);
            if (flag == 3)
                this.panel2.Controls.Remove(re);
            this.panel2.Controls.Add(fr);
            flag = 2;
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quiz q = new Quiz();
            q.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag==1)
                this.panel2.Controls.Remove(f);
            if(flag==2)
                this.panel2.Controls.Remove(fr);
            this.panel2.Controls.Add(re);
            flag = 3;
            re.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
