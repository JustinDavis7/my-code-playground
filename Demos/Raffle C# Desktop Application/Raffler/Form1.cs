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

            // Pass the names to the Raffler class.
            raffler.PickWinners(names);
        }
    }
}