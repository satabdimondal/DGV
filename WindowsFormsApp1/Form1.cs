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
    
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DemoDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Reset()
        {
            FnameTB.Text = "";
            LnameTB.Text = "";
            UnameTB.Text = "";
            PhoneTB.Text = "";
            AddressTB.Text = "";
            
        }

        private void populate()
        {
            con.Open();
            string query = "select * from InfoTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FnameTB.Text == "" || LnameTB.Text == "" || UnameTB.Text == "" || PhoneTB.Text == "" || AddressTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    string query = "insert into InfoTable values('" + FnameTB.Text + "', '" + LnameTB.Text + "', '" + UnameTB.Text + "', '" + PhoneTB.Text + "', '" + AddressTB.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Successfully Saved");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update InfoTable set FirstName=@FirstName, LastName=@LastName, UserName=@UserName, PhoneNo=@PhoneNo, Address=@Address", con);
            cmd.Parameters.AddWithValue("@FirstName", FnameTB.Text);
            cmd.Parameters.AddWithValue("@LastName", LnameTB.Text);
            cmd.Parameters.AddWithValue("@UserName", UnameTB.Text);
            cmd.Parameters.AddWithValue("@PhoneNo", int.Parse(PhoneTB.Text));
            cmd.Parameters.AddWithValue("@Address", AddressTB.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Information Successfully Updated");
            populate();
            Reset();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from InfoTable where UserName=@UserName", con);
            cmd.Parameters.AddWithValue("@UserName", UnameTB.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information Successfully Deleted");
            populate();
            Reset();
        }
    }
}
