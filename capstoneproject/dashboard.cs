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
using System.IO;

namespace capstoneproject
{
    public partial class dashboard : Form
    {
        public string username { get; set; }

        private const string ConnectionString = "Data Source=reyn\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True";
        public dashboard()
        {
            InitializeComponent();

            
        }
        private void LoadTodayData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Create a SQL query to fetch today's data
                string query = "SELECT Name, Department, Purpose, QueueNumber,QueueCode, QueueDate FROM stu_data WHERE CONVERT(date, QueueDate) = @QueueDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@QueueDate", DateTime.Today);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable todayData = new DataTable();
                        adapter.Fill(todayData);

                        // Bind the DataGridView to the filtered data
                        dataGridView1.DataSource = todayData;
                    }
                }
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            Users form3 = new Users();
            form3.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblusername.Text = "Welcome, " + username;
           
        
            lbldate.Text = DateTime.Now.ToLongDateString();
            LoadTodayData();
            timer1.Start();

        }

        private void dashboard_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginformDataSet7.stu_data' table. You can move, or remove it, as needed.
            this.stu_dataTableAdapter.Fill(this.loginformDataSet7.stu_data);



            LoadTodayData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            if (clickedButton != null)
            {
                lblshow.Text = "" + clickedButton.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            if (clickedButton != null)
            {
                lblshow.Text = " " + clickedButton.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            if (clickedButton != null)
            {
                lblshow.Text = " " + clickedButton.Text;
            }
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            Users form3 = new Users();
            form3.Show();
            this.Hide();

            if (clickedButton != null)
            {
                lblshow.Text = "" + clickedButton.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadTodayData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }
    }

}