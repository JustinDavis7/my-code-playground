using Raffler.rafflerClasses;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;

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

        
        // Method to serialize the list of winners to JSON
        public string SerializeWinners(List<string> winners)
        {
            // Serialize the list of winners to JSON
            return JsonConvert.SerializeObject(winners);
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

                if(names.Length > winnersCount)
                {
                    // Pass the names to the Raffler class.
                    List<string> winners = raffler.PickWinners(names, winnersCount);

                    string message = "Winners: \r\n";
                    foreach(string item in winners)
                    {
                        message += item + "\r\n";
                    }
                    message += "\r\nWhen you close this box, a web page will open up with the winners so you can print out the results.";
                    MessageBox.Show(message);

                    // Serialize the list of winners to JSON
                    string jsonWinners = SerializeWinners(winners);

                    // After showing the message box, open the HTML page with winners
                    string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string fullPath = Path.Combine(appDirectory, "Data", "Winners.html");
                    string partToRemove = "\\bin\\Debug\\net7.0-windows";
                    string modifiedPath = fullPath.Replace(partToRemove, "");

                    if (File.Exists(modifiedPath))
                    {
                        // Read the original HTML file content
                        string originalHtmlContent = File.ReadAllText(modifiedPath);

                        // Replace the numberOfWinners placeholder
                        string modifiedHtmlContent = originalHtmlContent.Replace("\"/* Replace with your numberOfWinners */\"", $"{winnersCount}");

                        // Replace the winnersList placeholder
                        modifiedHtmlContent = modifiedHtmlContent.Replace("\"/* Replace with your winnersList */\"", $"{jsonWinners}");

                        // Save the modified HTML content back to the file
                        File.WriteAllText(modifiedPath, modifiedHtmlContent);

                        // Open the modified HTML file in the default web browser
                        System.Diagnostics.Process.Start(new ProcessStartInfo
                        {
                            FileName = modifiedPath,
                            UseShellExecute = true
                        });

                        // After a delay (e.g., 5 seconds), restore the original HTML content
                        Task.Delay(500).ContinueWith(t =>
                        {
                            File.WriteAllText(modifiedPath, originalHtmlContent);
                        });
                    }
                    else
                    {
                        MessageBox.Show("The HTML file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (names.Length == winnersCount)
                    {
                        // User picked the same number of winners as names input which doesn't make sense
                        MessageBox.Show("You picked the same number of winners as contestants, that doesn't seem right does it?");
                    }
                    else
                    {
                        // User picked too high of a number of winners
                        MessageBox.Show("You want more winners than the number of names you put in!");
                    }
                }
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