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

        private void addbtn_Click(object sender, EventArgs e)
        {
            Users form3 = new Users();
            form3.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblusername.Text = "Welcome, " + username;
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void dashboard_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginformDataSet.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.loginformDataSet.tbl_login);

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
    }

}