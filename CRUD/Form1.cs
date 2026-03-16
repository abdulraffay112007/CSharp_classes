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

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn=new SqlConnection("Data Source=localhost;Initial Catalog=std_database;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd=new SqlCommand("INSERT INTO std_info(id,std_name,std_email,std_contact) VALUES(@id,@name,@email,@contact)",conn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(idbox.Text));
                    cmd.Parameters.AddWithValue("@name", namebox.Text);
                    cmd.Parameters.AddWithValue("@email", emailbox.Text);
                    cmd.Parameters.AddWithValue("@contact",contactbox.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Data saved ","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=std_database;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd=new SqlCommand("Delete from std_info where id=@id",conn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(idbox.Text));
                    cmd.ExecuteNonQuery ();
                }
            }
            MessageBox.Show("Data delete ", "conform", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=std_database;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE std_info set std_name=@name , std_email=@email,std_contact=@contact where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(idbox.Text));
                    cmd.Parameters.AddWithValue("@name", namebox.Text);
                    cmd.Parameters.AddWithValue("@email", emailbox.Text);
                    cmd.Parameters.AddWithValue("@contact", contactbox.Text);
                    cmd.ExecuteNonQuery () ;
                }
            }
            MessageBox.Show("Data update ", "conform", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=std_database;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from std_info", conn))
                {
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource= dt;
                }
            }

        }
    }
}
