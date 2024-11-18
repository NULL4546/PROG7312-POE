namespace PROG7312Lopes
{
    partial class EventsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listViewEvents = new ListView();
            columnHeaderTitle = new ColumnHeader();
            columnHeaderCategory = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderDescription = new ColumnHeader();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // listViewEvents
            // 
            listViewEvents.Columns.AddRange(new ColumnHeader[] { columnHeaderTitle, columnHeaderCategory, columnHeaderDate, columnHeaderDescription });
            listViewEvents.FullRowSelect = true;
            listViewEvents.GridLines = true;
            listViewEvents.Location = new Point(20, 80);
            listViewEvents.Margin = new Padding(4, 3, 4, 3);
            listViewEvents.Name = "listViewEvents";
            listViewEvents.Size = new Size(880, 400);
            listViewEvents.TabIndex = 0;
            listViewEvents.UseCompatibleStateImageBehavior = false;
            listViewEvents.View = View.Details;
            listViewEvents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // columnHeaderTitle
            // 
            columnHeaderTitle.Text = "Title";
            columnHeaderTitle.Width = 200;
            // 
            // columnHeaderCategory
            // 
            columnHeaderCategory.Text = "Category";
            columnHeaderCategory.Width = 150;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date";
            columnHeaderDate.Width = 120;
            // 
            // columnHeaderDescription
            // 
            columnHeaderDescription.Text = "Description";
            columnHeaderDescription.Width = 400;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(45, 45, 48);
            labelTitle.Location = new Point(20, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(270, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Events and Announcements";
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 519);
            Controls.Add(labelTitle);
            Controls.Add(listViewEvents);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EventsForm";
            Text = "Local Events and Announcements";
            Load += EventsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewEvents;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderCategory;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderDescription;
        private Label labelTitle;
    }
}
