using Raffler.rafflerClasses;
namespace Raffler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the minimum size of the form.
            this.MinimumSize = new Size(1000, 800);

            // Set the initial width of txtBoxNames to be 45% of the form's width.
            txtBoxNames.Width = this.ClientSize.Width * 45 / 100;

            // Set the maximum width of txtBoxNames.
            txtBoxNames.MaximumSize = new Size(1000, txtBoxNames.Height);

            // Assume textBox1 is an existing control on your form.
            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Update the width of txtBoxNames to be 45% of the form's width, but not more than 500 pixels.
            txtBoxNames.Width = Math.Min(this.ClientSize.Width * 45 / 100, txtBoxNames.MaximumSize.Width);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Assume Raffler is your class and it has a method called SetNames that takes a string array.
            rafflerClass raffler = new rafflerClass();

            // Split the text from the TextBox into an array of strings.
            string[] names = txtBoxNames.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            // Checking to make sure there are actually names to work on
            if(names.Length != 0)
            {
                // Grab the number of names to select from the list
                int winnersCount = (int) numUpDownPicker.Value;

                // Pass the names to the Raffler class.
                string[] winners = raffler.PickWinners(names, winnersCount);
            }
            else
            {
                // User didn't input any names into the box
                MessageBox.Show("You need to enter names before a winner can be picked!");
            }  
        }

        private void txtBoxNames_Resize(object sender, EventArgs e)
        {
            // Update the location of numUpDown and lblNames to be to the right of txtBoxNames.
            numUpDownPicker.Left = txtBoxNames.Right + 10;
            lblNumberPicker.Left = txtBoxNames.Right + 10;
        }
    }
}