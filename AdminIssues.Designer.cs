namespace PROG7312Lopes
{
    partial class AdminIssues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listView1 = new ListView();
            updateButton = new Button();
            textBoxNotes = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Reported Issues:";
            // 
            // listView1
            // 
            listView1.Location = new Point(52, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(783, 179);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(28, 151, 234);
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(30, 380);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(120, 35);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update Issue";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(524, 384);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.PlaceholderText = "Enter notes (optional)";
            textBoxNotes.Size = new Size(300, 23);
            textBoxNotes.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 384);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 388);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 388);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Notes";
            // 
            // AdminIssues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBoxNotes);
            Controls.Add(updateButton);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "AdminIssues";
            Text = "AdminIssues";
            Load += AdminIssues_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button updateButton;
        private TextBox textBoxNotes;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}