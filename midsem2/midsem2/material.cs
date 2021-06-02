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
    public partial class material : Form
    {
        public material()
        {
            InitializeComponent();
        }
        public void gettext(string s1,string s2)
        {
            label1.Text = s1;
            label2.Text = s2;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
