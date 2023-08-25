using System.Data;
using System.Data.SqlClient;

namespace Econtact
{
    public partial class Econtact : Form
    {
        private SqlConnection connection;
        public Econtact()
        {
            InitializeComponent();
        }

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
            string connectionString = "Data Source=(localdb)\\\\MSSQLLocalDB;Initial Catalog=Econtact;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(connectionString);
            {
                try
                {
                    connection.Open();
                    // Connection opened successfully, you can perform operations here
                }
                catch (Exception ex)
                {
                    // Handle connection error
                }
            }
        }
    }
}