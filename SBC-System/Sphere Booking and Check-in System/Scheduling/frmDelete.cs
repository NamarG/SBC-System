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

namespace Sphere_Booking_and_Check_in_System.Scheduling
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (DatePicker.Text == String.Empty || TimePickerStart.Text == String.Empty || TimePickerEnd.Text == String.Empty || cbopleid.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in missing values");
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Session WHERE Id = ", Connection);
                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("Record Deleted");
                        }
                        else
                        {
                            MessageBox.Show("Unexpected error, record was not deleted");
                            Connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }
    }
}