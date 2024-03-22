namespace NU_Society_Link.View
{
    partial class AdminMainView
    {
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button ApproveSociety;

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
            ApproveSociety = new Button();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.LightGray;
            leftPanel.Controls.Add(ApproveSociety);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 561);
            leftPanel.TabIndex = 0;
            // 
            // ApproveSociety
            // 
            ApproveSociety.Location = new Point(0, 52);
            ApproveSociety.Name = "ApproveSociety";
            ApproveSociety.Size = new Size(197, 23);
            ApproveSociety.TabIndex = 0;
            ApproveSociety.Text = "Approve Society";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(leftPanel);
            IsMdiContainer = true;
            Name = "Admin Main View";
            Text = "Admin Main View";
            leftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}