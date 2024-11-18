using System;
using System.Windows.Forms;

namespace PROG7312Lopes
{
    public partial class ReportIssueForm : Form
    {
        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private string filePath; // To store the attached media file path

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file
                    filePath = openFileDialog.FileName;

                    // Inform the user about the selected file
                    MessageBox.Show($"File selected: {filePath}");
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLocation.Text))
            {
                MessageBox.Show("Please enter a location.");
                textBoxLocation.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                richTextBoxDescription.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                MessageBox.Show("Please select an issue category.");
                comboBoxCategory.Focus();
                return;
            }

            // Create a new UserInput object
            UserInput input = new UserInput
            {
                Location = textBoxLocation.Text,
                Description = richTextBoxDescription.Text,
                Category = comboBoxCategory.Text,
                FilePath = string.IsNullOrWhiteSpace(filePath) ? "No Media Attached" : filePath, // Set default if filePath is null
                Status = "Pending",
                Notes = "N/A"
            };

            // Add the input to the centralized DataStorage
            DataStorage.AddServiceRequest(input);

            // Inform the user and close the form
            MessageBox.Show("Issue submitted successfully!");
            this.Close();
        }
    }
}
