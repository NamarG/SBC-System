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


namespace Sphere_Booking_and_Check_in_System.Employee_Managment
{
    public partial class frmEmpCtrl : Form
    {
        public frmEmpCtrl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //unused variable
        }

        private void frmEmpCtrl_Load(object sender, EventArgs e)
        {
            this.staffTableAdapter.Fill(this.mainDatabaseDataSet.Staff);
        }

        private void empView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //unused variable
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDatabaseDataSet);

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                if (FNameT.Text == String.Empty || UNameT.Text == String.Empty || EmailT.Text == String.Empty || PNT.Text == String.Empty || AdT.Text == String.Empty)
                {
                    MessageBox.Show("Error, values missing", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  //checks if values are present
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Staff ([firstname], [lastname], [address], [phoneNumber], [emailAddress], [username], [password], [preferWork] ) VALUES (@firstname, @lastname, @address, @phoneNumber, @emailAddress, @username, @password, @preferWork);", Connection);
                        cmd.Parameters.AddWithValue("@firstname", FNameT.Text);
                        cmd.Parameters.AddWithValue("@lastname", LNameT.Text);
                        cmd.Parameters.AddWithValue("@username", UNameT.Text);
                        cmd.Parameters.AddWithValue("@password", PWordT.Text);              //section uses SQL to add to DB
                        cmd.Parameters.AddWithValue("@emailAddress", EmailT.Text);
                        cmd.Parameters.AddWithValue("@phoneNumber", PNT.Text);
                        cmd.Parameters.AddWithValue("@address", AdT.Text);
                        cmd.Parameters.AddWithValue("@preferRole", PRoleT.Text);

                        int i = cmd.ExecuteNonQuery();
                        Connection.Close();

                        if (i == 1)
                        {
                            MessageBox.Show("Employee has been added");
                            FNameT.Clear();
                            UNameT.Clear();
                            EmailT.Clear();         //clears txtboxes after successful addition
                            PNT.Clear();
                            AdT.Clear();
                            UNameT.Clear();
                            PWordT.Clear();
                            PRoleT.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Employee couldn't be added");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }

            }
        }
        private void getPrimaryKey()
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT MAX(Id)+1 FROM Staff;", Connection);
                    Connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }

        private void AddLabel_Click(object sender, EventArgs e)
        { //unused variable
        }

        private void Rid_TextChanged(object sender, EventArgs e)
        { //unused variable
        }

        private void staffDataGridView_CellContentClick(object sender, EventArgs e)
        { //unused variable
        }
        private void UpdtBTN_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (Rid.Text == string.Empty)
                {
                    MessageBox.Show("Missing values");
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM Staff where id=Rid.text");    //SQL to delete row from DB


                        int i = cmd.ExecuteNonQuery();
                        Connection.Close();


                        if (i == 1)   //confirms success or fail
                        {
                            MessageBox.Show("Employee has been removed");
                            Rid.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Employee couldn't be removed");
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
