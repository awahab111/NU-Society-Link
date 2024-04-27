using System;
using System.Drawing;
using System.Windows.Forms;

namespace NU_Society_Link.View
{
    partial class AdminMainView
    {
        private Panel leftPanel;
        private Button ApproveSociety;
        private Button EventsButton; // Added button for Events
        private Button BackButton;
        private Button LogoutButton;
        private PictureBox logoPictureBox;

        private void InitializeComponent()
        {
            leftPanel = new Panel();
            ApproveSociety = new Button();
            EventsButton = new Button(); // Added button for Events
            BackButton = new Button();
            LogoutButton = new Button();
            logoPictureBox = new PictureBox();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();

            // leftPanel
            leftPanel.BackColor = Color.FromArgb(12, 116, 137);
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(ApproveSociety);
            leftPanel.Controls.Add(EventsButton); // Added button for Events
            leftPanel.Controls.Add(BackButton);
            leftPanel.Controls.Add(LogoutButton);
            leftPanel.Controls.Add(logoPictureBox);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(3, 4, 3, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(229, 748);
            leftPanel.TabIndex = 0;

            // ApproveSociety button
            ApproveSociety.BackColor = Color.FromArgb(4, 59, 72);
            ApproveSociety.FlatStyle = FlatStyle.Popup;
            ApproveSociety.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            ApproveSociety.ForeColor = Color.WhiteSmoke;
            ApproveSociety.Location = new Point(12, 110);
            ApproveSociety.Margin = new Padding(3, 4, 3, 4);
            ApproveSociety.Name = "ApproveSociety";
            ApproveSociety.Size = new Size(202, 31);
            ApproveSociety.TabIndex = 0;
            ApproveSociety.Text = "Approve Society";
            ApproveSociety.UseVisualStyleBackColor = false;

            // EventsButton
            EventsButton.BackColor = Color.FromArgb(4, 59, 72);
            EventsButton.FlatStyle = FlatStyle.Popup;
            EventsButton.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            EventsButton.ForeColor = Color.WhiteSmoke;
            EventsButton.Location = new Point(12, 150); // Adjusted position below ApproveSociety button
            EventsButton.Margin = new Padding(3, 4, 3, 4);
            EventsButton.Name = "EventsButton";
            EventsButton.Size = new Size(202, 31);
            EventsButton.TabIndex = 1;
            EventsButton.Text = "Events";
            EventsButton.UseVisualStyleBackColor = false;

            // BackButton
            BackButton.BackColor = Color.FromArgb(4, 59, 72);
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            BackButton.ForeColor = Color.WhiteSmoke;
            BackButton.Location = new Point(12, 701);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(202, 31);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;

            // LogoutButton
            LogoutButton.BackColor = Color.FromArgb(4, 59, 72);
            LogoutButton.FlatStyle = FlatStyle.Popup;
            LogoutButton.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            LogoutButton.ForeColor = Color.WhiteSmoke;
            LogoutButton.Location = new Point(12, 663);
            LogoutButton.Margin = new Padding(3, 4, 3, 4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(202, 31);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;

            // logoPictureBox
            logoPictureBox.BorderStyle = BorderStyle.FixedSingle;
            logoPictureBox.Image = Properties.Resources.logo;
            logoPictureBox.Location = new Point(28, 11);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(150, 55);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 4;
            logoPictureBox.TabStop = false;

            // AdminMainView
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 748);
            Controls.Add(leftPanel);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminMainView";
            Text = "Admin Main View";
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }
    }
}
