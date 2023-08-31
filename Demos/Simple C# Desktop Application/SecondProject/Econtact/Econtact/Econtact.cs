using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Econtact.econtactClasses;

namespace Econtact
{
    public partial class Econtact : Form
    {
        
        private SqlConnection connection;
        public Econtact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                // Connection closed
            }
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            //Load Data on Data Gridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

            /*  
             *  This is all my own code for moving the connetion of the db to the time when the program starts running. I may or may not
             *  adjust this so that the program uses a system like I'm used to with connecting the db to code. 
            */ 
            //string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //connection = new SqlConnection(connectionString);

            //try
            //{
            //    connection.Open();
            //    // Connection opened successfully, you can perform operations here
            //}
            //catch (Exception ex)
            //{
            //    // Handle connection error
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            //Inserting Data into Database using the method we created in previous episode
            bool success = c.Insert(c);
            if (success)
            {
                //Successfully Inserted
                MessageBox.Show("New Contact Successfully Added!");
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add New Contact. Try Again.");
            }
            //Load Data on Data Gridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }
    }
}