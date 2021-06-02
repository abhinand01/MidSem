using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace midsem2
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\midsem.mdf;Integrated Security=True;Connect Timeout=30");

                Con.Open();

                SqlCommand cmd = new SqlCommand("insert into [login] values('" + username.Text.Trim() + "','" + email.Text.Trim() + "','" + name.Text.Trim() + "','" + password.Text.Trim() + "')", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("YOU HAVE SIGNED IN SUCCESSFULLY!!");
                Con.Close();
                Form1 f = new Form1();
                f.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
