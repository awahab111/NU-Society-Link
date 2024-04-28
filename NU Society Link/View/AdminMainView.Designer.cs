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
            EventsButton = new Button();
            BackButton = new Button();
            LogoutButton = new Button();
            logoPictureBox = new PictureBox();
            Societybtn = new Button();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(12, 116, 137);
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(Societybtn);
            leftPanel.Controls.Add(ApproveSociety);
            leftPanel.Controls.Add(EventsButton);
            leftPanel.Controls.Add(BackButton);
            leftPanel.Controls.Add(LogoutButton);
            leftPanel.Controls.Add(logoPictureBox);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(201, 561);
            leftPanel.TabIndex = 0;
            // 
            // ApproveSociety
            // 
            ApproveSociety.BackColor = Color.FromArgb(4, 59, 72);
            ApproveSociety.FlatStyle = FlatStyle.Popup;
            ApproveSociety.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            ApproveSociety.ForeColor = Color.WhiteSmoke;
            ApproveSociety.Location = new Point(10, 82);
            ApproveSociety.Name = "ApproveSociety";
            ApproveSociety.Size = new Size(177, 23);
            ApproveSociety.TabIndex = 0;
            ApproveSociety.Text = "Approve Society";
            ApproveSociety.UseVisualStyleBackColor = false;
            // 
            // EventsButton
            // 
            EventsButton.BackColor = Color.FromArgb(4, 59, 72);
            EventsButton.FlatStyle = FlatStyle.Popup;
            EventsButton.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            EventsButton.ForeColor = Color.WhiteSmoke;
            EventsButton.Location = new Point(10, 112);
            EventsButton.Name = "EventsButton";
            EventsButton.Size = new Size(177, 23);
            EventsButton.TabIndex = 1;
            EventsButton.Text = "Events";
            EventsButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(4, 59, 72);
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            BackButton.ForeColor = Color.WhiteSmoke;
            BackButton.Location = new Point(10, 526);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(177, 23);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(4, 59, 72);
            LogoutButton.FlatStyle = FlatStyle.Popup;
            LogoutButton.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            LogoutButton.ForeColor = Color.WhiteSmoke;
            LogoutButton.Location = new Point(10, 497);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(177, 23);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BorderStyle = BorderStyle.FixedSingle;
            logoPictureBox.Image = Properties.Resources.logo;
            logoPictureBox.Location = new Point(24, 8);
            logoPictureBox.Margin = new Padding(3, 2, 3, 2);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(132, 42);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 4;
            logoPictureBox.TabStop = false;
            // 
            // Societybtn
            // 
            Societybtn.BackColor = Color.FromArgb(4, 59, 72);
            Societybtn.FlatStyle = FlatStyle.Popup;
            Societybtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            Societybtn.ForeColor = Color.WhiteSmoke;
            Societybtn.Location = new Point(10, 141);
            Societybtn.Name = "Societybtn";
            Societybtn.Size = new Size(177, 23);
            Societybtn.TabIndex = 5;
            Societybtn.Text = "Societies";
            Societybtn.UseVisualStyleBackColor = false;
            Societybtn.Click += button1_Click;
            // 
            // AdminMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(leftPanel);
            IsMdiContainer = true;
            Name = "AdminMainView";
            Text = "Admin Main View";
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        private Button Societybtn;
    }
}
