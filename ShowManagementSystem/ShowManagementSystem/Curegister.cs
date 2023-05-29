using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShowManagementSystem
{
    public partial class Curegister : Form
    {
        public Curegister()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection(Global.connectionString);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnameTxt.Clear();
            addressTxt.Clear();
            pnumbTxt.Clear();
            emailTxt.Clear();
            passTxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnameTxt.Text == "" || addressTxt.Text == "" || pnumbTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                //This is the connection to the database
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Insert into Customer([ID],[Name],[Address],[Phone],[Email],[DOB],[Password]) values(@Id,@Na,@Ad,@Ph,@Em,@DO,@Pa)", con);
                    cmd.Parameters.AddWithValue("@Id", cidTxt.Text);
                    cmd.Parameters.AddWithValue("@Na", cnameTxt.Text);
                    cmd.Parameters.AddWithValue("@Ad", addressTxt.Text);
                    cmd.Parameters.AddWithValue("@Ph", pnumbTxt.Text);
                    cmd.Parameters.AddWithValue("@Em", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@DO", dateReg.Value.Date);
                    cmd.Parameters.AddWithValue("@Pa", passTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details updated successfully");
                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }
    }
}
