using System;
using System.Windows.Forms;

namespace PROG7312Lopes
{
    public partial class TrackServiceForm : Form
    {
        public TrackServiceForm()
        {
            InitializeComponent();
        }

        private void TrackServiceForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Location", 120);
            listView1.Columns.Add("Category", 120);
            listView1.Columns.Add("Description", 200);
            listView1.Columns.Add("Media File", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Notes", 100);

            comboBoxCategoryFilter.Items.AddRange(new[] { "All", "Roads", "Sanitation", "Utilities" });
            comboBoxCategoryFilter.SelectedIndex = 0; // Default to "All"

            LoadServiceRequests();
        }

        private void LoadServiceRequests(string category = "All")
        {
            listView1.Items.Clear();

            var requests = category == "All"
                ? DataStorage.GetAllRequests()
                : DataStorage.ServiceRequestTree.ContainsKey(category)
                    ? DataStorage.ServiceRequestTree[category]
                    : new List<UserInput>();

            foreach (var request in requests)
            {
                ListViewItem item = new ListViewItem(request.Location); // Location column
                item.SubItems.Add(request.Category);                   // Category column
                item.SubItems.Add(request.Description);                // Description column
                item.SubItems.Add(request.FilePath ?? "No Media");     // Media File column
                item.SubItems.Add(request.Status);                     // Status column
                item.SubItems.Add(request.Notes ?? "N/A");             // Notes column

                listView1.Items.Add(item);
            }
        }

        private void comboBoxCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategoryFilter.SelectedItem.ToString();

            LoadServiceRequests(selectedCategory);
        }


    }
}
