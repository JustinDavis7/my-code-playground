namespace Raffler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the initial width of txtBoxNames to be 50% of the form's width.
            txtBoxNames.Width = this.ClientSize.Width / 2;

            // Assume textBox1 is an existing control on your form.
            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Set the width of the text box to be 50% of the width of the form.
            txtBoxNames.Width = this.ClientSize.Width / 2;
        }
    }
}