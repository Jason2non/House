using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ShowManagementSystem
{
    public partial class Employee : Form
    {
   
        public Employee()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection(Global.connectionString);
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
            addressTxt.Clear();
            phoneTxt.Clear();
            emailTxt.Clear();
            passTxt.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel form = new AdminPanel();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || addressTxt.Text == "" || phoneTxt.Text == "" || emailTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Fill in the missing fields");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Insert into Employee([ID],[Name],[Address],[Phone],[Email],[DOB],[Password]) values(@Id,@Na,@Ad,@Ph,@Em,@Do,@Pa)", con);
                    cmd.Parameters.AddWithValue("@Id", idTxt.Text);
                    cmd.Parameters.AddWithValue("@Na", nameTxt.Text);
                    cmd.Parameters.AddWithValue("@Ad", addressTxt.Text);
                    cmd.Parameters.AddWithValue("@Ph", phoneTxt.Text);
                    cmd.Parameters.AddWithValue("@Em", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@Do", dateTime.Value.Date);
                    //cmd.Parameters.AddWithValue("@Jo", jobCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Pa", passTxt.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Details added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
