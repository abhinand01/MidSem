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
    public partial class practice : Form
    {
        public practice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            question1 Q = new question1();
            Q.Show();
        }
    }
}
