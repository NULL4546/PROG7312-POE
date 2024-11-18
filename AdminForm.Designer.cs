namespace PROG7312Lopes
{
    partial class AdminForm
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
            adminLabel = new Label();
            reportedIssuesButton = new Button();
            eventsButton = new Button();
            SuspendLayout();
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            adminLabel.ForeColor = Color.FromArgb(45, 45, 48);
            adminLabel.Location = new Point(163, 28);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(143, 30);
            adminLabel.TabIndex = 0;
            adminLabel.Text = "Admin Panel";
            adminLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reportedIssuesButton
            // 
            reportedIssuesButton.BackColor = Color.FromArgb(28, 151, 234);
            reportedIssuesButton.FlatStyle = FlatStyle.Flat;
            reportedIssuesButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            reportedIssuesButton.ForeColor = Color.White;
            reportedIssuesButton.Location = new Point(166, 75);
            reportedIssuesButton.Margin = new Padding(3, 2, 3, 2);
            reportedIssuesButton.Name = "reportedIssuesButton";
            reportedIssuesButton.Size = new Size(140, 30);
            reportedIssuesButton.TabIndex = 1;
            reportedIssuesButton.Text = "Reported Issues";
            reportedIssuesButton.UseVisualStyleBackColor = false;
            reportedIssuesButton.Click += reportedIssuesButton_Click;
            // 
            // eventsButton
            // 
            eventsButton.BackColor = Color.FromArgb(28, 151, 234);
            eventsButton.FlatStyle = FlatStyle.Flat;
            eventsButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            eventsButton.ForeColor = Color.White;
            eventsButton.Location = new Point(166, 128);
            eventsButton.Margin = new Padding(3, 2, 3, 2);
            eventsButton.Name = "eventsButton";
            eventsButton.Size = new Size(140, 30);
            eventsButton.TabIndex = 2;
            eventsButton.Text = "Events & Announcements";
            eventsButton.UseVisualStyleBackColor = false;
            eventsButton.Click += eventsButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 210);
            Controls.Add(eventsButton);
            Controls.Add(reportedIssuesButton);
            Controls.Add(adminLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminLabel;
        private Button reportedIssuesButton;
        private Button eventsButton;
    }
}
