using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShowManagementSystem
{
    public partial class booking : Form
    {

        OleDbDataReader cap;
        public booking()
        {
           
            InitializeComponent();
            ShowVenue();
            showTitle();
            showDuration();
            showTime();
            showSeat();
            showTicket();

            
        }
        //showing the venue of the place
        OleDbConnection con = new OleDbConnection(Global.connectionString);
        private void ShowVenue()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [venue] FROM Venues", con);
                OleDbDataReader cap = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("venue", typeof(String));
                dt.Load(cap);
                venuCb.DisplayMember = "venue";
                venuCb.ValueMember = "venue";
                venuCb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        //To show the title of the movie
        private void showTitle()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [showtitle] FROM Schedule", con);
                cap = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("showtitle", typeof(String));
                dt.Load(cap);
                titleCb.DisplayMember = "showtitle";
                titleCb.ValueMember = "showtitle";
                titleCb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //Show the duration of that it takes in the movie
        private void showDuration()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [duration] FROM Schedule WHERE", con);
                cap = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("duration", typeof(String));
                dt.Load(cap);
                durCb.DisplayMember = "duration";
                durCb.ValueMember = "duration";
                durCb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void showTime()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [time] FROM Schedule", con);
                cap = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("time", typeof(String));
                dt.Load(cap);
                timeCb.DisplayMember = "time";
                timeCb.ValueMember = "time";
                timeCb.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void showSeat()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [seatnumber] FROM Venues WHERE seatnumber=@Sn", con);
                cap = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("seatnumber", typeof(String));
                dt.Load(cap);
                seatCb.DisplayMember = "seatnumber";
                seatCb.ValueMember = "seatnumber";
                seatCb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void showTicket()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [cast] FROM Schedule WHERE cast=@Ca", con);
                cap = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("cast", typeof(String));
                dt.Load(cap);
                tickCb.DisplayMember = "cast";
                tickCb.ValueMember = "cast";
                tickCb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void price()

        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Select [price] FROM Schedule WHERE [cast] IS NOT NULL", con);
                cap = cmd.ExecuteReader();
                while (cap.Read())
                {
                    //string price = cap.GetInt32(0).ToString();
                    textBox1.Text = cap["price"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
       /* private void seatnum()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Select [capacity] FROM Venues WHERE [venue] IS NOT NULL", con);
                cap = cmd.ExecuteReader();
                while (cap.Read())
                {
                    string capacity = cap.GetInt32(0).ToString();
                    capCb.Text = capacity;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
               con.Close();
            }

        }*/
        private void booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stageManagementSystemDataSet.place' table. You can move, or remove it, as needed.


        }
        
        private void pdfdisplay()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from booking", con);
                OleDbDataAdapter dr = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTicket();
            price();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();

        }

        private void genreCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDuration();

        }

        private void venuCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowVenue();
        }
        private void titleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTitle();
        }

        private void timeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTime();

        }

        private void seatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSeat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into Booking([Name],[Ttype],[Venue],[Snumber],[Title],[Date],[Duration],[Time],[Price]) values(@Na,@Tt,@Ve,@Sn,@Ti,@Da,@Du,@Ti,@Pr)", con);
                cmd.Parameters.AddWithValue("@Na", nameTxt.Text);
                cmd.Parameters.AddWithValue("@Tt", tickCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Ve", venuCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Sn", seatCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Ti", titleCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Da", dateTime.Value.Date);
                cmd.Parameters.AddWithValue("@Du", durCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Ti", timeCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Pr", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booked succesfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
