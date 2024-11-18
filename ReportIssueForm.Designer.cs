namespace PROG7312Lopes
{
    partial class ReportIssueForm
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
            labelLocation = new Label();
            textBoxLocation = new TextBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            labelDescription = new Label();
            richTextBoxDescription = new RichTextBox();
            labelAttachMedia = new Label();
            buttonAttachMedia = new Button();
            buttonSubmit = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelLocation.ForeColor = Color.FromArgb(45, 45, 48);
            labelLocation.Location = new Point(20, 20);
            labelLocation.Margin = new Padding(5, 0, 5, 0);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(67, 19);
            labelLocation.TabIndex = 0;
            labelLocation.Text = "Location:";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLocation.Location = new Point(20, 45);
            textBoxLocation.Margin = new Padding(5, 4, 5, 4);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(340, 25);
            textBoxLocation.TabIndex = 1;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategory.ForeColor = Color.FromArgb(45, 45, 48);
            labelCategory.Location = new Point(20, 85);
            labelCategory.Margin = new Padding(5, 0, 5, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(67, 19);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities" });
            comboBoxCategory.Location = new Point(20, 110);
            comboBoxCategory.Margin = new Padding(5, 4, 5, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(340, 25);
            comboBoxCategory.TabIndex = 3;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.ForeColor = Color.FromArgb(45, 45, 48);
            labelDescription.Location = new Point(20, 150);
            labelDescription.Margin = new Padding(5, 0, 5, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(79, 19);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDescription.Location = new Point(20, 175);
            richTextBoxDescription.Margin = new Padding(5, 4, 5, 4);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(340, 120);
            richTextBoxDescription.TabIndex = 5;
            richTextBoxDescription.Text = "";
            // 
            // labelAttachMedia
            // 
            labelAttachMedia.AutoSize = true;
            labelAttachMedia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAttachMedia.ForeColor = Color.FromArgb(45, 45, 48);
            labelAttachMedia.Location = new Point(20, 310);
            labelAttachMedia.Margin = new Padding(5, 0, 5, 0);
            labelAttachMedia.Name = "labelAttachMedia";
            labelAttachMedia.Size = new Size(92, 19);
            labelAttachMedia.TabIndex = 6;
            labelAttachMedia.Text = "Attach Media:";
            // 
            // buttonAttachMedia
            // 
            buttonAttachMedia.BackColor = Color.FromArgb(28, 151, 234);
            buttonAttachMedia.FlatStyle = FlatStyle.Flat;
            buttonAttachMedia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAttachMedia.ForeColor = Color.White;
            buttonAttachMedia.Location = new Point(20, 335);
            buttonAttachMedia.Margin = new Padding(5, 4, 5, 4);
            buttonAttachMedia.Name = "buttonAttachMedia";
            buttonAttachMedia.Size = new Size(120, 35);
            buttonAttachMedia.TabIndex = 7;
            buttonAttachMedia.Text = "Choose File";
            buttonAttachMedia.UseVisualStyleBackColor = false;
            buttonAttachMedia.Click += buttonAttachMedia_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(28, 151, 234);
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(20, 400);
            buttonSubmit.Margin = new Padding(5, 4, 5, 4);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(120, 35);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gray;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(240, 400);
            buttonBack.Margin = new Padding(5, 4, 5, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 35);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // ReportIssueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(buttonAttachMedia);
            Controls.Add(labelAttachMedia);
            Controls.Add(richTextBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(textBoxLocation);
            Controls.Add(labelLocation);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ReportIssueForm";
            Text = "Report an Issue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLocation;
        private TextBox textBoxLocation;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Label labelDescription;
        private RichTextBox richTextBoxDescription;
        private Label labelAttachMedia;
        private Button buttonAttachMedia;
        private Button buttonSubmit;
        private Button buttonBack;
    }
}
