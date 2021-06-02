using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midsem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
        }
        public delegate void sendusername(string str);
        public sendusername send;
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Name = null;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\midsem.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "select * from [login] where username = '" + username.Text + "' and password = '" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("LOGIN SUCCESS!!");
                    this.Hide();

                    try
                    {
                        using (SqlCommand command = new SqlCommand("SELECT name FROM [login] where username ='" + username.Text + "' ", conn))
                        {
                            conn.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Name = reader[0].ToString();

                                }
                            }
                        }

                        Learning nx = new Learning();
                        this.send += new sendusername(nx.gettext);
                        send(Name);
                        nx.Show();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("login failed");
            }
            catch
            {
                MessageBox.Show("login failed");
            }
        }
    }
}
