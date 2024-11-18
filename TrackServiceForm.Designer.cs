namespace PROG7312Lopes
{
    partial class TrackServiceForm
    {
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
            comboBoxCategoryFilter = new ComboBox();
            labelCategoryFilter = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 45, 48);
            label1.Location = new Point(52, 26);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 1;
            label1.Text = "Reported Issues:";
            // 
            // listView1
            // 
            listView1.Location = new Point(52, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(793, 233);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // comboBoxCategoryFilter
            // 
            comboBoxCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoryFilter.Location = new Point(725, 28);
            comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            comboBoxCategoryFilter.Size = new Size(120, 23);
            comboBoxCategoryFilter.TabIndex = 2;
            comboBoxCategoryFilter.SelectedIndexChanged += comboBoxCategoryFilter_SelectedIndexChanged;
            // 
            // labelCategoryFilter
            // 
            labelCategoryFilter.AutoSize = true;
            labelCategoryFilter.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoryFilter.ForeColor = Color.FromArgb(45, 45, 48);
            labelCategoryFilter.Location = new Point(578, 26);
            labelCategoryFilter.Name = "labelCategoryFilter";
            labelCategoryFilter.Size = new Size(100, 25);
            labelCategoryFilter.TabIndex = 1;
            labelCategoryFilter.Text = "Category Filter:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            // 
            // TrackServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 384);
            Controls.Add(labelCategoryFilter);
            Controls.Add(comboBoxCategoryFilter);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TrackServiceForm";
            Text = "Track Service Requests";
            Load += TrackServiceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ComboBox comboBoxCategoryFilter; // New ComboBox for category filtering
        private Label labelCategoryFilter; // New Label for the ComboBox filter
        private Button updateButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}
