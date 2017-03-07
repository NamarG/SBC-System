using System;
using System.Drawing;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmFindStaff : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Point oldLocation = new Point(int.MaxValue, 0);

        public frmFindStaff()
        {
            InitializeComponent();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            if (oldLocation.X != int.MaxValue && this.Owner != null)
            {
                this.Owner.Location = new Point(
                    this.Owner.Left + this.Left - oldLocation.X,
                    this.Owner.Top + this.Top - oldLocation.Y);
            }
            oldLocation = this.Location;
            base.OnLocationChanged(e);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool IsValidEmailAddress(string emailaddress) //REFERENCE: http://stackoverflow.com/questions/36035941/check-valid-email-address-in-c-sharp
        {
            try
            {
                Regex rx = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
                return rx.IsMatch(emailaddress);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtFirstName.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter the first name", "Input Error");
                    txtFirstName.Focus();
                }
                else if (txtLastName.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter the last name", "Input Error");
                    txtLastName.Focus();
                }
                else
                {
                    if (txtEmail.Text == String.Empty)
                    {
                        try
                        {
                            Connection.Open();
                            SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Staff WHERE firstName=@first AND lastName=@last", Connection);
                            cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                            cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                            int result = (int)cmd.ExecuteScalar();

                            if (result > 0)
                            {
                                Connection.Close();
                                using (cmd = new SqlCommand("SELECT Id, firstName, lastName, emailAddress FROM Staff WHERE firstName=@first AND lastName=@last", Connection))
                                {
                                    cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                                    cmd.Parameters.AddWithValue("@last", txtLastName.Text);

                                    cmd.CommandType = CommandType.Text;
                                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                    {
                                        using (DataSet ds = new DataSet())
                                        {
                                            sda.Fill(ds);
                                            dataGridViewX1.DataSource = ds.Tables[0];
                                        }
                                    }
                                }
                                txtSearchBox.Text = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
                                Properties.Settings.Default.staffID = int.Parse(txtSearchBox.Text);
                            }
                            else
                            {
                                MessageBoxEx.Show("Staff Member Does Not Exist");
                                //Clear rows
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBoxEx.Show("Unexpected error:" + ex.Message);
                            //Clear rows
                        }
                    }
                    else
                    {
                        if (IsValidEmailAddress(txtEmail.Text))
                        {
                            try
                            {
                                Connection.Open();
                                SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Staff WHERE firstName=@first AND lastName=@last AND emailAddress=@mail", Connection);
                                cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                                int result = (int)cmd.ExecuteScalar();

                                if (result > 0)
                                {
                                    Connection.Close();
                                    using (cmd = new SqlCommand("SELECT Id, firstName, lastName, emailAddress FROM Staff WHERE firstName=@first AND lastName=@last AND emailAddress=@mail", Connection))
                                    {
                                        cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                                        cmd.Parameters.AddWithValue("@last", txtLastName.Text);

                                        cmd.CommandType = CommandType.Text;
                                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                        {
                                            using (DataSet ds = new DataSet())
                                            {
                                                sda.Fill(ds);
                                                dataGridViewX1.DataSource = ds.Tables[0];
                                            }
                                        }
                                    }
                                    txtSearchBox.Text = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
                                    Properties.Settings.Default.staffID = int.Parse(txtSearchBox.Text);
                                }
                                else
                                {
                                    MessageBoxEx.Show("Staff Member Does Not Exist");
                                    //Clear rows
                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBoxEx.Show("Unexpected error:" + ex.Message);
                                //Clear rows
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Invlid Email Addres");
                            //Clear rows
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtSearchBox.Text == String.Empty)
                {
                    MessageBoxEx.Show("Search Critera is Empty");
                    txtSearchBox.Focus();
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT date, startTime, endTime FROM Staff_Scheduling WHERE (StaffID = '" + txtSearchBox.Text + "') AND booked = 0", Connection);
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Staff_Scheduling WHERE (staffID = '" + txtSearchBox.Text + "')", Connection);
                        int result = (int)cmdCheck.ExecuteScalar();

                        if (result > 0)
                        {
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                using (DataSet ds = new DataSet())
                                {
                                    sda.Fill(ds);
                                    dataGridViewX1.DataSource = ds.Tables[0];
                                }
                            }
                            Connection.Close();
                            Properties.Settings.Default.staffID = int.Parse(txtSearchBox.Text);
                        }
                        else
                        {
                            MessageBoxEx.Show("No Record Exists");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxEx.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }
    }
}