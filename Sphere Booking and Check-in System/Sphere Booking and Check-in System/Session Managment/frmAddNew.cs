using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmAddNew : Form
    {
        public frmAddNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to manually edit the primary key?", "Over-ride Primary Key", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtKey.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtKey.Text == String.Empty || txtStaffID.Text == String.Empty || txtDate.Text == String.Empty ||
                    txtTime.Text == String.Empty || txtCustomerID.Text == String.Empty || comboBoxSlope.Text == String.Empty)
                {
                    MessageBox.Show("Error, values missing", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Session() VALUES (@id, @slope, @staff, @date, @time, @customer)", Connection);
                        cmd.Parameters.AddWithValue("@id", txtKey.Text);
                        cmd.Parameters.AddWithValue("@slope", comboBoxSlope.Text);
                        cmd.Parameters.AddWithValue("@staff", txtStaffID.Text);
                        cmd.Parameters.AddWithValue("@date", txtDate.Text);
                        cmd.Parameters.AddWithValue("@time", txtTime.Text);
                        cmd.Parameters.AddWithValue("@customer", txtCustomerID.Text);

                        cmd.ExecuteScalar();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void frmAddNew_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT MAX(id) +1 FROM Session", Connection);
                    txtKey.Text = cmd.ExecuteScalar().ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }
    }
}
