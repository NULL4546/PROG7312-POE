namespace PROG7312Lopes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reportIssuesButton_Click(object sender, EventArgs e)
        {
            ReportIssueForm reportIssueForm = new ReportIssueForm();
            reportIssueForm.ShowDialog();
        }

        private void trackServiceRequestButton_Click(object sender, EventArgs e)
        {
            TrackServiceForm trackServiceForm = new TrackServiceForm();
            trackServiceForm.ShowDialog();
        }

        private void eventsAndAnnouncementsButton_Click(object sender, EventArgs e)
        {
            EventsForm eventsForm = new EventsForm();
            eventsForm.Show();
        }
    }
}
