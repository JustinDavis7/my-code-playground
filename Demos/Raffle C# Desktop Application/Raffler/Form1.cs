using Raffler.rafflerClasses;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        public string SerializeContestants(int contestants)
        {
            return JsonConvert.SerializeObject(contestants);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Assume Raffler is your class and it has a method called SetNames that takes a string array.
            rafflerClass raffler = new rafflerClass();

            // Split the text from the TextBox into an array of strings.
            string[] names = txtBoxNames.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            // Use LINQ to filter out empty strings from the name list
            List<string> nonEmptyStrings = names
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            // Convert the filtered list back to an array if needed
            names = nonEmptyStrings.ToArray();

            int contestants = names.Length;

            // Checking to make sure there are actually names to work on
            if(names.Length != 0)
            {
                // Grab the number of names to select from the list
                int winnersCount = (int) numUpDownPicker.Value;

                if(names.Length > winnersCount)
                {
                    // Pass the names to the Raffler class.
                    List<string> winners = raffler.PickWinners(names, winnersCount);

                    // Serialize the list of winners to JSON
                    string jsonWinners = SerializeWinners(winners);

                    // Serialize the number of contestants to JSON
                    string jsonContestants = SerializeContestants(contestants);

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

                        // Replace the contestantsCount placeholer
                        modifiedHtmlContent = modifiedHtmlContent.Replace("\"/* Replace with your contestantCount */\"", $"{jsonContestants}");

                        // Save the modified HTML content back to the file
                        File.WriteAllText(modifiedPath, modifiedHtmlContent);

                        // Open the modified HTML file in the default web browser
                        System.Diagnostics.Process.Start(new ProcessStartInfo
                        {
                            FileName = modifiedPath,
                            UseShellExecute = true
                        });

                        /* After a delay (e.g., 5 seconds), restore the original HTML content
                         * This is creating a temp form that shows up to cause a needed delay between runs.
                         * If this isn't here, then it's possible to hit the run button too fast, and then the
                         * html file doesn't get reset and the whole program breaks. There's better ways of handling
                         * this - create a master copy and then reset using that - but I wanted something simple.
                         */
                        var w = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(.5))
                            .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

                        MessageBox.Show(w, "Loading...");
                        File.WriteAllText(modifiedPath, originalHtmlContent);
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