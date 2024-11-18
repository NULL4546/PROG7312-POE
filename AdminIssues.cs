using System;
using System.Linq;
using System.Windows.Forms;

namespace PROG7312Lopes
{
    public partial class AdminIssues : Form
    {
        public AdminIssues()
        {
            InitializeComponent();
        }

        private void AdminIssues_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 50);          // ID column
            listView1.Columns.Add("Location", 120);
            listView1.Columns.Add("Category", 120);
            listView1.Columns.Add("Description", 200);
            listView1.Columns.Add("Media File", 80);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Notes", 100);

            LoadIssuesIntoListView();
        }

        private void LoadIssuesIntoListView()
        {
            listView1.Items.Clear();

            foreach (var input in DataStorage.GetAllRequests())
            {
                ListViewItem item = new ListViewItem(input.ID.ToString());
                item.SubItems.Add(input.Location);
                item.SubItems.Add(input.Category);
                item.SubItems.Add(input.Description);
                item.SubItems.Add(input.FilePath ?? "None");
                item.SubItems.Add(input.Status);
                item.SubItems.Add(input.Notes);

                listView1.Items.Add(item);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                int id = int.Parse(selectedItem.SubItems[0].Text); // Get the ID
                string status = textBox2.Text;
                string notes = textBoxNotes.Text;

                // Update the data in DataStorage
                DataStorage.UpdateServiceRequest(id, status, notes);

                // Reflect changes in the ListView
                selectedItem.SubItems[5].Text = status;
                selectedItem.SubItems[6].Text = notes;
            }
        }

    }
}
