namespace NU_Society_Link.View
{
    partial class MainWelcomePage
    {
        // Define controls
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.ListView listViewNotifications; // Added ListView control

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
            lblGreeting = new Label();
            lblPersonalInfo = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblPosition = new Label();
            lblBatch = new Label();
            btnNotifications = new Button();
            listViewNotifications = new ListView();
            head1 = new ColumnHeader();
            header2 = new ColumnHeader();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGreeting.Location = new Point(12, 9);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(129, 21);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Welcome, User!";
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPersonalInfo.Location = new Point(12, 39);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(172, 21);
            lblPersonalInfo.TabIndex = 1;
            lblPersonalInfo.Text = "Personal Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.Location = new Point(12, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(12, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email: ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.Location = new Point(12, 129);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone: ";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPosition.Location = new Point(12, 159);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 15);
            lblPosition.TabIndex = 5;
            lblPosition.Text = "Position: ";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBatch.Location = new Point(12, 189);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(45, 15);
            lblBatch.TabIndex = 6;
            lblBatch.Text = "Batch: ";
            // 
            // btnNotifications
            // 
            btnNotifications.Location = new Point(642, 189);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(120, 30);
            btnNotifications.TabIndex = 7;
            btnNotifications.Text = "Clear Notifications";
            btnNotifications.UseVisualStyleBackColor = true;
            // 
            // listViewNotifications
            // 
            listViewNotifications.Columns.AddRange(new ColumnHeader[] { head1, header2 });
            listViewNotifications.Location = new Point(12, 225);
            listViewNotifications.Name = "listViewNotifications";
            listViewNotifications.Size = new Size(750, 222);
            listViewNotifications.TabIndex = 8;
            listViewNotifications.UseCompatibleStateImageBehavior = false;
            listViewNotifications.View = System.Windows.Forms.View.Details;
            // 
            // head1
            // 
            head1.Text = "Message";
            head1.Width = 600;
            // 
            // header2
            // 
            header2.Text = "Date";
            header2.Width = 140;
            // 
            // MainWelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 426);
            Controls.Add(lblGreeting);
            Controls.Add(lblPersonalInfo);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblPosition);
            Controls.Add(lblBatch);
            Controls.Add(btnNotifications);
            Controls.Add(listViewNotifications);
            Name = "MainWelcomePage";
            Text = "MainWelcomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ColumnHeader head1;
        public ColumnHeader header2;
    }
}