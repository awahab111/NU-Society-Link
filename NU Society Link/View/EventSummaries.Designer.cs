namespace NU_Society_Link.View
{
    partial class EventSummaries
    {
        
        public System.Windows.Forms.Label lblEventTitle;
        public System.Windows.Forms.TextBox txtEventTitle;
        public System.Windows.Forms.Label lblSummary;
        public System.Windows.Forms.RichTextBox txtSummary;
        public System.Windows.Forms.Label lblNumberParticipants;
        public System.Windows.Forms.TextBox txtNumberParticipants;
        public System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            lblEventTitle = new Label();
            txtEventTitle = new TextBox();
            lblSummary = new Label();
            txtSummary = new RichTextBox();
            lblNumberParticipants = new Label();
            txtNumberParticipants = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblEventTitle
            // 
            lblEventTitle.AutoSize = true;
            lblEventTitle.Location = new Point(20, 21);
            lblEventTitle.Name = "lblEventTitle";
            lblEventTitle.Size = new Size(67, 17);
            lblEventTitle.TabIndex = 0;
            lblEventTitle.Text = "Event Title:";
            // 
            // txtEventTitle
            // 
            txtEventTitle.Location = new Point(108, 14);
            txtEventTitle.Name = "txtEventTitle";
            txtEventTitle.Size = new Size(200, 24);
            txtEventTitle.TabIndex = 1;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(20, 74);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(62, 17);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Summary:";
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(108, 74);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(400, 150);
            txtSummary.TabIndex = 3;
            txtSummary.Text = "";
            // 
            // lblNumberParticipants
            // 
            lblNumberParticipants.AutoSize = true;
            lblNumberParticipants.Location = new Point(20, 245);
            lblNumberParticipants.Name = "lblNumberParticipants";
            lblNumberParticipants.Size = new Size(136, 17);
            lblNumberParticipants.TabIndex = 4;
            lblNumberParticipants.Text = "Number of Participants:";
            // 
            // txtNumberParticipants
            // 
            txtNumberParticipants.Location = new Point(162, 242);
            txtNumberParticipants.Name = "txtNumberParticipants";
            txtNumberParticipants.Size = new Size(100, 24);
            txtNumberParticipants.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(4, 59, 72);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(250, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 26);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // EventSummaries
            // 
            AutoSize = true;
            BackColor = Color.FromArgb(12, 116, 137);
            ClientSize = new Size(550, 350);
            Controls.Add(lblEventTitle);
            Controls.Add(txtEventTitle);
            Controls.Add(lblSummary);
            Controls.Add(txtSummary);
            Controls.Add(lblNumberParticipants);
            Controls.Add(txtNumberParticipants);
            Controls.Add(btnSave);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F);
            ForeColor = Color.WhiteSmoke;
            Name = "EventSummaries";
            Text = "Event Summaries";
            ResumeLayout(false);
            PerformLayout();
        }
        

    }
}
