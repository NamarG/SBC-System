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
                                groupBox1.Visible = true;
                                this.Size = new Size(483, 483);
                                groupBox5.Enabled = true;
                                groupBox5.Visible = true;
                                btnSearchStaff.Enabled = false;

                                using (cmd = new SqlCommand("SELECT * FROM Staff WHERE firstName=@first AND lastName=@last", Connection))
                                {
                                    cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                                    cmd.Parameters.AddWithValue("@last", txtLastName.Text);

                                    SqlDataReader sdr = cmd.ExecuteReader();

                                    while (sdr.Read())
                                    {
                                        lblID.Text = (sdr["Id"].ToString());
                                        lblUsername.Text = (sdr["username"].ToString());
                                        lblFirst.Text = (sdr["firstName"].ToString());
                                        lblLast.Text = (sdr["lastName"].ToString());
                                        lblEmail.Text = (sdr["emailAddress"].ToString());
                                        lblAddress.Text = (sdr["address"].ToString());
                                        lblPhone.Text = (sdr["phoneNumber"].ToString());
                                        lblDays.Text = (sdr["preferWork"].ToString());

                                        txtSearchBox.Text = (sdr["Id"].ToString());
                                    }
                                    sdr.Close();
                                }
                                Properties.Settings.Default.staffID = int.Parse(txtSearchBox.Text);
                            }
                            else
                            {
                                MessageBoxEx.Show("Staff Member Does Not Exist");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBoxEx.Show("Unexpected error:" + ex.Message);
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
                                    groupBox1.Visible = true;
                                    this.Size = new Size(483, 483);

                                    using (cmd = new SqlCommand("SELECT * FROM Staff WHERE firstName=@first AND lastName=@last AND emailAddress=@mail", Connection))
                                    {
                                        cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                                        cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                                        cmd.Parameters.AddWithValue("@mail", txtEmail.Text);

                                        SqlDataReader sdr = cmd.ExecuteReader();

                                        while (sdr.Read())
                                        {
                                            lblID.Text = (sdr["Id"].ToString());
                                            lblUsername.Text = (sdr["username"].ToString());
                                            lblFirst.Text = (sdr["firstName"].ToString());
                                            lblLast.Text = (sdr["lastName"].ToString());
                                            lblEmail.Text = (sdr["emailAddress"].ToString());
                                            lblAddress.Text = (sdr["address"].ToString());
                                            lblPhone.Text = (sdr["phoneNumber"].ToString());
                                            lblDays.Text = (sdr["preferWork"].ToString());

                                            txtSearchBox.Text = (sdr["Id"].ToString());
                                        }
                                        sdr.Close();
                                    }
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
                            labelX5.Visible = true;
                            dataGridViewX1.Visible = true;
                            groupBox2.Visible = true;
                            groupBox5.Enabled = false;
                            this.Size = new Size(677, 483);

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

        private void frmFindStaff_Load(object sender, EventArgs e)
        {
            this.Size = new Size(273, 216);
            label15.ForeColor = Color.Red;
            lblDays.ForeColor = Color.Red;
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(273, 216);
            labelX5.Visible = false;
            groupBox1.Visible = false;
            dataGridViewX1.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = false;

            groupBox5.Enabled = false;
            btnSearchStaff.Enabled = true;

            lblUsername.Text = "";
            lblFirst.Text = "";
            lblLast.Text = "";
            lblEmail.Text = "";
            lblAddress.Text = "";
            lblPhone.Text = "";
            lblDays.Text = "";
            txtSearchBox.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (comboBox1.Text == String.Empty)
                {
                    MessageBoxEx.Show("Search Critera is Empty");
                    txtSearchBox.Focus();
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT date, startTime, endTime FROM Staff_Scheduling WHERE DATENAME(dw, date) LIKE '%'+ @search + '%'", Connection);
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Staff_Scheduling WHERE DATENAME(dw, date) LIKE '%'+ @search + '%' AND booked = 0", Connection);
                        cmdCheck.Parameters.AddWithValue("@search", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@search", comboBox1.Text);

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