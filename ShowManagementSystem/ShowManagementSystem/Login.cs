using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ShowManagementSystem
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Global.connectionString);
        private void Admin()
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (emailTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Fill in all the required fields");
            }
            else
            {
                try
                {

                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Select email,password FROM Customer", con);
                    //OleDbDataReader dr = cmd.ExecuteReader();
                    cmd.Parameters.AddWithValue("@Em", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@Pa", passTxt.Text);
                    OleDbDataAdapter sda = new OleDbDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int i = cmd.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Successfully logged in");
                        booking form = new booking();
                        this.Hide();
                        form.Show();

                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Password");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        /*
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    MessageBox.Show("Logoin successfull");
                    booking form = new booking();
                    form.ShowDialog();
                }

                else
                {
                    dr.Close();
                    MessageBox.Show("Now accounts found, please Register");
                }
                con.Close();
*/
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Curegister form = new Curegister();
            this.Hide();
            form.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (emailTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Fill in all the required fields");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Select username,password FROM Admin", con);
                    cmd.Parameters.AddWithValue("@Em", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@Pa", passTxt.Text);
                    OleDbDataAdapter sda = new OleDbDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int i = cmd.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Successfully logged in");
                        AdminPanel form = new AdminPanel();
                        this.Hide();
                        form.Show();

                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Password");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    //OleDbDataReader dr = cmd.ExecuteReader();
                    /*if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        MessageBox.Show("Login Successfull");
                        AdminPanel form = new AdminPanel();
                        form.Show();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    */
                }
        }
    }
}
