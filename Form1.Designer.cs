namespace PROG7312Lopes
{
    partial class Form1
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
            label1 = new Label();
            reportIssuesButton = new Button();
            trackServiceRequestButton = new Button();
            eventsAndAnnouncementsButton = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 45, 48);
            label1.Location = new Point(30, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome! Please select an option below:";
            // 
            // reportIssuesButton
            // 
            reportIssuesButton.BackColor = Color.FromArgb(28, 151, 234);
            reportIssuesButton.FlatStyle = FlatStyle.Flat;
            reportIssuesButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            reportIssuesButton.ForeColor = Color.White;
            reportIssuesButton.Location = new Point(30, 60);
            reportIssuesButton.Margin = new Padding(4, 3, 4, 3);
            reportIssuesButton.Name = "reportIssuesButton";
            reportIssuesButton.Size = new Size(200, 40);
            reportIssuesButton.TabIndex = 1;
            reportIssuesButton.Text = "Report Issues";
            reportIssuesButton.UseVisualStyleBackColor = false;
            reportIssuesButton.Click += reportIssuesButton_Click;
            // 
            // trackServiceRequestButton
            // 
            trackServiceRequestButton.BackColor = Color.FromArgb(28, 151, 234);
            trackServiceRequestButton.FlatStyle = FlatStyle.Flat;
            trackServiceRequestButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            trackServiceRequestButton.ForeColor = Color.White;
            trackServiceRequestButton.Location = new Point(30, 115);
            trackServiceRequestButton.Margin = new Padding(4, 3, 4, 3);
            trackServiceRequestButton.Name = "trackServiceRequestButton";
            trackServiceRequestButton.Size = new Size(200, 40);
            trackServiceRequestButton.TabIndex = 2;
            trackServiceRequestButton.Text = "Track Service Request";
            trackServiceRequestButton.UseVisualStyleBackColor = false;
            trackServiceRequestButton.Click += trackServiceRequestButton_Click;
            // 
            // eventsAndAnnouncementsButton
            // 
            eventsAndAnnouncementsButton.BackColor = Color.FromArgb(28, 151, 234);
            eventsAndAnnouncementsButton.FlatStyle = FlatStyle.Flat;
            eventsAndAnnouncementsButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            eventsAndAnnouncementsButton.ForeColor = Color.White;
            eventsAndAnnouncementsButton.Location = new Point(30, 170);
            eventsAndAnnouncementsButton.Margin = new Padding(4, 3, 4, 3);
            eventsAndAnnouncementsButton.Name = "eventsAndAnnouncementsButton";
            eventsAndAnnouncementsButton.Size = new Size(200, 40);
            eventsAndAnnouncementsButton.TabIndex = 3;
            eventsAndAnnouncementsButton.Text = "Events & Announcements";
            eventsAndAnnouncementsButton.UseVisualStyleBackColor = false;
            eventsAndAnnouncementsButton.Click += eventsAndAnnouncementsButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(45, 45, 48);
            groupBox1.Location = new Point(260, 60);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(250, 150);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Latest Announcements:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 250);
            Controls.Add(groupBox1);
            Controls.Add(eventsAndAnnouncementsButton);
            Controls.Add(trackServiceRequestButton);
            Controls.Add(reportIssuesButton);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "PROG7312 Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button reportIssuesButton;
        private Button trackServiceRequestButton;
        private Button eventsAndAnnouncementsButton;
        private GroupBox groupBox1;
    }
}
