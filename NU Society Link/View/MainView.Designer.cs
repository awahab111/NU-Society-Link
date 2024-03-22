namespace NU_Society_Link.View
{
    partial class MainView
    {
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button AddSocietybtn;
        private System.Windows.Forms.Button Membersbtn; // Added button for Members
        private System.Windows.Forms.Button Backbtn; // Added button for Back
        private System.Windows.Forms.Button Logoutbtn; // Added button for Logout

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
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.LightGray;
            leftPanel.Controls.Add(AddSocietybtn);
            leftPanel.Controls.Add(Membersbtn);
            leftPanel.Controls.Add(Backbtn);
            leftPanel.Controls.Add(Logoutbtn);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 561);
            leftPanel.TabIndex = 0;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // AddSocietybtn
            // 
            AddSocietybtn.Location = new Point(0, 52);
            AddSocietybtn.Name = "AddSocietybtn";
            AddSocietybtn.Size = new Size(197, 23);
            AddSocietybtn.TabIndex = 0;
            AddSocietybtn.Text = "Add Society";
            // 
            // Membersbtn
            // 
            Membersbtn.Location = new Point(0, 112);
            Membersbtn.Name = "Membersbtn";
            Membersbtn.Size = new Size(197, 23);
            Membersbtn.TabIndex = 1;
            Membersbtn.Text = "Members";
            // 
            // Backbtn
            // 
            Backbtn.Location = new Point(0, 526);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(197, 23);
            Backbtn.TabIndex = 2;
            Backbtn.Text = "Back";
            // 
            // Logoutbtn
            // 
            Logoutbtn.Location = new Point(0, 497);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(197, 23);
            Logoutbtn.TabIndex = 3;
            Logoutbtn.Text = "Logout";
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
            ResumeLayout(false);
        }

        // Event handler for painting rounded corners
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, leftPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            leftPanel.Region = new Region(new Rectangle(0, 0, leftPanel.Width, leftPanel.Height));
        }

        #endregion
    }
}