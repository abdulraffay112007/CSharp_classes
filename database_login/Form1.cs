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

namespace database_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name=textBox1.Text;
            string Email=textBox2.Text;
            using (SqlConnection con=new SqlConnection("Data Source=localhost;Initial Catalog=std_database;Integrated Security=True;"))
            {
                con.Open();
                using (SqlCommand cmd=new SqlCommand("SELECT COUNT(*) FROM std_info WHERE std_name=@name AND std_email=@email",con))
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@email", Email);
                    int count =Convert.ToInt32(cmd.ExecuteScalar());
                    if(count > 0)
                    {
                        MessageBox.Show("Login successful","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
