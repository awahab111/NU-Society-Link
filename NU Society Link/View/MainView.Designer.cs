using System.Drawing;
using System.Windows.Forms;

namespace NU_Society_Link.View

{
    partial class MainView
    {
        private PictureBox logoPictureBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button AddSocietybtn;
        private System.Windows.Forms.Button Membersbtn; // Added button for Members
        private System.Windows.Forms.Button Backbtn; // Added button for Members
        private System.Windows.Forms.Button Logoutbtn; // Added button for Members
// Added button for Members
 

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
            leftPanel = new Panel();
            btnCurrentEvents = new Button();
            btnAddEvent = new Button();
            AddSocietybtn = new Button();
            Membersbtn = new Button();
            Backbtn = new Button();
            Logoutbtn = new Button();
            logoPictureBox = new PictureBox();
            AddEventSummary = new Button();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(12, 116, 137);
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(AddEventSummary);
            leftPanel.Controls.Add(btnCurrentEvents);
            leftPanel.Controls.Add(btnAddEvent);
            leftPanel.Controls.Add(AddSocietybtn);
            leftPanel.Controls.Add(Membersbtn);
            leftPanel.Controls.Add(Backbtn);
            leftPanel.Controls.Add(Logoutbtn);
            leftPanel.Controls.Add(logoPictureBox);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(201, 561);
            leftPanel.TabIndex = 0;
            // 
            // btnCurrentEvents
            // 
            btnCurrentEvents.BackColor = Color.FromArgb(4, 59, 72);
            btnCurrentEvents.Cursor = Cursors.Hand;
            btnCurrentEvents.FlatStyle = FlatStyle.Popup;
            btnCurrentEvents.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCurrentEvents.ForeColor = Color.WhiteSmoke;
            btnCurrentEvents.Location = new Point(10, 252);
            btnCurrentEvents.Name = "btnCurrentEvents";
            btnCurrentEvents.Size = new Size(177, 23);
            btnCurrentEvents.TabIndex = 6;
            btnCurrentEvents.Text = "Current Events";
            btnCurrentEvents.UseVisualStyleBackColor = false;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BackColor = Color.FromArgb(4, 59, 72);
            btnAddEvent.Cursor = Cursors.Hand;
            btnAddEvent.FlatStyle = FlatStyle.Popup;
            btnAddEvent.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEvent.ForeColor = Color.WhiteSmoke;
            btnAddEvent.Location = new Point(10, 193);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(177, 23);
            btnAddEvent.TabIndex = 5;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = false;
            btnAddEvent.Click += button1_Click;
            // 
            // AddSocietybtn
            // 
            AddSocietybtn.BackColor = Color.FromArgb(4, 59, 72);
            AddSocietybtn.Cursor = Cursors.Hand;
            AddSocietybtn.FlatStyle = FlatStyle.Popup;
            AddSocietybtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddSocietybtn.ForeColor = Color.WhiteSmoke;
            AddSocietybtn.Location = new Point(10, 82);
            AddSocietybtn.Name = "AddSocietybtn";
            AddSocietybtn.Size = new Size(177, 23);
            AddSocietybtn.TabIndex = 0;
            AddSocietybtn.Text = "Add Society";
            AddSocietybtn.UseVisualStyleBackColor = false;
            AddSocietybtn.Click += AddSocietybtn_Click;
            // 
            // Membersbtn
            // 
            Membersbtn.BackColor = Color.FromArgb(4, 59, 72);
            Membersbtn.Cursor = Cursors.Hand;
            Membersbtn.FlatStyle = FlatStyle.Popup;
            Membersbtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Membersbtn.ForeColor = Color.WhiteSmoke;
            Membersbtn.Location = new Point(10, 138);
            Membersbtn.Name = "Membersbtn";
            Membersbtn.Size = new Size(177, 23);
            Membersbtn.TabIndex = 1;
            Membersbtn.Text = "Members";
            Membersbtn.UseVisualStyleBackColor = false;
            Membersbtn.Click += Membersbtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(4, 59, 72);
            Backbtn.FlatStyle = FlatStyle.Popup;
            Backbtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            Backbtn.ForeColor = Color.WhiteSmoke;
            Backbtn.Location = new Point(10, 526);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(177, 23);
            Backbtn.TabIndex = 2;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.FromArgb(4, 59, 72);
            Logoutbtn.FlatStyle = FlatStyle.Popup;
            Logoutbtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            Logoutbtn.ForeColor = Color.WhiteSmoke;
            Logoutbtn.Location = new Point(10, 497);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(177, 23);
            Logoutbtn.TabIndex = 3;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
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
            // AddEventSummary
            // 
            AddEventSummary.BackColor = Color.FromArgb(4, 59, 72);
            AddEventSummary.Cursor = Cursors.Hand;
            AddEventSummary.FlatStyle = FlatStyle.Popup;
            AddEventSummary.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddEventSummary.ForeColor = Color.WhiteSmoke;
            AddEventSummary.Location = new Point(10, 310);
            AddEventSummary.Name = "AddEventSummary";
            AddEventSummary.Size = new Size(177, 23);
            AddEventSummary.TabIndex = 7;
            AddEventSummary.Text = "Add Event Summary";
            AddEventSummary.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(leftPanel);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddEvent;
        private Button btnCurrentEvents;
        private Button AddEventSummary;
    }
}