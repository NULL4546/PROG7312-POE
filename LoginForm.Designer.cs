namespace PROG7312Lopes
{
    partial class LoginForm
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
            this.userButton = new Button();
            this.adminButton = new Button();
            this.label1 = new Label();
            this.SuspendLayout();

            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.FromArgb(28, 150, 215); // Blue shade
            this.userButton.FlatStyle = FlatStyle.Flat;
            this.userButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Location = new Point(325, 175);
            this.userButton.Name = "userButton";
            this.userButton.Size = new Size(150, 40);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "User Login";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += userButton_Click;

            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(28, 150, 215); // Blue shade
            this.adminButton.FlatStyle = FlatStyle.Flat;
            this.adminButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.Location = new Point(325, 240);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new Size(150, 40);
            this.adminButton.TabIndex = 1;
            this.adminButton.Text = "Admin Login";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += adminButton_Click;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64); // Dark gray
            this.label1.Location = new Point(240, 100);
            this.label1.Name = "label1";
            this.label1.Size = new Size(320, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select your login type to continue";

            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke; // Light gray background
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.userButton);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button userButton;
        private Button adminButton;
        private Label label1;
    }
}
