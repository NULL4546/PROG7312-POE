using System;
using System.Windows.Forms;

namespace PROG7312Lopes
{
    public partial class AdminEvent : Form
    {
        public AdminEvent()
        {
            InitializeComponent();
        }

        private void AdminEvent_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.AddRange(new string[] { "Sports", "Music", "Community", "Education" });
            dateTimePickerEvent.MinDate = DateTime.Today;
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string category = comboBoxCategory.Text;
            DateTime eventDate = dateTimePickerEvent.Value;
            string description = richTextBoxDescription.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter an event title.");
                textBoxTitle.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please select a category.");
                comboBoxCategory.Focus();
                return;
            }

            Event newEvent = new Event(title, category, eventDate, description);

            EventStorage.AddEvent(newEvent);

            MessageBox.Show("Event successfully created!");

            textBoxTitle.Clear();
            comboBoxCategory.SelectedIndex = -1;
            richTextBoxDescription.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
