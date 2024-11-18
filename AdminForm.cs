using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312Lopes
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void reportedIssuesButton_Click(object sender, EventArgs e)
        {
            AdminIssues adminIssues = new AdminIssues();
            adminIssues.Show();
            //  this.Hide();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            AdminEvent adminEvents = new AdminEvent();
            adminEvents.Show();
        }
    }
}
