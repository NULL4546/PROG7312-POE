namespace PROG7312Lopes
{
    partial class AdminEvent
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
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            labelEventDate = new Label();
            dateTimePickerEvent = new DateTimePicker();
            labelDescription = new Label();
            richTextBoxDescription = new RichTextBox();
            btnCreateEvent = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(30, 35);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(82, 19);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Event Title:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(140, 31);
            textBoxTitle.Margin = new Padding(4, 3, 4, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(233, 23);
            textBoxTitle.TabIndex = 1;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(30, 80);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 19);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(140, 77);
            comboBoxCategory.Margin = new Padding(4, 3, 4, 3);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(233, 23);
            comboBoxCategory.TabIndex = 3;
            // 
            // labelEventDate
            // 
            labelEventDate.AutoSize = true;
            labelEventDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelEventDate.Location = new Point(30, 127);
            labelEventDate.Name = "labelEventDate";
            labelEventDate.Size = new Size(84, 19);
            labelEventDate.TabIndex = 4;
            labelEventDate.Text = "Event Date:";
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Location = new Point(140, 123);
            dateTimePickerEvent.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(233, 23);
            dateTimePickerEvent.TabIndex = 5;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescription.Location = new Point(30, 171);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(89, 19);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(140, 170);
            richTextBoxDescription.Margin = new Padding(4, 3, 4, 3);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(233, 110);
            richTextBoxDescription.TabIndex = 7;
            richTextBoxDescription.Text = "";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.BackColor = Color.FromArgb(28, 151, 234);
            btnCreateEvent.FlatStyle = FlatStyle.Flat;
            btnCreateEvent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEvent.ForeColor = Color.White;
            btnCreateEvent.Location = new Point(140, 300);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(112, 27);
            btnCreateEvent.TabIndex = 8;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = false;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(276, 300);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 27);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 369);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateEvent);
            Controls.Add(richTextBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(dateTimePickerEvent);
            Controls.Add(labelEventDate);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminEvent";
            Text = "Admin - Create Event";
            Load += AdminEvent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvent;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnCancel;
    }
}
