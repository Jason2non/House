using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShowManagementSystem
{
    public partial class Schedule : Form
    {
        
        public Schedule()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Global.connectionString);

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel form = new AdminPanel();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showTxt.Clear();
            duraTxt.Clear();
            castTxt.Clear();
            crewTxt.Clear();
            timeTxt.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            venueTxt.Clear();
            sectTxt.Clear();
            seatTxt.Clear();
            capTxt.Clear();
        }

        private void shoBtn_Click(object sender, EventArgs e)
        {
            if (showTxt.Text == "" || duraTxt.Text == "" || castTxt.Text == "" || crewTxt.Text == "" || timeTxt.Text == "")
            {
                MessageBox.Show("Fill in any missing fields in adding show");
            }
            else
            {
                con.Open();
                try
                {

                    OleDbCommand cmd = new OleDbCommand("Insert into Schedule([ID],[showtitle],[genre],[duration],[cast],[crew],[price],[time])values(@Id,@St,@Ge,@Du,@Ca,@Cr,@Pr,@Ti)", con);
                    cmd.Parameters.AddWithValue("@Id", showidtxt.Text);
                    cmd.Parameters.AddWithValue("@St", showTxt.Text);
                    cmd.Parameters.AddWithValue("@Ge", genreCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Du", duraTxt.Text);
                    cmd.Parameters.AddWithValue("@Ca", castTxt.Text);
                    cmd.Parameters.AddWithValue("@Cr", crewTxt.Text);
                    cmd.Parameters.AddWithValue("@Pr", priceTxt.Text);
                    cmd.Parameters.AddWithValue("@Ti", timeTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (venueTxt.Text == "" || sectTxt.Text == "" || rowTxt.Text == "" || seatTxt.Text == "" || capTxt.Text == "")
            {
                MessageBox.Show("Fill in any missing fields in add seat");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Insert into Venues([venue],[section],[row],[seatnumber],[capacity])values(@Ve,@Se,@Ro,@Sn,@Ca)", con);
                    cmd.Parameters.AddWithValue("@Ve", venueTxt.Text);
                    cmd.Parameters.AddWithValue("@Se", sectTxt.Text);
                    cmd.Parameters.AddWithValue("@Ro", rowTxt.Text);
                    cmd.Parameters.AddWithValue("@Sn", seatTxt.Text);
                    cmd.Parameters.AddWithValue("@Ca", capTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved successfully");
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void showTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void duraTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void castTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sectTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rowTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void seatTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void genreCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
