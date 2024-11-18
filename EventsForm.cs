using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROG7312Lopes
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            LoadEventsIntoListView();
        }

        private void LoadEventsIntoListView()
        {
            listViewEvents.Items.Clear();
            List<Event> events = EventStorage.GetAllEvents();

            foreach (var evnt in events)
            {
                ListViewItem item = new ListViewItem(evnt.Title);
                item.SubItems.Add(evnt.Category);
                item.SubItems.Add(evnt.EventDate.ToShortDateString());
                item.SubItems.Add(evnt.Description);
                listViewEvents.Items.Add(item);
            }
        }
    }
}
