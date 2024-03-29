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
            AddSocietybtn = new Button();
            Membersbtn = new Button();
            Backbtn = new Button();
            Logoutbtn = new Button();
            logoPictureBox = new PictureBox();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(12, 116, 137);
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(AddSocietybtn);
            leftPanel.Controls.Add(Membersbtn);
            leftPanel.Controls.Add(Backbtn);
            leftPanel.Controls.Add(Logoutbtn);
            leftPanel.Controls.Add(logoPictureBox);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(3, 4, 3, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(229, 748);
            leftPanel.TabIndex = 0;
            // 
            // AddSocietybtn
            // 
            AddSocietybtn.BackColor = Color.FromArgb(4, 59, 72);
            AddSocietybtn.Cursor = Cursors.Hand;
            AddSocietybtn.FlatStyle = FlatStyle.Popup;
            AddSocietybtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddSocietybtn.ForeColor = Color.WhiteSmoke;
            AddSocietybtn.Location = new Point(12, 110);
            AddSocietybtn.Margin = new Padding(3, 4, 3, 4);
            AddSocietybtn.Name = "AddSocietybtn";
            AddSocietybtn.Size = new Size(202, 31);
            AddSocietybtn.TabIndex = 0;
            AddSocietybtn.Text = "Add Society";
            AddSocietybtn.UseVisualStyleBackColor = false;
            // 
            // Membersbtn
            // 
            Membersbtn.BackColor = Color.FromArgb(4, 59, 72);
            Membersbtn.Cursor = Cursors.Hand;
            Membersbtn.FlatStyle = FlatStyle.Popup;
            Membersbtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Membersbtn.ForeColor = Color.WhiteSmoke;
            Membersbtn.Location = new Point(12, 184);
            Membersbtn.Margin = new Padding(3, 4, 3, 4);
            Membersbtn.Name = "Membersbtn";
            Membersbtn.Size = new Size(202, 31);
            Membersbtn.TabIndex = 1;
            Membersbtn.Text = "Members";
            Membersbtn.UseVisualStyleBackColor = false;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(4, 59, 72);
            Backbtn.FlatStyle = FlatStyle.Popup;
            Backbtn.Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold);
            Backbtn.ForeColor = Color.WhiteSmoke;
            Backbtn.Location = new Point(12, 701);
            Backbtn.Margin = new Padding(3, 4, 3, 4);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(202, 31);
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
            Logoutbtn.Location = new Point(12, 663);
            Logoutbtn.Margin = new Padding(3, 4, 3, 4);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(202, 31);
            Logoutbtn.TabIndex = 3;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BorderStyle = BorderStyle.FixedSingle;
            logoPictureBox.Image = Properties.Resources.logo;
            logoPictureBox.Location = new Point(28, 11);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(150, 55);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 4;
            logoPictureBox.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 748);
            Controls.Add(leftPanel);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainView";
            Text = "MainView";
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}