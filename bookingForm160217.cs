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
using System.Configuration;

namespace Sphere_Booking_and_Check_in_System.Booking
{
    public partial class bookingForm : Form
    {
        bool isreg = false;
        SqlConnection con; //connection
        string connectionString;


        public bookingForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Sphere_Booking_and_Check_in_System.Properties.Settings.mainDatabaseConnectionString"].ConnectionString;
            //GetBookings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand checkid = new SqlCommand();
            checkid.CommandText = "select * from [Customer]";
            checkid.Connection = con;

            SqlDataReader rd = checkid.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0].ToString() == textBox1.Text) //the zero here is calling to the id col
                { //here we are saying that if rd var is == to the value user input is a match then isreg before true.
                    isreg = true;
                    //we then print it out to the label.
                }

            }
            if (isreg == true)
            {
                label3.Text = "Is registerd";
            }
            else
            {
                label3.Text = "Could not find";
            }
            isreg = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand checkid = new SqlCommand();
            checkid.CommandText = "select * from [Customer]";
            checkid.Connection = con;

            SqlDataReader rd = checkid.ExecuteReader();
            while (rd.Read())
            {
                if (rd[4].ToString() == textBox2.Text) //the 4 here is calling to the email col
                { //here we are saying that if rd var is == to the value user input is a match then isreg before true.
                    isreg = true;
                    //we then print it out to the label.
                }

            }
            if (isreg == true)
            {
                label4.Text = "Is registerd";
            }
            else
            {
                label4.Text = "Could not find";
            }
            isreg = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Queary = "insert into Booking (bookingDate,bookingTime,staffId,customerID,slopeID) values('" + this.dateTimePicker1.Text + "','" + this.time.Text + "','" + this.slopeID.Text + "','" + this.cusID.Text + "','" + this.staffID.Text + "');";
            con = new SqlConnection(connectionString);
            SqlCommand cmddatabase = new SqlCommand(Queary, con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmddatabase.ExecuteReader();
                    MessageBox.Show("saved");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void End_Click(object sender, EventArgs e)
        {
            Form1 mainmenu = new Form1();
            this.Hide(); //this while hide the main form.
            mainmenu.ShowDialog(); //this opens booking form "bf"
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString); //new connection
            SqlCommand com = new SqlCommand("select id,bookingDate, bookingTime from Booking where bookingDate =" +this.dateTimePicker2.Text+" and bookingTime ="+this.timeCheck.Text+");", con);
            try
            {
                SqlDataAdapter grid = new SqlDataAdapter();
                grid.SelectCommand = com;// this is the sql code i need
                DataTable griddataset = new DataTable(); //creating the datatable
                grid.Fill(griddataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = griddataset;
                dataGridView1.DataSource = bsource; //so the grid will have all data from b source 
                grid.Update(griddataset); 
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* private void GetBookings()
         {
             using (con = new SqlConnection(connectionString))
             using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT bookingDate FROM Booking", con))
             {

                 DataTable datentime = new DataTable();
                 adapter.Fill(datentime);

                 Ava.DisplayMember = "name";
                 Ava.ValueMember = "id";
                 Ava.DataSource = datentime;
             }
         }*/



    }
}



