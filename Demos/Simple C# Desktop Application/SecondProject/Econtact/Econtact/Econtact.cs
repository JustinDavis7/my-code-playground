using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Econtact.econtactClasses;

namespace Econtact
{
    public partial class Econtact : Form
    {
        
        private SqlConnection connection;
        static string myconnstr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        contactClass c = new contactClass();
        public Econtact()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxFirstName.Text != "" && txtboxLastName.Text != "" && txtboxContactNumber.Text != "" && txtboxAddress.Text != "" && txtboxAddress.Text != "")
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
                    //Call the Clear Method Here
                    Clear();
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
            else
            {
                MessageBox.Show("One or more data fields are empty! Please check to make sure you filled out every box except for Contact ID.");
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
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            /*  
             *  This is all my own code for moving the connetion of the db to the time when the program starts running. I may or may not
             *  adjust this so that the program uses a system like I'm used to with connecting the db to code. 
            */
            //if (connection != null && connection.State == ConnectionState.Open)
            //{
            //    connection.Close();
            //    // Connection closed
            //}
        }

        //Method to Clear Fields
        public void Clear()
        {
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxContactNumber.Text = "";
            txtboxAddress.Text = "";
            cmbGender.Text = "";
            txtboxContactID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the Data from textboxes
            if (txtboxContactID.Text != "")
            {
                c.ContactID = int.Parse(txtboxContactID.Text);
                c.FirstName = txtboxFirstName.Text;
                c.LastName = txtboxLastName.Text;
                c.ContactNo = txtboxContactNumber.Text;
                c.Address = txtboxAddress.Text;
                c.Gender = cmbGender.Text;
                //Update Data in Database
                bool success = c.Update(c);
                if (success)
                {
                    //Updated Successfully
                    MessageBox.Show("Contact Updated Successfully!");
                    //Load Data on Data Gridview
                    DataTable dt = c.Select();
                    dgvContactList.DataSource = dt;
                    //Call the Clear Method Here
                    Clear();
                }
                else
                {
                    //Failed to Update Contact
                    MessageBox.Show("Failed to Update Contact. Try Again.");
                }
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data From Data Grid View and Load it to the textboxes respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtboxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call the Clear Method Here
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtboxContactID.Text != "")
            {
                //Get Data from the Textboxes
                c.ContactID = Convert.ToInt32(txtboxContactID.Text);
                bool success = c.Delete(c);
                if (success)
                {
                    //Delete Successfully
                    MessageBox.Show("Contact Deleted Successfully!");
                    //Load Data on Data Gridview
                    DataTable dt = c.Select();
                    dgvContactList.DataSource = dt;
                    //Call the Clear Method Here
                    Clear();
                }
                else
                {
                    //Failed to Update Contact
                    MessageBox.Show("Failed to Delete Contact. Try Again.");
                }
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the balue from text box
            string keyword = txtBoxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%"+keyword+"%' OR LastName LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }
    }
}