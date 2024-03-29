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
            lblGreeting.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(389, 9);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(182, 34);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Welcome, User!";
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            lblPersonalInfo.Location = new Point(16, 57);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(156, 22);
            lblPersonalInfo.TabIndex = 1;
            lblPersonalInfo.Text = "Personal Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(16, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 22);
            lblName.TabIndex = 2;
            lblName.Text = "Name: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            lblEmail.Location = new Point(16, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 22);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email: ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            lblPhone.Location = new Point(16, 189);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 22);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone: ";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F);
            lblPosition.Location = new Point(16, 233);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(73, 22);
            lblPosition.TabIndex = 5;
            lblPosition.Text = "Position: ";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F);
            lblBatch.Location = new Point(16, 277);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(58, 22);
            lblBatch.TabIndex = 6;
            lblBatch.Text = "Batch: ";
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.FromArgb(4, 59, 72);
            btnNotifications.Cursor = Cursors.Hand;
            btnNotifications.FlatStyle = FlatStyle.Popup;
            btnNotifications.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            btnNotifications.Location = new Point(826, 277);
            btnNotifications.Margin = new Padding(3, 4, 3, 4);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(154, 44);
            btnNotifications.TabIndex = 7;
            btnNotifications.Text = "Clear Notifications";
            btnNotifications.UseVisualStyleBackColor = false;
            // 
            // listViewNotifications
            // 
            listViewNotifications.BackColor = Color.FromArgb(7, 72, 85);
            listViewNotifications.Columns.AddRange(new ColumnHeader[] { head1, header2 });
            listViewNotifications.ForeColor = Color.WhiteSmoke;
            listViewNotifications.Location = new Point(16, 330);
            listViewNotifications.Margin = new Padding(3, 4, 3, 4);
            listViewNotifications.Name = "listViewNotifications";
            listViewNotifications.Size = new Size(964, 324);
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
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(996, 625);
            Controls.Add(lblGreeting);
            Controls.Add(lblPersonalInfo);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblPosition);
            Controls.Add(lblBatch);
            Controls.Add(btnNotifications);
            Controls.Add(listViewNotifications);
            Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(3, 4, 3, 4);
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